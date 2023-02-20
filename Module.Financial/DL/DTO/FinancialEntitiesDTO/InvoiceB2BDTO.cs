using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Financial.DL.DTO.FinancialEntitiesDTO
{
    internal class InvoiceB2BDTO
    {
        public int InvoiceNumber { get; set; }

        public string InvoiceSerial { get; set; }
        public Guid OrderId { get; set; }
        public Guid VendorId { get; set; }

        public string VendorNameAr { get; set; }

        public string VendorNameEn { get; set; }

        public string VendorPhone { get; set; }

        public decimal PriceParts { get; set; }

        public decimal DeliveryCost { get; set; }

        public decimal TotalBeforeDiscount { get; set; }

        public decimal Discount { get; set; }

        public decimal TotalAfterDiscount { get; set; }

        public decimal VAT { get; set; }

        public decimal TotalCost { get; set; }

    }
}
