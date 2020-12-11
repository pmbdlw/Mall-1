﻿using Mall.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Mall.IServices
{
    public interface ISlideAdsService : IService
    {
        #region 手动轮播广告图片
        /// <summary>
        /// 获取手动轮播广告图片
        /// </summary>
        /// <returns></returns>
        List<HandSlideAdInfo> GetHandSlidAds();

        /// <summary>
        /// 添加一个手动轮播广告图片
        /// </summary>
        /// <param name="model"></param>
        void AddHandSlidAd(HandSlideAdInfo model);

        /// <summary>
        /// 删除一个手动轮播广告图片
        /// </summary>
        /// <param name="id"></param>
        void DeleteHandSlidAd(long id);

        /// <summary>
        /// 更新一个手动轮播广告图片
        /// </summary>
        /// <param name="models"></param>
        void UpdateHandSlidAd(HandSlideAdInfo models);

        /// <summary>
        /// 获取一个手动轮播广告图片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        HandSlideAdInfo GetHandSlidAd(long id);

        /// <summary>
        /// 给一个手动轮播广告图片排序
        /// </summary>
        /// <param name="id">手动轮播广告图片Id</param>
        /// <param name="direction">排序方向（true：前进   false：后退）</param>
        void AdjustHandSlidAdIndex(long id, bool direction);

        #endregion


        #region 自动轮播广告图片
        /// <summary>
        /// 获取自动轮播广告图片
        /// </summary>
        /// <returns></returns>
        List<SlideAdInfo> GetSlidAds(long shopId, SlideAdInfo.SlideAdType type);
        /// <summary>
        /// 获取广告位,如未初始化则初始化
        /// </summary>
        /// <param name="shopId"></param>
        /// <param name="slidAdsType"></param>
        /// <returns></returns>
        IEnumerable<SlideAdInfo> GetSlidAdsOrInit(long shopId, SlideAdInfo.SlideAdType? slidAdsType = SlideAdInfo.SlideAdType.Initial);

        /// <summary>
        /// 根据类型列表取首页轮播图
        /// </summary>
        /// <param name="shopId"></param>
        /// <param name="types"></param>
        /// <returns></returns>
        IEnumerable<SlideAdInfo> GetSlidAdsByTypes(long shopId, IEnumerable<SlideAdInfo.SlideAdType> types);
        /// <summary>
        /// 获取一个自动轮播广告图片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        SlideAdInfo GetSlidAd(long shopId, long id);

        /// <summary>
        /// 添加一个自动轮播广告图片
        /// </summary>
        /// <param name="model"></param>
        void AddSlidAd(SlideAdInfo model);

        /// <summary>
        /// 删除一个自动轮播广告图片
        /// </summary>
        /// <param name="id"></param>
        void DeleteSlidAd(long shopId, long id);

        /// <summary>
        /// 更新一个自动轮播广告图片
        /// </summary>
        /// <param name="models"></param>
        SlideAdInfo UpdateSlidAd(SlideAdInfo models);

        /// <summary>
        /// 给一个自动轮播广告图片排序
        /// </summary>
        /// <param name="id">自动轮播广告图片Id</param>
        /// <param name="direction">排序方向（true：前进   false：后退）</param>
        void AdjustSlidAdIndex(long shopId, long id, bool direction, SlideAdInfo.SlideAdType type);

        /// <summary>
        /// 排序上下移
        /// </summary>
        /// <param name="sourceSequence"></param>
        /// <param name="destiSequence"></param>
        void UpdateWeixinSlideSequence(long shopId, long sourceSequence, long destiSequence, SlideAdInfo.SlideAdType type);
        bool DelSlideAdByType(long shopId, SlideAdInfo.SlideAdType type);
        void BatchAddShopHome(List<SlideAdInfo> slides, long shopId);
        #endregion

        #region 普通广告图片

        void UpdateImageAd(ImageAdInfo model);

        IEnumerable<ImageAdInfo> GetImageAds(long shopId,Mall.CommonModel.ImageAdsType? ImageAdsType =Mall.CommonModel.ImageAdsType.Initial);


        ImageAdInfo GetImageAd(long shopId, long id);


        /// <summary>
        /// 添加APP引导页
        /// </summary>
        /// <param name="models"></param>
        void AddGuidePages(List<SlideAdInfo> models);

        #endregion

        //#region  微信轮播图
        ///// <summary>
        ///// 获取微信端轮播图
        ///// </summary>
        //IQueryable<SlideAdInfo> GetWeixinSlidAd();

        ///// <summary>
        ///// 根据ID获取轮播图实体
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //SlideAdInfo GetWeixinSlidAdById(long id);

        ///// <summary>
        ///// 新增微信端轮播图
        ///// </summary>
        ///// <param name="model"></param>
        //void AddWeixinSlidAd(SlideAdInfo model);

        ///// <summary>
        ///// 修改微信端轮播图
        ///// </summary>
        ///// <param name="model"></param>
        //void UpdateWeixinSlidAd(SlideAdInfo model);

        ///// <summary>
        ///// 删除微信轮播图
        ///// </summary>
        ///// <param name="id"></param>
        //void DeleteWeixinSlidAd(long id);


        //#endregion
    }
}
