using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMSwithRFID.Domain_Classes
{
    class AntennaObject
    {
        public int ID { get; set; }
        public Function Function { get; set; }
        public Product Product { get; set; }
        public DateTime DateCreated { get; set; }
        public int AntennaPortNumber { get; set; }
    }

    enum Function
    {
        Producer,
        Receiver,
        Transfer
    }
}
