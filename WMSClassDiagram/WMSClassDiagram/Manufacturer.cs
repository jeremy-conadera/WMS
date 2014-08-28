using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMSclassDiagram
{
    public class Manufacturer
    {
        [Key, ForeignKey("Warehouse")]
        public int WarehouseID { get; set; }

        public string WarehouseName { get; set; }
        public string WarehouseAddress { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
