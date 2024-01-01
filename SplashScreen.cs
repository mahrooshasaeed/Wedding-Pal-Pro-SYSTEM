using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Wedding_Pal_Pro_SYSTEM
{
    public partial class SplashScreen : Form
    {

        [DllImport("Gdi32.dll",EntryPoint ="CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse);
        
        public SplashScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Value += 1;
            ProgressBar1.Text=ProgressBar1.Value.ToString()+"%";

            if(ProgressBar1.Value == 100)
            {
                timer1.Enabled= false;
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }
    }
}
