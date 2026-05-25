using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace EcommerceABP.Categories
{
    public interface ICategoryRepository: IRepository<Category, Guid>
    {
        Task<bool> IsNameEnUniqueAsync(string nameEn);
        Task<bool> IsNameArUniqueAsync(string nameAr);

    }
}
