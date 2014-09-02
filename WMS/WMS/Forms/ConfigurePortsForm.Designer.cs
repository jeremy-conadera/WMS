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
            this.antennaPortsGB = new System.Windows.Forms.GroupBox();
            this.antennaPortGB4 = new System.Windows.Forms.GroupBox();
            this.productLabel4 = new System.Windows.Forms.Label();
            this.puposeLabel4 = new System.Windows.Forms.Label();
            this.productCB4 = new System.Windows.Forms.ComboBox();
            this.purposeCB4 = new System.Windows.Forms.ComboBox();
            this.antennaPortGB3 = new System.Windows.Forms.GroupBox();
            this.productLabel3 = new System.Windows.Forms.Label();
            this.puposeLabel3 = new System.Windows.Forms.Label();
            this.productCB3 = new System.Windows.Forms.ComboBox();
            this.purposeCB3 = new System.Windows.Forms.ComboBox();
            this.antennaPortGB2 = new System.Windows.Forms.GroupBox();
            this.productLabel2 = new System.Windows.Forms.Label();
            this.puposeLabel2 = new System.Windows.Forms.Label();
            this.productCB2 = new System.Windows.Forms.ComboBox();
            this.purposeCB2 = new System.Windows.Forms.ComboBox();
            this.antennaPortGB1 = new System.Windows.Forms.GroupBox();
            this.productLabel1 = new System.Windows.Forms.Label();
            this.purposeLabel1 = new System.Windows.Forms.Label();
            this.productCB1 = new System.Windows.Forms.ComboBox();
            this.purposeCB1 = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.antennaPortsGB.SuspendLayout();
            this.antennaPortGB4.SuspendLayout();
            this.antennaPortGB3.SuspendLayout();
            this.antennaPortGB2.SuspendLayout();
            this.antennaPortGB1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumberOfPortsLabel
            // 
            this.NumberOfPortsLabel.AutoSize = true;
            this.NumberOfPortsLabel.Location = new System.Drawing.Point(12, 9);
            this.NumberOfPortsLabel.Name = "NumberOfPortsLabel";
            this.NumberOfPortsLabel.Size = new System.Drawing.Size(218, 13);
            this.NumberOfPortsLabel.TabIndex = 0;
            this.NumberOfPortsLabel.Text = "How many antennas do you intend to install?";
            // 
            // numberOfAntennasComboBox
            // 
            this.numberOfAntennasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberOfAntennasComboBox.FormattingEnabled = true;
            this.numberOfAntennasComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.numberOfAntennasComboBox.Location = new System.Drawing.Point(236, 6);
            this.numberOfAntennasComboBox.Name = "numberOfAntennasComboBox";
            this.numberOfAntennasComboBox.Size = new System.Drawing.Size(39, 21);
            this.numberOfAntennasComboBox.TabIndex = 1;
            this.numberOfAntennasComboBox.SelectedIndexChanged += new System.EventHandler(this.numberOfAntennasComboBox_SelectedIndexChanged);
            // 
            // antennaPortsGB
            // 
            this.antennaPortsGB.Controls.Add(this.antennaPortGB4);
            this.antennaPortsGB.Controls.Add(this.antennaPortGB3);
            this.antennaPortsGB.Controls.Add(this.antennaPortGB2);
            this.antennaPortsGB.Controls.Add(this.antennaPortGB1);
            this.antennaPortsGB.Location = new System.Drawing.Point(15, 45);
            this.antennaPortsGB.Name = "antennaPortsGB";
            this.antennaPortsGB.Size = new System.Drawing.Size(550, 292);
            this.antennaPortsGB.TabIndex = 2;
            this.antennaPortsGB.TabStop = false;
            this.antennaPortsGB.Text = "configure antenna ports";
            // 
            // antennaPortGB4
            // 
            this.antennaPortGB4.Controls.Add(this.productLabel4);
            this.antennaPortGB4.Controls.Add(this.puposeLabel4);
            this.antennaPortGB4.Controls.Add(this.productCB4);
            this.antennaPortGB4.Controls.Add(this.purposeCB4);
            this.antennaPortGB4.Location = new System.Drawing.Point(19, 224);
            this.antennaPortGB4.Name = "antennaPortGB4";
            this.antennaPortGB4.Size = new System.Drawing.Size(506, 62);
            this.antennaPortGB4.TabIndex = 0;
            this.antennaPortGB4.TabStop = false;
            this.antennaPortGB4.Text = "antenna port 4";
            // 
            // productLabel4
            // 
            this.productLabel4.AutoSize = true;
            this.productLabel4.Location = new System.Drawing.Point(278, 27);
            this.productLabel4.Name = "productLabel4";
            this.productLabel4.Size = new System.Drawing.Size(44, 13);
            this.productLabel4.TabIndex = 1;
            this.productLabel4.Text = "Product";
            // 
            // puposeLabel4
            // 
            this.puposeLabel4.AutoSize = true;
            this.puposeLabel4.Location = new System.Drawing.Point(23, 27);
            this.puposeLabel4.Name = "puposeLabel4";
            this.puposeLabel4.Size = new System.Drawing.Size(46, 13);
            this.puposeLabel4.TabIndex = 1;
            this.puposeLabel4.Text = "Purpose";
            // 
            // productCB4
            // 
            this.productCB4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCB4.FormattingEnabled = true;
            this.productCB4.Location = new System.Drawing.Point(328, 24);
            this.productCB4.Name = "productCB4";
            this.productCB4.Size = new System.Drawing.Size(121, 21);
            this.productCB4.TabIndex = 0;
            // 
            // purposeCB4
            // 
            this.purposeCB4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.purposeCB4.FormattingEnabled = true;
            this.purposeCB4.Location = new System.Drawing.Point(74, 24);
            this.purposeCB4.Name = "purposeCB4";
            this.purposeCB4.Size = new System.Drawing.Size(121, 21);
            this.purposeCB4.TabIndex = 0;
            this.purposeCB4.SelectedIndexChanged += new System.EventHandler(this.purposeCB4_SelectedIndexChanged);
            // 
            // antennaPortGB3
            // 
            this.antennaPortGB3.Controls.Add(this.productLabel3);
            this.antennaPortGB3.Controls.Add(this.puposeLabel3);
            this.antennaPortGB3.Controls.Add(this.productCB3);
            this.antennaPortGB3.Controls.Add(this.purposeCB3);
            this.antennaPortGB3.Location = new System.Drawing.Point(19, 155);
            this.antennaPortGB3.Name = "antennaPortGB3";
            this.antennaPortGB3.Size = new System.Drawing.Size(506, 62);
            this.antennaPortGB3.TabIndex = 0;
            this.antennaPortGB3.TabStop = false;
            this.antennaPortGB3.Text = "antenna port 3";
            // 
            // productLabel3
            // 
            this.productLabel3.AutoSize = true;
            this.productLabel3.Location = new System.Drawing.Point(278, 27);
            this.productLabel3.Name = "productLabel3";
            this.productLabel3.Size = new System.Drawing.Size(44, 13);
            this.productLabel3.TabIndex = 1;
            this.productLabel3.Text = "Product";
            // 
            // puposeLabel3
            // 
            this.puposeLabel3.AutoSize = true;
            this.puposeLabel3.Location = new System.Drawing.Point(23, 27);
            this.puposeLabel3.Name = "puposeLabel3";
            this.puposeLabel3.Size = new System.Drawing.Size(46, 13);
            this.puposeLabel3.TabIndex = 1;
            this.puposeLabel3.Text = "Purpose";
            // 
            // productCB3
            // 
            this.productCB3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCB3.FormattingEnabled = true;
            this.productCB3.Location = new System.Drawing.Point(328, 24);
            this.productCB3.Name = "productCB3";
            this.productCB3.Size = new System.Drawing.Size(121, 21);
            this.productCB3.TabIndex = 0;
            // 
            // purposeCB3
            // 
            this.purposeCB3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.purposeCB3.FormattingEnabled = true;
            this.purposeCB3.Location = new System.Drawing.Point(74, 24);
            this.purposeCB3.Name = "purposeCB3";
            this.purposeCB3.Size = new System.Drawing.Size(121, 21);
            this.purposeCB3.TabIndex = 0;
            this.purposeCB3.SelectedIndexChanged += new System.EventHandler(this.purposeCB3_SelectedIndexChanged);
            // 
            // antennaPortGB2
            // 
            this.antennaPortGB2.Controls.Add(this.productLabel2);
            this.antennaPortGB2.Controls.Add(this.puposeLabel2);
            this.antennaPortGB2.Controls.Add(this.productCB2);
            this.antennaPortGB2.Controls.Add(this.purposeCB2);
            this.antennaPortGB2.Location = new System.Drawing.Point(19, 87);
            this.antennaPortGB2.Name = "antennaPortGB2";
            this.antennaPortGB2.Size = new System.Drawing.Size(506, 62);
            this.antennaPortGB2.TabIndex = 0;
            this.antennaPortGB2.TabStop = false;
            this.antennaPortGB2.Text = "antenna port 2";
            // 
            // productLabel2
            // 
            this.productLabel2.AutoSize = true;
            this.productLabel2.Location = new System.Drawing.Point(278, 27);
            this.productLabel2.Name = "productLabel2";
            this.productLabel2.Size = new System.Drawing.Size(44, 13);
            this.productLabel2.TabIndex = 1;
            this.productLabel2.Text = "Product";
            // 
            // puposeLabel2
            // 
            this.puposeLabel2.AutoSize = true;
            this.puposeLabel2.Location = new System.Drawing.Point(23, 27);
            this.puposeLabel2.Name = "puposeLabel2";
            this.puposeLabel2.Size = new System.Drawing.Size(46, 13);
            this.puposeLabel2.TabIndex = 1;
            this.puposeLabel2.Text = "Purpose";
            // 
            // productCB2
            // 
            this.productCB2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCB2.FormattingEnabled = true;
            this.productCB2.Location = new System.Drawing.Point(328, 24);
            this.productCB2.Name = "productCB2";
            this.productCB2.Size = new System.Drawing.Size(121, 21);
            this.productCB2.TabIndex = 0;
            // 
            // purposeCB2
            // 
            this.purposeCB2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.purposeCB2.FormattingEnabled = true;
            this.purposeCB2.Location = new System.Drawing.Point(74, 24);
            this.purposeCB2.Name = "purposeCB2";
            this.purposeCB2.Size = new System.Drawing.Size(121, 21);
            this.purposeCB2.TabIndex = 0;
            this.purposeCB2.SelectedIndexChanged += new System.EventHandler(this.purposeCB2_SelectedIndexChanged);
            // 
            // antennaPortGB1
            // 
            this.antennaPortGB1.Controls.Add(this.productLabel1);
            this.antennaPortGB1.Controls.Add(this.purposeLabel1);
            this.antennaPortGB1.Controls.Add(this.productCB1);
            this.antennaPortGB1.Controls.Add(this.purposeCB1);
            this.antennaPortGB1.Location = new System.Drawing.Point(19, 19);
            this.antennaPortGB1.Name = "antennaPortGB1";
            this.antennaPortGB1.Size = new System.Drawing.Size(506, 62);
            this.antennaPortGB1.TabIndex = 0;
            this.antennaPortGB1.TabStop = false;
            this.antennaPortGB1.Text = "antenna port 1";
            // 
            // productLabel1
            // 
            this.productLabel1.AutoSize = true;
            this.productLabel1.Location = new System.Drawing.Point(278, 27);
            this.productLabel1.Name = "productLabel1";
            this.productLabel1.Size = new System.Drawing.Size(44, 13);
            this.productLabel1.TabIndex = 1;
            this.productLabel1.Text = "Product";
            // 
            // purposeLabel1
            // 
            this.purposeLabel1.AutoSize = true;
            this.purposeLabel1.Location = new System.Drawing.Point(23, 27);
            this.purposeLabel1.Name = "purposeLabel1";
            this.purposeLabel1.Size = new System.Drawing.Size(46, 13);
            this.purposeLabel1.TabIndex = 1;
            this.purposeLabel1.Text = "Purpose";
            // 
            // productCB1
            // 
            this.productCB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCB1.FormattingEnabled = true;
            this.productCB1.Location = new System.Drawing.Point(328, 24);
            this.productCB1.Name = "productCB1";
            this.productCB1.Size = new System.Drawing.Size(121, 21);
            this.productCB1.TabIndex = 0;
            // 
            // purposeCB1
            // 
            this.purposeCB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.purposeCB1.FormattingEnabled = true;
            this.purposeCB1.Location = new System.Drawing.Point(74, 24);
            this.purposeCB1.Name = "purposeCB1";
            this.purposeCB1.Size = new System.Drawing.Size(121, 21);
            this.purposeCB1.TabIndex = 0;
            this.purposeCB1.SelectedIndexChanged += new System.EventHandler(this.purposeCB1_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(434, 347);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save Configuration";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // configureAntennaPortsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 382);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.antennaPortsGB);
            this.Controls.Add(this.numberOfAntennasComboBox);
            this.Controls.Add(this.NumberOfPortsLabel);
            this.Name = "configureAntennaPortsForm";
            this.Text = "Configure Antenna Ports";
            this.Load += new System.EventHandler(this.configureAntennaPortsForm_Load);
            this.antennaPortsGB.ResumeLayout(false);
            this.antennaPortGB4.ResumeLayout(false);
            this.antennaPortGB4.PerformLayout();
            this.antennaPortGB3.ResumeLayout(false);
            this.antennaPortGB3.PerformLayout();
            this.antennaPortGB2.ResumeLayout(false);
            this.antennaPortGB2.PerformLayout();
            this.antennaPortGB1.ResumeLayout(false);
            this.antennaPortGB1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumberOfPortsLabel;
        private System.Windows.Forms.ComboBox numberOfAntennasComboBox;
        private System.Windows.Forms.GroupBox antennaPortsGB;
        private System.Windows.Forms.GroupBox antennaPortGB1;
        private System.Windows.Forms.Label purposeLabel1;
        private System.Windows.Forms.ComboBox purposeCB1;
        private System.Windows.Forms.Label productLabel1;
        private System.Windows.Forms.ComboBox productCB1;
        private System.Windows.Forms.GroupBox antennaPortGB4;
        private System.Windows.Forms.Label productLabel4;
        private System.Windows.Forms.Label puposeLabel4;
        private System.Windows.Forms.ComboBox productCB4;
        private System.Windows.Forms.ComboBox purposeCB4;
        private System.Windows.Forms.GroupBox antennaPortGB3;
        private System.Windows.Forms.Label productLabel3;
        private System.Windows.Forms.Label puposeLabel3;
        private System.Windows.Forms.ComboBox productCB3;
        private System.Windows.Forms.ComboBox purposeCB3;
        private System.Windows.Forms.GroupBox antennaPortGB2;
        private System.Windows.Forms.Label productLabel2;
        private System.Windows.Forms.Label puposeLabel2;
        private System.Windows.Forms.ComboBox productCB2;
        private System.Windows.Forms.ComboBox purposeCB2;
        private System.Windows.Forms.Button saveButton;
    }
}

