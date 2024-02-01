using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trip_Planner
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnTrip_Click(object sender, EventArgs e)
        {
            Form reg = new Info();
            reg.Show();
            this.Hide();
        }

        private void aboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by young Jordanians aiming to show the stunning beauty of Jordan, this system was created to help you make your trip to Jordan " +
                "as special and memorable as possible!");
        }

        private void ApplyItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Start by clicking the generate trip button to have your perfect customized trip!");
        }

        private void websiteItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.mota.gov.jo/Default/Ar");
        }

        private void privacyItem_Click(object sender, EventArgs e)
        {
           MessageBox.Show("We are committed to protecting your privacy. We collect, use, and share your personal information to provide and improve our services and communicate with you.");
        }

        private void lblintro_Click(object sender, EventArgs e)
        {

        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

    

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPetra_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
