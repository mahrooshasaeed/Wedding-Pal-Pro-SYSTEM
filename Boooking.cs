using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wedding_Pal_Pro_SYSTEM
{
    public partial class Boooking : Form
    {
        public Boooking()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mahro\Documents\Marriagedb.mdf;Integrated Security=True;Connect Timeout=30");
        private DataGridView gunaDataGridView1 = new DataGridView();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                IcedteaPrice.Enabled = true;
                IcedteaQty.Enabled = true;

            }
            else
            {
                IcedteaPrice.Enabled = false;
                IcedteaQty.Enabled = false;
                IcedteaPrice.Text = "";
                IcedteaQty.Text = "";
            }
        }

        private void GolaCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (GolaCheckbox.Checked)
            {
                GolaPrice.Enabled = true;
                GolaQty.Enabled = true;

            }
            else
            {
                GolaPrice.Enabled = false;
                GolaQty.Enabled = false;
                GolaPrice.Text = "";
                GolaQty.Text = "";
            }
        }

        private void ColdcoffeecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ColdcoffeecheckBox.Checked)
            {
                ColdcofeePrice.Enabled = true;
                ColdcofeeQty.Enabled = true;

            }
            else
            {
                ColdcofeePrice.Enabled = false;
                ColdcofeeQty.Enabled = false;
                ColdcofeePrice.Text = "";
                ColdcofeeQty.Text = "";
            }
        }

        private void lassicheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lassicheckBox.Checked)
            {
                LassiPrice.Enabled = true;
                LassiQty.Enabled = true;

            }
            else
            {
                LassiPrice.Enabled = false;
                LassiQty.Enabled = false;
                LassiPrice.Text = "";
                LassiQty.Text = "";
            }
        }

        private void NimbupanicheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NimbupanicheckBox.Checked)
            {
                NimbupaniPrice.Enabled = true;
                NimbupaniQty.Enabled = true;

            }
            else
            {
                NimbupaniPrice.Enabled = false;
                NimbupaniQty.Enabled = false;
                NimbupaniPrice.Text = "";
                NimbupaniQty.Text = "";
            }
        }

        private void PineApplejuicecheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (PineApplejuicecheckBox.Checked)
            {
                PineAppleJuicePrice.Enabled = true;
                PineAppleJuiceQty.Enabled = true;

            }
            else
            {
                PineAppleJuicePrice.Enabled = false;
                PineAppleJuiceQty.Enabled = false;
                PineAppleJuicePrice.Text = "";
                PineAppleJuiceQty.Text = "";
            }
        }

        private void MixfruitjuicecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MixfruitjuicecheckBox.Checked)
            {
                MixFruitJuicePrice.Enabled = true;
                MixFruitJuiceQty.Enabled = true;

            }
            else
            {
                MixFruitJuicePrice.Enabled = false;
                MixFruitJuiceQty.Enabled = false;
                MixFruitJuicePrice.Text = "";
                MixFruitJuiceQty.Text = "";
            }
        }

        private void ColdDrinkcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ColdDrinkcheckBox.Checked)
            {
                ColdDrinkPrice.Enabled = true;
                ColdDrinkQty.Enabled = true;

            }
            else
            {
                ColdDrinkPrice.Enabled = false;
                ColdDrinkQty.Enabled = false;
                ColdDrinkPrice.Text = "";
                ColdDrinkQty.Text = "";
            }
        }

        private void MuttonHaleemcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MuttonHaleemcheckBox.Checked)
            {
                MuttonhaleemPrice.Enabled = true;
                MuttonhaleemQty.Enabled = true;

            }
            else
            {
                MuttonhaleemPrice.Enabled = false;
                MuttonhaleemQty.Enabled = false;
                MuttonhaleemPrice.Text = "";
                MuttonhaleemQty.Text = "";
            }
        }

        private void MuttonpulaocheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MuttonpulaocheckBox.Checked)
            {
                MuttonPulaoPrice.Enabled = true;
                MuttonPulaoQty.Enabled = true;

            }
            else
            {
                MuttonPulaoPrice.Enabled = false;
                MuttonPulaoQty.Enabled = false;
                MuttonPulaoPrice.Text = "";
                MuttonPulaoQty.Text = "";
            }
        }

        private void LukhmikebabcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LukhmikebabcheckBox.Checked)
            {
                Lukhmikebabprice.Enabled = true;
                LukhmikebabQty.Enabled = true;

            }
            else
            {
                Lukhmikebabprice.Enabled = false;
                LukhmikebabQty.Enabled = false;
                Lukhmikebabprice.Text = "";
                LukhmikebabQty.Text = "";
            }
        }

        private void FriedfishcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FriedfishcheckBox.Checked)
            {
                Friedfishprice.Enabled = true;
                FriedfishQty.Enabled = true;

            }
            else
            {
                Friedfishprice.Enabled = false;
                FriedfishQty.Enabled = false;
                Friedfishprice.Text = "";
                FriedfishQty.Text = "";
            }
        }

        private void LaalChickencheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LaalChickencheckBox.Checked)
            {
                LaalChickenprice.Enabled = true;
                LaalChickenQty.Enabled = true;

            }
            else
            {
                LaalChickenprice.Enabled = false;
                LaalChickenQty.Enabled = false;
                LaalChickenprice.Text = "";
                LaalChickenQty.Text = "";
            }
        }

        private void ChickenbiryanicheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenbiryanicheckBox.Checked)
            {
                ChickenBiryaniPrice.Enabled = true;
                ChickenBiryaniQty.Enabled = true;

            }
            else
            {
                ChickenBiryaniPrice.Enabled = false;
                ChickenBiryaniQty.Enabled = false;
                ChickenBiryaniPrice.Text = "";
                ChickenBiryaniQty.Text = "";
            }
        }

        private void MuttonBiryanicheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MuttonBiryanicheckBox.Checked)
            {
                MuttonBiryaniPrice.Enabled = true;
                MuttonBiryaniQty.Enabled = true;

            }
            else
            {
                MuttonBiryaniPrice.Enabled = false;
                MuttonBiryaniQty.Enabled = false;
                MuttonBiryaniPrice.Text = "";
                MuttonBiryaniQty.Text = "";
            }
        }

        private void ChickenPulaocheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenPulaocheckBox.Checked)
            {
                ChickenPulaoPrice.Enabled = true;
                ChickenPulaoQty.Enabled = true;

            }
            else
            {
                ChickenPulaoPrice.Enabled = false;
                ChickenPulaoQty.Enabled = false;
                ChickenPulaoPrice.Text = "";
                ChickenPulaoQty.Text = "";
            }
        }
        int bevcost = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int IcedTea = 0, Gola = 0, ColdCoffee = 0, lassi = 0, NimbuPani = 0, Pineapplejuice = 0, MixFruitJuice = 0, ColdDrink = 0;

            if (checkBox1.Checked == true && IcedteaPrice.Text == "" && IcedteaQty.Text == "")
            {
                MessageBox.Show("Enter Iced Tea Quantity");
            }
            else
            {
                IcedTea = Convert.ToInt32(IcedteaPrice.Text) * Convert.ToInt32(IcedteaQty.Text);
            }

            if (GolaCheckbox.Checked == true && GolaPrice.Text == "" && GolaQty.Text == "")
            {
                MessageBox.Show("Enter Gola Quantity");
            }
            else
            {
                Gola = Convert.ToInt32(GolaPrice.Text) * Convert.ToInt32(GolaQty.Text);
            }
            if (ColdcoffeecheckBox.Checked == true && ColdcofeePrice.Text == "" && ColdcofeeQty.Text == "")
            {
                MessageBox.Show("Enter Cold Coffee Quantity");
            }
            else
            {
                ColdCoffee = Convert.ToInt32(ColdcofeePrice.Text) * Convert.ToInt32(ColdcofeeQty.Text);
            }
            if (lassicheckBox.Checked == true && LassiPrice.Text == "" && LassiQty.Text == "")
            {
                MessageBox.Show("Enter Lassi Quantity");
            }
            else
            {
                lassi = Convert.ToInt32(LassiPrice.Text) * Convert.ToInt32(LassiQty.Text);
            }

            if (NimbupanicheckBox.Checked == true && NimbupaniPrice.Text == "" && NimbupaniQty.Text == "")
            {
                MessageBox.Show("Enter Nimbu Pani Quantity");
            }
            else
            {
                NimbuPani = Convert.ToInt32(NimbupaniPrice.Text) * Convert.ToInt32(NimbupaniQty.Text);
            }

            if (PineApplejuicecheckBox.Checked == true && PineAppleJuicePrice.Text == "" && PineAppleJuiceQty.Text == "")
            {
                MessageBox.Show("Enter Pine Apple Juice Quantity");
            }
            else
            {
                Pineapplejuice = Convert.ToInt32(PineAppleJuicePrice.Text) * Convert.ToInt32(PineAppleJuiceQty.Text);
            }

            if (MixfruitjuicecheckBox.Checked == true && MixFruitJuicePrice.Text == "" && MixFruitJuiceQty.Text == "")
            {
                MessageBox.Show("Enter Mix Fruit Juice Quantity");
            }
            else
            {
                MixFruitJuice = Convert.ToInt32(MixFruitJuicePrice.Text) * Convert.ToInt32(MixFruitJuiceQty.Text);
            }
            if (ColdDrinkcheckBox.Checked == true && ColdDrinkPrice.Text == "" && ColdDrinkQty.Text == "")
            {
                MessageBox.Show("Enter Cold Drink Quantity");
            }
            else
            {
                ColdDrink = Convert.ToInt32(ColdDrinkPrice.Text) * Convert.ToInt32(ColdDrinkQty.Text);
            }

            bevcost = IcedTea + Gola + ColdCoffee + lassi + NimbuPani + Pineapplejuice + MixFruitJuice + ColdDrink;
            Bevcostlbl.Text = "" + bevcost;
        }
        int FoodCost = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            int MuttonHaleem = 0, MuttonPulao = 0, LukhmiKebab = 0, FriedFish = 0, LaalChicken = 0, ChickenBiryani = 0, MuttonBiryani = 0, ChickenPulao = 0;
            if (MuttonHaleemcheckBox.Checked == true && MuttonhaleemPrice.Text == "" && MuttonhaleemQty.Text == "")
            {
                MessageBox.Show("Enter Mutton Haleem Quantity");
            }
            else
            {
                MuttonHaleem = Convert.ToInt32(MuttonhaleemPrice.Text) * Convert.ToInt32(MuttonhaleemQty.Text);


            }

            if (MuttonpulaocheckBox.Checked == true && MuttonPulaoPrice.Text == "" && MuttonPulaoQty.Text == "")
            {
                MessageBox.Show("Enter Mutton Pulao Quantity");
            }
            else
            {
                MuttonPulao = Convert.ToInt32(MuttonPulaoPrice.Text) * Convert.ToInt32(MuttonPulaoQty.Text);
            }

            if (LukhmikebabcheckBox.Checked == true && Lukhmikebabprice.Text == "" && LukhmikebabQty.Text == "")
            {
                MessageBox.Show("Enter Lukhmi Kebab Quantity");
            }
            else
            {
                LukhmiKebab = Convert.ToInt32(Lukhmikebabprice.Text) * Convert.ToInt32(LukhmikebabQty.Text);
            }

            if (FriedfishcheckBox.Checked == true && Friedfishprice.Text == "" && FriedfishQty.Text == "")
            {
                MessageBox.Show("Enter Fried Fish Quantity");
            }
            else
            {
                FriedFish = Convert.ToInt32(Friedfishprice.Text) * Convert.ToInt32(FriedfishQty.Text);
            }

            if (LaalChickencheckBox.Checked == true && LaalChickenprice.Text == "" && LaalChickenQty.Text == "")
            {
                MessageBox.Show("Enter Laal Chicken Quantity");
            }
            else
            {
                LaalChicken = Convert.ToInt32(LaalChickenprice.Text) * Convert.ToInt32(LaalChickenQty.Text);
            }

            if (ChickenbiryanicheckBox.Checked == true && ChickenBiryaniPrice.Text == "" && ChickenBiryaniQty.Text == "")
            {
                MessageBox.Show("Enter Chicken Biryani Quantity");
            }
            else
            {
                ChickenBiryani = Convert.ToInt32(ChickenBiryaniPrice.Text) * Convert.ToInt32(ChickenBiryaniQty.Text);
            }

            if (MuttonBiryanicheckBox.Checked == true && MuttonBiryaniPrice.Text == "" && MuttonBiryaniQty.Text == "")
            {
                MessageBox.Show("Enter Mutton Biryani Quantity");
            }
            else
            {
                MuttonBiryani = Convert.ToInt32(MuttonBiryaniPrice.Text) * Convert.ToInt32(MuttonBiryaniQty.Text);
            }

            if (ChickenPulaocheckBox.Checked == true && ChickenPulaoPrice.Text == "" && ChickenPulaoQty.Text == "")
            {
                MessageBox.Show("Enter Chicken Pulao Quantity");
            }
            else
            {
                ChickenPulao = Convert.ToInt32(ChickenPulaoPrice.Text) * Convert.ToInt32(ChickenPulaoQty.Text);
            }

            FoodCost = MuttonHaleem + MuttonPulao + LukhmiKebab + FriedFish + LaalChicken + ChickenBiryani + MuttonBiryani + ChickenPulao;
            FoodCostlbl.Text = "" + FoodCost;
        }
        private void GetCustid()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Custid from CustomerTbl", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Custid", typeof(string));
            dt.Load(rdr);
            custidcombo.ValueMember = "Custid";
            custidcombo.DataSource = dt;
            conn.Close();
        }
        private void Boooking_Load(object sender, EventArgs e)
        {
            GetCustid();
        }
        private void fetchCustName()
        {
            if (custidcombo.SelectedValue == null || string.IsNullOrEmpty(custidcombo.SelectedValue.ToString()))
            {
                Customernamelbl.Text = "No customer selected";
                return;
            }

            try
            {
                conn.Open();

                string mysql = "SELECT CustName FROM CustomerTbl WHERE Custid = @Custid";

                SqlCommand cmd = new SqlCommand(mysql, conn);
                cmd.Parameters.AddWithValue("@Custid", custidcombo.SelectedValue);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    Customernamelbl.Text = result.ToString();
                }
                else
                {
                    Customernamelbl.Text = "Customer not found";
                }
            }
            catch (Exception)
            {
                Customernamelbl.Text = "No Customer Selected";
            }
            finally
            {
                conn.Close();
            }
        }

        private void custidcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchCustName();
        }
        private void CalculateTotal()
        {
            // Bev Cost
            int bevcost = 0;
            if (!string.IsNullOrEmpty(Bevcostlbl.Text))
            {
                bevcost = Convert.ToInt32(Bevcostlbl.Text);
            }

            // Other Charges
            int otherCharges = 0;
            if (!string.IsNullOrEmpty(Otherchargestb.Text))
            {
                otherCharges = Convert.ToInt32(Otherchargestb.Text);
            }

            // Advance
            int advance = 0;
            if (!string.IsNullOrEmpty(Advancetb.Text))
            {
                advance = Convert.ToInt32(Advancetb.Text);
            }

            // Food Cost
            int FoodCost = 0;
            if (!string.IsNullOrEmpty(FoodCostlbl.Text))
            {
                FoodCost = Convert.ToInt32(FoodCostlbl.Text);
            }

            // Grand Total
            int grandTotal = bevcost + FoodCost + otherCharges;

            // Balance
            int balance = grandTotal - advance;


            Totalltb.Text = grandTotal.ToString();
            balancetb.Text = balance.ToString();
        }
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (Datetxt.Text == "" || timetxt.SelectedIndex == -1 || Customernamelbl.Text == "" || persontb.Text == "" || Dishes.Text == "" || Drinks.Text == "" || Bevcostlbl.Text == "" || FoodCostlbl.Text == "" || Otherchargestb.Text == "" || Totalltb.Text == "" || Advancetb.Text == "" || balancetb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO Boooking (BDate, BTime, CustName, Persons, Dishes, Drinks, CostFood, CostDrink, OtherCharges, GrdTotal, Advance, Balance) " +
                                   "VALUES (@BDate, @BTime, @CustName, @Persons, @Dishes, @Drinks, @CostFood, @CostDrink, @OtherCharges, @GrdTotal, @Advance, @Balance)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BDate", Datetxt.Value.ToString("yyyy-MM-dd")); // Assuming 'yyyy-MM-dd' is the appropriate date format for your SQL database
                    cmd.Parameters.AddWithValue("@BTime", timetxt.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CustName", Customernamelbl.Text);
                    cmd.Parameters.AddWithValue("@Persons", persontb.Text);
                    cmd.Parameters.AddWithValue("@Dishes", Dishes.Text);
                    cmd.Parameters.AddWithValue("@Drinks", Drinks.Text);
                    cmd.Parameters.AddWithValue("@CostFood", Bevcostlbl.Text);
                    cmd.Parameters.AddWithValue("@CostDrink", FoodCostlbl.Text);
                    cmd.Parameters.AddWithValue("@OtherCharges", Otherchargestb.Text);
                    cmd.Parameters.AddWithValue("@GrdTotal", Totalltb.Text);
                    cmd.Parameters.AddWithValue("@Advance", Advancetb.Text);
                    cmd.Parameters.AddWithValue("@Balance", balancetb.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Boooking successfully added");

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


        private void populate()
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
            Datetxt.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Customernamelbl.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            timetxt.SelectedItem = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            persontb.Text = gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Dishes.Text = gunaDataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            Drinks.Text = gunaDataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            Bevcostlbl.Text = gunaDataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            FoodCostlbl.Text = gunaDataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            Otherchargestb.Text = gunaDataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            Advancetb.Text = gunaDataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            Totalltb.Text = gunaDataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            balancetb.Text = gunaDataGridView1.SelectedRows[0].Cells[12].Value.ToString();


            if (persontb.Text == "")
            {
                BookKey = 0;
            }
            else
            {
                BookKey = Convert.ToInt32(gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        public void Clear()
        {
            Datetxt.Text = "";
            Customernamelbl.Text = "";
            timetxt.Text = "";
            persontb.Text = "";
            Dishes.Text = "";
            Drinks.Text = "";
            Bevcostlbl.Text = "";
            FoodCostlbl.Text = "";
            Otherchargestb.Text = "";
            Advancetb.Text = "";
            Totalltb.Text = "";
            balancetb.Text = "";
            BookKey = 0;
        }




        private void textBox51_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void label21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            MainForm Home = new MainForm();
            Home.Show();
            this.Hide();
        }

        private void Datetxt_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

