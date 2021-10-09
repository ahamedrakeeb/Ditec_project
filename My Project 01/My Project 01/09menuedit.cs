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
    public partial class frmedit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ahamedrakeeb\Desktop\My Project 01\My Project 01\Menu1.mdf;Integrated Security=True");
        SqlCommand com;
        public frmedit()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_text()
        {
            txtBox1.Clear();
            txtBox2.Clear();
            cbBox1.Text="";
            txtBox3.Clear();
            txtBox4.Clear();
            cbBox3.Text = "";
            
        }
        private void change_Status()
        {
            txtBox1.Enabled = true;
            txtBox2.Enabled = false;
            cbBox1.Enabled = false;
            txtBox3.Enabled = false;
            txtBox4.Enabled = false;
            cbBox3.Enabled = false;
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            



        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (txtBox1.Text.Length != 5)
            {
                MessageBox.Show("Wrong length - Input another item_code. in 5 characters", "Length Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox1.Clear();
                txtBox1.Focus();
            }
            else // correct length
            {
                try
                {
                    con.Open();
                    string sqlselect = "select * from menutable where item_code='" + txtBox1.Text + "'";
                    com = new SqlCommand(sqlselect, con);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        // enable the text boxes to display the details
                        txtBox2.Enabled = true;
                        cbBox1.Enabled = true;
                        txtBox3.Enabled = true;
                        txtBox4.Enabled = true;
                        cbBox3.Enabled = true;


                        txtBox2.Text = dr["item_name"].ToString();
                        cbBox1.Text = dr["category"].ToString();
                        txtBox3.Text = dr["description"].ToString();
                        txtBox4.Text = dr["price"].ToString();
                        cbBox3.Text = dr["type"].ToString();
                        // disable the txtstno & btndelete 
                      //  txtBox1.Enabled = false;
                      //  btndelete.Enabled = false;
                        DialogResult ans = MessageBox.Show("Are you sure to delete this record ?", "Confirmation for deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ans == DialogResult.Yes)
                        {
                            con.Close();
                            con.Open();
                            string sqldelete = "delete from menutable where item_code='" + txtBox1.Text + "'";
                            com = new SqlCommand(sqldelete, con);
                            com.ExecuteNonQuery();
                            MessageBox.Show("Record is deleted successfully", "Deleting a record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    else
                    {

                        MessageBox.Show("Record does not exist - Input another item_code.", "Record existance check", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtBox1.Clear();
                        txtBox1.Focus();

                    }
                    con.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text.Length != 5)
            {

                MessageBox.Show("Wrong length-input another item_code.in 5 characters", "Length check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox1.Clear();
                txtBox1.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    string sqlselect = "select * from menutable where item_code='" + txtBox1.Text + "'";
                    com = new SqlCommand(sqlselect, con);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())//dr is not empty or record exists means can edit
                    {
                        //enable the text boxes to display the details the details
                        txtBox2.Enabled = true;
                        cbBox1.Enabled = true;
                        txtBox3.Enabled = true;
                        txtBox4.Enabled = true;
                        cbBox3.Enabled = true;

                        txtBox2.Text = dr["item_name"].ToString();
                        cbBox1.Text = dr["category"].ToString();
                        txtBox3.Text = dr["description"].ToString();
                        txtBox4.Text = dr["price"].ToString();
                        cbBox3.Text = dr["type"].ToString();
                       
                        //get the focus to txtbxcusname to edit the name
                        txtBox2.Focus();
                        //disable the txtbxcusname & btnedit  
                       // txtBox1.Enabled = false;
                       // btnedit.Enabled = false;
                    }

                    else // dr is empty or record not available
                    {
                        MessageBox.Show("Record does not exist - Input another item_code", "Record existance check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBox1.Clear();
                        txtBox1.Focus();
                    }
                    con.Close();
                }//end of try
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }//end of catch
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlupdate = "update menutable set item_name='" + txtBox2.Text + "',category='" + cbBox1.Text + "',description='" + txtBox3.Text + "',price='" + txtBox4.Text + "',type='" + cbBox3.Text + "' where item_code='" + txtBox1.Text + "'";
                com = new SqlCommand(sqlupdate, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Amendments are saved in the table", "Editing an existing record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // call the general procedures

                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cbBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            clear_text();
            change_Status();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            DialogResult ans = MessageBox.Show("Are you sure to close the application now?", "confirmation for Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
