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

            invoice.InvoiceSerial = "IN-" + "ASPNS" + "-" + invoice.InvoiceNumber;

            invoice.TotalBeforeDiscount = invoice.PriceParts + invoice.DeliveryCost;
            invoice.TotalAfterDiscount = invoice.TotalBeforeDiscount - invoice.Discount;
            invoice.VAT = invoice.TotalAfterDiscount * (15 / 100);
            invoice.TotalCost = invoice.TotalAfterDiscount + invoice.VAT;

            unitOfWork.B2CInvoiceRepository.Add(invoice);
            //unitOfWork.Save();

            var OrderItems = getOrderItems.GetItems(invoice.OrderId).ToHashSet();
            //List<InvoiceItemB2C> ItemList = new List<InvoiceItemB2C>();

            foreach (var item in OrderItems)
            {
                var Additem = new InvoiceItemB2C();
                Additem.InvoiceId = invoice.Id;

                Additem.ItemAr = item.GetType().GetProperty("ItemAr").GetValue(item, null).ToString();


                //unitOfWork.B2CInvoiceItemRepository.Add(Additem);
            }

            return Ok(invoice);

        }

    }
}
