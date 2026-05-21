using EcommerceABP.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace EcommerceABP.Products
{
    public class Product : FullAuditedAggregateRoot<Guid>
    {
        public string NameAr {  get; set; }
        public string NameEn {  get; set; }
        public string DescriptionAr {  get; set; }
        public string DescriptionEn {  get; set; }
        [Range(0.1, double.MaxValue)]
        public decimal price  { get; set; }
        [Range(0, int.MaxValue)]
        public int stockQuantity { get; set; }
        public Guid CategoryId { get; set; }
        public Category ParentCategory { get; set; } 


    }
}
