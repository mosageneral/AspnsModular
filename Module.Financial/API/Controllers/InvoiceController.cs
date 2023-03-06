using AutoMapper;
using BL.Infrastructure;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Module.Financial.DL.DTO.FinancialEntitiesDTO;
using Module.Financial.DL.Entities.FinancialEntities;
using Shared.Infrastructure.Extensions;
using Shared.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace Module.Archive.Controllers
{
    [ApiController]
    [EnableCors("MyPolicy")]
    [Route("/api/Financial/[controller]")]
  //  [ClaimRequirement(ClaimTypes.Role, PermissionsConst.Archive)]
    internal class InvoiceController : ControllerBase
    {
        private readonly IGetOrderItems getOrderItems;
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper Mapper;
        private readonly IHostingEnvironment hostingEnvironment;

        public InvoiceController( IGetOrderItems getOrderItems , IUnitOfWork unitOfWork, IMapper mapper, IHostingEnvironment _hostingEnvironment)
        {
            this.getOrderItems = getOrderItems;
            this.unitOfWork = unitOfWork;
            Mapper = mapper;
            hostingEnvironment = _hostingEnvironment;
        }
     
        [HttpPost, Route("CreateB2BInvoice")]
        public IActionResult CreateB2BInvoice(InvoiceB2BDTO invoiceB2BDTO)
        {
            var invoice = Mapper.Map<InvoiceB2B>(invoiceB2BDTO);

            // Get last invoice number 
            var invoicenumber = unitOfWork.B2BInvoiceRepository.GetAll().OrderByDescending(t => t.InvoiceNumber).FirstOrDefault();
            if (invoicenumber == null)
            {
                invoice.InvoiceNumber = 1;
            }
            else
            {
                int lastnumber = invoicenumber.InvoiceNumber;
                invoice.InvoiceNumber = lastnumber + 1;
            }
            
            invoice.InvoiceSerial = "IN-" + "ASPNS" + "-" + invoice.InvoiceNumber;

            invoice.TotalBeforeDiscount = invoice.PriceParts + invoice.DeliveryCost;
            invoice.TotalAfterDiscount = invoice.TotalBeforeDiscount - invoice.Discount;
            invoice.VAT = invoice.TotalAfterDiscount * (15/100);
            invoice.TotalCost = invoice.TotalAfterDiscount + invoice.VAT;

            unitOfWork.B2BInvoiceRepository.Add(invoice);
            unitOfWork.Save();
           

           
            return Ok(invoice);

        }
         


        #region B2CInvoice

       
        // Create B2C Invoice  
        [HttpPost, Route("CreateB2CInvoice")]
        public IActionResult CreateB2CInvoice(InvoiceB2CDTO invoiceB2CDTO)
        {
            var invoice = Mapper.Map<InvoiceB2C>(invoiceB2CDTO);

            // Get last invoice number 
            var invoicenumber = unitOfWork.B2CInvoiceRepository.GetAll().OrderByDescending(t => t.InvoiceNumber).FirstOrDefault();
            if (invoicenumber == null)
            {
                invoice.InvoiceNumber = 1;
            }
            else
            {
                int lastnumber = invoicenumber.InvoiceNumber;
                invoice.InvoiceNumber = lastnumber + 1;
            }

            invoice.InvoiceSerial = "IN-"  + invoice.InvoiceNumber;

            // get items to calculate priceparts
            var OrderItems = getOrderItems.GetItems(invoice.OrderId).ToHashSet();
            decimal TotalPrice = 0;
          
            if (OrderItems != null)
            {
                foreach (var item in OrderItems)
                {

                    var Qty = (int)item.GetType().GetProperty("QTY").GetValue(item, null);
                    var PeacePrice = item.GetType().GetProperty("Price").GetValue(item, null).ToString();
                    decimal pricepart = System.Convert.ToDecimal(PeacePrice);
                    var Cost = Qty * pricepart;
                    TotalPrice += Cost;
                }

            }
            invoice.PriceParts = TotalPrice;

            var PercentVat = 15;
            var vat = (decimal)PercentVat / 100;
            invoice.TotalBeforeDiscount = invoice.PriceParts + invoice.DeliveryCost + invoice.OverHead + invoice.DeliverySubTWare;
            invoice.TotalAfterDiscount = invoice.TotalBeforeDiscount - invoice.Discount;
            invoice.VAT = invoice.TotalAfterDiscount * vat;
            invoice.TotalCost = invoice.TotalAfterDiscount + invoice.VAT ;

            unitOfWork.B2CInvoiceRepository.Add(invoice);
            unitOfWork.Save();

            
            

            foreach (var item in OrderItems)
            {
                var Additem = new InvoiceItemB2C();
                Additem.InvoiceId = invoice.Id;

                Additem.ItemAr = item.GetType().GetProperty("NameAr").GetValue(item, null).ToString();
                Additem.ItemEn = item.GetType().GetProperty("NameEn").GetValue(item, null).ToString();
                Additem.Quantity = (int)item.GetType().GetProperty("QTY").GetValue(item, null);
                var PeacePrice = item.GetType().GetProperty("Price").GetValue(item, null).ToString();
                Additem.PricePerPart = System.Convert.ToDecimal(PeacePrice);
                Additem.TotalPrice = Additem.Quantity * Additem.PricePerPart;

                unitOfWork.B2CInvoiceItemRepository.Add(Additem);
                unitOfWork.Save();     
            }
            var invoiceitem = unitOfWork.B2CInvoiceItemRepository.GetMany(a => a.InvoiceId == invoice.Id);

            return Ok(new { Invoice = invoice , invoiceItem = invoiceitem });

        }


        // Get all B2C Invoices
        [HttpGet, Route("GetAllB2CInvoice")]
        public IActionResult GetAllB2CInvoice()
        {
            return Ok(unitOfWork.B2CInvoiceRepository.GetAll().ToHashSet());
        }


        // Get  B2C Invoices By InvoiceId
        [HttpGet, Route("GetB2CInvoiceByInvoiceId")]
        public IActionResult GetB2CInvoiceByInvoiceId(Guid invoiceid)
        {
            return Ok(unitOfWork.B2CInvoiceRepository.GetById(invoiceid));
        }

        // Get  B2C Invoices By buyerid
        [HttpGet, Route("GetB2CInvoiceByBuyerId")]
        public IActionResult GetB2CInvoiceByBuyerId(Guid buyerid)
        {
            return Ok(unitOfWork.B2CInvoiceRepository.GetMany(a=>a.BuyerId == buyerid).ToHashSet());
        }



        #endregion
    }
}
