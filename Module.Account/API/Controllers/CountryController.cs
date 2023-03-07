using AutoMapper;
using BL.Infrastructure;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Module.Account.BL.Security;
using Module.Account.DL.DTO;
using Module.Account.DL.Entities.UserEntites;

namespace Module.Account.Controllers
{
    [EnableCors("MyPolicy")]
    [ApiController]
    [Route("/api/Account/[controller]")]
    internal class CountryController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IAuthenticateService authenticateService;
        private readonly IMapper _mapper;

        public CountryController(IUnitOfWork unitOfWork, IAuthenticateService authenticateService, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.authenticateService = authenticateService;
            _mapper = mapper;
        }

        #region Add

        [HttpPost, Route("AddCountry")]
        public IActionResult AddCountry(AddCountryDTO countrydto)
        {
            var country = _mapper.Map<Country>(countrydto);
            unitOfWork.CountryRepository.Add(country);
            unitOfWork.Save();
            return Ok(country);
        }

        [HttpPost, Route("AddCity")]
        public IActionResult AddCity(AddCityDTO citydto)
        {
            var city = _mapper.Map<City>(citydto);
            unitOfWork.CityRepository.Add(city);
            unitOfWork.Save();
            return Ok(city);
        }

        [HttpPost, Route("AddRegion")]
        public IActionResult AddRegion(AddRegionDTO regiondto)
        {
            var region = _mapper.Map<Region>(regiondto);

            unitOfWork.RegionRepository.Add(region);
            unitOfWork.Save();
            return Ok(region);
        }

        #endregion Add

        #region GetAll

        [HttpGet, Route("GetAllCountry")]
        public IActionResult GetAllCountry()
        {
            var Counrty = unitOfWork.CountryRepository.GetAll().ToHashSet();
            return Ok(Counrty);
        }

        [HttpGet, Route("GetAllRegionByCountryId")]
        public IActionResult GetAllRegionByCountryId(Guid CountryId)
        {
            var Regions = unitOfWork.RegionRepository.GetMany(a => a.CountryId == CountryId).ToHashSet();
            return Ok(Regions);
        }

        [HttpGet, Route("GetAllCityByRegionId")]
        public IActionResult GetAllCityByRegionId(Guid RegionId)
        {
            var Cities = unitOfWork.CityRepository.GetMany(a => a.RegionId == RegionId).ToHashSet();
            return Ok(Cities);
        }

        #endregion GetAll
    }
}