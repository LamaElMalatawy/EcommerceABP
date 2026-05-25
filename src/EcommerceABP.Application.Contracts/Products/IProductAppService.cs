using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace EcommerceABP.Products
{
    public interface IProductAppService: IApplicationService
    {
        public Task<ProductDto> CreateProductAsync(CreateProductDto productDto);
        public Task<bool> DeleteProductAsync(Guid id);
        public Task<List<ProductDto>> GetListAsync();
        public Task<ProductDto> GetProductAsync(Guid id);
        public Task<ProductDto> UpdateProductAsync(Guid id, UpdateProductDto productDto);
        
    }
}
