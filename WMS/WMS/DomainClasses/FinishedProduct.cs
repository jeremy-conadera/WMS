using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMS
{
    class FinishedProduct
    {
        public int FinishedProductID { get; set; }
        public DateTime DateManufactured { get; set; }
        public string EPC { get; set; }
        public Status Status { get; set; }

        [ForeignKey("AntennaProduct")]
        public int AntennaProductID { get; set; }

        [ForeignKey("Location")]
        public int WarehouseID { get; set; }

        public virtual AntennaProduct AntennaProduct { get; set; }
        public virtual Warehouse Location { get; set; }
        public virtual ICollection<TransactionFinishedProducts> TransactionFinishedProducts { get; set; }

        public DateTime DateExpiry
        {
            get
            {
                WMScontext ctx = new WMScontext();
                var result = (from days in ctx.Products
                              where days.AntennaProducts == this.AntennaProduct
                              select days.DaysToExpire).SingleOrDefault();
                int daysToExpire = result;
                return DateManufactured.AddDays(daysToExpire);
            }
        }
    }
}
