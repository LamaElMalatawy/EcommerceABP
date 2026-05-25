using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace EcommerceABP.Categories
{
    public class CreateCategoryDto : AuditedEntityDto<Guid>
    {
        [Required, MaxLength(128)]
        public string NameAr {  get; set; }
      
        [Required, MaxLength(128)]
        public string NameEn { get; set; }
        public Guid ParentCategoryId { get; set; }
    }
}
