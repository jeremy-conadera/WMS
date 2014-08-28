using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace WMS
{
    class TransactionProducts
    {
        public int TransactionProductsID { get; set; }

        [ForeignKey("Transaction")]
        public int TransactionID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }

        public int Quantity { get; set; }

        public virtual Transaction Transaction { get; set; }
        public virtual Product Product { get; set; }
    }
}
