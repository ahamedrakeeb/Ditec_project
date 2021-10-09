namespace My_Project_01
{
    partial class frmadd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadd));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBox3 = new System.Windows.Forms.ComboBox();
            this.cbBox1 = new System.Windows.Forms.ComboBox();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.grpBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD MENU ITEMS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(222, 85);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(223, 20);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(222, 131);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(223, 20);
            this.txtBox2.TabIndex = 1;
            this.txtBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtBox3
            // 
            this.txtBox3.Location = new System.Drawing.Point(222, 227);
            this.txtBox3.Multiline = true;
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(223, 38);
            this.txtBox3.TabIndex = 3;
            this.txtBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtBox4
            // 
            this.txtBox4.Location = new System.Drawing.Point(222, 292);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.Size = new System.Drawing.Size(223, 20);
            this.txtBox4.TabIndex = 4;
            this.txtBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Category";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Description";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Type";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbBox3
            // 
            this.cbBox3.FormattingEnabled = true;
            this.cbBox3.Items.AddRange(new object[] {
            "Vegetarian",
            "Non-Vegetarian"});
            this.cbBox3.Location = new System.Drawing.Point(222, 339);
            this.cbBox3.Name = "cbBox3";
            this.cbBox3.Size = new System.Drawing.Size(223, 21);
            this.cbBox3.TabIndex = 5;
            // 
            // cbBox1
            // 
            this.cbBox1.FormattingEnabled = true;
            this.cbBox1.Items.AddRange(new object[] {
            "Indian",
            "Chinese",
            "Continental",
            "Desserts"});
            this.cbBox1.Location = new System.Drawing.Point(222, 176);
            this.cbBox1.Name = "cbBox1";
            this.cbBox1.Size = new System.Drawing.Size(223, 21);
            this.cbBox1.TabIndex = 2;
            // 
            // grpBox1
            // 
            this.grpBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpBox1.BackgroundImage")));
            this.grpBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpBox1.Controls.Add(this.button1);
            this.grpBox1.Controls.Add(this.label1);
            this.grpBox1.Controls.Add(this.cbBox1);
            this.grpBox1.Controls.Add(this.cbBox3);
            this.grpBox1.Controls.Add(this.label5);
            this.grpBox1.Controls.Add(this.label8);
            this.grpBox1.Controls.Add(this.label4);
            this.grpBox1.Controls.Add(this.label7);
            this.grpBox1.Controls.Add(this.label2);
            this.grpBox1.Controls.Add(this.label3);
            this.grpBox1.Controls.Add(this.txtBox4);
            this.grpBox1.Controls.Add(this.txtBox3);
            this.grpBox1.Controls.Add(this.txtBox2);
            this.grpBox1.Controls.Add(this.btnadd);
            this.grpBox1.Controls.Add(this.txtBox1);
            this.grpBox1.Location = new System.Drawing.Point(-7, 0);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(740, 487);
            this.grpBox1.TabIndex = 4;
            this.grpBox1.TabStop = false;
            this.grpBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(235, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Item Code";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item Name";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Lucida Bright", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(81, 411);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Add Item";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 479);
            this.Controls.Add(this.grpBox1);
            this.Name = "frmadd";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.TextBox txtBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBox3;
        private System.Windows.Forms.ComboBox cbBox1;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button1;
    }
}