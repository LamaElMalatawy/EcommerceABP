using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace EcommerceABP.Products
{
    public interface IProductRepository: IRepository<Product, Guid>
    {
        Task<bool> IsNameEnUniqueAsync(string nameEn);
        Task<bool> IsNameArUniqueAsync(string nameAr);

    }
}
