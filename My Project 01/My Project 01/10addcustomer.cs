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
    public partial class Frmadcus : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ahamedrakeeb\Desktop\My Project 01\My Project 01\Menu1.mdf;Integrated Security=True");
        SqlCommand com;
        public Frmadcus()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
          
            
        }

        private void txtboxphoneno_TextChanged(object sender, EventArgs e)
        {

        }

        private void cobxmartialstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           // cobxmartialstatus.SelectedIndex = 1;
        }

        private void btnaddcustomer_Click(object sender, EventArgs e)
        {
            if(txtcustomerid.Text.Length!=5)
            {
                MessageBox.Show("Length is wrong-Enter5 characters");
                txtcustomerid.Clear();
                txtcustomerid.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    string sqlselect = "select * from Customers where Cus_ID= '" + txtcustomerid.Text + "'";
                    com = new SqlCommand(sqlselect, con);
                    SqlDataReader dr =com.ExecuteReader();
                    if(dr.Read())
                    {
                        MessageBox.Show("Record is already available");
                        txtcustomerid.Clear();
                        txtcustomerid.Focus();

                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        string sqlinsert="insert into Customers(Cus_ID,Cus_Name,Ads,Phn_No,Email_ID,Cus_type,DOB,Martial_Status) values('"+txtcustomerid.Text+"','"+txtcustomername.Text+"','"+txtaddress.Text+"','"+txtphoneno.Text+"','"+txtemailid.Text+"','"+cobxcustomertype.Text+"','"+dtetmpkr.Text+"','"+cobxmartialstatus.Text+"')";
                        com=new SqlCommand(sqlinsert,con);
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

        private void lblcustomername_Click(object sender, EventArgs e)
        {
        
        }

        private void cobxcustomertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cobxcustomertype.SelectedIndex = 0;
            
        }

        private void cobxdateofbirth_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void lblcustomerid_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtcustomerid.Clear();
            txtcustomername.Clear();
            txtaddress.Clear();
            txtphoneno.Clear();
            txtemailid.Clear();
            cobxcustomertype.Text = "";
            cobxmartialstatus.Text = "";

        }

        private void txtcustomerid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemailid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
