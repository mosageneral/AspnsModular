﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Product.DL.Entities.ProductEntities
{
    internal class Year:BaseDomain
    {
        public string Name { get; set; }
        public Guid ModelId { get; set; }
        public Model Model { get; set; }
    }
}
