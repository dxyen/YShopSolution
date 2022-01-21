using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YShopSolution.Data.Configurations;
using YShopSolution.Data.Entities;
using YShopSolution.Data.Extensions;

namespace YShopSolution.Data.EF
{
    public class YShopDbcontext : DbContext
    {

        public YShopDbcontext( DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder
                .ApplyConfiguration(new OrderConfiguration())
                .ApplyConfiguration(new CartConfiguration())
                .ApplyConfiguration(new OrderDetailConfiguration())
                .ApplyConfiguration(new AppUserConfiguration())
                .ApplyConfiguration(new ItemConfiguration())
                .ApplyConfiguration(new AppRoleConfiguration())
                .ApplyConfiguration(new CateroryConfiguration())
                .ApplyConfiguration(new CommentConfiguration())
                .ApplyConfiguration(new BannerConfiguration());
            //Data seeding
            modelBuilder.Seed();
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Caterory> Caterories { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
    }
}
