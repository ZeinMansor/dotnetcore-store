using System;
using System.Collections;
using System.Data;
using BasicStoreDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace BasicStoreDemo.Util
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var b_id = Guid.NewGuid();
            var d_id = Guid.NewGuid();
            var d_id2 = Guid.NewGuid();


            builder.Entity<Product>()
                   .Property(b => b.id)
                   .HasValueGenerator<GuidValueGenerator>();

            builder.Entity<ProductDescreption>()
                   .Property(b => b.id)
                   .HasValueGenerator<GuidValueGenerator>();


            var p1 = new Product
            {
                id = b_id,
                name = "First Test Product",
                imageUrl = "First Image URL",
                price = 120,
                discountPrice = 98,
                ratting = 2

            };
            //var description1 = new List<ProductDescreption>
            //{
            //   new ProductDescreption {  id = d_id, product = p1, text = "First product description" }
            //};
            var p2 = new Product
            {
                id = Guid.NewGuid(),
                name = "Second Test Product",
                imageUrl = "Second Image url",
                price = 650,
                discountPrice = 599,
                ratting = 4.3f

            };
            //var description2 = new List<ProductDescreption>
            //{
            //   new ProductDescreption { id = d_id2, product = p2, text = "Second product description" }
            //};


            builder.Entity<Product>().HasData(p1, p2);
            //builder.Entity<ProductDescreption>().HasData(description1, description2);
        }

        public DbSet<Product> Products { get; set; }

    }
}

