using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace EcommerceABP.Categories
{
    public class CategoryDto : AuditedEntityDto<Guid>
    {
        public string NameAr {  get; set; }
        public string NameEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public Guid ParentCategoryId { get; set; }
    }
}
