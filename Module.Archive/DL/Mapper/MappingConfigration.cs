

using AutoMapper;
using Module.Product.DL.DTO.productDto;
using Module.Product.DL.Entities.ProductEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Mapping
{

    public class ProductMappingConfigration : Profile
    {

        
        public ProductMappingConfigration()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Product, AddProductDto>(MemberList.Source).ReverseMap();
            CreateMap<Model, ModelDTO>(MemberList.Source).ReverseMap();
            CreateMap<SubCategory, SubCategoryDto>(MemberList.Source).ReverseMap();

        }
    }
}
