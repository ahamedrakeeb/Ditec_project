using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Project_01
{
    public partial class frmproject1_parent : Form
    {
        public frmproject1_parent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addMenuItemsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // create an object of child form
            frmmenusearch child = new frmmenusearch();
            // child object is in this  parent form 
            child.MdiParent = this;
            // show the object child
            child.Show();
            
          

        }

        private void addReservationToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void addMenuItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create an object of child form
            frmadd child = new frmadd();
            // child object is in this  parent form 
            child.MdiParent = this;
            // show the object child
            child.Show();

        }

        private void searchMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create an object of child form
       
            // child object is in this  parent form 
       
            // show the object child
       
            frmmenusearch f1 = new frmmenusearch();
            this.Hide();

            f1.Show();
           

          

        }

        private void editMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create an object of child form
            frmedit child = new frmedit();
            // child object is in this  parent form 
            child.MdiParent = this;
            // show the object child
            child.Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create an object of child form
          Frmadcus child = new Frmadcus();
            // child object is in this  parent form 
            child.MdiParent = this;
            // show the object child
            child.Show();

        }

     

        private void viewAllCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create an object of child form
            frmcusoutlk child = new frmcusoutlk();
            // child object is in this  parent form 
            child.MdiParent = this;
            // show the object child
            child.Show();
            
        }

        private void editCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create an object of child form
            frmcusedit child = new frmcusedit();
            // child object is in this  parent form 
            child.MdiParent = this;
            // show the object child
            child.Show();

        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create an object of child form
            frmuser1 child = new frmuser1();
            // child object is in this  parent form 
            child.MdiParent = this;
            // show the object child
            child.Show();
        }

        private void userOutlookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create an object of child form
            frmuser2 child= new frmuser2();
            // child object is in this  parent form 
            child.MdiParent = this;
            // show the object child
            child.Show();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create an object of child form
            frmuser3 child = new frmuser3();
            // child object is in this  parent form 
            child.MdiParent = this;
            // show the object child
            child.Show();
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                // create an object of child form
            frmbilling child = new frmbilling();
            // child object is in this  parent form 
            child.MdiParent = this;
            // show the object child
            child.Show();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
