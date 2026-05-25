using EcommerceABP.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace EcommerceABP.Categories
{
    public class CreateCategoryDto : AuditedEntityDto<Guid>
    {
        [Required, MaxLength(CategoryConsts.MaxNameLength)]
        public string NameAr {  get; set; }
      
        [Required, MaxLength(CategoryConsts.MaxNameLength)]
        public string NameEn { get; set; }
        public Guid ParentCategoryId { get; set; }
    }
}
