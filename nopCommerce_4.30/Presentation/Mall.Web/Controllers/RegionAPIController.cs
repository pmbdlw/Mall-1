﻿using Mall.Application;
using Mall.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;


namespace Mall.Web.Controllers
{
    public class RegionAPIController : Controller
    {
        private IRegionService _iRegionService;
        public RegionAPIController(IRegionService iRegionService)
        {
            _iRegionService = iRegionService;
        }

        [HttpPost]
        public JsonResult GetRegion(long? key = null, int? level = -1)
        {
            if (level == -1)
                key = 0;

            if (key.HasValue)
            {
                var regions = _iRegionService.GetRegion(key.Value);
                return Json(regions);
            }
            else
                return Json(new object[] { });
        }

        /// <summary>
        /// 获取 下级区域数据
        /// </summary>
        /// <param name="parent"></param>
        /// <returns></returns>
        public JsonResult GetSubRegion(int parent, bool bAddAll = false)
        {
            var regions = RegionApplication.GetSubRegion(parent);
            var models = regions.Select(p => new
            {
                p.Id,
                p.Name,
                p.ShortName,
                p.Level
            }).ToList();
            if (bAddAll && models.Any(n => n.Level == CommonModel.Region.RegionLevel.Town))
            {
                models.Insert(0, new { Id = 0, Name = "其它", ShortName = "其它", Level = CommonModel.Region.RegionLevel.Town });
            }
            return Json(models);
        }

        /// <summary>
        /// 获取 一串区域数据(用于绑定区域控件默认数据)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetRegionTree(int id)
        {
            var region = RegionApplication.GetRegion(id);

            if (region == null)
            {
                var rid = RegionApplication.GetDefaultRegionId();
                region = RegionApplication.GetRegion(rid);
            }


            Dictionary<string, object> map = new Dictionary<string, object>();
            //[
            //{ level:1,list:[{id,name,shortname}]},
            //{ level:2,list:[{id,name,shortname}]},
            //{ level:3,list:[{id,name,shortname}]},
            //]

            //添加子集
            if (region.Sub != null)
            {
                map.Add(
                    ((int)region.Level + 1).ToString(),
                    region.Sub.Select(p => new
                    {
                        Id = p.Id,
                        Name = p.Name,
                        ShortName = p.ShortName,
                        option = "",
                    }).ToList());
            }
            var parent = 0;
            do
            {
                parent = region.ParentId;//上级节点
                var cur = region.Id;//当前节点
                var level = (int)region.Level;
                var regions = RegionApplication.GetSubRegion(parent);
                var list = regions.Select(p => new
                {
                    Id = p.Id,
                    Name = p.Name,
                    ShortName = p.ShortName,
                    option = p.Id == cur ? "true" : ""
                }).ToList();
                map.Add(level.ToString(), list);
                region = region.Parent;
            } while (parent > 0);
            return Json(map);
        }

     //   [OutputCache(Duration = 1000)]
        public JsonResult GetAllRegion()
        {
            var region = RegionApplication.GetAllRegions().ToList();
            //region = region.Where(p => p.ParentId == 1944).ToList();

            List<Mall.CommonModel.Region> regions = new List<CommonModel.Region>();
            var province = region.Where(a => a.Level == CommonModel.Region.RegionLevel.Province).ToList();
            foreach (var r in province)
            {
                var model = new CommonModel.Region();
                model.Id = r.Id;
                model.Level = r.Level;
                model.Name = r.Name;
                model.ShortName = r.ShortName;
                //var sub = RegionApplication.GetSubRegion(r.Id);
                //var city = sub.Select(a => new Mall.CommonModel.Region()
                //{
                //    Id = a.Id,
                //    Name = a.Name,
                //    ShortName = a.ShortName,
                //    Level = CommonModel.Region.RegionLevel.City,
                //    Sub = new List<CommonModel.Region>()
                //}).ToList();
                //model.Sub = city;
                //foreach (var m in model.Sub)
                //{
                //    var citySub = RegionApplication.GetSubRegion(m.Id);
                //    var county = citySub.Select(a => new Mall.CommonModel.Region()
                //    {
                //        Id = a.Id,
                //        Name = a.Name,
                //        Sub = new List<CommonModel.Region>()
                //    }).ToList();
                //    m.Sub = county;
                //    foreach (var v in m.Sub)
                //    {
                //        var villageSub = RegionApplication.GetSubRegion(v.Id);
                //        var village = villageSub.Select(a => new Mall.CommonModel.Region()
                //        {
                //            Id = a.Id,
                //            Name = a.Name
                //        }).ToList();
                //        v.Sub = village;
                //    }
                //}
                regions.Add(model);
            }
            // string json = Newtonsoft.Json.JsonConvert.SerializeObject(regions);

            // return json;
            return Json(regions);
        }
    }
}

