using EcommerceABP.Permissions;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace EcommerceABP.Categories
{
    public class CategoryAppService : ApplicationService, ICategoryAppServices
    {
        private readonly IRepository<Category, Guid> _categoryRepository;

        public CategoryAppService(IRepository<Category, Guid> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        //[Authorize(EcommerceABPPermissions.CreateCategoryPermission)]
        public async Task<CategoryDto> CreateCategoryAsync(CreateCategoryDto categoryDto)
        {
            var category = new Category(
                GuidGenerator.Create(),
                categoryDto.NameEn,
                categoryDto.NameAr
                );

            await _categoryRepository.InsertAsync(category);
            return ObjectMapper.Map<Category, CategoryDto>(category);
        }

        //[Authorize(EcommerceABPPermissions.DeleteCategoryPermission)]
        public async Task<bool> DeleteCategoryAsync(Guid id)
        {
            var category = await _categoryRepository.FindAsync(id);
            if (category == null)
            {
                throw new BusinessException(EcommerceABPDomainErrorCodes.CategoryNotFound)
                    .WithData("Id", id);
            }

            await _categoryRepository.DeleteAsync(category);
            return true;
        }

        //[Authorize(EcommerceABPPermissions.ViewCategoryPermission)]
        public async Task<CategoryDto> GetCategoryAsync(Guid id)
        {
            var category = await _categoryRepository.FindAsync(id);
            if (category == null)
            {
                throw new BusinessException(EcommerceABPDomainErrorCodes.CategoryNotFound)
                    .WithData("Id", id);
            }

            return ObjectMapper.Map<Category, CategoryDto>(category);
        }

        //[Authorize(EcommerceABPPermissions.UpdateCategoryPermission)]
        public async Task<CategoryDto> UpdateCategoryAsync(Guid id, UpdateCategoryDto categoryDto)
        {
            var category = await _categoryRepository.FindAsync(id);
            if (category == null)
            {
                throw new BusinessException(EcommerceABPDomainErrorCodes.CategoryNotFound)
                    .WithData("Id", id);
            }

            category.Update(
                categoryDto.NameEn,
                categoryDto.NameAr,
                categoryDto.ParentCategoryId
                );

            return ObjectMapper.Map<Category, CategoryDto>(category);
        }


        //[Authorize(EcommerceABPPermissions.ViewCategoryPermission)]
        public async Task<List<CategoryDto>> GetListAsync()
        {
            var categories = await _categoryRepository.GetListAsync();
            return ObjectMapper.Map<List<Category>, List<CategoryDto>>(categories);
        }
    }
}
