﻿using Mall.API.Model;
using Mall.API.Model.ParamsModel;
using Mall.Application;
using Mall.CommonModel;
using Mall.CommonModel.Enum;
using Mall.Core;
using Mall.DTO;
using Mall.DTO.QueryModel;
using Mall.IServices;
using Mall.Entities;
using Mall.Web.Framework;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;
using System.Drawing;
using System.Web;
using System.Text.RegularExpressions;
using Nop.Core.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Mall.API
{
    public class MemberOrderController : BaseApiController
    {

        [HttpGet("GetOrders")]
        public object GetOrders(int? orderStatus, int pageNo, int pageSize = 8)
        {
            CheckUserLogin();

            var orderStatistic = StatisticApplication.GetMemberOrderStatistic(CurrentUser.Id);

            var orderService = ServiceProvider.Instance<IOrderService>.Create;
            if (orderStatus.HasValue && orderStatus == 0)
                orderStatus = null;

            var queryModel = new OrderQuery()
            {
                Status = (OrderInfo.OrderOperateStatus?)orderStatus,
                UserId = CurrentUser.Id,
                PageSize = pageSize,
                PageNo = pageNo,
                IsFront = true
            };
            if (queryModel.Status.HasValue && queryModel.Status.Value == OrderInfo.OrderOperateStatus.WaitReceiving)
            {
                if (queryModel.MoreStatus == null)
                {
                    queryModel.MoreStatus = new List<OrderInfo.OrderOperateStatus>() { };
                }
                queryModel.MoreStatus.Add(OrderInfo.OrderOperateStatus.WaitSelfPickUp);
            }
            if (orderStatus.GetValueOrDefault() == (int)OrderInfo.OrderOperateStatus.Finish)
                queryModel.Commented = false;//只查询未评价的订单
            QueryPageModel<OrderInfo> orders = orderService.GetOrders<OrderInfo>(queryModel);
            var productService = ServiceProvider.Instance<IProductService>.Create;
            var vshopService = ServiceProvider.Instance<IVShopService>.Create;
            var orderRefundService = ServiceProvider.Instance<IRefundService>.Create;
            var orderItems = OrderApplication.GetOrderItemsByOrderId(orders.Models.Select(p => p.Id));
            var orderRefunds = OrderApplication.GetOrderRefunds(orderItems.Select(p => p.Id));
            //查询结果的门店ID
            var branchIds = orders.Models.Where(e => e.ShopBranchId > 0).Select(p => p.ShopBranchId).ToList();
            //根据门店ID获取门店信息
            var shopBranchs = ShopBranchApplication.GetShopBranchByIds(branchIds);

            //TODO:FG 关联数据查询提取至循环外层
            var result = orders.Models.Select(order =>
            {
                if (order.OrderStatus >= OrderInfo.OrderOperateStatus.WaitDelivery)
                {
                    orderService.CalculateOrderItemRefund(order.Id);
                }
                var vshop = vshopService.GetVShopByShopId(order.ShopId);
                var _ordrefobj = orderRefundService.GetOrderRefundByOrderId(order.Id) ?? new OrderRefundInfo { Id = 0 };
                if (order.OrderStatus != OrderInfo.OrderOperateStatus.WaitDelivery && order.OrderStatus != OrderInfo.OrderOperateStatus.WaitSelfPickUp)
                {
                    _ordrefobj = new OrderRefundInfo { Id = 0 };
                }
                int? ordrefstate = (_ordrefobj == null ? null : (int?)_ordrefobj.SellerAuditStatus);
                ordrefstate = (ordrefstate > 4 ? (int?)_ordrefobj.ManagerConfirmStatus : ordrefstate);
                var branchObj = shopBranchs.FirstOrDefault(e => e.Id == order.ShopBranchId);
                string branchName = branchObj == null ? string.Empty : branchObj.ShopBranchName;
                //参照PC端会员中心的状态描述信息
                string statusText = order.OrderStatus.ToDescription();
                if (order.OrderStatus == OrderInfo.OrderOperateStatus.WaitDelivery || order.OrderStatus == OrderInfo.OrderOperateStatus.WaitSelfPickUp)
                {
                    if (ordrefstate.HasValue && ordrefstate != 0 && ordrefstate != 4)
                    {
                        statusText = "退款中";
                    }
                }
                var hasAppendComment = ServiceProvider.Instance<ICommentService>.Create.HasAppendComment(orderItems.FirstOrDefault(d=>d.OrderId==order.Id).Id);
                return new
                {
                    id = order.Id,
                    status = statusText,
                    orderStatus = order.OrderStatus,
                    orderType = order.OrderType,
                    orderTypeName = order.OrderType.ToDescription(),
                    shopname = order.ShopName,
                    vshopId = vshop == null ? 0 : vshop.Id,
                    orderTotalAmount = order.OrderTotalAmount.ToString("F2"),
                    productCount = OrderApplication.GetOrderTotalProductCount(order.Id),
                    commentCount = OrderApplication.GetOrderComment(order.Id).Count,
                    pickupCode = order.PickupCode,
                    ShopBranchId = order.ShopBranchId,
                    ShopBranchName = branchName,
                    EnabledRefundAmount = order.OrderEnabledRefundAmount,
                    itemInfo = orderItems.Where(oi => oi.OrderId == order.Id).Select(a =>
                    {
                        var prodata = productService.GetProduct(a.ProductId);
                        TypeInfo typeInfo = ServiceProvider.Instance<ITypeService>.Create.GetType(prodata.TypeId);
                        string colorAlias = (typeInfo == null || string.IsNullOrEmpty(typeInfo.ColorAlias)) ? SpecificationType.Color.ToDescription() : typeInfo.ColorAlias;
                        string sizeAlias = (typeInfo == null || string.IsNullOrEmpty(typeInfo.SizeAlias)) ? SpecificationType.Size.ToDescription() : typeInfo.SizeAlias;
                        string versionAlias = (typeInfo == null || string.IsNullOrEmpty(typeInfo.VersionAlias)) ? SpecificationType.Version.ToDescription() : typeInfo.VersionAlias;
                        if (prodata != null)
                        {
                            colorAlias = !string.IsNullOrWhiteSpace(prodata.ColorAlias) ? prodata.ColorAlias : colorAlias;
                            sizeAlias = !string.IsNullOrWhiteSpace(prodata.SizeAlias) ? prodata.SizeAlias : sizeAlias;
                            versionAlias = !string.IsNullOrWhiteSpace(prodata.VersionAlias) ? prodata.VersionAlias : versionAlias;
                        }
                        var itemrefund = orderRefunds.Where(or => or.OrderItemId == a.Id).FirstOrDefault(d => d.RefundMode != OrderRefundInfo.OrderRefundMode.OrderRefund);
                        int? itemrefstate = (itemrefund == null ? null : (int?)itemrefund.SellerAuditStatus);
                        itemrefstate = (itemrefstate > 4 ? (int?)itemrefund.ManagerConfirmStatus : itemrefstate);

                        return new
                        {
                            productId = a.ProductId,
                            productName = a.ProductName,
                            image = Core.MallIO.GetRomoteProductSizeImage(a.ThumbnailsUrl, 1, (int)Mall.CommonModel.ImageSize.Size_350),
                            count = a.Quantity,
                            price = a.SalePrice,
                            Unit = prodata == null ? "" : prodata.MeasureUnit,
                            color = a.Color,
                            size = a.Size,
                            version = a.Version,
                            ColorAlias = colorAlias,
                            SizeAlias = sizeAlias,
                            VersionAlias = versionAlias,
                            RefundStats = itemrefstate,
                            OrderRefundId = (itemrefund == null ? 0 : itemrefund.Id),
                            EnabledRefundAmount = a.EnabledRefundAmount
                        };
                    }),
                    RefundStats = ordrefstate,
                    OrderRefundId = _ordrefobj.Id,
                    HasExpressStatus = !string.IsNullOrWhiteSpace(order.ShipOrderNumber),
                    HasAppendComment = hasAppendComment,
                    //Invoice = order.InvoiceType.ToDescription(),
                    //InvoiceValue = (int)order.InvoiceType,
                    //InvoiceContext = order.InvoiceContext,
                    //InvoiceTitle = order.InvoiceTitle,
                    PaymentType = order.PaymentType.ToDescription(),
                    PaymentTypeValue = (int)order.PaymentType,
                    CanRefund = OrderApplication.CanRefund(order, itemId: 0),
                    IsVirtual = order.OrderType == OrderInfo.OrderTypes.Virtual ? 1 : 0,
                    IsPay = order.PayDate.HasValue ? 1 : 0
                };
            });
            return new
            {
                success = true,
                AllOrderCounts = orderStatistic.OrderCount,
                WaitingForComments = orderStatistic.WaitingForComments,
                WaitingForRecieve = orderStatistic.WaitingForRecieve + OrderApplication.GetWaitConsumptionOrderNumByUserId(CurrentUser.Id),
                WaitingForPay = orderStatistic.WaitingForPay,
                Orders = result
            };
        }


        [HttpGet("GetElectronicCredentials")]
        public object GetElectronicCredentials(long orderId)
        {
            bool validityType = false;
            string validityDate = string.Empty, validityDateStart = string.Empty;
            int total = 0;
            List<OrderVerificationCodeInfo> orderVerificationCodes = null;
            var orderInfo = OrderApplication.GetOrder(orderId);
            if (orderInfo != null && orderInfo.OrderType == OrderInfo.OrderTypes.Virtual)
            {
                var orderItemInfo = OrderApplication.GetOrderItemsByOrderId(orderId).FirstOrDefault();
                if (orderItemInfo != null)
                {
                    var virtualProductInfo = ProductManagerApplication.GetVirtualProductInfoByProductId(orderItemInfo.ProductId);
                    if (virtualProductInfo != null)
                    {
                        validityType = virtualProductInfo.ValidityType;
                        if (validityType)
                        {
                            validityDate = virtualProductInfo.EndDate.Value.ToString("yyyy-MM-dd");
                            validityDateStart = virtualProductInfo.StartDate.Value.ToString("yyyy-MM-dd");
                        }
                    }
                    orderVerificationCodes = OrderApplication.GetOrderVerificationCodeInfosByOrderIds(new List<long>() { orderId });
                    total = orderVerificationCodes.Count;
                    orderVerificationCodes.ForEach(a =>
                    {
                        a.QRCode = GetQRCode(a.VerificationCode);
                        a.VerificationCode = System.Text.RegularExpressions.Regex.Replace(a.VerificationCode, @"(\d{4})", "$1 ");
                    });
                }
            }

            return new
            {
                success = true,
                validityType = validityType,
                validityDate = validityDate,
                validityDateStart = validityDateStart,
                total = total,
                orderVerificationCodes = orderVerificationCodes.Select(a =>
                {
                    return new
                    {
                        QRCode = a.QRCode,
                        VerificationCode = a.VerificationCode,
                        Status = a.Status,
                        StatusText = a.Status.ToDescription()
                    };
                })
            };
        }

        private string GetQRCode(string verificationCode)
        {
            string qrCodeImagePath = string.Empty;
            Image qrcode = Core.Helper.QRCodeHelper.Create(verificationCode);
            string fileName = DateTime.Now.ToString("yyMMddHHmmssffffff") + ".jpg";
            qrCodeImagePath = CurrentUrlHelper.CurrentUrl() + "/temp/" + fileName;
            //  qrcode.Save(HttpContext.Current.Server.MapPath("~/temp/") + fileName);
            var env = EngineContext.Current.Resolve<IWebHostEnvironment>();
            qrcode.Save(env.ContentRootPath+"/temp/" + fileName);



            return qrCodeImagePath;
        }
        [HttpGet("GetOrderDetail")]
        public object GetOrderDetail(long id)
        {
            CheckUserLogin();
            OrderInfo order = ServiceProvider.Instance<IOrderService>.Create.GetOrder(id, CurrentUser.Id);

            var orderService = ServiceProvider.Instance<IOrderService>.Create;
            var bonusService = ServiceProvider.Instance<IShopBonusService>.Create;
            var orderRefundService = ServiceProvider.Instance<IRefundService>.Create;
            var bonusmodel = bonusService.GetGrantByUserOrder(id, CurrentUser.Id);
            bool hasBonus = bonusmodel != null ? true : false;
            string shareHref = "";
            string shareTitle = "";
            string shareDetail = "";
            string shareImg = "";
            if (hasBonus)
            {
                shareHref = CurrentUrlHelper.CurrentUrlNoPort() + "/m-weixin/shopbonus/index/" + bonusService.GetGrantIdByOrderId(id);
                var bonus = ShopBonusApplication.GetBonus(bonusmodel.ShopBonusId);
                shareTitle = bonus.ShareTitle;
                shareDetail = bonus.ShareDetail;
                shareImg = MallIO.GetRomoteImagePath(bonus.ShareImg);
            }
            var vshop = ServiceProvider.Instance<IVShopService>.Create.GetVShopByShopId(order.ShopId);

            var customerServices = CustomerServiceApplication.GetMobileCustomerServiceAndMQ(order.ShopId);

            var shop = ShopApplication.GetShop(order.ShopId);
            var orderItems = OrderApplication.GetOrderItemsByOrderId(order.Id);
            var products = ProductManagerApplication.GetProducts(orderItems.Select(p => p.ProductId));
            var refunds = OrderApplication.GetOrderRefundsByOrder(order.Id);            //获取订单商品项数据
            var orderDetail = new
            {
                ShopId = shop.Id,
                ShopName = shop.ShopName,
                OrderItems = orderItems.Select(item =>
                {
                    var product = products.FirstOrDefault(p => p.Id == item.ProductId);
                    var typeInfo = TypeApplication.GetType(product.TypeId);

                    string colorAlias = (typeInfo == null || string.IsNullOrEmpty(typeInfo.ColorAlias)) ? SpecificationType.Color.ToDescription() : typeInfo.ColorAlias;
                    string sizeAlias = (typeInfo == null || string.IsNullOrEmpty(typeInfo.SizeAlias)) ? SpecificationType.Size.ToDescription() : typeInfo.SizeAlias;
                    string versionAlias = (typeInfo == null || string.IsNullOrEmpty(typeInfo.VersionAlias)) ? SpecificationType.Version.ToDescription() : typeInfo.VersionAlias;
                    if (product != null)
                    {
                        colorAlias = !string.IsNullOrWhiteSpace(product.ColorAlias) ? product.ColorAlias : colorAlias;
                        sizeAlias = !string.IsNullOrWhiteSpace(product.SizeAlias) ? product.SizeAlias : sizeAlias;
                        versionAlias = !string.IsNullOrWhiteSpace(product.VersionAlias) ? product.VersionAlias : versionAlias;
                    }
                    var itemrefund = refunds.FirstOrDefault(d => d.OrderItemId == item.Id && d.RefundMode != OrderRefundInfo.OrderRefundMode.OrderRefund);
                    int? itemrefstate = (itemrefund == null ? null : (int?)itemrefund.SellerAuditStatus);
                    itemrefstate = (itemrefstate > 4 ? (int?)itemrefund.ManagerConfirmStatus : itemrefstate);
                    var IsCanRefund = OrderApplication.CanRefund(order, itemrefstate, itemId: item.Id);
                    return new
                    {
                        ItemId = item.Id,
                        ProductId = item.ProductId,
                        ProductName = item.ProductName,
                        Count = item.Quantity,
                        Price = item.SalePrice,
                        ProductImage = Core.MallIO.GetRomoteProductSizeImage(product.RelativePath, 1, (int)Mall.CommonModel.ImageSize.Size_100),
                        color = item.Color,
                        size = item.Size,
                        version = item.Version,
                        IsCanRefund = IsCanRefund,
                        ColorAlias = colorAlias,
                        SizeAlias = sizeAlias,
                        VersionAlias = versionAlias,
                        EnabledRefundAmount = item.EnabledRefundAmount,
                        OrderRefundId = (itemrefund == null ? 0 : itemrefund.Id),
                        RefundStats = itemrefstate
                    };
                })
            };
            //取拼团订单状态
            var fightGroupOrderInfo = ServiceProvider.Instance<IFightGroupService>.Create.GetFightGroupOrderStatusByOrderId(order.Id);
            var _ordrefobj = orderRefundService.GetOrderRefundByOrderId(order.Id) ?? new OrderRefundInfo { Id = 0 };
            if (order.OrderStatus != OrderInfo.OrderOperateStatus.WaitDelivery && order.OrderStatus != OrderInfo.OrderOperateStatus.WaitSelfPickUp)
            {
                _ordrefobj = new OrderRefundInfo { Id = 0 };
            }
            int? ordrefstate = (_ordrefobj == null ? null : (int?)_ordrefobj.SellerAuditStatus);
            ordrefstate = (ordrefstate > 4 ? (int?)_ordrefobj.ManagerConfirmStatus : ordrefstate);

            var hasAppendComment = ServiceProvider.Instance<ICommentService>.Create.HasAppendComment(orderItems.FirstOrDefault().Id);
            var orderModel = new
            {
                Id = order.Id,
                OrderType = order.OrderType,
                OrderTypeName = order.OrderType.ToDescription(),
                Status = order.OrderStatus.ToDescription(),
                JoinStatus = fightGroupOrderInfo == null ? -2 : fightGroupOrderInfo.JoinStatus,
                ShipTo = order.ShipTo,
                Phone = order.CellPhone,
                Address = order.RegionFullName + " " + order.Address,
                HasExpressStatus = !string.IsNullOrWhiteSpace(order.ShipOrderNumber),
                ExpressCompanyName = order.ExpressCompanyName,
                Freight = order.Freight,
                Tax = order.Tax,
                IntegralDiscount = order.IntegralDiscount,
                RealTotalAmount = order.OrderTotalAmount,
                CapitalAmount = order.CapitalAmount,
                RefundTotalAmount = order.RefundTotalAmount,
                ProductTotalAmount = order.ProductTotalAmount,
                OrderPayAmount = order.OrderPayAmount,//订单需要第三方支付的金额
                PaymentTypeName = PaymentApplication.GetPaymentTypeDescById(order.PaymentTypeGateway) ?? order.PaymentTypeName,
                PaymentTypeDesc = order.PaymentTypeDesc,
                OrderDate = order.OrderDate.ToString("yyyy-MM-dd HH:mm:ss"),
                ShopName = order.ShopName,
                VShopId = vshop == null ? 0 : vshop.Id,
                commentCount = OrderApplication.GetOrderCommentCount(order.Id),
                ShopId = order.ShopId,
                orderStatus = (int)order.OrderStatus,
                //Invoice = order.InvoiceType.ToDescription(),
                //InvoiceValue = (int)order.InvoiceType,
                //InvoiceContext = order.InvoiceContext,
                //InvoiceTitle = order.InvoiceTitle,
                //InvoiceCode = order.InvoiceCode,
                PaymentType = order.PaymentType.ToDescription(),
                PaymentTypeValue = (int)order.PaymentType,
                FullDiscount = order.FullDiscount,
                DiscountAmount = order.DiscountAmount,
                OrderRemarks = string.IsNullOrEmpty(order.OrderRemarks) ? "" : order.OrderRemarks,
                HasBonus = hasBonus,
                ShareHref = shareHref,
                ShareTitle = shareTitle,
                ShareDetail = shareDetail,
                ShareImg = shareImg,
                IsCanRefund = !(orderDetail.OrderItems.Any(e => e.IsCanRefund == true)) && OrderApplication.CanRefund(order, ordrefstate, null),
                RefundStats = ordrefstate,
                OrderRefundId = _ordrefobj.Id > 0 ? _ordrefobj.Id : 0,
                EnabledRefundAmount = order.OrderEnabledRefundAmount,
                HasAppendComment = hasAppendComment,
                SelfTake = order.DeliveryType == Mall.CommonModel.DeliveryType.SelfTake ? 1 : 0,
                OrderInvoice = OrderApplication.GetOrderInvoiceInfo(order.Id)
            };
            #region 门店配送信息
            Mall.DTO.ShopBranch storeInfo = null;
            if (order.ShopBranchId > 0)
            {
                storeInfo = ShopBranchApplication.GetShopBranchById(order.ShopBranchId);
            }
            #endregion
            #region 虚拟订单信息
            VirtualProductInfo virtualProductInfo = null;
            int validityType = 0; string startDate = string.Empty, endDate = string.Empty;
            List<dynamic> orderVerificationCodes = null;
            List<dynamic> virtualOrderItemInfos = null;
            bool isCanRefundVirtual = false;
            if (order.OrderType == OrderInfo.OrderTypes.Virtual)
            {
                var orderItemInfo = orderItems.FirstOrDefault();
                if (orderItemInfo != null)
                {
                    virtualProductInfo = ProductManagerApplication.GetVirtualProductInfoByProductId(orderItemInfo.ProductId);
                    if (virtualProductInfo != null)
                    {
                        validityType = virtualProductInfo.ValidityType ? 1 : 0;
                        if (validityType == 1)
                        {
                            startDate = virtualProductInfo.StartDate.Value.ToString("yyyy-MM-dd");
                            endDate = virtualProductInfo.EndDate.Value.ToString("yyyy-MM-dd");
                        }
                    }
                    var codes = OrderApplication.GetOrderVerificationCodeInfosByOrderIds(new List<long>() { order.Id });
                    orderVerificationCodes = codes.Select(p =>
                    {
                        return new
                        {
                            VerificationCode = Regex.Replace(p.VerificationCode, @"(\d{4})", "$1 "),
                            Status = p.Status,
                            StatusText = p.Status.ToDescription(),
                            QRCode = GetQRCode(p.VerificationCode)
                        };
                    }).ToList<dynamic>();

                    var virtualItems = OrderApplication.GetVirtualOrderItemInfosByOrderId(order.Id);
                    virtualOrderItemInfos = virtualItems.Select(p =>
                    {
                        return new
                        {
                            VirtualProductItemName = p.VirtualProductItemName,
                            Content = ReplaceImage(p.Content, p.VirtualProductItemType),
                            VirtualProductItemType = p.VirtualProductItemType
                        };
                    }).ToList<dynamic>();
                }
            }
            if (order.OrderStatus == Mall.Entities.OrderInfo.OrderOperateStatus.WaitVerification)
            {
                if (virtualProductInfo != null)
                {
                    if (virtualProductInfo.SupportRefundType == 2)
                    {
                        isCanRefundVirtual = true;
                    }
                    else if (virtualProductInfo.SupportRefundType == 1)
                    {
                        if (virtualProductInfo.EndDate.Value > DateTime.Now)
                        {
                            isCanRefundVirtual = true;
                        }
                    }
                    else if (virtualProductInfo.SupportRefundType == 3)
                    {
                        isCanRefundVirtual = false;
                    }

                    if (isCanRefundVirtual)
                    {
                        long num = orderVerificationCodes.Where(a => a.Status == OrderInfo.VerificationCodeStatus.WaitVerification).Count();
                        if (num > 0)
                        {
                            isCanRefundVirtual = true;
                        }
                        else
                        {
                            isCanRefundVirtual = false;
                        }
                    }
                }
            }
            #endregion
            #region 虚拟订单核销地址信息
            string shipperAddress = string.Empty, shipperTelPhone = string.Empty;
            if (order.OrderType == OrderInfo.OrderTypes.Virtual)
            {
                if (order.ShopBranchId > 0 && storeInfo != null)
                {
                    shipperAddress = RegionApplication.GetFullName(storeInfo.AddressId) + " " + storeInfo.AddressDetail;
                    shipperTelPhone = storeInfo.ContactPhone;
                }
                else
                {
                    var verificationShipper = ShopShippersApplication.GetDefaultVerificationShipper(order.ShopId);
                    if (verificationShipper != null)
                    {
                        shipperAddress = RegionApplication.GetFullName(verificationShipper.RegionId) + " " + verificationShipper.Address;
                        shipperTelPhone = verificationShipper.TelPhone;
                    }
                }
            } 
            #endregion
            return new
            {
                success = true,
                Order = orderModel,
                OrderItem = orderDetail.OrderItems,
                StoreInfo = storeInfo,
                CustomerServices = customerServices,
                ValidityType = validityType,
                StartDate = startDate,
                EndDate = endDate,
                OrderVerificationCodes = orderVerificationCodes,
                VirtualOrderItemInfos = virtualOrderItemInfos,
                IsCanRefundVirtual = isCanRefundVirtual,
                ShipperAddress = shipperAddress,
                ShipperTelPhone = shipperTelPhone
            };
        }
        [HttpGet("GetExpressInfo")]
        public object GetExpressInfo(long orderId)
        {
            CheckUserLogin();
            OrderInfo order = ServiceProvider.Instance<IOrderService>.Create.GetOrder(orderId, CurrentUser.Id);
            if (order.DeliveryType == DeliveryType.CityExpress)
            {
                float StoreLat = 0, Storelng = 0;
                if (order == null)
                {
                    throw new MallException("错误的订单编号");
                }
                if (order.ShopBranchId > 0)
                {
                    var sbdata = ShopBranchApplication.GetShopBranchById(order.ShopBranchId);
                    if (sbdata != null)
                    {
                        StoreLat = sbdata.Latitude;
                        Storelng = sbdata.Longitude;
                    }
                }
                else
                {
                    var shopshiper = ShopShippersApplication.GetDefaultSendGoodsShipper(order.ShopId);
                    if (shopshiper != null && shopshiper.Latitude.HasValue && shopshiper.Longitude.HasValue)
                    {
                        StoreLat = shopshiper.Latitude.Value;
                        Storelng = shopshiper.Longitude.Value;
                    }
                }
                return new
                {
                    success = true,
                    ExpressNum = order.ShipOrderNumber,
                    ExpressCompanyName = order.ExpressCompanyName,
                    deliveryType = DeliveryType.CityExpress.GetHashCode(),
                    userLat = order.ReceiveLatitude,
                    userLng = order.ReceiveLongitude,
                    storeLat = StoreLat,
                    Storelng = Storelng,
                };
            }
            else
            {
                var expressData = ServiceProvider.Instance<IExpressService>.Create.GetExpressData(order.ExpressCompanyName, order.ShipOrderNumber);

                if (expressData.Success)
                    expressData.ExpressDataItems = expressData.ExpressDataItems.OrderByDescending(item => item.Time);//按时间逆序排列
                var json = new
                {
                    success = expressData.Success,
                    msg = expressData.Message,
                    data = expressData.ExpressDataItems.Select(item => new
                    {
                        time = item.Time.ToString("yyyy-MM-dd HH:mm:ss"),
                        content = item.Content
                    })
                };
                return new
                {
                    success = true,
                    ExpressNum = order.ShipOrderNumber,
                    ExpressCompanyName = order.ExpressCompanyName,
                    Comment = json
                };
            }
        }

        //确认收货

        [HttpPost("PostConfirmOrder")]
        public object PostConfirmOrder(MemberOrderConfirmOrderModel value)
        {
            CheckUserLogin();
            long orderId = value.orderId;
            ServiceProvider.Instance<IOrderService>.Create.MembeConfirmOrder(orderId, CurrentUser.UserName);

            var data = ServiceProvider.Instance<IOrderService>.Create.GetOrder(orderId);
            if (data.PaymentType == OrderInfo.PaymentTypes.CashOnDelivery)
            {//货到付款的订单，在会员确认收货时
                MemberApplication.UpdateNetAmount(data.UserId, data.OrderTotalAmount);
                MemberApplication.IncreaseMemberOrderNumber(data.UserId);
            }
            //确认收货写入结算表(修改LH的方法)
            // ServiceProvider.Instance<IOrderService>.Create.WritePendingSettlnment(data);
            return SuccessResult();
        }

        //取消订单

        [HttpPost("PostCloseOrder")]
        public object PostCloseOrder(MemberOrderCloseOrderModel value)
        {
            CheckUserLogin();
            long orderId = value.orderId;
            var order = ServiceProvider.Instance<IOrderService>.Create.GetOrder(orderId, CurrentUser.Id);
            if (order != null)
            {
                //拼团处理
                if (order.OrderType == OrderInfo.OrderTypes.FightGroup)
                {
                    throw new MallApiException("拼团订单，会员不能取消！");
                }
                ServiceProvider.Instance<IOrderService>.Create.MemberCloseOrder(orderId, CurrentUser.UserName);
            }
            else
            {
                throw new MallApiException("取消失败，该订单已删除或者不属于当前用户！");
            }
            return SuccessResult();
        }
        /// <summary>
        /// 订单提货码
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        [HttpGet("GetPickupGoods")]
        public object GetPickupGoods(long id)
        {
            CheckUserLogin();
            var orderInfo = OrderApplication.GetOrder(id);
            if (orderInfo == null)
                return ErrorResult("订单不存在！");
            if (orderInfo.UserId != CurrentUser.Id)
                return ErrorResult("只能查看自己的提货码！");
            var productService = ServiceProvider.Instance<IProductService>.Create;
           // AutoMapper.Mapper.CreateMap<Order, Mall.DTO.OrderListModel>();
         //  AutoMapper.Mapper.CreateMap<DTO.OrderItem, OrderItemListModel>();
            var orderModel = orderInfo.Map<Mall.DTO.OrderListModel>();
            var orderItems = OrderApplication.GetOrderItemsByOrderId(orderInfo.Id);
            var newOrderItems = new List<DTO.OrderItem>();
            foreach (var item in orderItems)
            {
                item.ThumbnailsUrl = Core.MallIO.GetRomoteProductSizeImage(productService.GetProduct(item.ProductId).RelativePath, 1, (int)Mall.CommonModel.ImageSize.Size_50);
                // item.ThumbnailsUrl = Mall.Core.MallIO.GetRomoteProductSizeImage(item.ThumbnailsUrl, 1, (int)Mall.CommonModel.ImageSize.Size_50);
                newOrderItems.Add(item);
            }
            // orderModel.OrderItemList = AutoMapper.Mapper.Map<List<DTO.OrderItem>, List<OrderItemListModel>>(orderItems);
            orderModel.OrderItemList = newOrderItems.Map<List<OrderItemListModel>>();
            if (orderInfo.ShopBranchId> 0)
            {//补充数据
                var branch = ShopBranchApplication.GetShopBranchById(orderInfo.ShopBranchId);
                orderModel.ShopBranchName = branch.ShopBranchName;
                orderModel.ShopBranchAddress = branch.AddressFullName;
                orderModel.ShopBranchContactPhone = branch.ContactPhone;
            }

            return new { success = true, OrderModel = orderModel };
        }
        //public object PostPayOrder([FromBody]dynamic value)
        //{
        //    string id = value.id;
        //    id = DecodePaymentId(id);
        //    string errorMsg = string.Empty;

        //    try
        //    {
        //        var payment = Core.PluginsManagement.GetPlugin<IPaymentPlugin>(id);
        //        var payInfo = payment.Biz.ProcessReturn(HttpContext.Request);
        //        if (payInfo != null)
        //        {
        //            var payTime = payInfo.TradeTime;

        //            var orderid = payInfo.OrderIds.FirstOrDefault();
        //            var orderIds = ServiceApplication.Create<IOrderService>().GetOrderPay(orderid).Select(item => item.OrderId).ToList();

        //            ViewBag.OrderIds = string.Join(",", orderIds);
        //            ServiceApplication.Create<IOrderService>().PaySucceed(orderIds, id, payInfo.TradeTime.Value, payInfo.TradNo, payId: orderid);

        //            string payStateKey = CacheKeyCollection.PaymentState(string.Join(",", orderIds));//获取支付状态缓存键
        //            Cache.Insert(payStateKey, true, 15);//标记为已支付
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        errorMsg = ex.Message;
        //        Core.Log.Error("移动端同步返回出错，支持方式：" + id, ex);
        //    }
        //    ServiceProvider.Instance<IOrderService>.Create.PaySucceed(orderIds, id, payInfo.TradeTime.Value, payInfo.TradNo, payId: orderid);
        //}
        private string DecodePaymentId(string paymentId)
        {
            return paymentId.Replace("-", ".");
        }
        [HttpGet("GetOrderBonus")]
        public object GetOrderBonus(string orderIds)
        {
            CheckUserLogin();
            List<BonuModel> bonus = new List<BonuModel>();
            var shopService = ServiceProvider.Instance<IShopService>.Create;
            var orderService = ServiceProvider.Instance<IOrderService>.Create;
            var bonusService = ServiceProvider.Instance<IShopBonusService>.Create;
            string orderids = orderIds;
            string[] orderArray = orderids.Split(',');
            foreach (string item in orderArray)
            {
                long orderid = 0;
                if (long.TryParse(item, out orderid))
                {
                    var BonusInfo = bonusService.GetGrantByUserOrder(orderid, CurrentUser.Id);
                    if (BonusInfo != null)
                    {
                        BonuModel bonuObject = new BonuModel();
                        var info = ShopBonusApplication.GetBonus(BonusInfo.ShopBonusId);
                        bonuObject.ShareHref = CurrentUrlHelper.CurrentUrlNoPort() + "/m-weixin/shopbonus/index/" + BonusInfo.Id;
                        bonuObject.ShareCount = info.Count;
                        bonuObject.ShareDetail = info.ShareDetail;
                        bonuObject.ShareTitle = info.ShareTitle;
                        bonuObject.ShopName = shopService.GetShop(info.ShopId).ShopName;
                        bonus.Add(bonuObject);
                    }
                }
            }

            return new { success = true, List = bonus };
        }
        /// <summary>
        /// 获取订单状态
        /// <para>供支付时使用</para>
        /// </summary>
        /// <param name="orderIds"></param>
        /// <returns></returns>
        /// 

        [HttpGet("GetOrerStatus")]
        public object GetOrerStatus(string orderIds)
        {
            CheckUserLogin();
            var orderService = ServiceProvider.Instance<IOrderService>.Create;
            var fgService = ServiceProvider.Instance<IFightGroupService>.Create;
            List<long> ordids = orderIds.Split(',').Where(d => !string.IsNullOrWhiteSpace(d)).Select(t => long.Parse(t)).ToList();
            IEnumerable<OrderInfo> orders = orderService.GetOrders(ordids).ToList();
            var data = orders.Select(d =>
            {
                long activeId = 0, groupId = 0;
                bool isgroupsuccess = false;
                if (d.OrderType == OrderInfo.OrderTypes.FightGroup)
                {
                    var fg = fgService.GetFightGroupOrderStatusByOrderId(d.Id);
                    if (fg != null)
                    {
                        activeId = fg.ActiveId;
                        groupId = fg.GroupId;
                        isgroupsuccess = fg.GroupStatus == FightGroupBuildStatus.Success;
                    }
                }
                return new MemberOrderGetStatusModel
                {
                    orderId = d.Id,
                    status = d.OrderStatus.GetHashCode(),
                    activeId = activeId,
                    groupId = groupId,
                    groupsuccess = isgroupsuccess

                };
            }).ToList();
            return new { success = true, list = data };
        }

        private List<string> ReplaceImage(string content, ProductInfo.VirtualProductItemType type)
        {
            if (type != ProductInfo.VirtualProductItemType.Picture)
                return new List<string>() { content };

            List<string> list = content.Split(',').ToList();
            return list.Select(a => a = CurrentUrlHelper.CurrentUrl() + a).ToList();
        }
    }
}