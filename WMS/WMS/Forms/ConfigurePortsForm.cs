using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WMS
{
    public partial class configureAntennaPortsForm : Form
    {
        public configureAntennaPortsForm()
        {
            InitializeComponent();
            LoadProductTypeCB();
            LoadPurposeCB();
        }       

        private void configureAntennaPortsForm_Load(object sender, EventArgs e)
        {
            antennaPortsGB.Enabled = false;
            antennaPortGB1.Enabled = false;
            antennaPortGB2.Enabled = false;
            antennaPortGB3.Enabled = false;
            antennaPortGB4.Enabled = false;
        }

        private void numberOfAntennasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            antennaPortsGB.Enabled = true;
            Console.WriteLine(purposeCB1.Text);
            if(numberOfAntennasComboBox.SelectedIndex > -1)
            {
                antennaPortGB1.Enabled = true;
            }
            else
            {
                antennaPortGB1.Enabled = false;
            }
            if (numberOfAntennasComboBox.SelectedIndex > 0)
            {
                antennaPortGB2.Enabled = true;
            }
            else
            {
                antennaPortGB2.Enabled = false;
            }
            if (numberOfAntennasComboBox.SelectedIndex > 1)
            {
                antennaPortGB3.Enabled = true;
            }
            else
            {
                antennaPortGB3.Enabled = false;
            }
            if (numberOfAntennasComboBox.SelectedIndex > 2)
            {
                antennaPortGB4.Enabled = true;
            }
            else
            {
                antennaPortGB4.Enabled = false;
            }           
        }

        private void LoadProductTypeCB()
        {
            Product product = new Product();
            string display = "ProductName";
            string value = "ProductID";

            productCB1.DataSource = product.GetAllProductQuery();
            productCB1.DisplayMember = display;
            productCB1.ValueMember = value;

            productCB2.DataSource = product.GetAllProductQuery();
            productCB2.DisplayMember = display;
            productCB2.ValueMember = value;

            productCB3.DataSource = product.GetAllProductQuery();
            productCB3.DisplayMember = display;
            productCB3.ValueMember = value;

            productCB4.DataSource = product.GetAllProductQuery();
            productCB4.DisplayMember = display;
            productCB4.ValueMember = value;
        }

        private void LoadPurposeCB()
        {
            purposeCB1.DataSource = Enum.GetValues(typeof(Purpose));
            purposeCB2.DataSource = Enum.GetValues(typeof(Purpose));
            purposeCB3.DataSource = Enum.GetValues(typeof(Purpose));
            purposeCB4.DataSource = Enum.GetValues(typeof(Purpose));
        }

        private void purposeCB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (purposeCB1.SelectedIndex != 0)
            {
                productCB1.Enabled = false;
            }
            else
            {
                productCB1.Enabled = true;
            }
        }

        private void purposeCB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (purposeCB2.SelectedIndex != 0)
            {
                productCB2.Enabled = false;
            }
            else
            {
                productCB2.Enabled = true;
            }
        }

        private void purposeCB3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (purposeCB3.SelectedIndex != 0)
            {
                productCB3.Enabled = false;
            }
            else
            {
                productCB3.Enabled = true;
            }
        }

        private void purposeCB4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (purposeCB4.SelectedIndex != 0)
            {
                productCB4.Enabled = false;
            }
            else
            {
                productCB4.Enabled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            WMScontext ctx = new WMScontext();
            Product product1 = (Product)productCB1.SelectedItem;
            Product product2 = (Product)productCB2.SelectedItem;
            Product product3 = (Product)productCB3.SelectedItem;
            Product product4 = (Product)productCB4.SelectedItem;
            Purpose purpose1 = (Purpose)purposeCB1.SelectedItem;
            Purpose purpose2 = (Purpose)purposeCB2.SelectedItem;
            Purpose purpose3 = (Purpose)purposeCB3.SelectedItem;
            Purpose purpose4 = (Purpose)purposeCB4.SelectedItem;
            Warehouse warehouse = (from ware in ctx.Warehouses where ware.WarehouseID == 1 select ware).SingleOrDefault();

            if (antennaPortGB1.Enabled)
            {
                AntennaPort antennaPort1 = addAntennaPort(1, purpose1, warehouse.WarehouseID);
                ctx.AntennaPorts.Add(antennaPort1);
                ctx.SaveChanges();
                
                if (productCB1.Enabled)
                {                    
                    ctx.AntennaProducts.Add(addAntennaProduct(antennaPort1.AntennaPortID, product1.ProductID));
                    ctx.SaveChanges();
                }
            }

            if (antennaPortGB2.Enabled)
            {
                AntennaPort antennaPort2 = addAntennaPort(2, purpose2, warehouse.WarehouseID);
                ctx.AntennaPorts.Add(antennaPort2);
                ctx.SaveChanges();

                if (productCB2.Enabled)
                {
                    ctx.AntennaProducts.Add(addAntennaProduct(antennaPort2.AntennaPortID, product2.ProductID));
                    ctx.SaveChanges();
                }
            }

            if (antennaPortGB3.Enabled)
            {
                AntennaPort antennaPort3 = addAntennaPort(3, purpose3, warehouse.WarehouseID);
                ctx.AntennaPorts.Add(antennaPort3);
                ctx.SaveChanges();

                if (productCB3.Enabled)
                {
                    ctx.AntennaProducts.Add(addAntennaProduct(antennaPort3.AntennaPortID, product3.ProductID));
                    ctx.SaveChanges();
                }
            }

            if (antennaPortGB4.Enabled)
            {
                AntennaPort antennaPort4 = addAntennaPort(4, purpose4, warehouse.WarehouseID);
                ctx.AntennaPorts.Add(antennaPort4);
                ctx.SaveChanges();

                if (productCB4.Enabled)
                {
                    ctx.AntennaProducts.Add(addAntennaProduct(antennaPort4.AntennaPortID, product4.ProductID));
                    ctx.SaveChanges();
                }
            }

        }

        private AntennaPort addAntennaPort(int portNumber, Purpose purpose, int warehouseID)
        {
            WMScontext ctx = new WMScontext();
            AntennaPort antennaPort = new AntennaPort
            {
                PortNumber = portNumber,
                Purpose = purpose,
                DateCreated = DateTime.Now,
                WarehouseID = warehouseID
            };
            return antennaPort;
        }

        private AntennaProduct addAntennaProduct(int antennaPortID, int productID)
        {
            WMScontext ctx = new WMScontext();
            AntennaProduct antennaProduct = new AntennaProduct
            {
                DateCreated = DateTime.Now,
                AntennaPortID = antennaPortID,
                ProductID = productID
            };
            return antennaProduct;
        }
    }
}
