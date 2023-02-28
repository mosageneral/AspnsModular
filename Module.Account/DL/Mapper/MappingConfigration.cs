﻿

using AutoMapper;
using Module.Account.DL.DTO;
using Module.Account.DL.Entities.UserEntites;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Mapping
{

    public class AccountMappingConfigration : Profile
    {


        public AccountMappingConfigration()
        {
            // Add as many of these lines as you need to map your objects
           CreateMap<User, AddUserDTO>(MemberList.Source).ReverseMap();
           CreateMap<Country, AddCountryDTO>(MemberList.Source).ReverseMap();
           CreateMap<Region, AddRegionDTO>(MemberList.Source).ReverseMap();
           CreateMap<City, AddCityDTO>(MemberList.Source).ReverseMap();


        }
    }
}
