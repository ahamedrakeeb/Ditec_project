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
    public partial class frmadd : Form
    {
        // create an object for connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ahamedrakeeb\Desktop\My Project 01\My Project 01\Menu1.mdf;Integrated Security=True");
        // declare an object for command to hold the sql statements
        SqlCommand com;

        public frmadd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if(txtBox1.Text.Length!=5)
            {
                MessageBox.Show("Length is wrong-Enter5 characters");
                txtBox1.Clear();
                txtBox1.Focus();
            }
            else
            {


                try
                {
                    con.Open();
                    string sqlselect = "select * from menutable where item_code= '" + txtBox1.Text + "'";
                    com = new SqlCommand(sqlselect, con);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Record is already available");
                        txtBox1.Clear();
                        txtBox1.Focus();

                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        string sqlinsert = "insert into menutable(item_code,item_name,category,description,price,type) values('" + txtBox1.Text + "','" + txtBox2.Text + "','" + cbBox1.Text + "','" + txtBox3.Text + "','" + txtBox4.Text + "','" + cbBox3.Text + "')";
                        com = new SqlCommand(sqlinsert, con);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Record is added");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                
            }
        }

        public string textBox2 { get; set; }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtBox1.Clear();
            txtBox2.Clear();
            cbBox1.Text="";
            txtBox3.Clear();
            txtBox4.Clear();
            cbBox3.Text = "";


        }
    }
}
