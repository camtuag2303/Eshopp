﻿using Eshop.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eshop.Database.Configs
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        
    public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.Description).HasColumnType("ntext");
            builder.Property(x => x.CoverImg).HasMaxLength(500);

            //khoa ngoai
            builder.HasOne(x => x.ProductCategory)
                    .WithMany()
                    .IsRequired(false)
                    .HasForeignKey(x => x.CategoryId);
        }
    }
}
