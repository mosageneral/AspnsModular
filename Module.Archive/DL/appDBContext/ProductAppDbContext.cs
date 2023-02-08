using Microsoft.EntityFrameworkCore;


using Module.Product.BL.Abstraction;
using Shared.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Product.DL.appDBContext
{
    internal class ProductAppDbContext : ModuleDbContext,IProductAppDbContext
    {
        protected override string Schema => "Product";

       

        public ProductAppDbContext(DbContextOptions<ProductAppDbContext> options) : base(options)
        {
        }

        public DbSet<Product.DL.Entities.ProductEntities.Product> Products { get; set; }
        public DbSet<Product.DL.Entities.ProductEntities.Category> Categories { get; set; }
        public DbSet<Product.DL.Entities.ProductEntities.SubCategory> SubCategories { get; set; }
        public DbSet<Product.DL.Entities.ProductEntities.Make> Makes { get; set; }
        public DbSet<Product.DL.Entities.ProductEntities.Model> Models { get; set; }
        public DbSet<Product.DL.Entities.ProductEntities.Year> Years { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            base.OnModelCreating(modelBuilder);
        }
    }
}
