using EcommerceABP.Categories;
using EcommerceABP.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;

namespace EcommerceABP.Data
{
    [Dependency(ReplaceServices = true)]
    internal class ProductsDataSeeder : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Product, Guid> _productsRepository;
        private readonly IRepository<Category, Guid> _categoriesRepository;
        private readonly IGuidGenerator _guidGenerator;

        public ProductsDataSeeder(IRepository<Product, Guid> productsRepository, IRepository<Category, Guid> categoriesRepository, IGuidGenerator guidGenerator)
        {
            _productsRepository = productsRepository;
            _categoriesRepository = categoriesRepository;
            _guidGenerator = guidGenerator;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            var categories = await _categoriesRepository.GetListAsync();
            var electronicsCategory = categories.FirstOrDefault(c => c.NameEn == "Electronics");
            var clothingCategory = categories.FirstOrDefault(c => c.NameEn == "Clothing");
            var fragrancessCategory = categories.FirstOrDefault(c => c.NameEn == "Detergents");
            var detergentsCategory = categories.FirstOrDefault(c => c.NameEn == "Fragrances");


            if(electronicsCategory != null)
            {
                var product1 = new Product(
                _guidGenerator.Create(),
                "Smartphone",
                "هاتف ذكى",
                "Advanced Smartphone",
                "هاتف ذكى متطور",
                70000,
                30,
                electronicsCategory.Id);

               await _productsRepository.InsertAsync(product1);

                var product2 = new Product(
                _guidGenerator.Create(),
                "Laptop",
                "حاسوب",
                "High performance laptop",
                "حاسوب عالى الاداء",
                80000,
                50,
                electronicsCategory.Id
                );

                await _productsRepository.InsertAsync(product2);
            }


            if (detergentsCategory != null)
            {
                var product3 = new Product(
                _guidGenerator.Create(),
                "Multi-Surface Cleaner",
                "منظف متعدد الأسطح",
                "Safe cleaner for all surfaces",
                "منظف آمن لجميع الأسطح",
                200,
                10,
                detergentsCategory.Id);

                await _productsRepository.InsertAsync(product3);

                var product4 = new Product(
                _guidGenerator.Create(),
                "Dishwash Soap",
                "منظف غسيل الصحون",
                "TPowerful cleaner for removing fats and grease",
                "منظف قوي لإزالة الدهون والشحوم",
                80000,
                50,
                detergentsCategory.Id
                );

                await _productsRepository.InsertAsync(product4);
            }

            if (clothingCategory != null)
            {
                var product5 = new Product(
                _guidGenerator.Create(),
                "Men's tshirt",
                "قميص رجالى",
                "Premium cotton",
                "قميص قطني فاخر",
                500,
                30,
                clothingCategory.Id);

                await _productsRepository.InsertAsync(product5);

                var product6 = new Product(
                _guidGenerator.Create(),
                "Women's Dress",
                "فستان نسائي",
                "Elegant evening dress",
                "فستان سهرة أنيق",
                700,
                50,
                clothingCategory.Id
                );

                await _productsRepository.InsertAsync(product6);
            }

            if (fragrancessCategory != null)
            {
                var product7 = new Product(
                _guidGenerator.Create(),
                "Men's Perfume",
                "عطر رجالي",
                "Elegant perfume",
                "عطر فاخر",
                300,
                30,
                fragrancessCategory.Id);

                await _productsRepository.InsertAsync(product7);

                var product8 = new Product(
                _guidGenerator.Create(),
                "Women's Perfume",
                "عطر نسائى",
                "Elegant perfume",
                "عطر فاخر",
                400,
                30,
                fragrancessCategory.Id);

                await _productsRepository.InsertAsync(product8);
            }




        }
    }
}



