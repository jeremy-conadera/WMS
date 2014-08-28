using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMSwithRFID.Domain_Classes
{
    class ProductionLine
    {
        public int ID { get; set; }
        public int ProductionLineNo { get; set; }
        public Product Product { get; set; }
       // public Manufacturer Manufacturer { get; set; }
    }
}
