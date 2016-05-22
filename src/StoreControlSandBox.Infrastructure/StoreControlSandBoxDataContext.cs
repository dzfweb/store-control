using Microsoft.EntityFrameworkCore;
using StoreControlSandBox.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreControlSandBox.Infrastructure
{
    public class StoreControlSandBoxDataContext : DbContext
    {
        public StoreControlSandBoxDataContext(DbContextOptions<StoreControlSandBoxDataContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           //add entities

            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
       
    }
}
