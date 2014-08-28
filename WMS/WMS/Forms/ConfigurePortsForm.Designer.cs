namespace WMS
{
    partial class configureAntennaPortsForm
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
            this.NumberOfPortsLabel = new System.Windows.Forms.Label();
            this.numberOfAntennasComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NumberOfPortsLabel
            // 
            this.NumberOfPortsLabel.AutoSize = true;
            this.NumberOfPortsLabel.Location = new System.Drawing.Point(12, 42);
            this.NumberOfPortsLabel.Name = "NumberOfPortsLabel";
            this.NumberOfPortsLabel.Size = new System.Drawing.Size(172, 13);
            this.NumberOfPortsLabel.TabIndex = 0;
            this.NumberOfPortsLabel.Text = "How many antennas do you have?";
            // 
            // numberOfAntennasComboBox
            // 
            this.numberOfAntennasComboBox.FormattingEnabled = true;
            this.numberOfAntennasComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.numberOfAntennasComboBox.Location = new System.Drawing.Point(190, 39);
            this.numberOfAntennasComboBox.Name = "numberOfAntennasComboBox";
            this.numberOfAntennasComboBox.Size = new System.Drawing.Size(39, 21);
            this.numberOfAntennasComboBox.TabIndex = 1;
            // 
            // configureAntennaPortsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.numberOfAntennasComboBox);
            this.Controls.Add(this.NumberOfPortsLabel);
            this.Name = "configureAntennaPortsForm";
            this.Text = "Configure Antenna Ports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumberOfPortsLabel;
        private System.Windows.Forms.ComboBox numberOfAntennasComboBox;
    }
}

