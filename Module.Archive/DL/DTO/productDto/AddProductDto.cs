using Module.Product.DL.Entities.ProductEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Product.DL.DTO.productDto
{
    internal class AddProductDto
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public Guid SubCategoryId { get; set; }
      
        public Guid ModelId { get; set; }
     
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
