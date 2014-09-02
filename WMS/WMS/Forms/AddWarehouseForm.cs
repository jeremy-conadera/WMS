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
    public partial class AddWarehouseForm : Form
    {
        public AddWarehouseForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            WMScontext context = new WMScontext();
            Warehouse warehouse = new Warehouse
            {
                WarehouseName = this.nameTB.Text,
                WarehouseAddress = this.addressTB.Text,
            };

            context.Warehouses.Add(warehouse);
            context.SaveChanges();     
        }
    }
}
