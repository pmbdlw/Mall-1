﻿using Mall.Core;
using Mall.Web.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Mall.Web;
using Mall.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Mall.Web.Areas.SellerAdmin.Controllers
{
    public class MobileHomeProductsController : BaseSellerController
    {
        IMobileHomeProductsService _iMobileHomeProductsService;
        IBrandService _iBrandService;
        ICategoryService _iCategoryService;
        IShopCategoryService _iShopCategoryService;
        MobileHomeProducts mobileHomeproduct;
        public MobileHomeProductsController(
             IMobileHomeProductsService iMobileHomeProductsService,
            IBrandService iBrandService,
            ICategoryService iCategoryService,
            IShopCategoryService iShopCategoryService

            )
        {
            _iBrandService = iBrandService;
            _iCategoryService = iCategoryService;
            _iMobileHomeProductsService = iMobileHomeProductsService;
            _iShopCategoryService = iShopCategoryService;
            mobileHomeproduct = new MobileHomeProducts();
        }
        [HttpPost]
        public JsonResult GetMobileHomeProducts(PlatformType platformType, int page, int rows, string brandName, string productName, long? categoryId = null)
        {
            object model = mobileHomeproduct.GetSellerMobileHomePageProducts(CurrentSellerManager.ShopId, platformType, page, rows, brandName, categoryId);
            return Json(model);
        }

        [HttpPost]
        public JsonResult AddHomeProducts(string productIds, PlatformType platformType)
        {
            if (string.IsNullOrEmpty(productIds)) return Json(new { success = true });
            mobileHomeproduct.AddHomeProducts(CurrentSellerManager.ShopId, productIds, platformType);
            return Json(new { success = true });
        }

        [HttpPost]
        public JsonResult UpdateSequence(long id, short sequence)
        {
            mobileHomeproduct.UpdateSequence(CurrentSellerManager.ShopId, id, sequence);
            return Json(new { success = true });
        }

        [HttpPost]
        public JsonResult Delete(long id)
        {
            mobileHomeproduct.Delete(CurrentSellerManager.ShopId, id);
            return Json(new { success = true });
        }

        [HttpPost]
        public JsonResult GetAllHomeProductIds(PlatformType platformType)
        {
            var homeProductIds = mobileHomeproduct.GetAllHomeProductIds(CurrentSellerManager.ShopId, platformType);
            return Json(homeProductIds);
        }
    }
}