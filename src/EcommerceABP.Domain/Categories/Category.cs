using EcommerceABP.Constants;
using EcommerceABP.Products;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace EcommerceABP.Categories
{
    public class Category : FullAuditedAggregateRoot<Guid>
    {
        public string NameEn { get; private set; }
        public string NameAr { get; private set; }
        public Guid? ParentCategoryId { get; private set; }
        public Category ParentCategory { get; private set; }
        public ICollection<Category> Children { get; private set; }
        public ICollection<Product> Products { get; private set; }

        public Category()
        {
        }

        public Category(Guid id, string nameEn, string nameAr, Guid? parentCategoryId = null) : base(id)
        {
            SetNameEn(nameEn);
            SetNameAr(nameAr);
            SetParentCategory(parentCategoryId);
            Children = new List<Category>();
            Products = new List<Product>();


        }

        private Category SetNameEn(string nameEn)
        {
            Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn));
            Check.Length(nameEn, nameof(nameEn), CategoryConsts.MaxNameLength);
            NameEn = nameEn;
            return this;
        }

        private Category SetNameAr(string nameAr)
        {
            Check.NotNullOrWhiteSpace(nameAr, nameof(nameAr));
            Check.Length(nameAr, nameof(nameAr), CategoryConsts.MaxNameLength);
            NameAr = nameAr;
            return this;
        }

        private Category SetParentCategory(Guid? parentCategoryId)
        {
            if (parentCategoryId == Id)
                throw new BusinessException(EcommerceABPDomainErrorCodes.CategoryCannotBeItsOwnParent).WithData("CategoryId", Id);

            ParentCategoryId = parentCategoryId;
            return this;
        }

        public Category Update(string nameEn, string nameAr, Guid? parentCategoryId)
        {
            SetNameAr(nameAr);
            SetNameEn(nameEn);
            SetParentCategory(parentCategoryId);
            return this;
        }
    }
}
