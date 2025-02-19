﻿using AutoMapper;
using BL.Infrastructure;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Module.Product.DL.DTO.productDto;
using Module.Product.DL.Entities.ProductEntities;
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


namespace Module.Archive.Controllers
{
    [ApiController]
    [EnableCors("MyPolicy")]
    [Route("/api/Product/[controller]")]
  //  [ClaimRequirement(ClaimTypes.Role, PermissionsConst.Archive)]
    internal class ProductController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper Mapper;
        private readonly IHostingEnvironment hostingEnvironment;

        public ProductController( IUnitOfWork unitOfWork, IMapper mapper, IHostingEnvironment _hostingEnvironment)
        {
          
            this.unitOfWork = unitOfWork;
            Mapper = mapper;
            hostingEnvironment = _hostingEnvironment;
        }
        [HttpPost,Route("AddCategory")]
        public IActionResult AddCategory(Category category)
        {
            unitOfWork.CategoryRepository.Add(category);
            unitOfWork.Save();
            return Ok(category);

        }
        [HttpPost, Route("AddSubCategory")]
        public IActionResult AddSubCategory(SubCategoryDto Subcategory)
        {
            var sub = Mapper.Map<Product.DL.Entities.ProductEntities.SubCategory>(Subcategory);

            unitOfWork.SubCategoryRepository.Add(sub);
            unitOfWork.Save();
            return Ok(sub);

        }
        [HttpGet,Route("GetAllSubcategoryByCategoryId")]
        public IActionResult GetAllSubcategoryByCategoryId(Guid CategoryId)
        {
           var SubCats = unitOfWork.SubCategoryRepository.GetMany(a=>a.CategoryId==CategoryId).ToHashSet();
            return Ok(SubCats);
        }
        [HttpGet, Route("GetAllcategory")]
        public IActionResult GetAllcategory()
        {
            var SubCats = unitOfWork.CategoryRepository.GetAll().ToHashSet();
            return Ok(SubCats);
        }
        [HttpPost,Route("AddMake")]
        public IActionResult AddMake(Make make)
        {
            unitOfWork.MakeRepository.Add(make);
            unitOfWork.Save();
            return Ok(make);
        }
        [HttpPost, Route("AddModel")]
        public IActionResult AddModel(ModelDTO Model)
        {
            var model = Mapper.Map<Product.DL.Entities.ProductEntities.Model>(Model);
            unitOfWork.ModelRepository.Add(model);
            unitOfWork.Save();
            return Ok(Model);
        }
        [HttpPost, Route("AddYear")]
        public IActionResult AddYear(YearDTO YearDTO)
        {
            var year = Mapper.Map<Product.DL.Entities.ProductEntities.Year>(YearDTO);
            unitOfWork.YearRepository.Add(year);
            unitOfWork.Save();
            return Ok(year);
        }
        [HttpGet,Route("GetAllMake")]
        public IActionResult GetAllMake()
        {
            return Ok(unitOfWork.MakeRepository.GetAll());
        }

        [HttpGet,Route("GetAllModelsByMakeId")]
        public IActionResult GetAllModelsByMakeId(Guid MakeId)
        {
            return Ok(unitOfWork.ModelRepository.GetMany(a => a.MakeId == MakeId).ToHashSet());
        }
        [HttpGet, Route("GetAllYearByModelId")]
        public IActionResult GetAllYearByModelId(Guid ModelId)
        {
            return Ok(unitOfWork.YearRepository.GetMany(a => a.ModelId == ModelId).ToHashSet());
        }

        [HttpPost,Route("AddProduct")]
        public IActionResult AddProduct(Product.DL.DTO.productDto.AddProductDto productDto)
        {
            var Product = Mapper.Map<Product.DL.Entities.ProductEntities.Product>(productDto);
            unitOfWork.ProductRepository.Add(Product);
            unitOfWork.Save();
            return Ok(Product);
        }
        [HttpGet,Route("GetALlProduct")]
        public IActionResult GetAllProduct()
        {
            return Ok(unitOfWork.ProductRepository.GetAll().ToHashSet());
        }
        [HttpGet, Route("GetProductByPartNumber")]
        public IActionResult GetProductByPartNumber(string PartNumber)
        {
            return Ok(unitOfWork.ProductRepository.GetMany(a=>a.PartNumber== PartNumber).ToHashSet());
        }
        [HttpGet, Route("GetProductByModelId")]
        public IActionResult GetProductByModelId(Guid ModelId)
        {
            return Ok(unitOfWork.ProductRepository.GetMany(a => a.ModelId == ModelId).ToHashSet());
        }
    }
}
