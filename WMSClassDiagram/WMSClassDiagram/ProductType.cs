using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMSclassDiagram
{
    class ProductType
    {
        public int ProductTypeID { get; set; }
        public string ProductTypeName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
