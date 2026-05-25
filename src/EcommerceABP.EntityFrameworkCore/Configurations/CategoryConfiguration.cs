using EcommerceABP.Categories;
using EcommerceABP.Constants;
using EcommerceABP.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace EcommerceABP.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ConfigureByConvention();
            builder.Property(x => x.NameEn).IsRequired().HasMaxLength(CategoryConsts.MaxNameLength);
            builder.Property(x => x.NameAr).IsRequired().HasMaxLength(CategoryConsts.MaxNameLength);

            builder.HasOne(x => x.ParentCategory)
                .WithMany(x => x.Children)
                .HasForeignKey(x => x.ParentCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Categories");

        }
    }
}