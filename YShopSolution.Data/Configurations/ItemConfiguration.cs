using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YShopSolution.Data.Entities;

namespace YShopSolution.Data.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(10, 2)");
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Image).IsRequired();

        }
    }
}
