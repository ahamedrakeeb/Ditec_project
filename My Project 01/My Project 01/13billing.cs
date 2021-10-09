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
    public partial class frmbilling : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ahamedrakeeb\Desktop\My Project 01\My Project 01\Menu1.mdf;Integrated Security=True");
        SqlCommand com;

        public frmbilling()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void btnadd_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string sqlselect = "select * from Billing where Bill_No='" + txtboxbillno.Text + "'";
                com = new SqlCommand(sqlselect, con);
                SqlDataReader dr = com.ExecuteReader();
                /* if(dr.Read())
                 {
                     MessageBox.Show("Record exists - Input another Bill_No.","Record existance check",MessageBoxButtons.OK,MessageBoxIcon.Information);
                     txtboxbillno.Clear();
                     txtboxbillno.Focus();

                 }
                 else
                 {*/
                if (txtboxitemcode.Text.Length != 5)
                {
                    MessageBox.Show("Length is wrong Enter 5 characters");
                    txtboxitemcode.Clear();
                    txtboxitemcode.Focus();
                }
                else
                {
                    con.Close();
                    con.Open();
                    string sqlinsert = "insert into Billing(Bill_No,Item_Code,Date_of_Billing,Quantity,Price,Total_price) values('" + txtboxbillno.Text + "','" + txtboxitemcode.Text + "','" + dateTimePicker1.Value + "','" + txtboxquantity.Text + "' , '" + txtbxprice.Text + "','" + txtbxtotalprice.Text + "')";
                    com = new SqlCommand(sqlinsert, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Record is added");

                    con.Close();
                    con.Open();
                    String sql = "select * from Billing where Bill_No='" + txtboxbillno.Text + "'";
                    com = new SqlCommand(sqlselect, con);
                    SqlDataReader dataread = com.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dataread);
                    dgvshow.DataSource = dt;
                    con.Close();
                }



                // }
                con.Close();
            }// end of try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }// end of catch
        }
        /*private void btnremove_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
               // string sqldelete = "Delete from Billing where Bill_No='" + txtboxbillno.Text + "',Item_code='" + txtboxitemcode.Text + "',Date_of_Billing='"+dateTimePicker1.Value+"',Quantity='" + txtboxquantity.Text + "',Price='" + txtbxprice.Text + "',Total_price='" + txtbxtotalprice.Text + "'";
                string sqldelete = "Delete from Billing Where Bill_No='" + txtboxbillno.Text + "' ";
                com = new SqlCommand(sqldelete, con);
                MessageBox.Show("Record is deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }*/


        private void btnshow_Click_1(object sender, EventArgs e)
        {
            try
            {
                /*con.Open();
                string sqlselect = "select * from Billing where Bill_No='" + txtboxbillno.Text + "'";
                com = new SqlCommand(sqlselect, con);
                SqlDataReader dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvshow.DataSource = dt;
                con.Close();*/


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtboxbillno.Clear();
            txtboxitemcode.Clear();
            txtboxquantity.Clear();
            txtbxprice.Clear();
            txtbxcostprice.Clear();
            txtbxpayment.Clear();
            txtbxbalance.Clear();
            txtbxtotalprice.Clear();
            txtboxitemcode.Clear();
        }

       

        private void btncalculte_Click(object sender, EventArgs e)
        {

            int Bill_No, Item_code, Quantity, Price, Total_price;
            Bill_No = int.Parse(txtboxbillno.Text);
            Item_code = int.Parse(txtboxitemcode.Text);
            Quantity = int.Parse(txtboxquantity.Text);
            Price = int.Parse(txtbxprice.Text);
            Total_price = Quantity * Price;


            txtbxtotalprice.Text = Total_price.ToString();
            try
            {
                con.Open();
                string sql = "Update Billing Set Quantity='" + txtboxquantity.Text + "',Price='" + txtbxprice.Text + "'Where Item_code='" + txtboxitemcode.Text + "'";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Data updated successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtboxitemcode.ReadOnly = false;

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

        private void btnenter_Click(object sender, EventArgs e)
        {

            con.Open();
            string sqlselect = "select SUM(Total_Price) from Billing where Bill_No='"+txtboxbillno.Text+"'";
            com = new SqlCommand(sqlselect, con);
            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {

                txtbxcostprice.Text = dr[0].ToString();
            }


            con.Close();


            try
            {
               
                con.Open();
                int Cost_price, Payment, Balance;
                Cost_price = int.Parse(txtbxcostprice.Text);
                Payment = int.Parse(txtbxpayment.Text);

                Balance = Payment - Cost_price;

                txtbxbalance.Text = Balance.ToString();

                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lblbillno_Click(object sender, EventArgs e)
        {

        }

        private void txtboxbillno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxitemcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtboxquantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }


        
        
    

    
               
    


