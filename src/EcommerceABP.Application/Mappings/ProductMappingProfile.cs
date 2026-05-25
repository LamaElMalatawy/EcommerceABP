using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using EcommerceABP.Products;


namespace EcommerceABP.Mappings
{
    public class ProductMappingProfile: Profile
    {
       public ProductMappingProfile() {

            CreateMap<Product, ProductDto>();

        }


    }
}
