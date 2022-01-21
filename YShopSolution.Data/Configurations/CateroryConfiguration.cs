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
    public class CateroryConfiguration : IEntityTypeConfiguration<Caterory>
    {
        public void Configure(EntityTypeBuilder<Caterory> builder)
        {
            builder.Property(x => x.Description).IsRequired(false);
            builder.Property(x => x.Image).IsRequired(false);
            builder.Property(x => x.Name).IsRequired();

        }
    }
}
