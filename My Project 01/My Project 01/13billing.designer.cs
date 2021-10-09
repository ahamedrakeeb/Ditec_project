namespace My_Project_01
{
    partial class frmbilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbilling));
            this.lblbillno = new System.Windows.Forms.Label();
            this.lblitemcode = new System.Windows.Forms.Label();
            this.lbldateofbilling = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtboxitemcode = new System.Windows.Forms.TextBox();
            this.txtboxbillno = new System.Windows.Forms.TextBox();
            this.txtboxquantity = new System.Windows.Forms.TextBox();
            this.btncalculte = new System.Windows.Forms.Button();
            this.txtbxcostprice = new System.Windows.Forms.TextBox();
            this.txtbxpayment = new System.Windows.Forms.TextBox();
            this.txtbxbalance = new System.Windows.Forms.TextBox();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvshow = new System.Windows.Forms.DataGridView();
            this.btnclear = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxprice = new System.Windows.Forms.TextBox();
            this.btnenter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxtotalprice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbillno
            // 
            this.lblbillno.AutoSize = true;
            this.lblbillno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbillno.Location = new System.Drawing.Point(22, 21);
            this.lblbillno.Name = "lblbillno";
            this.lblbillno.Size = new System.Drawing.Size(60, 20);
            this.lblbillno.TabIndex = 0;
            this.lblbillno.Text = "Bill No";
            this.lblbillno.Click += new System.EventHandler(this.lblbillno_Click);
            // 
            // lblitemcode
            // 
            this.lblitemcode.AutoSize = true;
            this.lblitemcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemcode.Location = new System.Drawing.Point(22, 61);
            this.lblitemcode.Name = "lblitemcode";
            this.lblitemcode.Size = new System.Drawing.Size(92, 20);
            this.lblitemcode.TabIndex = 1;
            this.lblitemcode.Text = "Item Code";
            // 
            // lbldateofbilling
            // 
            this.lbldateofbilling.AutoSize = true;
            this.lbldateofbilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateofbilling.ForeColor = System.Drawing.Color.Black;
            this.lbldateofbilling.Location = new System.Drawing.Point(269, 19);
            this.lbldateofbilling.Name = "lbldateofbilling";
            this.lbldateofbilling.Size = new System.Drawing.Size(122, 20);
            this.lbldateofbilling.TabIndex = 2;
            this.lbldateofbilling.Text = "Date of Billing";
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.ForeColor = System.Drawing.Color.Black;
            this.lblquantity.Location = new System.Drawing.Point(269, 61);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(76, 20);
            this.lblquantity.TabIndex = 3;
            this.lblquantity.Text = "Quantity";
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(579, 117);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(94, 30);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtboxitemcode
            // 
            this.txtboxitemcode.Location = new System.Drawing.Point(120, 61);
            this.txtboxitemcode.Name = "txtboxitemcode";
            this.txtboxitemcode.Size = new System.Drawing.Size(119, 20);
            this.txtboxitemcode.TabIndex = 1;
            this.txtboxitemcode.TextChanged += new System.EventHandler(this.txtboxitemcode_TextChanged);
            // 
            // txtboxbillno
            // 
            this.txtboxbillno.Location = new System.Drawing.Point(120, 19);
            this.txtboxbillno.Name = "txtboxbillno";
            this.txtboxbillno.Size = new System.Drawing.Size(119, 20);
            this.txtboxbillno.TabIndex = 0;
            this.txtboxbillno.TextChanged += new System.EventHandler(this.txtboxbillno_TextChanged);
            // 
            // txtboxquantity
            // 
            this.txtboxquantity.Location = new System.Drawing.Point(418, 63);
            this.txtboxquantity.Name = "txtboxquantity";
            this.txtboxquantity.Size = new System.Drawing.Size(119, 20);
            this.txtboxquantity.TabIndex = 3;
            this.txtboxquantity.TextChanged += new System.EventHandler(this.txtboxquantity_TextChanged);
            // 
            // btncalculte
            // 
            this.btncalculte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculte.Location = new System.Drawing.Point(16, 405);
            this.btncalculte.Name = "btncalculte";
            this.btncalculte.Size = new System.Drawing.Size(94, 30);
            this.btncalculte.TabIndex = 5;
            this.btncalculte.Text = "Calculate";
            this.btncalculte.UseVisualStyleBackColor = true;
            this.btncalculte.Click += new System.EventHandler(this.btncalculte_Click);
            // 
            // txtbxcostprice
            // 
            this.txtbxcostprice.Location = new System.Drawing.Point(456, 337);
            this.txtbxcostprice.Name = "txtbxcostprice";
            this.txtbxcostprice.Size = new System.Drawing.Size(100, 20);
            this.txtbxcostprice.TabIndex = 6;
            // 
            // txtbxpayment
            // 
            this.txtbxpayment.Location = new System.Drawing.Point(456, 379);
            this.txtbxpayment.Name = "txtbxpayment";
            this.txtbxpayment.Size = new System.Drawing.Size(100, 20);
            this.txtbxpayment.TabIndex = 7;
            // 
            // txtbxbalance
            // 
            this.txtbxbalance.Location = new System.Drawing.Point(456, 423);
            this.txtbxbalance.Name = "txtbxbalance";
            this.txtbxbalance.Size = new System.Drawing.Size(100, 20);
            this.txtbxbalance.TabIndex = 8;
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.AutoSize = true;
            this.lbltotalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalprice.Location = new System.Drawing.Point(320, 284);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(94, 20);
            this.lbltotalprice.TabIndex = 14;
            this.lbltotalprice.Text = "Total Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Balance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cost Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Payment";
            // 
            // dgvshow
            // 
            this.dgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshow.Location = new System.Drawing.Point(26, 107);
            this.dgvshow.Name = "dgvshow";
            this.dgvshow.Size = new System.Drawing.Size(530, 197);
            this.dgvshow.TabIndex = 19;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(689, 117);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(94, 30);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(418, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(119, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "price";
            // 
            // txtbxprice
            // 
            this.txtbxprice.Location = new System.Drawing.Point(664, 19);
            this.txtbxprice.Name = "txtbxprice";
            this.txtbxprice.Size = new System.Drawing.Size(119, 20);
            this.txtbxprice.TabIndex = 4;
            // 
            // btnenter
            // 
            this.btnenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenter.Location = new System.Drawing.Point(609, 339);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(94, 30);
            this.btnenter.TabIndex = 8;
            this.btnenter.Text = "Enter";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Total Price";
            // 
            // txtbxtotalprice
            // 
            this.txtbxtotalprice.Location = new System.Drawing.Point(664, 63);
            this.txtbxtotalprice.Name = "txtbxtotalprice";
            this.txtbxtotalprice.Size = new System.Drawing.Size(119, 20);
            this.txtbxtotalprice.TabIndex = 5;
            // 
            // frmbilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 473);
            this.Controls.Add(this.txtbxtotalprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.txtbxprice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.dgvshow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltotalprice);
            this.Controls.Add(this.txtbxbalance);
            this.Controls.Add(this.txtbxpayment);
            this.Controls.Add(this.txtbxcostprice);
            this.Controls.Add(this.btncalculte);
            this.Controls.Add(this.txtboxquantity);
            this.Controls.Add(this.txtboxbillno);
            this.Controls.Add(this.txtboxitemcode);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblquantity);
            this.Controls.Add(this.lbldateofbilling);
            this.Controls.Add(this.lblitemcode);
            this.Controls.Add(this.lblbillno);
            this.Name = "frmbilling";
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbillno;
        private System.Windows.Forms.Label lblitemcode;
        private System.Windows.Forms.Label lbldateofbilling;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtboxitemcode;
        private System.Windows.Forms.TextBox txtboxbillno;
        private System.Windows.Forms.TextBox txtboxquantity;
        private System.Windows.Forms.Button btncalculte;
        private System.Windows.Forms.TextBox txtbxcostprice;
        private System.Windows.Forms.TextBox txtbxpayment;
        private System.Windows.Forms.TextBox txtbxbalance;
        private System.Windows.Forms.Label lbltotalprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxprice;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxtotalprice;
    }
}