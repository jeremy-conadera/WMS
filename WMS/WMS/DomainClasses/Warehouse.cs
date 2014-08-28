using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS
{
    class Warehouse
    {
        public int WarehouseID { get; set; }
        public string WarehouseName { get; set; }
        public string WarehouseAddress { get; set; }

        public virtual ICollection<AntennaPort> Antennas { get; set; }
        public virtual ICollection<FinishedProduct> FinishedProducts { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual ICollection<User> Users{ get; set; }
        
    }
}
