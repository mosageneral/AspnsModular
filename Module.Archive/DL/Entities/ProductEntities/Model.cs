using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Product.DL.Entities.ProductEntities
{
    internal class Model:BaseDomain
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public Guid MakeId { get; set; }
        public Make Make { get; set; }

    }
}
