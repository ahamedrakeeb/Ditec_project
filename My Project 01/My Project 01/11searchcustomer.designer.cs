namespace My_Project_01
{
    partial class frmcusoutlk
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
            this.txtcusid = new System.Windows.Forms.TextBox();
            this.dgvdisplayall = new System.Windows.Forms.DataGridView();
            this.btndisplayall = new System.Windows.Forms.Button();
            this.lblcustomerid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplayall)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcusid
            // 
            this.txtcusid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusid.Location = new System.Drawing.Point(308, 22);
            this.txtcusid.Name = "txtcusid";
            this.txtcusid.Size = new System.Drawing.Size(178, 22);
            this.txtcusid.TabIndex = 0;
            this.txtcusid.TextChanged += new System.EventHandler(this.txtcusid_TextChanged);
            // 
            // dgvdisplayall
            // 
            this.dgvdisplayall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdisplayall.Location = new System.Drawing.Point(12, 50);
            this.dgvdisplayall.Name = "dgvdisplayall";
            this.dgvdisplayall.Size = new System.Drawing.Size(694, 276);
            this.dgvdisplayall.TabIndex = 3;
            this.dgvdisplayall.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdisplayall_CellContentClick);
            // 
            // btndisplayall
            // 
            this.btndisplayall.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplayall.Location = new System.Drawing.Point(279, 340);
            this.btndisplayall.Name = "btndisplayall";
            this.btndisplayall.Size = new System.Drawing.Size(140, 49);
            this.btndisplayall.TabIndex = 1;
            this.btndisplayall.Text = "Display All";
            this.btndisplayall.UseVisualStyleBackColor = true;
            this.btndisplayall.Click += new System.EventHandler(this.btndisplayall_Click);
            // 
            // lblcustomerid
            // 
            this.lblcustomerid.AutoSize = true;
            this.lblcustomerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomerid.Location = new System.Drawing.Point(162, 22);
            this.lblcustomerid.Name = "lblcustomerid";
            this.lblcustomerid.Size = new System.Drawing.Size(110, 20);
            this.lblcustomerid.TabIndex = 3;
            this.lblcustomerid.Text = "Customer ID";
            this.lblcustomerid.Click += new System.EventHandler(this.lblcustomerid_Click);
            // 
            // frmcusoutlk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::My_Project_01.Properties.Resources.pexels_photo_1267299;
            this.ClientSize = new System.Drawing.Size(729, 401);
            this.Controls.Add(this.lblcustomerid);
            this.Controls.Add(this.btndisplayall);
            this.Controls.Add(this.dgvdisplayall);
            this.Controls.Add(this.txtcusid);
            this.Name = "frmcusoutlk";
            this.Text = "Form Customer Out Look";
            this.Load += new System.EventHandler(this.frmcusoutlk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplayall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcusid;
        private System.Windows.Forms.DataGridView dgvdisplayall;
        private System.Windows.Forms.Button btndisplayall;
        private System.Windows.Forms.Label lblcustomerid;
    }
}