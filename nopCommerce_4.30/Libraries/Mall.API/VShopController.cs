﻿using Mall.API.Model;
using Mall.API.Model.ParamsModel;
using Mall.Application;
using Mall.Core;
using Mall.DTO.QueryModel;
using Mall.IServices;
using Mall.Web.Framework;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Nop.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Mall.API
{
    public class VShopController : BaseApiController
    {

        [HttpGet("GetVShops")]
        public object GetVShops(int pageNo, int pageSize)
        {
            int total;
            var vshops = ServiceProvider.Instance<IVShopService>.Create.GetVShops(pageNo, pageSize, out total, Entities.VShopInfo.VShopStates.Normal,true).ToArray();
            long[] favoriteShopIds = new long[] { };
            if (CurrentUser != null)
                favoriteShopIds = ServiceProvider.Instance<IShopService>.Create.GetFavoriteShopInfos(CurrentUser.Id).Select(item => item.ShopId).ToArray();
            var model = vshops.Select(item => new
            {
                id = item.Id,
                //image = "http://" + Url.Request.RequestUri.Host + item.BackgroundImage,
                image = Core.MallIO.GetRomoteImagePath(item.WXLogo),
                tags = item.Tags,
                name = item.Name,
                shopId = item.ShopId,
                favorite = favoriteShopIds.Contains(item.ShopId),
                productCount = ProductManagerApplication.GetProductCount(item.ShopId),
                FavoritesCount = ServiceProvider.Instance<IShopService>.Create.GetShopFavoritesCount(item.ShopId)//关注人数
            });
            dynamic result = SuccessResult();
            result.total = total;
            result.VShops = model;
            return result;
        }

        [HttpGet("GetVShop")]
        public object GetVShop(long id, bool sv = false)
        {
            var vshopService = ServiceProvider.Instance<IVShopService>.Create;
            var vshop = vshopService.GetVShop(id);
            if (vshop == null)
                return new Result { success = false, msg = "未开通微店", code = -4 };
            if (vshop.State == Entities.VShopInfo.VShopStates.Close)
                return new Result { success = false, msg = "商家暂未开通微店", code = -5 };
            if (!vshop.IsOpen)
                return new Result { success = false, msg = "此微店已关闭", code = -3 };
            var s = ShopApplication.GetShop(vshop.ShopId);
            if (null != s && s.ShopStatus == Entities.ShopInfo.ShopAuditStatus.HasExpired)
                return new Result { success = false, msg = "此店铺已过期", code = -1 };
            //throw new MallApiException("此店铺已过期");
            if (null != s && s.ShopStatus == Entities.ShopInfo.ShopAuditStatus.Freeze)
                return new Result { success = false, msg = "此店铺已冻结", code = -2 };

            //throw new MallApiException("此店铺已冻结");

            //轮播图配置只有商家微店首页配置页面可配置，现在移动端都读的这个数据
            var slideImgs = ServiceProvider.Instance<ISlideAdsService>.Create.GetSlidAds(vshop.ShopId, Entities.SlideAdInfo.SlideAdType.VShopHome).ToList();

            //首页商品现在只有商家配置微信首页，APP读的也是这个数据所以平台类型选的的微信端
            var homeProducts = ServiceProvider.Instance<IMobileHomeProductsService>.Create.GetMobileHomeProducts(vshop.ShopId, PlatformType.WeiXin, 1, 8);
            #region 价格更新
            //会员折扣
            decimal discount = 1M;
            long SelfShopId = 0;
            if (CurrentUser != null)
            {
                discount = CurrentUser.MemberDiscount;
                var shopInfo = ShopApplication.GetSelfShop();
                SelfShopId = shopInfo.Id;
            }

            var limit = LimitTimeApplication.GetLimitProducts();
            var fight = FightGroupApplication.GetFightGroupPrice();

            var products = new List<ProductItem>();
            var productData = ProductManagerApplication.GetProducts(homeProducts.Models.Select(p => p.ProductId));
            foreach (var item in homeProducts.Models)
            {
                var product = productData.FirstOrDefault(p => p.Id == item.ProductId);
                var pitem = new ProductItem();
                pitem.Id = item.ProductId;
                pitem.ImageUrl = Core.MallIO.GetRomoteProductSizeImage(product.RelativePath, 1, (int)Mall.CommonModel.ImageSize.Size_350);
                pitem.Name = product.ProductName;
                pitem.MarketPrice = product.MarketPrice;
                pitem.SalePrice = product.MinSalePrice;
                if (item.ShopId == SelfShopId)
                    pitem.SalePrice = product.MinSalePrice * discount;
                var isLimit = limit.Where(r => r.ProductId == item.ProductId).FirstOrDefault();
                var isFight = fight.Where(r => r.ProductId == item.ProductId).FirstOrDefault();
                if (isLimit != null)
                    pitem.SalePrice = isLimit.MinPrice;
                if (isFight != null)
                {
                    pitem.SalePrice = isFight.ActivePrice;
                }
                products.Add(pitem);
            }
            #endregion
            var banner = ServiceProvider.Instance<INavigationService>.Create.GetSellerNavigations(vshop.ShopId, Core.PlatformType.WeiXin).ToList();

            var couponInfo = GetCouponList(vshop.ShopId);

            var SlideAds = slideImgs.ToArray().Select(item => new HomeSlideAdsModel() { ImageUrl = Core.MallIO.GetRomoteImagePath(item.ImageUrl), Url = item.Url });

            var Banner = banner;
            var Products = products;

            bool favoriteShop = false;
            if (CurrentUser != null)
                favoriteShop = ServiceProvider.Instance<IShopService>.Create.IsFavoriteShop(CurrentUser.Id, vshop.ShopId);
            string followUrl = "";
            //快速关注
            var vshopSetting = ServiceProvider.Instance<IVShopService>.Create.GetVShopSetting(vshop.ShopId);
            if (vshopSetting != null)
                followUrl = vshopSetting.FollowUrl;
            var model = new
            {
                Id = vshop.Id,
                //Logo = "http://" + Url.Request.RequestUri.Host + vshop.Logo,
                Logo = Core.MallIO.GetRomoteImagePath(vshop.StrLogo),
                Name = vshop.Name,
                ShopId = vshop.ShopId,
                Favorite = favoriteShop,
                State = vshop.State,
                FollowUrl = followUrl
            };

            // 客服
            var customerServices = CustomerServiceApplication.GetMobileCustomerServiceAndMQ(vshop.ShopId);

            //统计访问量
            if (!sv)
            {
                vshopService.LogVisit(id);
                //统计店铺访问人数
                StatisticApplication.StatisticShopVisitUserCount(vshop.ShopId);
            }
            dynamic result = SuccessResult();
            result.VShop = model;
            result.SlideImgs = SlideAds;
            result.Products = products;
            result.Banner = banner;
            result.Coupon = couponInfo;
            result.CustomerServices = customerServices;
            return result;
        }

        [HttpGet("GetVShopCategory")]
        public object GetVShopCategory(long id)
        {
            var vshopInfo = ServiceProvider.Instance<IVShopService>.Create.GetVShop(id);
            var bizCategories = ServiceProvider.Instance<IShopCategoryService>.Create.GetShopCategory(vshopInfo.ShopId).Where(a=>a.IsShow).ToList();
            var shopCategories = GetSubCategories(bizCategories, 0, 0);
            long shopId = 0;
            if (vshopInfo != null) shopId = vshopInfo.ShopId;
            dynamic result = SuccessResult();
            result.VShopId = id;
            result.ShopCategories = shopCategories;
            result.ShopId = shopId;
            return result;
        }

        [HttpGet("GetVShopIntroduce")]
        public object GetVShopIntroduce(long id)
        {
            var vshop = ServiceProvider.Instance<IVShopService>.Create.GetVShop(id);
            string qrCodeImagePath = string.Empty;
            if (vshop != null)
            {
                Image qrcode;
                string vshopUrl = CurrentUrlHelper.CurrentUrlNoPort() + "/m-" + PlatformType.WeiXin.ToString() + "/vshop/detail/" + id;
                //string vshopUrl = Core.MallIO.GetRomoteImagePath("/m-" + PlatformType.WeiXin.ToString() + "/vshop/detail/") + id;
                //string logoFullPath = HttpContext.Current.Server.MapPath(vshop.Logo);
                if (!string.IsNullOrWhiteSpace(vshop.StrLogo) && MallIO.ExistFile(vshop.StrLogo))
                    qrcode = Core.Helper.QRCodeHelper.Create(vshopUrl, MallIO.GetImagePath(vshop.StrLogo));
                else
                    qrcode = Core.Helper.QRCodeHelper.Create(vshopUrl);

                //string logoFullPath = Core.MallIO.GetRomoteImagePath(vshop.StrLogo);
                //if (string.IsNullOrWhiteSpace(vshop.StrLogo) || !Core.MallIO.ExistFile(logoFullPath))
                //    qrcode = Core.Helper.QRCodeHelper.Create(vshopUrl);
                //else
                //    qrcode = Core.Helper.QRCodeHelper.Create(vshopUrl, logoFullPath);

                string fileName = DateTime.Now.ToString("yyMMddHHmmssffffff") + ".jpg";
                qrCodeImagePath = CurrentUrlHelper.CurrentUrlNoPort() + "/temp/" + fileName;
                //    qrcode.Save(HttpContext.Current.Server.MapPath("~/temp/") + fileName);

                var env = EngineContext.Current.Resolve<IWebHostEnvironment>();

                qrcode.Save(env.ContentRootPath + "/temp/" + fileName);


            }
            var qrCode = qrCodeImagePath;
            bool favorite = false;

            if (CurrentUser != null)
                favorite = ServiceProvider.Instance<IShopService>.Create.IsFavoriteShop(CurrentUser.Id, vshop.ShopId);

            var mark = ShopServiceMark.GetShopComprehensiveMark(vshop.ShopId);
            var shopMark = mark.ComprehensiveMark.ToString();

            #region 获取店铺的评价统计
            var shopStatisticOrderComments = ServiceProvider.Instance<IShopService>.Create.GetShopStatisticOrderComments(vshop.ShopId);

            var productAndDescription = shopStatisticOrderComments.Where(c => c.CommentKey == Entities.StatisticOrderCommentInfo.EnumCommentKey.ProductAndDescription).FirstOrDefault();
            var sellerServiceAttitude = shopStatisticOrderComments.Where(c => c.CommentKey == Entities.StatisticOrderCommentInfo.EnumCommentKey.SellerServiceAttitude).FirstOrDefault();
            var sellerDeliverySpeed = shopStatisticOrderComments.Where(c => c.CommentKey ==
                Entities.StatisticOrderCommentInfo.EnumCommentKey.SellerDeliverySpeed).FirstOrDefault();

            var productAndDescriptionPeer = shopStatisticOrderComments.Where(c => c.CommentKey == Entities.StatisticOrderCommentInfo.EnumCommentKey.ProductAndDescriptionPeer).FirstOrDefault();
            var sellerServiceAttitudePeer = shopStatisticOrderComments.Where(c => c.CommentKey == Entities.StatisticOrderCommentInfo.EnumCommentKey.SellerServiceAttitudePeer).FirstOrDefault();
            var sellerDeliverySpeedPeer = shopStatisticOrderComments.Where(c => c.CommentKey ==
                Entities.StatisticOrderCommentInfo.EnumCommentKey.SellerDeliverySpeedPeer).FirstOrDefault();

            decimal defaultValue = 5;
            var _productAndDescription = defaultValue;
            var _sellerServiceAttitude = defaultValue;
            var _sellerDeliverySpeed = defaultValue;
            //宝贝与描述
            if (productAndDescription != null && productAndDescriptionPeer != null)
            {
                _productAndDescription = productAndDescription.CommentValue;
            }
            //卖家服务态度
            if (sellerServiceAttitude != null && sellerServiceAttitudePeer != null)
            {
                _sellerServiceAttitude = sellerServiceAttitude.CommentValue;
            }
            //卖家发货速度
            if (sellerDeliverySpeedPeer != null && sellerDeliverySpeed != null)
            {
                _sellerDeliverySpeed = sellerDeliverySpeed.CommentValue;
            }
            #endregion
            var vshopModel = new
            {
                QRCode = qrCode,
                Name = vshop.Name,
                IsFavorite = favorite,
                ProductAndDescription = _productAndDescription,
                SellerDeliverySpeed = _sellerDeliverySpeed,
                SellerServiceAttitude = _sellerServiceAttitude,
                Description = vshop.Description,
                ShopId = vshop.ShopId,
                Id = vshop.Id,
                //Logo = "http://" + Url.Request.RequestUri.Host+vshop.Logo
                Logo = Core.MallIO.GetRomoteImagePath(vshop.StrLogo)
            };
            dynamic result = SuccessResult();
            result.VShop = vshopModel;
            return result;
        }
        //新增或删除店铺收藏

        [HttpPost("PostAddFavoriteShop")]
        public object PostAddFavoriteShop(VShopAddFavoriteShopModel value)
        {
            CheckUserLogin();
            long shopId = value.shopId;
            var favoriteTShopIds = ServiceProvider.Instance<IShopService>.Create.GetFavoriteShopInfos(CurrentUser.Id).Select(item => item.ShopId).ToArray();
            if (favoriteTShopIds.Contains(shopId))
            {
                ServiceProvider.Instance<IShopService>.Create.CancelConcernShops(shopId, CurrentUser.Id);
                return SuccessResult("取消成功");
            }
            else
            {
                ServiceProvider.Instance<IShopService>.Create.AddFavoriteShop(CurrentUser.Id, shopId);
                return SuccessResult("关注成功");
            }
        }

        [HttpGet("GetVShopSearchProducts")]
        public object GetVShopSearchProducts(long vshopId,
        string keywords = "", /* 搜索关键字 */
        string exp_keywords = "", /* 渐进搜索关键字 */
        long cid = 0,  /* 分类ID */
        long b_id = 0, /* 品牌ID */
        string a_id = "",  /* 属性ID, 表现形式：attrId_attrValueId */
        int orderKey = 1, /* 排序项（1：默认，2：销量，3：价格，4：评论数，5：上架时间） */
        int orderType = 1, /* 排序方式（1：升序，2：降序） */
        int pageNo = 1, /*页码*/
        int pageSize = 10 /*每页显示数据量*/
        )
        {
            long total;
            long shopId = -1;
            var vshop = ServiceProvider.Instance<IVShopService>.Create.GetVShop(vshopId);
            if (vshop != null)
                shopId = vshop.ShopId;

            if (!string.IsNullOrWhiteSpace(keywords))
                keywords = keywords.Trim();

            ProductSearch model = new ProductSearch()
            {
                shopId = shopId,
                BrandId = b_id,
                Ex_Keyword = exp_keywords,
                Keyword = keywords,
                OrderKey = orderKey,
                OrderType = orderType == 1,
                AttrIds = new System.Collections.Generic.List<string>(),
                PageNumber = pageNo,
                PageSize = pageSize,
                ShopCategoryId = cid
            };

            var productsResult = ServiceProvider.Instance<IProductService>.Create.SearchProduct(model);
            total = productsResult.Total;
            var products = productsResult.Models.ToArray();
  
            var productsModel = products.Select(item =>
                new ProductItem()
                {
                    Id = item.Id,
                    ImageUrl = Core.MallIO.GetRomoteProductSizeImage(item.RelativePath, 1, (int)CommonModel.ImageSize.Size_350),
                    SalePrice = item.MinSalePrice,
                    Name = item.ProductName,
                    //TODO:FG 循环内调用
                    CommentsCount = CommentApplication.GetProductCommentCount(item.Id),
                }
            );
            var bizCategories = ServiceProvider.Instance<IShopCategoryService>.Create.GetShopCategory(shopId);
            var shopCategories = GetSubCategories(bizCategories, 0, 0);
            //统计店铺访问人数
            StatisticApplication.StatisticShopVisitUserCount(vshop.ShopId);
            dynamic result = SuccessResult();
            result.ShopCategory = shopCategories;
            result.Products = productsModel;
            result.VShopId = vshopId;
            result.Keywords = keywords;
            result.total = total;
            return result;
        }



        private object GetCouponList(long shopid)
        {
            var service = ServiceProvider.Instance<ICouponService>.Create;
            var result = service.GetCouponList(shopid);
            var couponSetList = ServiceProvider.Instance<IVShopService>.Create.GetVShopCouponSetting(shopid).Where(d => d.PlatForm == PlatformType.Wap).Select(item => item.CouponID);
            if (result.Count() > 0 && couponSetList.Count() > 0)
            {
                var couponList = result.ToArray().Where(item => couponSetList.Contains(item.Id)).Select(item => new
                {
                    Id = item.Id,
                    Price = item.Price.ToString("F2"),
                    OrderAmount = item.OrderAmount.ToString("F2")
                });//取设置的优惠券
                return couponList;
            }
            return null;
        }

        IEnumerable<CategoryModel> GetSubCategories(IEnumerable<Entities.ShopCategoryInfo> allCategoies, long categoryId, int depth)
        {
            var categories = allCategoies
                .Where(item => item.ParentCategoryId == categoryId&&item.IsShow)
                .Select(item =>
                {
                    string image = string.Empty;
                    return new CategoryModel()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        SubCategories = GetSubCategories(allCategoies, item.Id, depth + 1),
                        Depth = 1
                    };
                }).OrderBy(item => item.Id);
            return categories;
        }
    }
}
