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
using System.Drawing.Printing;

namespace Wedding_Pal_Pro_SYSTEM
{
    public partial class ViewBooking : Form
    {
        public ViewBooking()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);


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
        public void populate()
        {
            conn.Open();
            string query = "select * from Boooking";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            gunaDataGridView1.AutoGenerateColumns = true;
            conn.Close();
        }
        int BookKey = 0;

        public void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string BookDate = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if (BookDate == "")
            {
                BookKey = 0;
            }
            else
            {
                BookKey = Convert.ToInt32(gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString());
              
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }

        }
        


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string Bookid = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string Bookdate = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string BookTime = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string Name = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string Pers = gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            string Dishes = gunaDataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            string Bev = gunaDataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            string Drinkcost = gunaDataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            string DishCost = gunaDataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            string Tot = gunaDataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            string Adv = gunaDataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            string Bal = gunaDataGridView1.SelectedRows[0].Cells[11].Value.ToString();

            e.Graphics.DrawString("Booking Summary", new Font("Century Gothic", 25, FontStyle.Regular), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Booking Id :" + Bookid, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.BlueViolet, new Point(100, 150));
            e.Graphics.DrawString("Booking Date :" + Bookdate, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.BlueViolet, new Point(100, 190));
            e.Graphics.DrawString("Booking Time :" + BookTime, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.BlueViolet, new Point(100, 230));
            e.Graphics.DrawString("Customer Name :" + Name, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.BlueViolet, new Point(100, 270));
            e.Graphics.DrawString("No Persons :" + Pers, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.BlueViolet, new Point(100, 310));
            e.Graphics.DrawString("Dishes :" + Dishes, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.BlueViolet, new Point(100, 340));
            e.Graphics.DrawString("Beverage :" + Bev, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.BlueViolet, new Point(100, 370));
            e.Graphics.DrawString("Drinks Cost :" + Drinkcost, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(100, 400));
            e.Graphics.DrawString("Dishes Cost :" + DishCost, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(100, 440));
            e.Graphics.DrawString("Total :" + Tot, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(100, 470));
            e.Graphics.DrawString("Advance :" + Adv, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(100, 510));
            e.Graphics.DrawString("Balance : " + Bal, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(100, 550));


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            if (!printPreviewDialog1.Visible)  // Check if the dialog is not already visible
            {
                printPreviewDialog1.Document = printDocument1;
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                printPreviewDialog1.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
