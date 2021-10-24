namespace M2
{
    partial class Booking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoOfGuests = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChapelLightPrice = new System.Windows.Forms.TextBox();
            this.txtCLCLightPrice = new System.Windows.Forms.TextBox();
            this.txtCCLightPrice = new System.Windows.Forms.TextBox();
            this.txtJDLightPrice = new System.Windows.Forms.TextBox();
            this.chkChapelLight = new System.Windows.Forms.CheckBox();
            this.chkCCLight = new System.Windows.Forms.CheckBox();
            this.chkCLCLight = new System.Windows.Forms.CheckBox();
            this.chkJDLight = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoundPrice = new System.Windows.Forms.TextBox();
            this.chkSoundEquipment = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChapTablePrice = new System.Windows.Forms.TextBox();
            this.txtCLCTablePrice = new System.Windows.Forms.TextBox();
            this.txtCCTablePrice = new System.Windows.Forms.TextBox();
            this.txtJDTablePrice = new System.Windows.Forms.TextBox();
            this.chkChapelTables = new System.Windows.Forms.CheckBox();
            this.chkCCTable = new System.Windows.Forms.CheckBox();
            this.chkCLCTable = new System.Windows.Forms.CheckBox();
            this.chkJDTables = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVatIncluded = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radFuneral = new System.Windows.Forms.RadioButton();
            this.radSeminar = new System.Windows.Forms.RadioButton();
            this.radOther = new System.Windows.Forms.RadioButton();
            this.radWedding = new System.Windows.Forms.RadioButton();
            this.cmbVenue = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.bookingTableAdapter1 = new M2.group11DataSetTableAdapters.BookingTableAdapter();
            this.customerTableAdapter1 = new M2.group11DataSetTableAdapters.CustomerTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 41);
            this.panel1.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(817, 7);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 22);
            this.label16.TabIndex = 1;
            this.label16.Text = "X";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.date.Location = new System.Drawing.Point(86, 115);
            this.date.Margin = new System.Windows.Forms.Padding(2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(235, 24);
            this.date.TabIndex = 2;
            this.date.Value = new System.DateTime(2021, 9, 10, 11, 16, 25, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start Time: ";
            // 
            // startTime
            // 
            this.startTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.startTime.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTime.Location = new System.Drawing.Point(508, 112);
            this.startTime.Margin = new System.Windows.Forms.Padding(2);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(89, 24);
            this.startTime.TabIndex = 5;
            this.startTime.Value = new System.DateTime(2021, 9, 13, 11, 23, 0, 0);
            this.startTime.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "No. of Guest:";
            // 
            // txtNoOfGuests
            // 
            this.txtNoOfGuests.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtNoOfGuests.Location = new System.Drawing.Point(508, 61);
            this.txtNoOfGuests.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoOfGuests.Name = "txtNoOfGuests";
            this.txtNoOfGuests.ReadOnly = true;
            this.txtNoOfGuests.Size = new System.Drawing.Size(89, 24);
            this.txtNoOfGuests.TabIndex = 7;
            this.txtNoOfGuests.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtChapelLightPrice);
            this.groupBox1.Controls.Add(this.txtCLCLightPrice);
            this.groupBox1.Controls.Add(this.txtCCLightPrice);
            this.groupBox1.Controls.Add(this.txtJDLightPrice);
            this.groupBox1.Controls.Add(this.chkChapelLight);
            this.groupBox1.Controls.Add(this.chkCCLight);
            this.groupBox1.Controls.Add(this.chkCLCLight);
            this.groupBox1.Controls.Add(this.chkJDLight);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 162);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(320, 209);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lighting";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price";
            // 
            // txtChapelLightPrice
            // 
            this.txtChapelLightPrice.Location = new System.Drawing.Point(189, 129);
            this.txtChapelLightPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtChapelLightPrice.Name = "txtChapelLightPrice";
            this.txtChapelLightPrice.ReadOnly = true;
            this.txtChapelLightPrice.Size = new System.Drawing.Size(94, 24);
            this.txtChapelLightPrice.TabIndex = 7;
            this.txtChapelLightPrice.Text = "6500";
            // 
            // txtCLCLightPrice
            // 
            this.txtCLCLightPrice.Location = new System.Drawing.Point(189, 73);
            this.txtCLCLightPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtCLCLightPrice.Name = "txtCLCLightPrice";
            this.txtCLCLightPrice.ReadOnly = true;
            this.txtCLCLightPrice.Size = new System.Drawing.Size(94, 24);
            this.txtCLCLightPrice.TabIndex = 6;
            this.txtCLCLightPrice.Text = "9000";
            // 
            // txtCCLightPrice
            // 
            this.txtCCLightPrice.Location = new System.Drawing.Point(189, 101);
            this.txtCCLightPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtCCLightPrice.Name = "txtCCLightPrice";
            this.txtCCLightPrice.ReadOnly = true;
            this.txtCCLightPrice.Size = new System.Drawing.Size(94, 24);
            this.txtCCLightPrice.TabIndex = 5;
            this.txtCCLightPrice.Text = "11000";
            // 
            // txtJDLightPrice
            // 
            this.txtJDLightPrice.Location = new System.Drawing.Point(189, 45);
            this.txtJDLightPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtJDLightPrice.Name = "txtJDLightPrice";
            this.txtJDLightPrice.ReadOnly = true;
            this.txtJDLightPrice.Size = new System.Drawing.Size(94, 24);
            this.txtJDLightPrice.TabIndex = 4;
            this.txtJDLightPrice.Text = "12500";
            this.txtJDLightPrice.TextChanged += new System.EventHandler(this.txtJDLightPrice_TextChanged);
            // 
            // chkChapelLight
            // 
            this.chkChapelLight.AutoSize = true;
            this.chkChapelLight.Location = new System.Drawing.Point(20, 125);
            this.chkChapelLight.Margin = new System.Windows.Forms.Padding(2);
            this.chkChapelLight.Name = "chkChapelLight";
            this.chkChapelLight.Size = new System.Drawing.Size(80, 23);
            this.chkChapelLight.TabIndex = 3;
            this.chkChapelLight.Text = "Chapel";
            this.chkChapelLight.UseVisualStyleBackColor = true;
            this.chkChapelLight.CheckedChanged += new System.EventHandler(this.chkChapelLight_CheckedChanged);
            // 
            // chkCCLight
            // 
            this.chkCCLight.AutoSize = true;
            this.chkCCLight.Location = new System.Drawing.Point(20, 100);
            this.chkCCLight.Margin = new System.Windows.Forms.Padding(2);
            this.chkCCLight.Name = "chkCCLight";
            this.chkCCLight.Size = new System.Drawing.Size(161, 23);
            this.chkCCLight.TabIndex = 2;
            this.chkCCLight.Text = "Conference Centre";
            this.chkCCLight.UseVisualStyleBackColor = true;
            this.chkCCLight.CheckedChanged += new System.EventHandler(this.chkCCLight_CheckedChanged);
            // 
            // chkCLCLight
            // 
            this.chkCLCLight.AutoSize = true;
            this.chkCLCLight.Location = new System.Drawing.Point(20, 72);
            this.chkCLCLight.Margin = new System.Windows.Forms.Padding(2);
            this.chkCLCLight.Name = "chkCLCLight";
            this.chkCLCLight.Size = new System.Drawing.Size(164, 23);
            this.chkCLCLight.TabIndex = 1;
            this.chkCLCLight.Text = "Christian Life Centre";
            this.chkCLCLight.UseVisualStyleBackColor = true;
            this.chkCLCLight.CheckedChanged += new System.EventHandler(this.chkCLCLight_CheckedChanged);
            // 
            // chkJDLight
            // 
            this.chkJDLight.AutoSize = true;
            this.chkJDLight.Location = new System.Drawing.Point(20, 46);
            this.chkJDLight.Margin = new System.Windows.Forms.Padding(2);
            this.chkJDLight.Name = "chkJDLight";
            this.chkJDLight.Size = new System.Drawing.Size(108, 23);
            this.chkJDLight.TabIndex = 0;
            this.chkJDLight.Text = "Jesus Dome";
            this.chkJDLight.UseVisualStyleBackColor = true;
            this.chkJDLight.CheckedChanged += new System.EventHandler(this.chkJDLight_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSoundPrice);
            this.groupBox2.Controls.Add(this.chkSoundEquipment);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(396, 309);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(422, 124);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sound System Cost ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price";
            // 
            // txtSoundPrice
            // 
            this.txtSoundPrice.Location = new System.Drawing.Point(182, 46);
            this.txtSoundPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoundPrice.Name = "txtSoundPrice";
            this.txtSoundPrice.ReadOnly = true;
            this.txtSoundPrice.Size = new System.Drawing.Size(94, 24);
            this.txtSoundPrice.TabIndex = 4;
            this.txtSoundPrice.Text = "4500";
            // 
            // chkSoundEquipment
            // 
            this.chkSoundEquipment.AutoSize = true;
            this.chkSoundEquipment.Location = new System.Drawing.Point(13, 48);
            this.chkSoundEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.chkSoundEquipment.Name = "chkSoundEquipment";
            this.chkSoundEquipment.Size = new System.Drawing.Size(152, 23);
            this.chkSoundEquipment.TabIndex = 0;
            this.chkSoundEquipment.Text = "Sound Equipment";
            this.chkSoundEquipment.UseVisualStyleBackColor = true;
            this.chkSoundEquipment.CheckedChanged += new System.EventHandler(this.chkSoundEquipment_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtChapTablePrice);
            this.groupBox3.Controls.Add(this.txtCLCTablePrice);
            this.groupBox3.Controls.Add(this.txtCCTablePrice);
            this.groupBox3.Controls.Add(this.txtJDTablePrice);
            this.groupBox3.Controls.Add(this.chkChapelTables);
            this.groupBox3.Controls.Add(this.chkCCTable);
            this.groupBox3.Controls.Add(this.chkCLCTable);
            this.groupBox3.Controls.Add(this.chkJDTables);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 405);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(320, 210);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tables";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Price";
            // 
            // txtChapTablePrice
            // 
            this.txtChapTablePrice.Location = new System.Drawing.Point(189, 129);
            this.txtChapTablePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtChapTablePrice.Name = "txtChapTablePrice";
            this.txtChapTablePrice.ReadOnly = true;
            this.txtChapTablePrice.Size = new System.Drawing.Size(94, 24);
            this.txtChapTablePrice.TabIndex = 7;
            this.txtChapTablePrice.Text = "1500";
            // 
            // txtCLCTablePrice
            // 
            this.txtCLCTablePrice.Location = new System.Drawing.Point(189, 73);
            this.txtCLCTablePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtCLCTablePrice.Name = "txtCLCTablePrice";
            this.txtCLCTablePrice.ReadOnly = true;
            this.txtCLCTablePrice.Size = new System.Drawing.Size(94, 24);
            this.txtCLCTablePrice.TabIndex = 6;
            this.txtCLCTablePrice.Text = "3500";
            // 
            // txtCCTablePrice
            // 
            this.txtCCTablePrice.Location = new System.Drawing.Point(189, 101);
            this.txtCCTablePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtCCTablePrice.Name = "txtCCTablePrice";
            this.txtCCTablePrice.ReadOnly = true;
            this.txtCCTablePrice.Size = new System.Drawing.Size(94, 24);
            this.txtCCTablePrice.TabIndex = 5;
            this.txtCCTablePrice.Text = "6000";
            // 
            // txtJDTablePrice
            // 
            this.txtJDTablePrice.Location = new System.Drawing.Point(189, 45);
            this.txtJDTablePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtJDTablePrice.Name = "txtJDTablePrice";
            this.txtJDTablePrice.ReadOnly = true;
            this.txtJDTablePrice.Size = new System.Drawing.Size(94, 24);
            this.txtJDTablePrice.TabIndex = 4;
            this.txtJDTablePrice.Text = "8750";
            // 
            // chkChapelTables
            // 
            this.chkChapelTables.AutoSize = true;
            this.chkChapelTables.Location = new System.Drawing.Point(20, 125);
            this.chkChapelTables.Margin = new System.Windows.Forms.Padding(2);
            this.chkChapelTables.Name = "chkChapelTables";
            this.chkChapelTables.Size = new System.Drawing.Size(80, 23);
            this.chkChapelTables.TabIndex = 3;
            this.chkChapelTables.Text = "Chapel";
            this.chkChapelTables.UseVisualStyleBackColor = true;
            this.chkChapelTables.CheckedChanged += new System.EventHandler(this.chkChapelTables_CheckedChanged);
            // 
            // chkCCTable
            // 
            this.chkCCTable.AutoSize = true;
            this.chkCCTable.Location = new System.Drawing.Point(20, 100);
            this.chkCCTable.Margin = new System.Windows.Forms.Padding(2);
            this.chkCCTable.Name = "chkCCTable";
            this.chkCCTable.Size = new System.Drawing.Size(161, 23);
            this.chkCCTable.TabIndex = 2;
            this.chkCCTable.Text = "Conference Centre";
            this.chkCCTable.UseVisualStyleBackColor = true;
            this.chkCCTable.CheckedChanged += new System.EventHandler(this.chkCCTable_CheckedChanged);
            // 
            // chkCLCTable
            // 
            this.chkCLCTable.AutoSize = true;
            this.chkCLCTable.Location = new System.Drawing.Point(20, 72);
            this.chkCLCTable.Margin = new System.Windows.Forms.Padding(2);
            this.chkCLCTable.Name = "chkCLCTable";
            this.chkCLCTable.Size = new System.Drawing.Size(164, 23);
            this.chkCLCTable.TabIndex = 1;
            this.chkCLCTable.Text = "Christian Life Centre";
            this.chkCLCTable.UseVisualStyleBackColor = true;
            this.chkCLCTable.CheckedChanged += new System.EventHandler(this.chkCLCTable_CheckedChanged);
            // 
            // chkJDTables
            // 
            this.chkJDTables.AutoSize = true;
            this.chkJDTables.Location = new System.Drawing.Point(20, 46);
            this.chkJDTables.Margin = new System.Windows.Forms.Padding(2);
            this.chkJDTables.Name = "chkJDTables";
            this.chkJDTables.Size = new System.Drawing.Size(108, 23);
            this.chkJDTables.TabIndex = 0;
            this.chkJDTables.Text = "Jesus Dome";
            this.chkJDTables.UseVisualStyleBackColor = true;
            this.chkJDTables.CheckedChanged += new System.EventHandler(this.chkJDTables_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.btnPay);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtBalance);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtTotal);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtDeposit);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtDiscount);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtVatIncluded);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(396, 449);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(422, 163);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amount Due";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(232, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 25);
            this.button1.TabIndex = 21;
            this.button1.Text = "Calculate Discount";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPay
            // 
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPay.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.Black;
            this.btnPay.Location = new System.Drawing.Point(232, 90);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(131, 25);
            this.btnPay.TabIndex = 20;
            this.btnPay.Text = "Calculate Payment";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(228, 130);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 19);
            this.label15.TabIndex = 19;
            this.label15.Text = "Balance:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(296, 128);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(2);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(94, 24);
            this.txtBalance.TabIndex = 18;
            this.txtBalance.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(19, 130);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 19);
            this.label14.TabIndex = 17;
            this.label14.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(106, 128);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(94, 24);
            this.txtTotal.TabIndex = 16;
            this.txtTotal.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(19, 92);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 19);
            this.label13.TabIndex = 15;
            this.label13.Text = "Deposit";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(106, 90);
            this.txtDeposit.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(94, 24);
            this.txtDeposit.TabIndex = 14;
            this.txtDeposit.Text = "0";
            this.txtDeposit.TextChanged += new System.EventHandler(this.txtDeposit_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(14, 64);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(106, 63);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(94, 24);
            this.txtDiscount.TabIndex = 12;
            this.txtDiscount.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(14, 35);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "VAT Includ.";
            // 
            // txtVatIncluded
            // 
            this.txtVatIncluded.Location = new System.Drawing.Point(106, 35);
            this.txtVatIncluded.Margin = new System.Windows.Forms.Padding(2);
            this.txtVatIncluded.Name = "txtVatIncluded";
            this.txtVatIncluded.ReadOnly = true;
            this.txtVatIncluded.Size = new System.Drawing.Size(94, 24);
            this.txtVatIncluded.TabIndex = 10;
            this.txtVatIncluded.Text = "0";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.loginButton.Location = new System.Drawing.Point(188, 634);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(132, 37);
            this.loginButton.TabIndex = 11;
            this.loginButton.Text = "Add Booking";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnReset.Location = new System.Drawing.Point(351, 634);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 37);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radFuneral);
            this.groupBox5.Controls.Add(this.radSeminar);
            this.groupBox5.Controls.Add(this.radOther);
            this.groupBox5.Controls.Add(this.radWedding);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(396, 162);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(422, 124);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Event Type";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // radFuneral
            // 
            this.radFuneral.AutoSize = true;
            this.radFuneral.Location = new System.Drawing.Point(22, 73);
            this.radFuneral.Margin = new System.Windows.Forms.Padding(2);
            this.radFuneral.Name = "radFuneral";
            this.radFuneral.Size = new System.Drawing.Size(78, 23);
            this.radFuneral.TabIndex = 3;
            this.radFuneral.TabStop = true;
            this.radFuneral.Text = "Funeral";
            this.radFuneral.UseVisualStyleBackColor = true;
            // 
            // radSeminar
            // 
            this.radSeminar.AutoSize = true;
            this.radSeminar.Location = new System.Drawing.Point(204, 46);
            this.radSeminar.Margin = new System.Windows.Forms.Padding(2);
            this.radSeminar.Name = "radSeminar";
            this.radSeminar.Size = new System.Drawing.Size(82, 23);
            this.radSeminar.TabIndex = 2;
            this.radSeminar.TabStop = true;
            this.radSeminar.Text = "Seminar";
            this.radSeminar.UseVisualStyleBackColor = true;
            // 
            // radOther
            // 
            this.radOther.AutoSize = true;
            this.radOther.Location = new System.Drawing.Point(204, 75);
            this.radOther.Margin = new System.Windows.Forms.Padding(2);
            this.radOther.Name = "radOther";
            this.radOther.Size = new System.Drawing.Size(66, 23);
            this.radOther.TabIndex = 1;
            this.radOther.TabStop = true;
            this.radOther.Text = "Other";
            this.radOther.UseVisualStyleBackColor = true;
            // 
            // radWedding
            // 
            this.radWedding.AutoSize = true;
            this.radWedding.Location = new System.Drawing.Point(22, 45);
            this.radWedding.Margin = new System.Windows.Forms.Padding(2);
            this.radWedding.Name = "radWedding";
            this.radWedding.Size = new System.Drawing.Size(92, 23);
            this.radWedding.TabIndex = 0;
            this.radWedding.TabStop = true;
            this.radWedding.Text = "Wedding";
            this.radWedding.UseVisualStyleBackColor = true;
            // 
            // cmbVenue
            // 
            this.cmbVenue.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.cmbVenue.FormattingEnabled = true;
            this.cmbVenue.Items.AddRange(new object[] {
            "Jesus Dome",
            "Christian Life Centre",
            "Conference Centre",
            "Chapel"});
            this.cmbVenue.Location = new System.Drawing.Point(86, 62);
            this.cmbVenue.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVenue.Name = "cmbVenue";
            this.cmbVenue.Size = new System.Drawing.Size(235, 27);
            this.cmbVenue.TabIndex = 1;
            this.cmbVenue.SelectedIndexChanged += new System.EventHandler(this.cmbVenue_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(22, 63);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 21);
            this.label17.TabIndex = 13;
            this.label17.Text = "Venue:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(624, 115);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 21);
            this.label18.TabIndex = 15;
            this.label18.Text = "End Time:";
            // 
            // endTime
            // 
            this.endTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.endTime.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.endTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTime.Location = new System.Drawing.Point(730, 112);
            this.endTime.Margin = new System.Windows.Forms.Padding(2);
            this.endTime.Name = "endTime";
            this.endTime.ShowUpDown = true;
            this.endTime.Size = new System.Drawing.Size(89, 24);
            this.endTime.TabIndex = 16;
            this.endTime.Value = new System.DateTime(2021, 9, 13, 11, 23, 0, 0);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtName.Location = new System.Drawing.Point(670, 60);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 24);
            this.txtName.TabIndex = 18;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(604, 62);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 21);
            this.label19.TabIndex = 17;
            this.label19.Text = "Name:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnBack.Location = new System.Drawing.Point(535, 634);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 37);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // bookingTableAdapter1
            // 
            this.bookingTableAdapter1.ClearBeforeFill = true;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 692);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cmbVenue);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNoOfGuests);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Booking";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Booking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoOfGuests;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChapelLightPrice;
        private System.Windows.Forms.TextBox txtCLCLightPrice;
        private System.Windows.Forms.TextBox txtCCLightPrice;
        private System.Windows.Forms.TextBox txtJDLightPrice;
        private System.Windows.Forms.CheckBox chkChapelLight;
        private System.Windows.Forms.CheckBox chkCCLight;
        private System.Windows.Forms.CheckBox chkCLCLight;
        private System.Windows.Forms.CheckBox chkJDLight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoundPrice;
        private System.Windows.Forms.CheckBox chkSoundEquipment;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtChapTablePrice;
        private System.Windows.Forms.TextBox txtCLCTablePrice;
        private System.Windows.Forms.TextBox txtCCTablePrice;
        private System.Windows.Forms.TextBox txtJDTablePrice;
        private System.Windows.Forms.CheckBox chkChapelTables;
        private System.Windows.Forms.CheckBox chkCCTable;
        private System.Windows.Forms.CheckBox chkCLCTable;
        private System.Windows.Forms.CheckBox chkJDTables;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVatIncluded;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radFuneral;
        private System.Windows.Forms.RadioButton radSeminar;
        private System.Windows.Forms.RadioButton radOther;
        private System.Windows.Forms.RadioButton radWedding;
        private System.Windows.Forms.ComboBox cmbVenue;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnBack;
        private group11DataSetTableAdapters.BookingTableAdapter bookingTableAdapter1;
        private group11DataSetTableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button button1;
    }
}