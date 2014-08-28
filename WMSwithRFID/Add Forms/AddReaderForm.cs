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
    public partial class AddReaderForm : Form
    {
        public AddReaderForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            WMScontext context = new WMScontext();
            string com = comPortTB.Text.Substring(0, 3).ToUpper();
            string comPort = com + comPortTB.Text.Substring(3);
            ReaderObject reader = new ReaderObject
            {                
                COMPort = comPort
            };

            context.Readers.Add(reader);
            context.SaveChanges();
        }
    }
}
