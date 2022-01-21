using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YShopSolution.Data.Entities;

namespace YShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Caterory>().HasData(
                new Caterory { Id = 1, Name = "Chocolate", Description = "For Choco Addicts", Image = "default" },
                new Caterory { Id = 2, Name = "Fruits", Description = "A taste of tropics", Image = "default" },
                new Caterory { Id = 3, Name = "Exotic", Description = "Oreo, Rochers & more", Image = "default" },
                new Caterory { Id = 4, Name = "Blackforest", Description = "The all time Favourite", Image = "default" },
                new Caterory { Id = 5, Name = "Butterscotch", Description = "For Candy Fans", Image = "default" },
                new Caterory { Id = 6, Name = "Vanilla", Description = "The Evergreen", Image = "default" },
                new Caterory { Id = 7, Name = "Coffee", Description = "For Expresso Lover", Image = "default" },
                new Caterory { Id = 8, Name = "Strawberry", Description = "An ideal Complement", Image = "default" }
                );

            modelBuilder.Entity<Item>().HasData(
            new Item()
            {
                Id = 1,
                Name = "Blackforest Cake ",
                Price = 1000000,
                Description = "We kept this Classic cake untouched and unblemished because we feel it's perfect as it is. Baked with the richness of cocoa and lusciousness of fresh vanilla cream, topped with soft chocolate shavings and fresh cherries, this delicious cake will make you surrender to the zest forces of Sweet Indulgence. Savour the original taste of the all time classic- The Black Forest.",
                Image = "default",
                CateroryId = 1
            },
            new Item()
            {
                Id = 2,
                Name = "Blackforest Cake Cherries",
                Price = 1000000,
                Description = "We kept this Classic cake untouched and unblemished because we feel it's perfect as it is. Baked with the richness of cocoa and lusciousness of fresh vanilla cream, topped with soft chocolate shavings and fresh cherries, this delicious cake will make you surrender to the zest forces of Sweet Indulgence. Savour the original taste of the all time classic- The Black Forest.",
                Image = "default",
                CateroryId = 1
            },
            new Item()
            {
                Id = 3,
                Name = "Blackforest With Cherries",
                Price = 1000000,
                Description = "We kept this Classic cake untouched and unblemished because we feel it's perfect as it is. Baked with the richness of cocoa and lusciousness of fresh vanilla cream, topped with soft chocolate shavings and fresh cherries, this delicious cake will make you surrender to the zest forces of Sweet Indulgence. Savour the original taste of the all time classic- The Black Forest.",
                Image = "default",
                CateroryId = 2
            },
             new Item()
             {
                 Id = 4,
                 Name = "Blackforest Cake With Cherries",
                 Price = 1000000,
                 Description = "We kept this Classic cake untouched and unblemished because we feel it's perfect as it is. Baked with the richness of cocoa and lusciousness of fresh vanilla cream, topped with soft chocolate shavings and fresh cherries, this delicious cake will make you surrender to the zest forces of Sweet Indulgence. Savour the original taste of the all time classic- The Black Forest.",
                 Image = "default",
                 CateroryId = 3
             });
        }
    }
}
