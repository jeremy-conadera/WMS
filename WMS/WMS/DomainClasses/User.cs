using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace WMS
{
    class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public AccountType AccountType { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }

        [ForeignKey("Workplace")]
        public int WarehouseID { get; set; }

        public virtual Warehouse Workplace { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
