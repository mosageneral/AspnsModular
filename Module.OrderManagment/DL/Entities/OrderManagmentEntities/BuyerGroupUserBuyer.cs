﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.OrderManagment.DL.Entities.OrderManagmentEntities
{
    internal class BuyerGroupUserBuyer:BaseDomain
    {
        public Guid BuyerId { get; set; }
        public Guid BuyerGroupId { get; set; }
        public BuyerGroup BuyerGroup { get; set; }
    }
}
