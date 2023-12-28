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
    public partial class ViewBooking : Form
    {
        public ViewBooking()
        {
            InitializeComponent();
        }
        private void ViewBooking_Load(object sender, EventArgs e)
        {
            populate();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mahro\Documents\Marriagedb.mdf;Integrated Security=True;Connect Timeout=30");


        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            MainForm Home = new MainForm();
            Home.Show();
            this.Hide();
        }
        
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            if (BookKey == 0)
            {
                MessageBox.Show("Select the customer to be deleted");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "Delete from Boooking where Bid = " + BookKey + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking sucessfully deleted");
                    conn.Close();
                    populate();
                    //Clear();
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
            string query = "select * from Boooking";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
        int BookKey = 0;
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string BookDate = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if (BookDate == "")
            {
                BookKey = 0;
            }
            else
            {
                BookKey = Convert.ToInt32(gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string Bid = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string BDate = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string BTime = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string CustName = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string Persons = gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            string Dishes = gunaDataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            string Drinks = gunaDataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            string CostFood = gunaDataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            string CostDrink = gunaDataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            string GrdTotal = gunaDataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            string Advance = gunaDataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            string Balance = gunaDataGridView1.SelectedRows[0].Cells[11].Value.ToString();

            e.Graphics.DrawString("Booking Summary", new Font("Century Gothic", 25, FontStyle.Regular), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Booking Id"+ Bid, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(130,150));
            e.Graphics.DrawString("Booking Date"+ BDate, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(130, 200));
            e.Graphics.DrawString("Booking Time" + BTime, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(130, 200));
            e.Graphics.DrawString("Customer Name" + CustName, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(130, 200));
            e.Graphics.DrawString("No Persons" + Persons, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(130, 200));
            e.Graphics.DrawString("Dishes" + Dishes, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(130, 200));
            e.Graphics.DrawString("Drinks" + Drinks, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(130, 200));
            e.Graphics.DrawString("Dishes Cost" + CostFood, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(130, 200));
            e.Graphics.DrawString("Drink Cost" + CostDrink, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(130, 200));
            e.Graphics.DrawString("Total" + GrdTotal, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(130, 200));
            e.Graphics.DrawString("Advance" + Advance, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(130, 200));
            e.Graphics.DrawString("Balance" + Balance, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(130, 200));



        }
    }
}
