using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Product.DL.Entities.ProductEntities
{
    internal class SubCategory:BaseDomain
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
