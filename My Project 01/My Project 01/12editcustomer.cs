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
    public partial class frmcusedit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ahamedrakeeb\Desktop\My Project 01\My Project 01\Menu1.mdf;Integrated Security=True");
        SqlCommand com;

        public frmcusedit()
        {
            InitializeComponent();
        }

        private void lbledtcustomer_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

      

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you sure to close the application now?", "confirmation for Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void clear_text()
        {
            txtbxcusid.Clear();
            txtbxcusname.Clear();
            txtbxads.Clear();
            txtbxphnno.Clear();
            txtbxemailid.Clear();
            cobbxcustype.Text = "";
            cobbxmartialstus.Text = "";
        }
        private void change_Status()
        {
            txtbxcusid.Enabled = true;
            txtbxcusname.Enabled = false;
            txtbxads.Enabled = false;
            txtbxphnno.Enabled = false;
            txtbxemailid.Enabled = false;
            cobbxcustype.Enabled = false;
            cobbxcustype.Enabled = false;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear_text();
            change_Status();
           
            
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (txtbxcusid.Text.Length != 5)
            {
                MessageBox.Show("Wrong length - Input another Customer ID. in 5 characters", "Length Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbxcusid.Clear();
                txtbxcusid.Focus();
            }
            else // correct length
            {
                try
                {
                    con.Open();
                    string sqlselect = "select * from Customers where Cus_ID='" + txtbxcusid.Text + "'";
                    com = new SqlCommand(sqlselect, con);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        // enable the text boxes to display the details
                        txtbxcusname.Enabled = true;
                        txtbxads.Enabled = true;
                        txtbxphnno.Enabled = true;
                        txtbxemailid.Enabled = true;
                        cobbxcustype.Enabled = true;
                        cobbxmartialstus.Enabled = true;
                        txtbxcusname.Text = dr["Cus_Name"].ToString();
                        txtbxads.Text = dr["Ads"].ToString();
                        txtbxphnno.Text = dr["Phn_No"].ToString();
                        txtbxemailid.Text = dr["Email_ID"].ToString();
                        cobbxcustype.Text = dr["Cus_Type"].ToString();
                        cobbxmartialstus.Text = dr["Martial_Status"].ToString();
                       
                      //  txtbxcusid.Enabled = false;
                        //btndelete.Enabled = false;
                        DialogResult ans = MessageBox.Show("Are you sure to delete this record ?", "Confirmation for deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ans == DialogResult.Yes)
                        {
                            con.Close();
                            con.Open();
                            string sqldelete = "delete from Customers where Cus_ID='" + txtbxcusid.Text + "'";
                            com = new SqlCommand(sqldelete, con);
                            com.ExecuteNonQuery();
                            MessageBox.Show("Record is deleted successfully", "Deleting a record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    else
                    {

                        MessageBox.Show("Record does not exist - Input another Student No.", "Record existance check", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtbxcusid.Clear();
                        txtbxcusid.Focus();

                    }
                    con.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void btnedit_Click_1(object sender, EventArgs e)
        {
            if (txtbxcusid.Text.Length != 5)
            {

                MessageBox.Show("Wrong length-input another Customer ID.in 5 characters", "Length check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbxcusid.Clear();
                txtbxcusid.Focus();
            }
            else
            {
                
                try
                {
                    con.Open();
                    string sqlselect = "select * from Customers where Cus_ID='" + txtbxcusid.Text + "'";
                    com = new SqlCommand(sqlselect, con);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())//dr is not empty or record exists means can edit
                    {
                        //enable the text boxes to display the details the details
                        txtbxcusname.Enabled = true;
                        txtbxads.Enabled = true;
                        txtbxphnno.Enabled = true;
                        txtbxemailid.Enabled = true;
                        cobbxcustype.Enabled = true;
                        cobbxmartialstus.Enabled = true;

                      
                        txtbxcusname.Text = dr["Cus_Name"].ToString();
                        txtbxads.Text = dr["Ads"].ToString();
                        txtbxphnno.Text = dr["Phn_No"].ToString();
                        txtbxemailid.Text = dr["Email_ID"].ToString();
                        cobbxcustype.Text = dr["Cus_Type"].ToString();
                        cobbxmartialstus.Text = dr["Martial_Status"].ToString();
                        //get the focus to txtbxcusname to edit the name
                        txtbxcusname.Focus();
                        //disable the txtbxcusname & btnedit  
                           txtbxcusid.Enabled = false;
                     // btnedit.Enabled = false;
                    }

                    else // dr is empty or record not available
                    {
                        MessageBox.Show("Record does not exist - Input another Customer ID", "Record existance check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtbxcusid.Clear();
                        txtbxcusid.Focus();
                    }
                    con.Close();
                }//end of try
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }//end of catch
            }
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlupdate = "Update Customers set Cus_Name='" + txtbxcusname.Text + "',Ads='" + txtbxads.Text + "',Phn_No='"+txtbxphnno.Text+"',Email_ID='"+txtbxemailid.Text+"',Cus_Type='"+cobbxcustype.Text+"',Martial_Status='"+cobbxmartialstus.Text+"' where Cus_ID='" + txtbxcusid.Text + "'";
                com = new SqlCommand(sqlupdate, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Amendments are saved in the table", "Editing an existing record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // call the general procedures
                clear_text();
                change_Status(); 
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtbxphnno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}