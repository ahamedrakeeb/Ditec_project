namespace My_Project_01
{
    partial class Frmadcus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmadcus));
            this.lbladdnewcustomer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtetmpkr = new System.Windows.Forms.DateTimePicker();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.lblcustomerid = new System.Windows.Forms.Label();
            this.lblphoneno = new System.Windows.Forms.Label();
            this.cobxmartialstatus = new System.Windows.Forms.ComboBox();
            this.cobxcustomertype = new System.Windows.Forms.ComboBox();
            this.btnaddcustomer = new System.Windows.Forms.Button();
            this.txtphoneno = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.txtemailid = new System.Windows.Forms.TextBox();
            this.lblmartialstatus = new System.Windows.Forms.Label();
            this.lbldateofbirth = new System.Windows.Forms.Label();
            this.lblcustomertype = new System.Windows.Forms.Label();
            this.lblemailid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblcustomername = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbladdnewcustomer
            // 
            this.lbladdnewcustomer.AutoSize = true;
            this.lbladdnewcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdnewcustomer.Location = new System.Drawing.Point(17, 16);
            this.lbladdnewcustomer.Name = "lbladdnewcustomer";
            this.lbladdnewcustomer.Size = new System.Drawing.Size(162, 20);
            this.lbladdnewcustomer.TabIndex = 0;
            this.lbladdnewcustomer.Text = "Add New Customer";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dtetmpkr);
            this.groupBox1.Controls.Add(this.lbladdnewcustomer);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.txtcustomerid);
            this.groupBox1.Controls.Add(this.lblcustomerid);
            this.groupBox1.Controls.Add(this.lblphoneno);
            this.groupBox1.Controls.Add(this.cobxmartialstatus);
            this.groupBox1.Controls.Add(this.cobxcustomertype);
            this.groupBox1.Controls.Add(this.btnaddcustomer);
            this.groupBox1.Controls.Add(this.txtphoneno);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.txtcustomername);
            this.groupBox1.Controls.Add(this.txtemailid);
            this.groupBox1.Controls.Add(this.lblmartialstatus);
            this.groupBox1.Controls.Add(this.lbldateofbirth);
            this.groupBox1.Controls.Add(this.lblcustomertype);
            this.groupBox1.Controls.Add(this.lblemailid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbladdress);
            this.groupBox1.Controls.Add(this.lblcustomername);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 499);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtetmpkr
            // 
            this.dtetmpkr.CustomFormat = "yyy.MM.dd";
            this.dtetmpkr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtetmpkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtetmpkr.Location = new System.Drawing.Point(236, 331);
            this.dtetmpkr.Name = "dtetmpkr";
            this.dtetmpkr.Size = new System.Drawing.Size(220, 24);
            this.dtetmpkr.TabIndex = 6;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(283, 425);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(145, 43);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.Location = new System.Drawing.Point(236, 59);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.Size = new System.Drawing.Size(220, 20);
            this.txtcustomerid.TabIndex = 0;
            this.txtcustomerid.TextChanged += new System.EventHandler(this.txtcustomerid_TextChanged);
            // 
            // lblcustomerid
            // 
            this.lblcustomerid.AutoSize = true;
            this.lblcustomerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomerid.Location = new System.Drawing.Point(33, 59);
            this.lblcustomerid.Name = "lblcustomerid";
            this.lblcustomerid.Size = new System.Drawing.Size(110, 20);
            this.lblcustomerid.TabIndex = 22;
            this.lblcustomerid.Text = "Customer ID";
            this.lblcustomerid.Click += new System.EventHandler(this.lblcustomerid_Click);
            // 
            // lblphoneno
            // 
            this.lblphoneno.AutoSize = true;
            this.lblphoneno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphoneno.Location = new System.Drawing.Point(33, 207);
            this.lblphoneno.Name = "lblphoneno";
            this.lblphoneno.Size = new System.Drawing.Size(87, 20);
            this.lblphoneno.TabIndex = 21;
            this.lblphoneno.Text = "Phone No";
            this.lblphoneno.Click += new System.EventHandler(this.label1_Click);
            // 
            // cobxmartialstatus
            // 
            this.cobxmartialstatus.FormattingEnabled = true;
            this.cobxmartialstatus.Items.AddRange(new object[] {
            "Married",
            "Unmarried"});
            this.cobxmartialstatus.Location = new System.Drawing.Point(236, 377);
            this.cobxmartialstatus.Name = "cobxmartialstatus";
            this.cobxmartialstatus.Size = new System.Drawing.Size(220, 21);
            this.cobxmartialstatus.TabIndex = 7;
            this.cobxmartialstatus.SelectedIndexChanged += new System.EventHandler(this.cobxmartialstatus_SelectedIndexChanged);
            // 
            // cobxcustomertype
            // 
            this.cobxcustomertype.FormattingEnabled = true;
            this.cobxcustomertype.Items.AddRange(new object[] {
            "Silver",
            "Gold",
            "Platinum"});
            this.cobxcustomertype.Location = new System.Drawing.Point(236, 288);
            this.cobxcustomertype.Name = "cobxcustomertype";
            this.cobxcustomertype.Size = new System.Drawing.Size(220, 21);
            this.cobxcustomertype.TabIndex = 5;
            this.cobxcustomertype.SelectedIndexChanged += new System.EventHandler(this.cobxcustomertype_SelectedIndexChanged);
            // 
            // btnaddcustomer
            // 
            this.btnaddcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcustomer.Location = new System.Drawing.Point(103, 425);
            this.btnaddcustomer.Name = "btnaddcustomer";
            this.btnaddcustomer.Size = new System.Drawing.Size(135, 43);
            this.btnaddcustomer.TabIndex = 8;
            this.btnaddcustomer.Text = "Add Customer";
            this.btnaddcustomer.UseVisualStyleBackColor = true;
            this.btnaddcustomer.Click += new System.EventHandler(this.btnaddcustomer_Click);
            // 
            // txtphoneno
            // 
            this.txtphoneno.Location = new System.Drawing.Point(236, 207);
            this.txtphoneno.Name = "txtphoneno";
            this.txtphoneno.Size = new System.Drawing.Size(220, 20);
            this.txtphoneno.TabIndex = 3;
            this.txtphoneno.TextChanged += new System.EventHandler(this.txtboxphoneno_TextChanged);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(236, 134);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(220, 53);
            this.txtaddress.TabIndex = 2;
            this.txtaddress.MultilineChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtcustomername
            // 
            this.txtcustomername.Location = new System.Drawing.Point(236, 99);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(220, 20);
            this.txtcustomername.TabIndex = 1;
            // 
            // txtemailid
            // 
            this.txtemailid.Location = new System.Drawing.Point(236, 247);
            this.txtemailid.Name = "txtemailid";
            this.txtemailid.Size = new System.Drawing.Size(220, 20);
            this.txtemailid.TabIndex = 4;
            this.txtemailid.TextChanged += new System.EventHandler(this.txtemailid_TextChanged);
            // 
            // lblmartialstatus
            // 
            this.lblmartialstatus.AutoSize = true;
            this.lblmartialstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmartialstatus.Location = new System.Drawing.Point(33, 377);
            this.lblmartialstatus.Name = "lblmartialstatus";
            this.lblmartialstatus.Size = new System.Drawing.Size(121, 20);
            this.lblmartialstatus.TabIndex = 6;
            this.lblmartialstatus.Text = "Martial Status";
            this.lblmartialstatus.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbldateofbirth
            // 
            this.lbldateofbirth.AutoSize = true;
            this.lbldateofbirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateofbirth.Location = new System.Drawing.Point(33, 331);
            this.lbldateofbirth.Name = "lbldateofbirth";
            this.lbldateofbirth.Size = new System.Drawing.Size(115, 20);
            this.lbldateofbirth.TabIndex = 5;
            this.lbldateofbirth.Text = "Date Of Birth";
            // 
            // lblcustomertype
            // 
            this.lblcustomertype.AutoSize = true;
            this.lblcustomertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomertype.Location = new System.Drawing.Point(33, 289);
            this.lblcustomertype.Name = "lblcustomertype";
            this.lblcustomertype.Size = new System.Drawing.Size(129, 20);
            this.lblcustomertype.TabIndex = 4;
            this.lblcustomertype.Text = "Customer Type";
            // 
            // lblemailid
            // 
            this.lblemailid.AutoSize = true;
            this.lblemailid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemailid.Location = new System.Drawing.Point(33, 247);
            this.lblemailid.Name = "lblemailid";
            this.lblemailid.Size = new System.Drawing.Size(77, 20);
            this.lblemailid.TabIndex = 3;
            this.lblemailid.Text = "Email ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 2;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(33, 143);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(75, 20);
            this.lbladdress.TabIndex = 1;
            this.lbladdress.Text = "Address";
            // 
            // lblcustomername
            // 
            this.lblcustomername.AutoSize = true;
            this.lblcustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomername.Location = new System.Drawing.Point(33, 97);
            this.lblcustomername.Name = "lblcustomername";
            this.lblcustomername.Size = new System.Drawing.Size(137, 20);
            this.lblcustomername.TabIndex = 0;
            this.lblcustomername.Text = "Customer Name";
            this.lblcustomername.Click += new System.EventHandler(this.lblcustomername_Click);
            // 
            // Frmadcus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 480);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frmadcus";
            this.Text = "Form AddCustomer";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbladdnewcustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnaddcustomer;
        private System.Windows.Forms.TextBox txtphoneno;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Windows.Forms.TextBox txtemailid;
        private System.Windows.Forms.Label lblmartialstatus;
        private System.Windows.Forms.Label lbldateofbirth;
        private System.Windows.Forms.Label lblcustomertype;
        private System.Windows.Forms.Label lblemailid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblcustomername;
        private System.Windows.Forms.ComboBox cobxmartialstatus;
        private System.Windows.Forms.ComboBox cobxcustomertype;
        private System.Windows.Forms.Label lblphoneno;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.Label lblcustomerid;
        private System.Windows.Forms.DateTimePicker dtetmpkr;
        private System.Windows.Forms.Button btnclear;
    }
}