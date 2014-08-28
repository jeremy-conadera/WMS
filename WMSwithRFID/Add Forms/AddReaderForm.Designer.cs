namespace WMSwithRFID.Add_Forms
{
    partial class AddReaderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelButton = new System.Windows.Forms.Button();
            this.antennaGB = new System.Windows.Forms.GroupBox();
            this.instLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.portLabel = new System.Windows.Forms.Label();
            this.egLabel = new System.Windows.Forms.Label();
            this.comPortTB = new System.Windows.Forms.TextBox();
            this.antennaGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(291, 144);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // antennaGB
            // 
            this.antennaGB.Controls.Add(this.comPortTB);
            this.antennaGB.Controls.Add(this.egLabel);
            this.antennaGB.Controls.Add(this.portLabel);
            this.antennaGB.Controls.Add(this.instLabel);
            this.antennaGB.Location = new System.Drawing.Point(29, 30);
            this.antennaGB.Name = "antennaGB";
            this.antennaGB.Size = new System.Drawing.Size(339, 99);
            this.antennaGB.TabIndex = 4;
            this.antennaGB.TabStop = false;
            this.antennaGB.Text = "select the COM port of the reader";
            // 
            // instLabel
            // 
            this.instLabel.AutoSize = true;
            this.instLabel.Location = new System.Drawing.Point(6, 25);
            this.instLabel.Name = "instLabel";
            this.instLabel.Size = new System.Drawing.Size(325, 13);
            this.instLabel.TabIndex = 2;
            this.instLabel.Text = "the COM port of the reader can be checked in the Device Manager";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(179, 144);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(77, 53);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(52, 13);
            this.portLabel.TabIndex = 3;
            this.portLabel.Text = "COM port";
            // 
            // egLabel
            // 
            this.egLabel.AutoSize = true;
            this.egLabel.Location = new System.Drawing.Point(147, 77);
            this.egLabel.Name = "egLabel";
            this.egLabel.Size = new System.Drawing.Size(103, 13);
            this.egLabel.TabIndex = 5;
            this.egLabel.Text = "e.g., COM1, COM12";
            // 
            // comPortTB
            // 
            this.comPortTB.Location = new System.Drawing.Point(135, 50);
            this.comPortTB.Name = "comPortTB";
            this.comPortTB.Size = new System.Drawing.Size(124, 20);
            this.comPortTB.TabIndex = 6;
            // 
            // AddReaderForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(379, 177);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.antennaGB);
            this.Controls.Add(this.addButton);
            this.Name = "AddReaderForm";
            this.Text = "Add Reader";
            this.antennaGB.ResumeLayout(false);
            this.antennaGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox antennaGB;
        private System.Windows.Forms.Label instLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label egLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox comPortTB;
    }
}