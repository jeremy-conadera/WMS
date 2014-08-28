namespace WMSwithRFID.Add_Forms
{
    partial class AddAntennaForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.antennaGB = new System.Windows.Forms.GroupBox();
            this.egLabel = new System.Windows.Forms.Label();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.antennaGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(201, 117);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // antennaGB
            // 
            this.antennaGB.Controls.Add(this.egLabel);
            this.antennaGB.Controls.Add(this.descriptionTB);
            this.antennaGB.Location = new System.Drawing.Point(12, 12);
            this.antennaGB.Name = "antennaGB";
            this.antennaGB.Size = new System.Drawing.Size(376, 99);
            this.antennaGB.TabIndex = 1;
            this.antennaGB.TabStop = false;
            this.antennaGB.Text = "input the description of the antenna";
            this.antennaGB.Enter += new System.EventHandler(this.antennaGB_Enter);
            // 
            // egLabel
            // 
            this.egLabel.AutoSize = true;
            this.egLabel.Location = new System.Drawing.Point(10, 58);
            this.egLabel.Name = "egLabel";
            this.egLabel.Size = new System.Drawing.Size(291, 13);
            this.egLabel.TabIndex = 2;
            this.egLabel.Text = "e.g., production antenna, door1 antenna, entrance antenna ";
            // 
            // descriptionTB
            // 
            this.descriptionTB.Location = new System.Drawing.Point(6, 32);
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(364, 20);
            this.descriptionTB.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(313, 117);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddAntennaForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(400, 152);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.antennaGB);
            this.Controls.Add(this.addButton);
            this.MaximizeBox = false;
            this.Name = "AddAntennaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure Antennas";
            this.TopMost = true;
            this.antennaGB.ResumeLayout(false);
            this.antennaGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox antennaGB;
        private System.Windows.Forms.TextBox descriptionTB;
        private System.Windows.Forms.Label egLabel;
        private System.Windows.Forms.Button cancelButton;
    }
}