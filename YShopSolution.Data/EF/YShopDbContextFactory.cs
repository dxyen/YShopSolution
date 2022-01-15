using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YShopSolution.Data.EF
{
    public class YShopDbContextFactory : IDesignTimeDbContextFactory<YShopDbcontext>
    {
        public YShopDbcontext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("YShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<YShopDbcontext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new YShopDbcontext(optionsBuilder.Options);
        }
    }
}
