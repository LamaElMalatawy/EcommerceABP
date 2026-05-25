using EcommerceABP.Constants;
using EcommerceABP.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace EcommerceABP.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> builder)
        {
            builder.ConfigureByConvention();
            builder.Property(p => p.NameAr).IsRequired().HasMaxLength(ProductConsts.MaxNameLength);
            builder.Property(p => p.NameEn).IsRequired().HasMaxLength(ProductConsts.MaxNameLength);
            builder.Property(p => p.DescriptionAr).HasMaxLength(ProductConsts.MaxDescriptionLength);
            builder.Property(p => p.DescriptionEn).HasMaxLength(ProductConsts.MaxDescriptionLength);
            builder.Property(p => p.Price).HasColumnType("decimal(18,2)");
            builder.Property(p => p.StockQuantity).IsRequired();
            builder.HasOne(p => p.Category)
                   .WithMany()
                   .HasForeignKey(p => p.CategoryId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Products");
        }
    }
}
