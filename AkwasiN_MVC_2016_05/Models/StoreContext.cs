using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AkwasiN_MVC_2016_05.Models
{

    public class StoreContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }

        public StoreContext() : base("StoreDB")
        {
            Database.SetInitializer<StoreContext>(new StoreInitializer());
        }
    }

    public class StoreInitializer : DropCreateDatabaseAlways<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var stores = new List<Store>()
            {
                new Store() { Name = "Store Small", Address = "Street Store 1, 224 77 Lund", },
                new Store() { Name = "Store Medium", Address = "Street Store 2, 226 43 Lund"},
                new Store() { Name = "Store Large", Address = "Street Store 3, 222 22 Lund", Products = new List<Product>()
                {
                new Product() { Name = "Twix", Price = 2, ProductInStock = 120, ProductText = "Chocolate & Biscuiet", ProductNumber = "p-119"},
                new Product() { Name = "Snickers", Price = 3, ProductInStock = 90, ProductText = "Chocolate & Peanuts", ProductNumber = "p-120"},
                new Product() { Name = "Milkyway", Price = 3, ProductInStock = 80, ProductText = "Chocolate & Milk...", ProductNumber = "p-121"},
                new Product() { Name = "Mars", Price = 2, ProductInStock = 100, ProductText = "Like Snickers without Nuts", ProductNumber = "p-122"},
                new Product() { Name = "Bounty", Price = 3, ProductInStock = 110, ProductText = "Chocolate & Coconut", ProductNumber = "p-123"},
                }
                },
            };

            foreach (var store in stores)
            {
                context.Stores.Add(store);
            }
            context.SaveChanges();

            var products = new List<Product>()
            {
                new Product() { Name = "Twix", Price = 2, ProductInStock = 120, ProductText = "Chocolate & Biscuiet", ProductNumber = "p-119"},
                new Product() { Name = "Snickers", Price = 3, ProductInStock = 90, ProductText = "Chocolate & Peanuts", ProductNumber = "p-120"},
                new Product() { Name = "Milkyway", Price = 3, ProductInStock = 80, ProductText = "Chocolate & Milk...", ProductNumber = "p-121"},
                new Product() { Name = "Mars", Price = 2, ProductInStock = 100, ProductText = "Like Snickers without Nuts", ProductNumber = "p-122"},
                new Product() { Name = "Bounty", Price = 3, ProductInStock = 110, ProductText = "Chocolate & Coconut", ProductNumber = "p-123"},
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();
        }
    }
}
