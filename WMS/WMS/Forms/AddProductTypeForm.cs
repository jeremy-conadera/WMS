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
    public partial class AddProductTypeForm : Form
    {
        private ProductType productType;
        public AddProductTypeForm()
        {
            InitializeComponent();
        }      

        private void addButton_Click(object sender, EventArgs e)
        {
            WMScontext ctx = new WMScontext();
           
                productType = new ProductType
                {
                    ProductTypeName = productTypeNameTB.Text
                };
                ctx.ProductTypes.Add(productType);
            try
            {                
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(productTypeNameTB.Text + " already exists.");
            }
            
            
        }
    }
}
