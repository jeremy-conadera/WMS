using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMS
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Weight { get; set; }
        public int DaysToExpire { get; set; }
        public double UnitPrice { get; set; }
        public DateTime DateCreated { get; set; }

        [ForeignKey("ProductType")]
        public int ProductTypeID { get; set; }

        public virtual ProductType ProductType { get; set; }
        public virtual ICollection<AntennaProduct> AntennaProducts { get; set; }
        public virtual ICollection<TransactionProducts> TransactionProducts { get; set; }

        
    }
}
