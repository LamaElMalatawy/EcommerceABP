using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace EcommerceABP.Categories
{
    public class Category : FullAuditedAggregateRoot<Guid>
    {
        public string nameEn {  get; set; }
        public string nameAr { get; set; }
        public int parentCategoryId { get; set; }
        public Category parentCategory { get; set; }
        public ICollection<Category> children { get; set; }

    }
}
