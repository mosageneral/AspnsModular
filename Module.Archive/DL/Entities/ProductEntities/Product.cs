using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Product.DL.Entities.ProductEntities
{
    internal class Product:BaseDomain
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public Guid SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public Guid ModelId { get; set; }
        public Model Model { get; set; }
        public int QTY { get; set; }
        public Guid VendorId { get; set; }
        public decimal BuyPriceRetail { get; set; }
        public decimal BuyPricewhole { get; set; }
        public decimal SellPrice { get; set; }
        public decimal ASPNSEarn { get; set; }
        public string Image { get; set; }
        public string PartNumber { get; set; }

    }
}
