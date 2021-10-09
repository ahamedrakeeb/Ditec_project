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
    public partial class frmuser1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ahamedrakeeb\Desktop\My Project 01\My Project 01\Menu1.mdf;Integrated Security=True");
        SqlCommand com;
        public frmuser1()
        {
            InitializeComponent();
        }

        private void btncreateneuuser_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text!=txtconfirmpassword.Text)
            {
                MessageBox.Show("Password is not correct ");
                txtpassword.Clear();
                txtconfirmpassword.Clear();
                txtpassword.Focus();
            }
            else
            {
                try 
	{	        con.Open();
                string sqlinsert = "insert into create_user(user_ID,user_name,password,confirm_password,last_name,first_name,date_of_birth,location,contact_No,Email_ID,user_type) values('" + txtuserid.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "','" + txtconfirmpassword.Text + "','" + txtlastname.Text + "','" + txtfirstname.Text + "','" + dtp1.Text + "','" + txtlocation.Text + "','" + txtcontactno.Text + "','" + txtemailid.Text + "','" + comboboxusertype.Text + "')";
                com = new SqlCommand(sqlinsert, con);
                com.ExecuteNonQuery();  
		         MessageBox.Show("Record is added");
	}
	catch (Exception ex)
	{
		

	
     
         MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }          
    }
          

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtconfirmpassword.Clear();
            txtcontactno.Clear();
            txtemailid.Clear();
            txtfirstname.Clear();
            txtlastname.Clear();
            txtlocation.Clear();
            txtpassword.Clear();
            txtuserid.Clear();
            txtusername.Clear();
            txtuserid.Focus();
            comboboxusertype.Text = "";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you sure to close the application now?", "Confirmation for close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ans==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnchecklength_Click(object sender, EventArgs e)
        {
            if (txtuserid.Text.Length!=4)
            {
                MessageBox.Show("Wrong length - Please enter 4 characters");
                txtuserid.Clear();
                txtuserid.Focus();
            }
            else
            {
                txtusername.Focus();
            }
        }
    }
}

