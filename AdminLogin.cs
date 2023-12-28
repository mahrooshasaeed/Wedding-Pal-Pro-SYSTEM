using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wedding_Pal_Pro_SYSTEM
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(Passtb.Text == "")
            {
                MessageBox.Show("Enter the Admin Password");
            }
            else if(Passtb.Text == "rooshay")
            {
                Staff st = new Staff();
                st.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password***Contact admin *Mahroosha* Of this system");
            }
        }
    }
}
