using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceABP.Products
{
    public interface IProductAppService
    {
        public Task<ProductDto> CreateProductAsync(CreateProductDto productDto);
        public Task<bool> DeleteProductAsync(Guid id);
        public Task<ProductDto> GetListAsync();
        public Task<ProductDto> GetProductAsync(Guid id);
        public Task<ProductDto> UpdateProductAsync(CreateProductDto productDto);
        
    }
}
