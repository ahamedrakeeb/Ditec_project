namespace My_Project_01
{
    partial class frmproject1_parent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmproject1_parent));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userOutlookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenuItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenuItemsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReservationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManagementToolStripMenuItem,
            this.menuManagementToolStripMenuItem,
            this.customerManagementToolStripMenuItem,
            this.addReservationToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(959, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem,
            this.userOutlookToolStripMenuItem,
            this.editUserToolStripMenuItem});
            this.userManagementToolStripMenuItem.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.createUserToolStripMenuItem.Text = "Create User";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // userOutlookToolStripMenuItem
            // 
            this.userOutlookToolStripMenuItem.Name = "userOutlookToolStripMenuItem";
            this.userOutlookToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.userOutlookToolStripMenuItem.Text = "User Outlook";
            this.userOutlookToolStripMenuItem.Click += new System.EventHandler(this.userOutlookToolStripMenuItem_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.editUserToolStripMenuItem.Text = "Edit / Delete  User";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // menuManagementToolStripMenuItem
            // 
            this.menuManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuItemsToolStripMenuItem,
            this.addMenuItemsToolStripMenuItem1,
            this.editMenuItemToolStripMenuItem});
            this.menuManagementToolStripMenuItem.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuManagementToolStripMenuItem.Name = "menuManagementToolStripMenuItem";
            this.menuManagementToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.menuManagementToolStripMenuItem.Text = "Menu Management";
            // 
            // addMenuItemsToolStripMenuItem
            // 
            this.addMenuItemsToolStripMenuItem.Name = "addMenuItemsToolStripMenuItem";
            this.addMenuItemsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.addMenuItemsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.addMenuItemsToolStripMenuItem.Text = "Add Menu Items";
            this.addMenuItemsToolStripMenuItem.Click += new System.EventHandler(this.addMenuItemsToolStripMenuItem_Click);
            // 
            // addMenuItemsToolStripMenuItem1
            // 
            this.addMenuItemsToolStripMenuItem1.Name = "addMenuItemsToolStripMenuItem1";
            this.addMenuItemsToolStripMenuItem1.Size = new System.Drawing.Size(225, 22);
            this.addMenuItemsToolStripMenuItem1.Text = "View  / Search Menu";
            this.addMenuItemsToolStripMenuItem1.Click += new System.EventHandler(this.addMenuItemsToolStripMenuItem1_Click);
            // 
            // editMenuItemToolStripMenuItem
            // 
            this.editMenuItemToolStripMenuItem.Name = "editMenuItemToolStripMenuItem";
            this.editMenuItemToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.editMenuItemToolStripMenuItem.Text = "Edit / Delete Menu Item";
            this.editMenuItemToolStripMenuItem.Click += new System.EventHandler(this.editMenuItemToolStripMenuItem_Click);
            // 
            // customerManagementToolStripMenuItem
            // 
            this.customerManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.viewAllCustomerToolStripMenuItem,
            this.editCustomerToolStripMenuItem});
            this.customerManagementToolStripMenuItem.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerManagementToolStripMenuItem.Name = "customerManagementToolStripMenuItem";
            this.customerManagementToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
            this.customerManagementToolStripMenuItem.Text = "Customer Management";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // viewAllCustomerToolStripMenuItem
            // 
            this.viewAllCustomerToolStripMenuItem.Name = "viewAllCustomerToolStripMenuItem";
            this.viewAllCustomerToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.viewAllCustomerToolStripMenuItem.Text = "Search / View All Customer";
            this.viewAllCustomerToolStripMenuItem.Click += new System.EventHandler(this.viewAllCustomerToolStripMenuItem_Click);
            // 
            // editCustomerToolStripMenuItem
            // 
            this.editCustomerToolStripMenuItem.Name = "editCustomerToolStripMenuItem";
            this.editCustomerToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.editCustomerToolStripMenuItem.Text = "Edit / Delete Customer";
            this.editCustomerToolStripMenuItem.Click += new System.EventHandler(this.editCustomerToolStripMenuItem_Click);
            // 
            // addReservationToolStripMenuItem1
            // 
            this.addReservationToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billingToolStripMenuItem});
            this.addReservationToolStripMenuItem1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addReservationToolStripMenuItem1.Name = "addReservationToolStripMenuItem1";
            this.addReservationToolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.addReservationToolStripMenuItem1.Text = "Billing";
            this.addReservationToolStripMenuItem1.Click += new System.EventHandler(this.addReservationToolStripMenuItem1_Click);
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.billingToolStripMenuItem.Text = "Billing";
            this.billingToolStripMenuItem.Click += new System.EventHandler(this.billingToolStripMenuItem_Click);
            // 
            // frmproject1_parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 487);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmproject1_parent";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userOutlookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMenuItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMenuItemsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editMenuItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReservationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
    }
}

