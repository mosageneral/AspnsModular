using AutoMapper;
using BL.Infrastructure;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Module.OrderManagment.DL.DTO.OrderManagmentDto;
using Module.OrderManagment.DL.Entities.OrderManagmentEntities;
using Shared.Infrastructure.Extensions;
using Shared.Models.Constant;
using Shared.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace Module.OrderManagment.Controllers
{
    [ApiController]
    [EnableCors("MyPolicy")]
    [Route("/api/OrderManagment/[controller]")]
  //  [ClaimRequirement(ClaimTypes.Role, PermissionsConst.Archive)]
    internal class OrderManagmentController : ControllerBase
    {
        private readonly IGetProductById getProductById;
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper Mapper;
        private readonly IHostingEnvironment hostingEnvironment;

        public OrderManagmentController(IGetProductById getProductById, IUnitOfWork unitOfWork, IMapper mapper, IHostingEnvironment _hostingEnvironment)
        {
            this.getProductById = getProductById;
            this.unitOfWork = unitOfWork;
            Mapper = mapper;
            hostingEnvironment = _hostingEnvironment;
        }
        #region WareHouse 
        [HttpPost,Route("CreateWareHouse")]
        public IActionResult CreateWareHouse(WareHouse wareHouse)
        {
            unitOfWork.WareHouseRepository.Add(wareHouse);
            unitOfWork.Save();
            return Ok(wareHouse);
        }
        [HttpPost, Route("DeleteWareHouse")]
        public IActionResult DeleteWareHouse(Guid Id)
        {
            unitOfWork.WareHouseRepository.Delete(Id);
            unitOfWork.Save();
            return Ok();
        }
        [HttpPost, Route("UpdateWareHouse")]
        public IActionResult UpdateWareHouse(WareHouse wareHouse)
        {
            unitOfWork.WareHouseRepository.Update(wareHouse);
            unitOfWork.Save();
            return Ok(wareHouse);
        }
        [HttpGet, Route("GetWareHouse")]
        public IActionResult GetWareHouse(Guid Id)
        {
          var WareHouse =  unitOfWork.WareHouseRepository.GetById(Id);
            
            return Ok(WareHouse);
        }
        [HttpGet, Route("GetAllWareHouse")]
        public IActionResult GetAllWareHouse()
        {
            var WareHouse = unitOfWork.WareHouseRepository.GetAll().ToHashSet();
           
            return Ok(WareHouse);
        }
        #endregion



        #region VendorGroup 
        [HttpPost, Route("CreateVendorGroup")]
        public IActionResult CreateVendorGroup(VendorGroup VendorGroup)
        {
            unitOfWork.VendorGroupRepository.Add(VendorGroup);
            unitOfWork.Save();
            return Ok(VendorGroup);
        }
        [HttpPost, Route("DeleteVendorGroup")]
        public IActionResult DeleteVendorGroup(Guid Id)
        {
            unitOfWork.VendorGroupRepository.Delete(Id);
            unitOfWork.Save();
            return Ok();
        }
        [HttpPost, Route("UpdateVendorGroup")]
        public IActionResult UpdateVendorGroup(VendorGroup VendorGroup)
        {
            unitOfWork.VendorGroupRepository.Update(VendorGroup);
            unitOfWork.Save();
            return Ok(VendorGroup);
        }
        [HttpGet, Route("GetVendorGroup")]
        public IActionResult GetVendorGroup(Guid Id)
        {
            var VendorGroup = unitOfWork.VendorGroupRepository.GetById(Id);

            return Ok(VendorGroup);
        }
        [HttpGet, Route("GetAllVendorGroup")]
        public IActionResult GetAllVendorGroup()
        {
            var VendorGroup = unitOfWork.VendorGroupRepository.GetAll().ToHashSet();

            return Ok(VendorGroup);
        }
        #endregion


        #region BuyerGroup 
        [HttpPost, Route("CreateBuyerGroup")]
        public IActionResult CreateBuyerGroup(BuyerGroup BuyerGroup)
        {
            unitOfWork.BuyerGroupRepository.Add(BuyerGroup);
            unitOfWork.Save();
            return Ok(BuyerGroup);
        }
        [HttpPost, Route("DeleteBuyerGroup")]
        public IActionResult DeleteBuyerGroup(Guid Id)
        {
            unitOfWork.BuyerGroupRepository.Delete(Id);
            unitOfWork.Save();
            return Ok();
        }
        [HttpPost, Route("UpdateBuyerGroup")]
        public IActionResult UpdateBuyerGroup(BuyerGroup BuyerGroup)
        {
            unitOfWork.BuyerGroupRepository.Update(BuyerGroup);
            unitOfWork.Save();
            return Ok(BuyerGroup);
        }
        [HttpGet, Route("GetBuyerGroup")]
        public IActionResult GetBuyerGroup(Guid Id)
        {
            var BuyerGroup = unitOfWork.BuyerGroupRepository.GetById(Id);

            return Ok(BuyerGroup);
        }
        [HttpGet, Route("GetAllBuyerGroup")]
        public IActionResult GetAllBuyerGroup()
        {
            var BuyerGroup = unitOfWork.BuyerGroupRepository.GetAll().ToHashSet();

            return Ok(BuyerGroup);
        }
        #endregion


        #region Order 
        [HttpPost,Route("Order")]
        public IActionResult Order(OrderDTo orderDTo)
        {
           List<OrderItem> OrderItems = new List<OrderItem>();
            foreach (var item in orderDTo.ProductsIds)
            {
                var product =  getProductById.GetProductById(item);

                var name = product.GetType().GetProperty("NameAr").GetValue(product, null);
            }
            return Ok(orderDTo);
        }
        [HttpPost, Route("GetAllOrders")]
        public IActionResult GetAllOrders()
        {
           
            return Ok(unitOfWork.OrderRepository.GetAll().ToHashSet());
        }
        #endregion
    }
}
