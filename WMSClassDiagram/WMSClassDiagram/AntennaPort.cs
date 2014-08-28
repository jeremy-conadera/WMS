using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMSclassDiagram
{
    public class AntennaPort
    {
        public int AntennaPortID { get; set; }
        public int PortNumber { get; set; }
        public Purpose Purpose { get; set; }
        public DateTime DateCreated { get; set; }

        
        [ForeignKey("Warehouse")]
        public int WarehouseID { get; set; }

        public virtual Warehouse Warehouse { get; set; }

        public ICollection<AntennaProduct> AntennaProducts { get; set; }
        
    }
}
