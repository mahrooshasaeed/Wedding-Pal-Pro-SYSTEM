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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mahro\Documents\Marriagedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            AdminLogin Ad = new AdminLogin();
            Ad.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(Usernametb.Text==""|| Passwordtb.Text == "")
            {
                MessageBox.Show("Enter username or password");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select COUNT(*) from  StaffTbl where StaffName='" + Usernametb.Text + "' and StaffPassword='" + Passwordtb.Text + "'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MainForm Home = new MainForm();
                        Home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password");
                        Usernametb.Text = "";
                        Passwordtb.Text = "";
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
