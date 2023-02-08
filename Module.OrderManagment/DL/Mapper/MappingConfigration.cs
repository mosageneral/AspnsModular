using AutoMapper;
using Module.OrderManagment.DL.DTO.OrderManagmentDto;
using Module.OrderManagment.DL.Entities.OrderManagmentEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Mapping
{

    internal class MappingConfigration : Profile
    {

        
        public MappingConfigration()
        {
            // Add as many of these lines as you need to map your objects
          CreateMap<Order, OrderDTo>(MemberList.Source).ReverseMap();

        }
    }
}
