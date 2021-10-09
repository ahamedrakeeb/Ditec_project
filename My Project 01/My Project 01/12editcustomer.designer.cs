namespace My_Project_01
{
    partial class frmcusedit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcusedit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbledtcustomer = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.dtetmpkr = new System.Windows.Forms.DateTimePicker();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtbxcusid = new System.Windows.Forms.TextBox();
            this.lblcusid = new System.Windows.Forms.Label();
            this.lblcustomername = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblphoneno = new System.Windows.Forms.Label();
            this.lblemailid = new System.Windows.Forms.Label();
            this.lblcostomertype = new System.Windows.Forms.Label();
            this.lbldateofbirth = new System.Windows.Forms.Label();
            this.lblmartialstatus = new System.Windows.Forms.Label();
            this.txtbxcusname = new System.Windows.Forms.TextBox();
            this.txtbxads = new System.Windows.Forms.TextBox();
            this.txtbxphnno = new System.Windows.Forms.TextBox();
            this.txtbxemailid = new System.Windows.Forms.TextBox();
            this.cobbxcustype = new System.Windows.Forms.ComboBox();
            this.cobbxmartialstus = new System.Windows.Forms.ComboBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lbledtcustomer);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.dtetmpkr);
            this.groupBox1.Controls.Add(this.btnclose);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.txtbxcusid);
            this.groupBox1.Controls.Add(this.lblcusid);
            this.groupBox1.Controls.Add(this.lblcustomername);
            this.groupBox1.Controls.Add(this.lbladdress);
            this.groupBox1.Controls.Add(this.lblphoneno);
            this.groupBox1.Controls.Add(this.lblemailid);
            this.groupBox1.Controls.Add(this.lblcostomertype);
            this.groupBox1.Controls.Add(this.lbldateofbirth);
            this.groupBox1.Controls.Add(this.lblmartialstatus);
            this.groupBox1.Controls.Add(this.txtbxcusname);
            this.groupBox1.Controls.Add(this.txtbxads);
            this.groupBox1.Controls.Add(this.txtbxphnno);
            this.groupBox1.Controls.Add(this.txtbxemailid);
            this.groupBox1.Controls.Add(this.cobbxcustype);
            this.groupBox1.Controls.Add(this.cobbxmartialstus);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 510);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbledtcustomer
            // 
            this.lbledtcustomer.AutoSize = true;
            this.lbledtcustomer.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledtcustomer.Location = new System.Drawing.Point(17, 16);
            this.lbledtcustomer.Name = "lbledtcustomer";
            this.lbledtcustomer.Size = new System.Drawing.Size(168, 24);
            this.lbledtcustomer.TabIndex = 1;
            this.lbledtcustomer.Text = "Edit Customer";
            this.lbledtcustomer.Click += new System.EventHandler(this.lbledtcustomer_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Lucida Fax", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(200, 393);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(98, 29);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Lucida Fax", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(58, 393);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(98, 29);
            this.btnedit.TabIndex = 7;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click_1);
            // 
            // dtetmpkr
            // 
            this.dtetmpkr.CustomFormat = "yyy.MM.dd";
            this.dtetmpkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtetmpkr.Location = new System.Drawing.Point(187, 306);
            this.dtetmpkr.Name = "dtetmpkr";
            this.dtetmpkr.Size = new System.Drawing.Size(214, 20);
            this.dtetmpkr.TabIndex = 33;
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Lucida Fax", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(458, 393);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 29);
            this.btnclose.TabIndex = 10;
            this.btnclose.Text = "Close";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Lucida Fax", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(330, 393);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(98, 29);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtbxcusid
            // 
            this.txtbxcusid.Location = new System.Drawing.Point(187, 78);
            this.txtbxcusid.Name = "txtbxcusid";
            this.txtbxcusid.Size = new System.Drawing.Size(214, 20);
            this.txtbxcusid.TabIndex = 0;
            // 
            // lblcusid
            // 
            this.lblcusid.AutoSize = true;
            this.lblcusid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcusid.Location = new System.Drawing.Point(16, 78);
            this.lblcusid.Name = "lblcusid";
            this.lblcusid.Size = new System.Drawing.Size(110, 20);
            this.lblcusid.TabIndex = 29;
            this.lblcusid.Text = "Customer ID";
            // 
            // lblcustomername
            // 
            this.lblcustomername.AutoSize = true;
            this.lblcustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomername.Location = new System.Drawing.Point(16, 108);
            this.lblcustomername.Name = "lblcustomername";
            this.lblcustomername.Size = new System.Drawing.Size(137, 20);
            this.lblcustomername.TabIndex = 3;
            this.lblcustomername.Text = "Customer Name";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(18, 150);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(75, 20);
            this.lbladdress.TabIndex = 4;
            this.lbladdress.Text = "Address";
            // 
            // lblphoneno
            // 
            this.lblphoneno.AutoSize = true;
            this.lblphoneno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphoneno.Location = new System.Drawing.Point(18, 197);
            this.lblphoneno.Name = "lblphoneno";
            this.lblphoneno.Size = new System.Drawing.Size(87, 20);
            this.lblphoneno.TabIndex = 5;
            this.lblphoneno.Text = "Phone No";
            // 
            // lblemailid
            // 
            this.lblemailid.AutoSize = true;
            this.lblemailid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemailid.Location = new System.Drawing.Point(18, 234);
            this.lblemailid.Name = "lblemailid";
            this.lblemailid.Size = new System.Drawing.Size(77, 20);
            this.lblemailid.TabIndex = 6;
            this.lblemailid.Text = "Email ID";
            // 
            // lblcostomertype
            // 
            this.lblcostomertype.AutoSize = true;
            this.lblcostomertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcostomertype.Location = new System.Drawing.Point(18, 269);
            this.lblcostomertype.Name = "lblcostomertype";
            this.lblcostomertype.Size = new System.Drawing.Size(129, 20);
            this.lblcostomertype.TabIndex = 7;
            this.lblcostomertype.Text = "Customer Type";
            // 
            // lbldateofbirth
            // 
            this.lbldateofbirth.AutoSize = true;
            this.lbldateofbirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateofbirth.Location = new System.Drawing.Point(18, 306);
            this.lbldateofbirth.Name = "lbldateofbirth";
            this.lbldateofbirth.Size = new System.Drawing.Size(115, 20);
            this.lbldateofbirth.TabIndex = 8;
            this.lbldateofbirth.Text = "Date Of Birth";
            // 
            // lblmartialstatus
            // 
            this.lblmartialstatus.AutoSize = true;
            this.lblmartialstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmartialstatus.Location = new System.Drawing.Point(18, 341);
            this.lblmartialstatus.Name = "lblmartialstatus";
            this.lblmartialstatus.Size = new System.Drawing.Size(121, 20);
            this.lblmartialstatus.TabIndex = 9;
            this.lblmartialstatus.Text = "Martial Status";
            // 
            // txtbxcusname
            // 
            this.txtbxcusname.Enabled = false;
            this.txtbxcusname.Location = new System.Drawing.Point(187, 110);
            this.txtbxcusname.Name = "txtbxcusname";
            this.txtbxcusname.Size = new System.Drawing.Size(214, 20);
            this.txtbxcusname.TabIndex = 1;
            // 
            // txtbxads
            // 
            this.txtbxads.Enabled = false;
            this.txtbxads.Location = new System.Drawing.Point(187, 141);
            this.txtbxads.Multiline = true;
            this.txtbxads.Name = "txtbxads";
            this.txtbxads.Size = new System.Drawing.Size(214, 40);
            this.txtbxads.TabIndex = 2;
            // 
            // txtbxphnno
            // 
            this.txtbxphnno.Location = new System.Drawing.Point(187, 199);
            this.txtbxphnno.Name = "txtbxphnno";
            this.txtbxphnno.Size = new System.Drawing.Size(214, 20);
            this.txtbxphnno.TabIndex = 3;
            this.txtbxphnno.TextChanged += new System.EventHandler(this.txtbxphnno_TextChanged);
            // 
            // txtbxemailid
            // 
            this.txtbxemailid.Location = new System.Drawing.Point(187, 234);
            this.txtbxemailid.Name = "txtbxemailid";
            this.txtbxemailid.Size = new System.Drawing.Size(214, 20);
            this.txtbxemailid.TabIndex = 4;
            // 
            // cobbxcustype
            // 
            this.cobbxcustype.FormattingEnabled = true;
            this.cobbxcustype.Items.AddRange(new object[] {
            "Silver",
            "Gold",
            "Platinum"});
            this.cobbxcustype.Location = new System.Drawing.Point(187, 268);
            this.cobbxcustype.Name = "cobbxcustype";
            this.cobbxcustype.Size = new System.Drawing.Size(214, 21);
            this.cobbxcustype.TabIndex = 5;
            // 
            // cobbxmartialstus
            // 
            this.cobbxmartialstus.FormattingEnabled = true;
            this.cobbxmartialstus.Items.AddRange(new object[] {
            "Married",
            "Unmarried"});
            this.cobbxmartialstus.Location = new System.Drawing.Point(187, 340);
            this.cobbxmartialstus.Name = "cobbxmartialstus";
            this.cobbxmartialstus.Size = new System.Drawing.Size(214, 21);
            this.cobbxmartialstus.TabIndex = 6;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Lucida Fax", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(268, 445);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(98, 29);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // frmcusedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 554);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmcusedit";
            this.Text = "Form Edit Customer";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblcustomername;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblphoneno;
        private System.Windows.Forms.Label lblemailid;
        private System.Windows.Forms.Label lblcostomertype;
        private System.Windows.Forms.Label lbldateofbirth;
        private System.Windows.Forms.Label lblmartialstatus;
        private System.Windows.Forms.TextBox txtbxcusname;
        private System.Windows.Forms.TextBox txtbxads;
        private System.Windows.Forms.TextBox txtbxphnno;
        private System.Windows.Forms.TextBox txtbxemailid;
        private System.Windows.Forms.ComboBox cobbxcustype;
        private System.Windows.Forms.ComboBox cobbxmartialstus;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label lbledtcustomer;
        private System.Windows.Forms.TextBox txtbxcusid;
        private System.Windows.Forms.Label lblcusid;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.DateTimePicker dtetmpkr;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnedit;
    }
}