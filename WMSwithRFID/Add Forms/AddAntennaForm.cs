using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMSwithRFID.Domain_Classes;

namespace WMSwithRFID.Add_Forms
{
    public partial class AddAntennaForm : Form
    {
        public AddAntennaForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            WMScontext context = new WMScontext();
            AntennaObject antenna = new AntennaObject
            {
                
                
            };

            context.Antennas.Add(antenna);
            context.SaveChanges();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void antennaGB_Enter(object sender, EventArgs e)
        {

        }
    }
}
