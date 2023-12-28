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
using System.IdentityModel.Protocols.WSTrust;

namespace Wedding_Pal_Pro_SYSTEM
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mahro\Documents\Marriagedb.mdf;Integrated Security=True;Connect Timeout=30");
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
        int StaffKey = 0;
        public void Clear()
        {
            staffnametb.Text = "";
            staffpass.Text = "";
            staffphonetb.Text = "";
            StaffKey = 0;
            staffgender.SelectedIndex = -1;
        }
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
                   Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void Staff_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void editstaffbtn_Click(object sender, EventArgs e)
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
                    string query = "update StaffTbl set StaffName ='" + staffnametb.Text + "',StaffPassword='" + staffpass.Text + "',StaffPhone='" + staffphonetb.Text + "',StaffGender='" + staffgender.Text+"' where Staffid = " + StaffKey + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff sucessfully updated");
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

        private void resetstaffbtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void deletestaffbtn_Click(object sender, EventArgs e)
        {

            if (StaffKey == 0)
            {
                MessageBox.Show("Select the Staff to be deleted");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "Delete from StaffTbl where Staffid = " + StaffKey + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff sucessfully deleted");
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

        private void StaffDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            staffnametb.Text = StaffDGV.SelectedRows[0].Cells[1].Value.ToString();
            staffphonetb.Text = StaffDGV.SelectedRows[0].Cells[2].Value.ToString();
            staffgender.SelectedItem = StaffDGV.SelectedRows[0].Cells[3].Value.ToString();
            staffpass.Text = StaffDGV.SelectedRows[0].Cells[2].Value.ToString();
            if (staffnametb.Text == "")
            {
                StaffKey = 0;
            }
            else
            {
                StaffKey = Convert.ToInt32(StaffDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}
