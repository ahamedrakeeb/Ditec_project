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
    public partial class frmwlcm : Form
    {
        public frmwlcm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            
            // create an object of child form
              frmlogin child = new frmlogin();
            // child object is in this  parent form 
         //  this.Hide();
           child.Show();
           this.Hide();
        }
    }
}
