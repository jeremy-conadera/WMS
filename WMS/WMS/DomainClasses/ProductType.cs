using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WMS
{
    class ProductType
    {
        public int ProductTypeID { get; set; }

        [Index(IsUnique = true)]
        [StringLength(200)] 
        public string ProductTypeName { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public List<ProductType> GetAllProductTypeQuery()
        {
            WMScontext ctx = new WMScontext();
            return (from productTypes in ctx.ProductTypes
                          select productTypes).ToList();            
        }
    }
}
