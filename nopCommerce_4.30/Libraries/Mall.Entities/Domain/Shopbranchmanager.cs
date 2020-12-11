﻿using System;
using System.Collections.Generic;

namespace Mall.Entities.Domain
{
    public partial class ShopBranchManagerInfo
    {
        public long Id { get; set; }
        public long ShopBranchId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public DateTime CreateDate { get; set; }
        public string Remark { get; set; }
        public string RealName { get; set; }
    }
}