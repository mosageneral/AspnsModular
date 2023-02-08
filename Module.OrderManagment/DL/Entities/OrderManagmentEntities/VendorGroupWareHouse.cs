using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.OrderManagment.DL.Entities.OrderManagmentEntities
{
    internal class VendorGroupWareHouse:BaseDomain
    {
        public Guid VendorId { get; set; }
        public Guid WareHouseId { get; set; }
        public WareHouse WareHouse { get; set; }

    }
}
