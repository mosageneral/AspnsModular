


using AutoMapper;
using Module.Financial.DL.DTO.FinancialEntitiesDTO;
using Module.Financial.DL.Entities.FinancialEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Mapping
{

    public class FinancialMappingConfigration : Profile
    {


        public FinancialMappingConfigration()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<InvoiceB2B, InvoiceB2BDTO>(MemberList.Source).ReverseMap();

            CreateMap<InvoiceItemB2B, InvoiceItemB2BDTO>(MemberList.Source).ReverseMap();

            CreateMap<InvoiceB2C, InvoiceB2CDTO>(MemberList.Source).ReverseMap();
            CreateMap<InvoiceItemB2C, InvoiceItemB2CDTO>(MemberList.Source).ReverseMap();

        }
    }
}
