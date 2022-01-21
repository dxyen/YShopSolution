using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
    public class YShopDbcontext : IdentityDbContext<AppUser, AppRole, Guid>
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

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

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
    }
}
