namespace WMSwithRFID
{
    partial class ManageReader
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
            this.components = new System.ComponentModel.Container();
            this.AntennaTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.stopAntenna1Btn = new System.Windows.Forms.Button();
            this.startAntenna1Btn = new System.Windows.Forms.Button();
            this.antenna1GridView = new System.Windows.Forms.DataGridView();
            this.productAntenna1CB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.functionAntenna1CB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusAntenna1Cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.stopAntenna2Btn = new System.Windows.Forms.Button();
            this.startAntenna2Btn = new System.Windows.Forms.Button();
            this.antenna2GridView = new System.Windows.Forms.DataGridView();
            this.productAntenna2CB = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.functionAntenna2CB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusAntenna2Cb = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.stopAntenna3Btn = new System.Windows.Forms.Button();
            this.startAntenna3Btn = new System.Windows.Forms.Button();
            this.antenna3GridView = new System.Windows.Forms.DataGridView();
            this.functionAntenna3CB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productAntenna3CB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.statusAntenna3Cb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.stoptAntenna4btn = new System.Windows.Forms.Button();
            this.startAntenna4Btn = new System.Windows.Forms.Button();
            this.antenna4GridView = new System.Windows.Forms.DataGridView();
            this.productAntenna4CB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.functionAntenna4CB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.statusAntenna4Cb = new System.Windows.Forms.ComboBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.antennaTimer = new System.Windows.Forms.Timer(this.components);
            this.comPortComboBox = new System.Windows.Forms.ComboBox();
            this.comPortLabel = new System.Windows.Forms.Label();
            this.AntennaTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antenna1GridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antenna2GridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antenna3GridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antenna4GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AntennaTabControl
            // 
            this.AntennaTabControl.Controls.Add(this.tabPage1);
            this.AntennaTabControl.Controls.Add(this.tabPage2);
            this.AntennaTabControl.Controls.Add(this.tabPage3);
            this.AntennaTabControl.Controls.Add(this.tabPage4);
            this.AntennaTabControl.Location = new System.Drawing.Point(0, 42);
            this.AntennaTabControl.Name = "AntennaTabControl";
            this.AntennaTabControl.SelectedIndex = 0;
            this.AntennaTabControl.Size = new System.Drawing.Size(808, 403);
            this.AntennaTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.stopAntenna1Btn);
            this.tabPage1.Controls.Add(this.startAntenna1Btn);
            this.tabPage1.Controls.Add(this.antenna1GridView);
            this.tabPage1.Controls.Add(this.productAntenna1CB);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.functionAntenna1CB);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.statusAntenna1Cb);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(800, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Antenna 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // stopAntenna1Btn
            // 
            this.stopAntenna1Btn.Location = new System.Drawing.Point(719, 9);
            this.stopAntenna1Btn.Name = "stopAntenna1Btn";
            this.stopAntenna1Btn.Size = new System.Drawing.Size(75, 23);
            this.stopAntenna1Btn.TabIndex = 21;
            this.stopAntenna1Btn.Text = "Stop";
            this.stopAntenna1Btn.UseVisualStyleBackColor = true;
            this.stopAntenna1Btn.Click += new System.EventHandler(this.stopAntenna1Btn_Click);
            // 
            // startAntenna1Btn
            // 
            this.startAntenna1Btn.Location = new System.Drawing.Point(629, 9);
            this.startAntenna1Btn.Name = "startAntenna1Btn";
            this.startAntenna1Btn.Size = new System.Drawing.Size(75, 23);
            this.startAntenna1Btn.TabIndex = 20;
            this.startAntenna1Btn.Text = "Start";
            this.startAntenna1Btn.UseVisualStyleBackColor = true;
            this.startAntenna1Btn.Click += new System.EventHandler(this.startAntenna1Btn_Click);
            // 
            // antenna1GridView
            // 
            this.antenna1GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.antenna1GridView.Location = new System.Drawing.Point(12, 52);
            this.antenna1GridView.Name = "antenna1GridView";
            this.antenna1GridView.Size = new System.Drawing.Size(782, 305);
            this.antenna1GridView.TabIndex = 22;
            // 
            // productAntenna1CB
            // 
            this.productAntenna1CB.FormattingEnabled = true;
            this.productAntenna1CB.Items.AddRange(new object[] {
            "Hog Grower"});
            this.productAntenna1CB.Location = new System.Drawing.Point(459, 11);
            this.productAntenna1CB.Name = "productAntenna1CB";
            this.productAntenna1CB.Size = new System.Drawing.Size(106, 21);
            this.productAntenna1CB.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(405, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Product";
            // 
            // functionAntenna1CB
            // 
            this.functionAntenna1CB.FormattingEnabled = true;
            this.functionAntenna1CB.Items.AddRange(new object[] {
            "Producer",
            "Receiver",
            "Transfer"});
            this.functionAntenna1CB.Location = new System.Drawing.Point(275, 11);
            this.functionAntenna1CB.Name = "functionAntenna1CB";
            this.functionAntenna1CB.Size = new System.Drawing.Size(106, 21);
            this.functionAntenna1CB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Function";
            // 
            // statusAntenna1Cb
            // 
            this.statusAntenna1Cb.FormattingEnabled = true;
            this.statusAntenna1Cb.Items.AddRange(new object[] {
            "Online",
            "Offline"});
            this.statusAntenna1Cb.Location = new System.Drawing.Point(53, 11);
            this.statusAntenna1Cb.Name = "statusAntenna1Cb";
            this.statusAntenna1Cb.Size = new System.Drawing.Size(106, 21);
            this.statusAntenna1Cb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.stopAntenna2Btn);
            this.tabPage2.Controls.Add(this.startAntenna2Btn);
            this.tabPage2.Controls.Add(this.antenna2GridView);
            this.tabPage2.Controls.Add(this.productAntenna2CB);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.functionAntenna2CB);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.statusAntenna2Cb);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(800, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Antenna 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // stopAntenna2Btn
            // 
            this.stopAntenna2Btn.Location = new System.Drawing.Point(708, 9);
            this.stopAntenna2Btn.Name = "stopAntenna2Btn";
            this.stopAntenna2Btn.Size = new System.Drawing.Size(75, 23);
            this.stopAntenna2Btn.TabIndex = 23;
            this.stopAntenna2Btn.Text = "Stop";
            this.stopAntenna2Btn.UseVisualStyleBackColor = true;
            // 
            // startAntenna2Btn
            // 
            this.startAntenna2Btn.Location = new System.Drawing.Point(618, 9);
            this.startAntenna2Btn.Name = "startAntenna2Btn";
            this.startAntenna2Btn.Size = new System.Drawing.Size(75, 23);
            this.startAntenna2Btn.TabIndex = 22;
            this.startAntenna2Btn.Text = "Start";
            this.startAntenna2Btn.UseVisualStyleBackColor = true;
            // 
            // antenna2GridView
            // 
            this.antenna2GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.antenna2GridView.Location = new System.Drawing.Point(12, 40);
            this.antenna2GridView.Name = "antenna2GridView";
            this.antenna2GridView.Size = new System.Drawing.Size(771, 322);
            this.antenna2GridView.TabIndex = 24;
            // 
            // productAntenna2CB
            // 
            this.productAntenna2CB.FormattingEnabled = true;
            this.productAntenna2CB.Items.AddRange(new object[] {
            "Producer",
            "Receiver",
            "Transfer"});
            this.productAntenna2CB.Location = new System.Drawing.Point(470, 6);
            this.productAntenna2CB.Name = "productAntenna2CB";
            this.productAntenna2CB.Size = new System.Drawing.Size(106, 21);
            this.productAntenna2CB.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(416, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Product";
            // 
            // functionAntenna2CB
            // 
            this.functionAntenna2CB.FormattingEnabled = true;
            this.functionAntenna2CB.Items.AddRange(new object[] {
            "Producer",
            "Receiver",
            "Transfer"});
            this.functionAntenna2CB.Location = new System.Drawing.Point(275, 6);
            this.functionAntenna2CB.Name = "functionAntenna2CB";
            this.functionAntenna2CB.Size = new System.Drawing.Size(106, 21);
            this.functionAntenna2CB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Function";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status";
            // 
            // statusAntenna2Cb
            // 
            this.statusAntenna2Cb.FormattingEnabled = true;
            this.statusAntenna2Cb.Items.AddRange(new object[] {
            "Online",
            "Offline"});
            this.statusAntenna2Cb.Location = new System.Drawing.Point(53, 6);
            this.statusAntenna2Cb.Name = "statusAntenna2Cb";
            this.statusAntenna2Cb.Size = new System.Drawing.Size(106, 21);
            this.statusAntenna2Cb.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.stopAntenna3Btn);
            this.tabPage3.Controls.Add(this.startAntenna3Btn);
            this.tabPage3.Controls.Add(this.antenna3GridView);
            this.tabPage3.Controls.Add(this.functionAntenna3CB);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.productAntenna3CB);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.statusAntenna3Cb);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(800, 377);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Antenna 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // stopAntenna3Btn
            // 
            this.stopAntenna3Btn.Location = new System.Drawing.Point(705, 9);
            this.stopAntenna3Btn.Name = "stopAntenna3Btn";
            this.stopAntenna3Btn.Size = new System.Drawing.Size(75, 23);
            this.stopAntenna3Btn.TabIndex = 23;
            this.stopAntenna3Btn.Text = "Stop";
            this.stopAntenna3Btn.UseVisualStyleBackColor = true;
            // 
            // startAntenna3Btn
            // 
            this.startAntenna3Btn.Location = new System.Drawing.Point(615, 9);
            this.startAntenna3Btn.Name = "startAntenna3Btn";
            this.startAntenna3Btn.Size = new System.Drawing.Size(75, 23);
            this.startAntenna3Btn.TabIndex = 22;
            this.startAntenna3Btn.Text = "Start";
            this.startAntenna3Btn.UseVisualStyleBackColor = true;
            // 
            // antenna3GridView
            // 
            this.antenna3GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.antenna3GridView.Location = new System.Drawing.Point(8, 38);
            this.antenna3GridView.Name = "antenna3GridView";
            this.antenna3GridView.Size = new System.Drawing.Size(772, 324);
            this.antenna3GridView.TabIndex = 20;
            // 
            // functionAntenna3CB
            // 
            this.functionAntenna3CB.FormattingEnabled = true;
            this.functionAntenna3CB.Items.AddRange(new object[] {
            "Producer",
            "Receiver",
            "Transfer"});
            this.functionAntenna3CB.Location = new System.Drawing.Point(271, 5);
            this.functionAntenna3CB.Name = "functionAntenna3CB";
            this.functionAntenna3CB.Size = new System.Drawing.Size(106, 21);
            this.functionAntenna3CB.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Function";
            // 
            // productAntenna3CB
            // 
            this.productAntenna3CB.FormattingEnabled = true;
            this.productAntenna3CB.Items.AddRange(new object[] {
            "Producer",
            "Receiver",
            "Transfer"});
            this.productAntenna3CB.Location = new System.Drawing.Point(448, 5);
            this.productAntenna3CB.Name = "productAntenna3CB";
            this.productAntenna3CB.Size = new System.Drawing.Size(106, 21);
            this.productAntenna3CB.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(394, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Product";
            // 
            // statusAntenna3Cb
            // 
            this.statusAntenna3Cb.FormattingEnabled = true;
            this.statusAntenna3Cb.Items.AddRange(new object[] {
            "Online",
            "Offline"});
            this.statusAntenna3Cb.Location = new System.Drawing.Point(49, 5);
            this.statusAntenna3Cb.Name = "statusAntenna3Cb";
            this.statusAntenna3Cb.Size = new System.Drawing.Size(106, 21);
            this.statusAntenna3Cb.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Status";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.stoptAntenna4btn);
            this.tabPage4.Controls.Add(this.startAntenna4Btn);
            this.tabPage4.Controls.Add(this.antenna4GridView);
            this.tabPage4.Controls.Add(this.productAntenna4CB);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.functionAntenna4CB);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.statusAntenna4Cb);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(800, 377);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Antenna 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // stoptAntenna4btn
            // 
            this.stoptAntenna4btn.Location = new System.Drawing.Point(707, 4);
            this.stoptAntenna4btn.Name = "stoptAntenna4btn";
            this.stoptAntenna4btn.Size = new System.Drawing.Size(75, 23);
            this.stoptAntenna4btn.TabIndex = 19;
            this.stoptAntenna4btn.Text = "Stop";
            this.stoptAntenna4btn.UseVisualStyleBackColor = true;
            // 
            // startAntenna4Btn
            // 
            this.startAntenna4Btn.Location = new System.Drawing.Point(617, 4);
            this.startAntenna4Btn.Name = "startAntenna4Btn";
            this.startAntenna4Btn.Size = new System.Drawing.Size(75, 23);
            this.startAntenna4Btn.TabIndex = 3;
            this.startAntenna4Btn.Text = "Start";
            this.startAntenna4Btn.UseVisualStyleBackColor = true;
            // 
            // antenna4GridView
            // 
            this.antenna4GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.antenna4GridView.Location = new System.Drawing.Point(11, 36);
            this.antenna4GridView.Name = "antenna4GridView";
            this.antenna4GridView.Size = new System.Drawing.Size(771, 323);
            this.antenna4GridView.TabIndex = 18;
            // 
            // productAntenna4CB
            // 
            this.productAntenna4CB.FormattingEnabled = true;
            this.productAntenna4CB.Items.AddRange(new object[] {
            "Producer",
            "Receiver",
            "Transfer"});
            this.productAntenna4CB.Location = new System.Drawing.Point(449, 4);
            this.productAntenna4CB.Name = "productAntenna4CB";
            this.productAntenna4CB.Size = new System.Drawing.Size(106, 21);
            this.productAntenna4CB.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(395, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Product";
            // 
            // functionAntenna4CB
            // 
            this.functionAntenna4CB.FormattingEnabled = true;
            this.functionAntenna4CB.Items.AddRange(new object[] {
            "Producer",
            "Receiver",
            "Transfer"});
            this.functionAntenna4CB.Location = new System.Drawing.Point(269, 4);
            this.functionAntenna4CB.Name = "functionAntenna4CB";
            this.functionAntenna4CB.Size = new System.Drawing.Size(106, 21);
            this.functionAntenna4CB.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Function";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Status";
            // 
            // statusAntenna4Cb
            // 
            this.statusAntenna4Cb.FormattingEnabled = true;
            this.statusAntenna4Cb.Items.AddRange(new object[] {
            "Online",
            "Offline"});
            this.statusAntenna4Cb.Location = new System.Drawing.Point(47, 4);
            this.statusAntenna4Cb.Name = "statusAntenna4Cb";
            this.statusAntenna4Cb.Size = new System.Drawing.Size(106, 21);
            this.statusAntenna4Cb.TabIndex = 13;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(195, 4);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 1;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Location = new System.Drawing.Point(276, 4);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(75, 23);
            this.disconnectBtn.TabIndex = 2;
            this.disconnectBtn.Text = "Disconnect";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // comPortComboBox
            // 
            this.comPortComboBox.FormattingEnabled = true;
            this.comPortComboBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17"});
            this.comPortComboBox.Location = new System.Drawing.Point(70, 6);
            this.comPortComboBox.Name = "comPortComboBox";
            this.comPortComboBox.Size = new System.Drawing.Size(106, 21);
            this.comPortComboBox.TabIndex = 23;
            // 
            // comPortLabel
            // 
            this.comPortLabel.AutoSize = true;
            this.comPortLabel.Location = new System.Drawing.Point(12, 9);
            this.comPortLabel.Name = "comPortLabel";
            this.comPortLabel.Size = new System.Drawing.Size(52, 13);
            this.comPortLabel.TabIndex = 24;
            this.comPortLabel.Text = "COM port";
            // 
            // ManageReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 457);
            this.Controls.Add(this.comPortLabel);
            this.Controls.Add(this.comPortComboBox);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.AntennaTabControl);
            this.Name = "ManageReader";
            this.Text = "Manage Reader";
            this.Load += new System.EventHandler(this.ManageReader_Load);
            this.AntennaTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antenna1GridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antenna2GridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antenna3GridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antenna4GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl AntennaTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.ComboBox functionAntenna1CB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox statusAntenna1Cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox functionAntenna2CB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox statusAntenna2Cb;
        private System.Windows.Forms.ComboBox functionAntenna3CB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox statusAntenna3Cb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox productAntenna4CB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox functionAntenna4CB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox statusAntenna4Cb;
        private System.Windows.Forms.ComboBox productAntenna2CB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox productAntenna3CB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox productAntenna1CB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView antenna1GridView;
        private System.Windows.Forms.DataGridView antenna2GridView;
        private System.Windows.Forms.DataGridView antenna3GridView;
        private System.Windows.Forms.Button startAntenna4Btn;
        private System.Windows.Forms.DataGridView antenna4GridView;
        private System.Windows.Forms.Button stoptAntenna4btn;
        private System.Windows.Forms.Button stopAntenna1Btn;
        private System.Windows.Forms.Button startAntenna1Btn;
        private System.Windows.Forms.Button stopAntenna2Btn;
        private System.Windows.Forms.Button startAntenna2Btn;
        private System.Windows.Forms.Button stopAntenna3Btn;
        private System.Windows.Forms.Button startAntenna3Btn;
        private System.Windows.Forms.Timer antennaTimer;
        private System.Windows.Forms.ComboBox comPortComboBox;
        private System.Windows.Forms.Label comPortLabel;
    }
}