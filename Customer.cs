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

namespace Wedding_Pal_Pro_SYSTEM
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            populate();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mahro\Documents\Marriagedb.mdf;Integrated Security=True;Connect Timeout=30");
        private void addcustbtn_Click(object sender, EventArgs e)
        {
            if(Custnametb.Text == "" || Custaddtb.Text == "" || Custphonetb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query ="insert into CustomerTbl values('"+ Custnametb.Text +"','" + Custaddtb.Text + "','" + Custphonetb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer sucessfully added");
                    conn.Close();
                    populate();
                    Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void populate()
        {
            conn.Open();
            string query = "select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];
            conn.Close() ;
        }
        int custkey = 0;
        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Custnametb.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
            Custaddtb.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString() ;
            Custphonetb.Text = CustomerDGV.SelectedRows[0].Cells[3].Value.ToString();
            if(Custphonetb.Text == "")
            {
                custkey = 0;
            }
            else
            {
                custkey = Convert.ToInt32(CustomerDGV.SelectedRows[0].Cells[0].Value.ToString()); 
            }
        }
        public void Clear()
        {
            Custphonetb.Text = "";
            Custnametb.Text = "";
            Custaddtb.Text = "";
            custkey = 0;
        }
        private void resetcustbtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void deletecustbtn_Click(object sender, EventArgs e)
        {

            if (custkey==0)
            {
                MessageBox.Show("Select the customer to be deleted");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "Delete from CustomerTbl where Custid = " + custkey + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer sucessfully deleted");
                    conn.Close();
                    populate();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void editcustbtn_Click(object sender, EventArgs e)
        {

            if (Custnametb.Text == "" || Custaddtb.Text == "" || Custphonetb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "update CustomerTbl set CustName ='" +Custnametb.Text+"',CustAdd='"+Custaddtb.Text+"',CustPhone='"+Custphonetb.Text+ "' where Custid = " + custkey + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer sucessfully updated");
                    conn.Close();
                    populate();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void backcustbtn_Click(object sender, EventArgs e)
        {
            MainForm Home = new MainForm();
            Home.Show();
            this.Hide();
        }
    }
}
    

