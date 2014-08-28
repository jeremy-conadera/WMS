using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using WMSwithRFID.Domain_Classes;

namespace WMSwithRFID
{
    public partial class ManageReader : Form
    {
        public ManageReader()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private Reader reader = new Reader();
               
        private void dataGridView1_MouseHover(object sender, EventArgs e)
        {
            antennaTimer.Enabled = false;
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            antennaTimer.Enabled = true;
        }

        private void stopAntenna1Btn_Click(object sender, EventArgs e)
        {
            reader.accessDatabase = false;
            updateStartStopButtons();
        }

        private void startAntenna1Btn_Click(object sender, EventArgs e)
        {
            reader.accessDatabase = true;
            updateStartStopButtons();

        }
        private void updateStartStopButtons()
        {

            startAntenna1Btn.Enabled = !reader.accessDatabase;
            stopAntenna1Btn.Enabled = reader.accessDatabase;

        }

        private void ManageReader_Load(object sender, EventArgs e)
        {            
            updateStartStopButtons();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (reader.openConnection(comPortComboBox.SelectedItem.ToString()) && reader.StartReading())
                {
                    MessageBox.Show("Connection successful!");
                }
                else
                {
                    MessageBox.Show("Connection failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Disconnection failed!\n" + ex.Message);

            }
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (reader.CloseConnection())
                {
                    MessageBox.Show("Disconnection successful!");
                }

                else
                {
                    MessageBox.Show("Disconnection failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Disconnection failed!\n" + ex.Message);
            }
        }

       

    }
}
