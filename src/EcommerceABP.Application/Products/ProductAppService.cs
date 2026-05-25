using AutoMapper;
using EcommerceABP.Categories;
using EcommerceABP.Mappings;
using EcommerceABP.Permissions;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace EcommerceABP.Products
{
    public class ProductAppService : ApplicationService, IProductAppService
    {
        private readonly IRepository<Product, Guid> _productRepository;
        //private readonly ICategoryRepository _categoryRepository;

        public ProductAppService(IRepository<Product, Guid> productRepository)
        {
            _productRepository = productRepository;
        }

        //[Authorize(EcommerceABPPermissions.CreateProductPermission)]
        public async Task<ProductDto> CreateProductAsync(CreateProductDto productDto)
        {
            var product = new Product(
                GuidGenerator.Create(),
                productDto.NameEn,
                productDto.NameAr,
                productDto.DescriptionEn,
                productDto.DescriptionAr,
                productDto.Price,
                productDto.StockQuantity,
                productDto.CategoryId
                );

            await _productRepository.InsertAsync(product);
            return ObjectMapper.Map<Product, ProductDto>(product);
        }

        //[Authorize(EcommerceABPPermissions.DeleteProductPermission)]
        public async Task<bool> DeleteProductAsync(Guid id)
        {
            var product = await _productRepository.FindAsync(id);
            if(product == null)
            {
                throw new BusinessException(EcommerceABPDomainErrorCodes.ProductNotFound).WithData("Id",id);
            }
            await _productRepository.DeleteAsync(product);
            return true;
        }

        [AllowAnonymous]
        public async Task<List<ProductDto>> GetListAsync()
        {
            var products = await _productRepository.GetListAsync();
            return ObjectMapper.Map<List<Product>, List<ProductDto>>(products);
        }

        //[Authorize(EcommerceABPPermissions.ViewProductPermission)]
        public async Task<ProductDto> GetProductAsync(Guid id)
        {
            var product = await _productRepository.FindAsync(id);
            if (product == null)
            {
                throw new BusinessException(EcommerceABPDomainErrorCodes.ProductNotFound).WithData("Id", id);
            }

            return ObjectMapper.Map<Product, ProductDto>(product);
            
        }

        //[Authorize(EcommerceABPPermissions.UpdateProductPermission)]
        public async Task<ProductDto> UpdateProductAsync(Guid id, UpdateProductDto productDto)
        {
            var product = await _productRepository.FindAsync(id);
            if (product == null)
            {
                throw new BusinessException(EcommerceABPDomainErrorCodes.ProductNotFound).WithData("Id", id);
            }

            product.Update(
                productDto.NameAr,
                productDto.NameEn,
                productDto.DescriptionAr,
                productDto.DescriptionEn,
                productDto.Price,
                productDto.StockQuantity,
                productDto.CategoryId
                );

            await _productRepository.UpdateAsync(product);
            return ObjectMapper.Map<Product, ProductDto>(product);
        }
    }
}
