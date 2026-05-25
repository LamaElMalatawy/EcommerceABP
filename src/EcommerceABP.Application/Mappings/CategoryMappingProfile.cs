using AutoMapper;
using EcommerceABP.Categories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceABP.Mappings
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category, CategoryDto>();
        }
    }
}
