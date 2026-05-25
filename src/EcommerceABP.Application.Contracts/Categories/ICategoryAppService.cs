using EcommerceABP.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace EcommerceABP.Categories
{
    public interface ICategoryAppServices : IApplicationService
    {
        public Task<CategoryDto> CreateCategoryAsync(CreateCategoryDto categoryDto);
        public Task<bool> DeleteCategoryAsync(Guid id);
        public Task<List<CategoryDto>> GetListAsync();
        public Task<CategoryDto> GetCategoryAsync(Guid id);
        public Task<CategoryDto> UpdateCategoryAsync(Guid id, UpdateCategoryDto categoryDto);
    }
}
