//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mall.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserMemberInfo:BaseModel
    {
        public UserMemberInfo()
        {
            this.FavoriteInfo = new HashSet<FavoriteInfo>();
            this.MemberOpenIdInfo = new HashSet<MemberOpenIdInfo>();
            this.ShippingAddressInfo = new HashSet<ShippingAddressInfo>();
            this.ShoppingCartInfo = new HashSet<ShoppingCartItemInfo>();
            this.FavoriteShops = new HashSet<FavoriteShopInfo>();
            this.BrowsingHistory = new HashSet<BrowsingHistoryInfo>();
            this.ProductComments = new HashSet<ProductCommentInfo>();
            this.MemberIntegralRecord = new HashSet<MemberIntegralRecord>();
            this.MemberIntegral = new HashSet<MemberIntegral>();
            this.InviteMemberRecord = new HashSet<InviteRecordInfo>();
            this.RegMemberRecord = new HashSet<InviteRecordInfo>();
            this.BonusReceive = new HashSet<BonusReceiveInfo>();
            this.ShopBonusReceive = new HashSet<ShopBonusReceiveInfo>();
            this.ShopBonusGrant = new HashSet<ShopBonusGrantInfo>();
            this.AgentProducts = new HashSet<AgentProductsInfo>();
            this.Promoter = new HashSet<PromoterInfo>();
            this.DistributionUserLink = new HashSet<DistributionUserLinkInfo>();
        }
    
        long _id;
        public new long Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string Email { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int TopRegionId { get; set; }
        public int RegionId { get; set; }
        public string RealName { get; set; }
        public string CellPhone { get; set; }
        public string QQ { get; set; }
        public string Address { get; set; }
        public bool Disabled { get; set; }
        public System.DateTime LastLoginDate { get; set; }
        public int OrderNumber { get; set; }
        public decimal Expenditure { get; set; }
        public int Points { get; set; }
        public string Nick { get; set; }
        public string photo { get; set; }
        public long ParentSellerId { get; set; }
        public string Remark { get; set; }
        public string PayPwd { get; set; }
        public string PayPwdSalt { get; set; }
        public Nullable<long> InviteUserId { get; set; }
        public Nullable<Mall.CommonModel.SexType> Sex { get; set; }
        public Nullable<long> ShareUserId { get; set; }
        public decimal TotalAmount { get; set; }
        public Nullable<System.DateTime> BirthDay { get; set; }
        public string Occupation { get; set; }
        public decimal NetAmount { get; set; }
        public Nullable<System.DateTime> LastConsumptionTime { get; set; }
    
        public virtual ICollection<FavoriteInfo> FavoriteInfo { get; set; }
        public virtual ICollection<MemberOpenIdInfo> MemberOpenIdInfo { get; set; }
        public virtual ICollection<ShippingAddressInfo> ShippingAddressInfo { get; set; }
        public virtual ICollection<ShoppingCartItemInfo> ShoppingCartInfo { get; set; }
        public virtual ICollection<FavoriteShopInfo> FavoriteShops { get; set; }
        public virtual ICollection<BrowsingHistoryInfo> BrowsingHistory { get; set; }
        public virtual ICollection<ProductCommentInfo> ProductComments { get; set; }
        public virtual ICollection<MemberIntegralRecord> MemberIntegralRecord { get; set; }
        public virtual ICollection<MemberIntegral> MemberIntegral { get; set; }
        public virtual ICollection<InviteRecordInfo> InviteMemberRecord { get; set; }
        public virtual ICollection<InviteRecordInfo> RegMemberRecord { get; set; }
        public virtual ICollection<BonusReceiveInfo> BonusReceive { get; set; }
        public virtual ICollection<ShopBonusReceiveInfo> ShopBonusReceive { get; set; }
        public virtual ICollection<ShopBonusGrantInfo> ShopBonusGrant { get; set; }
        public virtual ICollection<AgentProductsInfo> AgentProducts { get; set; }
        public virtual ICollection<PromoterInfo> Promoter { get; set; }
        public virtual ICollection<DistributionUserLinkInfo> DistributionUserLink { get; set; }
    }
}
