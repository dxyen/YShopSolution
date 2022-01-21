﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YShopSolution.Data.EF;

namespace YShopSolution.Data.Migrations
{
    [DbContext(typeof(YShopDbcontext))]
    [Migration("20220121074416_Initial6")]
    partial class Initial6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YShopSolution.Data.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles");
                });

            modelBuilder.Entity("YShopSolution.Data.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Avatar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("default-avatar.png");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("YShopSolution.Data.Entities.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Banners");
                });

            modelBuilder.Entity("YShopSolution.Data.Entities.Cart", b =>
                {
                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("ItemId", "UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("YShopSolution.Data.Entities.Caterory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Caterories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "For Choco Addicts",
                            Image = "default",
                            Name = "Chocolate"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A taste of tropics",
                            Image = "default",
                            Name = "Fruits"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Oreo, Rochers & more",
                            Image = "default",
                            Name = "Exotic"
                        },
                        new
                        {
                            Id = 4,
                            Description = "The all time Favourite",
                            Image = "default",
                            Name = "Blackforest"
                        },
                        new
                        {
                            Id = 5,
                            Description = "For Candy Fans",
                            Image = "default",
                            Name = "Butterscotch"
                        },
                        new
                        {
                            Id = 6,
                            Description = "The Evergreen",
                            Image = "default",
                            Name = "Vanilla"
                        },
                        new
                        {
                            Id = 7,
                            Description = "For Expresso Lover",
                            Image = "default",
                            Name = "Coffee"
                        },
                        new
                        {
                            Id = 8,
                            Description = "An ideal Complement",
                            Image = "default",
                            Name = "Strawberry"
                        });
                });

            modelBuilder.Entity("YShopSolution.Data.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("UserId1");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("YShopSolution.Data.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CateroryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("CateroryId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CateroryId = 1,
                            Description = "We kept this Classic cake untouched and unblemished because we feel it's perfect as it is. Baked with the richness of cocoa and lusciousness of fresh vanilla cream, topped with soft chocolate shavings and fresh cherries, this delicious cake will make you surrender to the zest forces of Sweet Indulgence. Savour the original taste of the all time classic- The Black Forest.",
                            Image = "default",
                            Name = "Blackforest Cake ",
                            Price = 1000000m
                        },
                        new
                        {
                            Id = 2,
                            CateroryId = 1,
                            Description = "We kept this Classic cake untouched and unblemished because we feel it's perfect as it is. Baked with the richness of cocoa and lusciousness of fresh vanilla cream, topped with soft chocolate shavings and fresh cherries, this delicious cake will make you surrender to the zest forces of Sweet Indulgence. Savour the original taste of the all time classic- The Black Forest.",
                            Image = "default",
                            Name = "Blackforest Cake Cherries",
                            Price = 1000000m
                        },
                        new
                        {
                            Id = 3,
                            CateroryId = 2,
                            Description = "We kept this Classic cake untouched and unblemished because we feel it's perfect as it is. Baked with the richness of cocoa and lusciousness of fresh vanilla cream, topped with soft chocolate shavings and fresh cherries, this delicious cake will make you surrender to the zest forces of Sweet Indulgence. Savour the original taste of the all time classic- The Black Forest.",
                            Image = "default",
                            Name = "Blackforest With Cherries",
                            Price = 1000000m
                        },
                        new
                        {
                            Id = 4,
                            CateroryId = 3,
                            Description = "We kept this Classic cake untouched and unblemished because we feel it's perfect as it is. Baked with the richness of cocoa and lusciousness of fresh vanilla cream, topped with soft chocolate shavings and fresh cherries, this delicious cake will make you surrender to the zest forces of Sweet Indulgence. Savour the original taste of the all time classic- The Black Forest.",
                            Image = "default",
                            Name = "Blackforest Cake With Cherries",
                            Price = 1000000m
                        });
                });

            modelBuilder.Entity("YShopSolution.Data.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId1");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("YShopSolution.Data.Entities.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("OrderId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("YShopSolution.Data.Entities.AppUser", b =>
                {
                    b.HasOne("YShopSolution.Data.Entities.AppRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("YShopSolution.Data.Entities.Cart", b =>
                {
                    b.HasOne("YShopSolution.Data.Entities.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YShopSolution.Data.Entities.AppUser", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId1");

                    b.Navigation("Item");

                    b.Navigation("User");
                });

            modelBuilder.Entity("YShopSolution.Data.Entities.Comment", b =>
                {
                    b.HasOne("YShopSolution.Data.Entities.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YShopSolution.Data.Entities.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");

                    b.Navigation("Item");

                    b.Navigation("User");
                });

            modelBuilder.Entity("YShopSolution.Data.Entities.Item", b =>
                {
                    b.HasOne("YShopSolution.Data.Entities.Caterory", "Caterory")
                        .WithMany("Items")
                        .HasForeignKey("CateroryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Caterory");
                });

            modelBuilder.Entity("YShopSolution.Data.Entities.Order", b =>
                {
                    b.HasOne("YShopSolution.Data.Entities.AppUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId1");

                    b.Navigation("User");
                });

            modelBuilder.Entity("YShopSolution.Data.Entities.OrderDetail", b =>
                {
                    b.HasOne("YShopSolution.Data.Entities.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YShopSolution.Data.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("YShopSolution.Data.Entities.AppUser", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("YShopSolution.Data.Entities.Caterory", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}