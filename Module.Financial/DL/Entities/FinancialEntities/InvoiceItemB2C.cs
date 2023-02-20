using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Financial.DL.Entities.FinancialEntities
{
    internal class InvoiceItemB2C : BaseDomain
    {
        public Guid InvoiceId { get; set; }

        public int ItemId { get; set; }

        public string ItemAr { get; set; }

        public string ItemEn { get; set; }

        public int Quantity { get; set; }

        public decimal PricePerPart { get; set; }

        public decimal TotalPrice { get; set; }

    }
}
