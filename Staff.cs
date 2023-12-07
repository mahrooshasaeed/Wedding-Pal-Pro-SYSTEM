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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mahro\Documents\Marriagedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void addstaffbtn_Click(object sender, EventArgs e)
        {

            if (staffnametb.Text == "" || staffpass.Text == "" || staffphonetb.Text == "" || staffgender.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "insert into StaffTbl values('" + staffnametb.Text + "','" + staffphonetb.Text + "','" + staffgender.SelectedItem.ToString() + "' ,'" + staffpass.Text + "' )";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff sucessfully added");
                    conn.Close();
                    populate();
                   // Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void populate()
        {
            conn.Open();
            string query = "select * from StaffTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StaffDGV.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
