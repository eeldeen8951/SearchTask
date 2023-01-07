using AutoMapper;
using Core.Models;
using Shared.SearchDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Mapper
{
    public class ProductMapper: Profile
    {
        //CreateMap<CategoryDto, Category>().ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Name)).ForMember(dest => dest.CategoryId, opt => opt.Ignore());
        public ProductMapper()
        {
            //CreateMap<ProductDTO, Product>()
            //    .ForMember(p => p.Id, opt => opt.MapFrom(src => src.Id))
            //    .ForMember(p => p.Description, opt => opt.MapFrom(src => src.Description));
            CreateMap<Product, ProductDTO>()
                .ForMember(p => p.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(p => p.Description, opt => opt.MapFrom(src => src.Description));
        }

    }
}
