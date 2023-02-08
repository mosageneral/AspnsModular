using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.OrderManagment.DL.Entities.OrderManagmentEntities
{
    internal class OrderItem:BaseDomain
    {
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string Price { get; set; }
        public string image { get; set; }
        public Guid VendorId { get; set; }
        public string PartNumber { get; set; }
    }
}
