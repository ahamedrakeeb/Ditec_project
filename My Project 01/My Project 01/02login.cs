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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "gunethi";
            string password = "gunethi";
          
            if(txtusername.Text==username && txtpassword.Text==password)
            {
                MessageBox.Show("You Can Log Into The System","Login Permission",MessageBoxButtons.OK,MessageBoxIcon.Information);
                frmproject1_parent f1 = new frmproject1_parent();
                this.Hide();
                f1.Show();

                
            }else
            {
                MessageBox.Show("You Cant Log Into System.Enter The Valid Details", "Login Permisssion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.Clear();
                txtpassword.Clear();
                txtusername.Focus();



                       
        }
         
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you sure to close the application now?", "Confirmation for close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
