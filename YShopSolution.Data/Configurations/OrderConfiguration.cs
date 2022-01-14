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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.DateDeleted).IsRequired(false);
            builder.Property(x => x.DateModified).IsRequired(false);
            builder.Property(x => x.DeliveryDate).IsRequired(false);
        }
    }
}
