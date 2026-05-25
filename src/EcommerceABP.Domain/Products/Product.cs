using EcommerceABP.Categories;
using EcommerceABP.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace EcommerceABP.Products
{
    public class Product : FullAuditedAggregateRoot<Guid>
    {
        public string NameAr { get; private set; }
        public string NameEn { get; private set; }
        public string DescriptionAr { get; private set; }
        public string DescriptionEn { get; private set; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }
        public Guid CategoryId { get; private set; }
        public Category Category { get; private set; }

        public Product()
        {
        }

        public Product(Guid id, string nameAr, string nameEn, string descriptionAr, string descriptionEn, decimal price, int stockQuantity, Guid categoryId) : base(id)
        {
            SetNameAr(nameAr);
            SetNameEn(nameEn);
            SetDescriptionAr(descriptionAr);
            SetDescriptionEn(descriptionEn);
            SetPrice(price);
            SetStockQuantity(stockQuantity);
            SetCategory(categoryId);
        }

        private Product SetNameAr(string nameAr)
        {
            Check.NotNullOrWhiteSpace(nameAr, nameof(nameAr));
            Check.Length(nameAr, nameof(nameAr), ProductConsts.MaxNameLength);
            NameAr = nameAr;
            return this;
        }

        private Product SetNameEn(string nameEn)
        {
            Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn));
            Check.Length(nameEn, nameof(nameEn), ProductConsts.MaxNameLength);
            NameEn = nameEn;
            return this;
        }

        private Product SetDescriptionAr(string descriptionAr)
        {
            Check.Length(descriptionAr, nameof(descriptionAr), ProductConsts.MaxDescriptionLength);
            DescriptionAr = descriptionAr;
            return this;
        }

        private Product SetDescriptionEn(string descriptionEn)
        {
            Check.Length(descriptionEn, nameof(descriptionEn), ProductConsts.MaxDescriptionLength);
            DescriptionEn = descriptionEn;
            return this;
        }

        private Product SetPrice(decimal price)
        {
            if (price < 0)
            {
                throw new BusinessException(EcommerceABPDomainErrorCodes.ProductPriceMustBeGreaterThanZero).WithData("Price", price);
            }
            this.Price = price;
            return this;
        }

        private Product SetStockQuantity(int stockQuantity)
        {
            if (stockQuantity < 0)
            {
                throw new BusinessException(EcommerceABPDomainErrorCodes.ProductStockCannotBeNegative).WithData("StockQuantity", stockQuantity);
            }
            StockQuantity = stockQuantity;
            return this;
        }

        private Product SetCategory(Guid categoryId)
        {
            if (categoryId == Guid.Empty)
            {
                throw new BusinessException(EcommerceABPDomainErrorCodes.ProductMustBelongToCategory).WithData("CategoryId", categoryId);
            }
            CategoryId = categoryId;
            return this;
        }

        public Product Update(String NameAr, string NameEn, string DescriptionAr, string DescriptionEn, decimal Price, int StockQuantity, Guid CategoryId)
        {
            SetNameAr(NameAr);
            SetNameEn(NameEn);
            SetDescriptionAr(DescriptionAr);
            SetDescriptionEn(DescriptionEn);
            SetPrice(Price);
            SetStockQuantity(StockQuantity);
            SetCategory(CategoryId);
            return this;
        }
    }
}
