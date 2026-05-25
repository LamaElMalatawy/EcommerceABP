using EcommerceABP.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace EcommerceABP.Categories
{
    public interface ICategoryAppServices
    {
       public Task<CategoryDto> CreateCategoryAsync(CreateCategoryDto categoryDto);
        public Task<bool> DeleteCategoryAsync(Guid id);
        public Task<CategoryDto> GetListAsync();
        public Task<CategoryDto> GetCategoryAsync(Guid id);
        public Task<CategoryDto> UpdateCategoryAsync(CreateCategoryDto categoryDto);
    }
}
