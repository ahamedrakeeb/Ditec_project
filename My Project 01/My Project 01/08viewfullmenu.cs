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
    public partial class frmmenusearch : Form
    {  // create an object for connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ahamedrakeeb\Desktop\My Project 01\My Project 01\Menu1.mdf;Integrated Security=True");
        // declare an object for command to hold the sql statements
        SqlCommand com;

        public frmmenusearch()
        {
          







            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }   

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dgvdisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

            }

        private void btndisplayall_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlselect = "select * from menutable";
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlselect = "select * from menutable where item_code='" + textBox1.Text + "'";
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
        }
        }
    

