﻿using Mall.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Mall.IServices
{
    public interface IWeixinMenuService : IService
    {
        /// <summary>
        /// 获取微信自定义菜单的所有主分类
        /// </summary>
        /// <returns></returns>
        List<MenuInfo> GetMainMenu(long shopId);

        /// <summary>
        /// 获取指定菜单下的子菜单
        /// </summary>
        /// <param name="id">父类ID</param>
        /// <returns></returns>
        List<MenuInfo> GetMenuByParentId(long id);

        /// <summary>
        /// 添加一个菜单
        /// </summary>
        /// <param name="model">Menu实体</param>
        void AddMenu(MenuInfo model);
        
        /// <summary>
        /// 获取一个菜单
        /// </summary>
        /// <returns></returns>
        MenuInfo GetMenu(long id);


        /// <summary>
        /// 根据Menus实体更新菜单
        /// </summary>
        /// <param name="model">Menu实体</param>
        void UpdateMenu(MenuInfo model);

        /// <summary>
        /// 根据ID删除菜单
        /// </summary>
        /// <param name="id">主键ID</param>
        void DeleteMenu(long id);

        /// <summary>
        /// 菜单同步至微信
        /// </summary>
        /// <param name="shopId">店铺ID</param>
        void ConsistentToWeixin(long shopId);

        List<MobileFootMenuInfo> GetFootMenus();

        MobileFootMenuInfo GetFootMenusById(long id);
        void UpdateMobileFootMenu(MobileFootMenuInfo footmenu);
        void AddMobileFootMenu(MobileFootMenuInfo footmenu);

        void DeleteFootMenu(long id);
    }
}
