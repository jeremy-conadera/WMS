using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WarehouseManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            bool bInit = false;

            if (!bInit)
            {
                MessageBox.Show("Failed to initialized!");
                return;
            }

            // 2.Connect
            bConnState = RfidApi.SAAT_Open(pHandle);
            if (!bConnState)
            {
                MessageBox.Show("Failed to connect!");
                return;
            }

            MessageBox.Show("Succeeded to connect");
        }
    }
}
