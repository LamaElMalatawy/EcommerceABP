using EcommerceABP.Constants;
using EcommerceABP.Permissions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace EcommerceABP.Products
{
    public class UpdateProductDto : AuditedEntityDto<Guid>
    {

        [MaxLength(ProductConsts.MaxNameLength)]
        public string NameAr { get; set; }
        [MaxLength(ProductConsts.MaxNameLength)]
        public string NameEn { get; set; }
        [MaxLength(ProductConsts.MaxDescriptionLength)]
        public string DescriptionAr { get; set; }
        [MaxLength(ProductConsts.MaxDescriptionLength)]
        public string DescriptionEn { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = EcommerceABPDomainErrorCodes.ProductPriceCannotBeNegative)]
        public decimal Price { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = EcommerceABPDomainErrorCodes.ProductStockCannotBeNegative)]
        public int StockQuantity { get; set; }
        public Guid CategoryId { get; set; }
    }
}
