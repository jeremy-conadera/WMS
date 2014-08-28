using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace WMSClassDiagram
{
    class WMScontext:DbContext
    {
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<AntennaPort> AntennaPorts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<AntennaProduct> AntennaProducts { get; set; }

    }
}
