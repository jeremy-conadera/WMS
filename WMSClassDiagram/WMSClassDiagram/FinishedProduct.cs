using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMSclassDiagram
{
    class FinishedProduct
    {
        public int FinishedProductID { get; set; }
        public DateTime DateManufactured { get; set; }
        public string EPC { get; set; }
        public Status Status { get; set; }

        [ForeignKey("AntennaProduct")]
        public int AntennaProductID { get; set; }

        public virtual AntennaProduct AntennaProduct { get; set; }
    }
}
