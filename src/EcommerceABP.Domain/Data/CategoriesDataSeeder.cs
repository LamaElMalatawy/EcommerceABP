using EcommerceABP.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;

namespace EcommerceABP.Data
{
    internal class CategoriesDataSeeder : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Category, Guid> _categoryRepository;
        private readonly IGuidGenerator _guidGenerator;

        public CategoriesDataSeeder(IRepository<Category,Guid> categoriesRepository, IGuidGenerator guidGenerator)
        {
            _categoryRepository = categoriesRepository;
            _guidGenerator = guidGenerator;
        }
        public Task SeedAsync(DataSeedContext context)
        {

            var categories = new List<Category>
            {
                new Category(
                    _guidGenerator.Create(),
                    nameAr: "الكترونيا_guidGeneraterlت",
                    nameEn: "Electronics"
                    ),
                new Category(
                    _guidGenerator.Create(),
                    nameAr: "ملابس",
                    nameEn: "Clothing"
                    ),
                new Category(
                     _guidGenerator.Create(),
                    nameAr: "ادوات تنظيف",
                    nameEn: "Detergents"
                    ),
                new Category(
                     _guidGenerator.Create(),
                    nameAr: "عطور",
                    nameEn: "Fragrances"
                    )
            };



            return _categoryRepository.InsertManyAsync(categories);
        }
    }
}
