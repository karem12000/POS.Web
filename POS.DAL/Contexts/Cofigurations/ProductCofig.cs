using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Tables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL.Contexts.Cofigurations
{
    public class ProductCofig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(P => P.Category)
                   .WithMany(C => C.Products);

            builder.Property(P => P.Price)
                   .HasColumnType("decimal(18,2)");
        }
    }
}
