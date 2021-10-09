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
    public partial class frmuser3 : Form
    {
        SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ahamedrakeeb\Desktop\My Project 01\My Project 01\Menu1.mdf;Integrated Security=True");
        SqlCommand com;
        public frmuser3()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
             try
            {
                if (txtuserid.Text.Length != 4)
                {
                    MessageBox.Show("Length is wrong-Enter 4 numbers", "Length check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtuserid.Clear();
                    txtuserid.Focus();
                }
                else   //correct length
                {
                    con.Open();
                    string sqlselect = "Select * from create_user where user_ID='" + txtuserid.Text + "'";
                     com = new SqlCommand(sqlselect, con);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read()) //dr is not empty or record exists means can edit
                    {
                        txtuserid.Text = dr["user_ID"].ToString();
                        txtusername.Text = dr["user_name"].ToString();
                        txtpassword.Text = dr["password"].ToString();
                        txtcontactno.Text = dr["contact_No"].ToString();
                        txtdatheofbirth.Text = dr["date_of_birth"].ToString();
                        txtemailid.Text = dr["Email_ID"].ToString();
                        txtlastname.Text = dr["last_name"].ToString();
                        txtfirstname.Text = dr["first_name"].ToString();
                        txtlocation.Text = dr["location"].ToString();
                        cbusertype.Text = dr["user_type"].ToString();
                          }
                    else   //dr is empty
                    {
                        MessageBox.Show("Record is not found-Input a another user_ID", "Record existance check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtuserid.Clear();
                        txtuserid.Focus();
                    }
                    con.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
              
                   
               
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
             try
            {
                con.Open();
                string quary = "update create_user set last_name='" + txtlastname.Text + "',first_name='" + txtfirstname.Text + "',date_of_birth='" + txtdatheofbirth.Text + "',location='" + txtlocation.Text + "',Email_ID='" + txtemailid.Text + "',contact_No='" + txtcontactno.Text + "',user_name='"+txtusername.Text+"',confirm_password='"+txtconfirmpassword.Text+"',user_type='"+cbusertype.Text+"',password='"+txtpassword.Text+"' where user_ID='"+txtuserid.Text+"'";
                com = new SqlCommand(quary, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Changes are saved "," ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                con.Close();
                    

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ans = MessageBox.Show("Are you sure to delete this record ?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(ans==DialogResult.Yes)
                

                con.Open();
                string quary = "delete from create_user where user_ID='" + txtuserid.Text + "'";
                com = new SqlCommand(quary, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Delete success");
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtuserid.Clear();
            txtusername.Clear();
            txtfirstname.Clear();
            txtlastname.Clear();
            txtlocation.Clear();
            txtconfirmpassword.Clear();
            txtcontactno.Clear();
            txtemailid.Clear();
            txtpassword.Clear();
            txtdatheofbirth.Clear();
            cbusertype.Text = "";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you sure to close the application now ?", "Confirmation for close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ans==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void cbusertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
