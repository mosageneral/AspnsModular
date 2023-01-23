using AutoMapper;
using BL.Infrastructure;
using BL.Security;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Module.Account.BL.Security;
using Module.Account.DL.DTO;
using Module.Account.DL.Entities.UserEntites;
using Shared.Infrastructure.Extensions;
using Shared.Models.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Module.Account.Controllers
{
    [EnableCors("MyPolicy")]
    [ApiController]
    [Route("/api/Account/[controller]")]
  //  [ClaimRequirement(ClaimTypes.Role, PermissionsConst.Admin)]

    internal class CountryController:ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IAuthenticateService authenticateService;
        private readonly Mapper mapper;

        public CountryController(IUnitOfWork unitOfWork,IAuthenticateService authenticateService,Mapper Mapper)
        {
            this.unitOfWork = unitOfWork;
            this.authenticateService = authenticateService;
            mapper = Mapper;
        }
        #region Add
        [HttpPost,Route("AddCountry")]
        public IActionResult AddCountry(Country country)
        {
            unitOfWork.CountryRepository.Add(country);
            unitOfWork.Save();
            return Ok(country);
        }
        [HttpPost, Route("AddCity")]
        public IActionResult AddCity(City city)
        {
            unitOfWork.CityRepository.Add(city);
            unitOfWork.Save();
            return Ok(city);
        }
        [HttpPost, Route("AddRegion")]
        public IActionResult AddRegion(Region region)
        {
            unitOfWork.RegionRepository.Add(region);
            unitOfWork.Save();
            return Ok(region);
        }
        #endregion

        #region GetAll
        [HttpGet,Route("GetAllCountry")]
        public IActionResult GetAllCountry()
        {
           var Counrty =  unitOfWork.CountryRepository.GetAll().ToHashSet();
            return Ok(Counrty);

        }
        [HttpGet, Route("GetAllRegionByCountryId")]
        public IActionResult GetAllRegionByCountryId(Guid CountryId)
        {
            var Regions = unitOfWork.RegionRepository.GetMany(a=>a.CountryId==CountryId).ToHashSet();
            return Ok(Regions);

        }
        [HttpGet, Route("GetAllCityByRegionId")]
        public IActionResult GetAllCityByRegionId(Guid RegionId)
        {
            var Cities = unitOfWork.CityRepository.GetMany(a => a.RegionId == RegionId).ToHashSet();
            return Ok(Cities);

        }
        #endregion
    }
}
