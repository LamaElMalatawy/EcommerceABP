using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace EcommerceABP.Categories
{
    public class CreateUpdateCategoryDto : AuditedEntityDto<Guid>
    {
        public string NameAr {  get; set; }
        public string NameEn { get; set; }
        public Guid ParentCategoryId { get; set; }
    }
}
