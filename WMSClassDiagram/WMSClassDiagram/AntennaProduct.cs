using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMSClassDiagram
{
    class AntennaProduct
    {
        public int AntennaProductID { get; set; }
        public DateTime DateCreated { get; set; }
        [ForeignKey("AntennaPorts")]
        public int AntennaPortID { get; set; }
        [ForeignKey("Products")]
        public int ProductID { get; set; }

        public virtual AntennaPort AntennaPort { get; set; }
        public virtual Product Product { get; set; }

        public virtual ICollection<FinishedProduct> FinishedProducts { get; set; }
    }
}
