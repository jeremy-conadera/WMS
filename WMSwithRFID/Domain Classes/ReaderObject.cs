using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMSwithRFID.Domain_Classes
{
    class ReaderObject
    {
        public int ID { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Warehouse Warehouse { get; set; }        
        public string COMPort { get; set; }
        public AntennaObject Antenna { get; set; }
    }
}
