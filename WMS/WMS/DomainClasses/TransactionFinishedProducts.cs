using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace WMS
{
    class TransactionFinishedProducts
    {
        public int TransactionFinishedProductsID { get; set; }
        
        [ForeignKey("Transaction")]
        public int TransactionID { get; set; }

        [ForeignKey("FinishedProduct")]
        public int FinishedProductID { get; set; }

        public virtual Transaction Transaction { get; set; }
        public virtual FinishedProduct FinishedProduct { get; set; }
    }
}
