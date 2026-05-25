using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace EcommerceABP.Categories
{
    public class UpdateCategoryDto : AuditedEntityDto<Guid>
    {
        [MaxLength(128)]
        public string NameAr {  get; set; }
        [MaxLength(128)]
        public string NameEn { get; set; }
        public Guid ParentCategoryId { get; set; }
    }
}
