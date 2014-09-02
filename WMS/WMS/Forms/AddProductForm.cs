using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WMS.Forms
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            LoadProductTypeCB();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            WMScontext ctx = new WMScontext();
            ProductType pt = (ProductType)typeCB.SelectedItem;
            Product product = new Product
            {
                
                ProductName = productNameTB.Text,
                Weight = Convert.ToInt32(weightInput.Value),
                DaysToExpire = Convert.ToInt32(daysToExpireInput.Value),
                UnitPrice = Convert.ToDouble(unitPriceInput.Value),
                DateCreated = DateTime.Now,
                ProductTypeID = pt.ProductTypeID,
            };

            ctx.Products.Add(product);
            ctx.SaveChanges();
        }

        private void LoadProductTypeCB()
        {
            Product product = new Product();
            typeCB.DataSource = product.GetAllProductQuery();
            typeCB.DisplayMember = "ProductName";
            typeCB.ValueMember = "ProductID";
        }
    }
}
