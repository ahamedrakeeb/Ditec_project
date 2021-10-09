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
    public partial class frmuser2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ahamedrakeeb\Desktop\My Project 01\My Project 01\Menu1.mdf;Integrated Security=True");
        SqlCommand com;
        public frmuser2()
        {
            InitializeComponent();
        }

        private void btndisplayall_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlselect = "select*from create_user";
                com = new SqlCommand(sqlselect, con);
                SqlDataReader dr = com.ExecuteReader();
                // create an object named data table
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

        private void txtuserid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlselect = "select*from create_user where user_ID='" + txtuserid.Text + "'";
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

        private void dgvdisplayall_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
