using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WMS
{
    class WMScontext:DbContext
    {
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<AntennaPort> AntennaPorts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<AntennaProduct> AntennaProducts { get; set; }
        public DbSet<FinishedProduct> FinishedProducts { get; set; }
        public DbSet<Transaction> Transactions{ get; set; }
        public DbSet<TransactionFinishedProducts> TransactionFinishedProducts { get; set; }
        public DbSet<TransactionProducts> TransactionProducts { get; set; }
        public DbSet<User> Users{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        }
    }
}
