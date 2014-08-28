using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMS
{
    class AntennaProduct
    {
        public int AntennaProductID { get; set; }
        public DateTime DateCreated { get; set; }

        [ForeignKey("AntennaPort")]
        public int AntennaPortID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }

        public virtual AntennaPort AntennaPort { get; set; }
        public virtual Product Product { get; set; }

        public virtual ICollection<FinishedProduct> FinishedProducts { get; set; }
    }
}
