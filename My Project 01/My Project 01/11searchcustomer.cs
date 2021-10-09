using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace My_Project_01
{
    public partial class frmcusoutlk : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ahamedrakeeb\Desktop\My Project 01\My Project 01\Menu1.mdf;Integrated Security=True");
        SqlCommand com;
        public frmcusoutlk()
        {
            InitializeComponent();
        }

        private void dgvdisplayall_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btndisplayall_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlselect = "select * from Customers";
                com = new SqlCommand(sqlselect, con);
                SqlDataReader dr = com.ExecuteReader();
                // create an object named data table
                DataTable dt = new DataTable();
                // move the records from the data reader to the data table object
                dt.Load(dr);
                // move the records from the data table to the data grid view
                dgvdisplayall.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


          
        }

        private void txtcusid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlselect = "select * from Customers where Cus_ID='" + txtcusid.Text + "'";
                com = new SqlCommand(sqlselect, con);
                SqlDataReader dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvdisplayall.DataSource = dt;
                con.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

         private void frmcusoutlk_Load(object sender, EventArgs e)
        {

        }

         private void lblcusid_Click(object sender, EventArgs e)
         {

         }

         private void lblcustomerid_Click(object sender, EventArgs e)
         {

         }
    }
}































