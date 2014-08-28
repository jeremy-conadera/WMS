using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace WMS
{
    class Transaction
    {
        public int TransactionID { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime DateIssued { get; set; }
        public DateTime LastUpdate { get; set; }

        [ForeignKey("Issuer")]
        public int UserID { get; set; }

        public virtual User Issuer { get; set; }
        public virtual ICollection<TransactionProducts> TransactionProducts { get; set; }
        public virtual ICollection<TransactionFinishedProducts> TransactionFinishedProducts { get; set; }
    }
}
