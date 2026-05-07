using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanapKafe
{
    public partial class NearbyForm : Form
    {
        public NearbyForm()
        {
            InitializeComponent();
        }

        private void NearbyFormButton_Click(object sender, EventArgs e)
        {
            NearbyForm nearbyBtn = new NearbyForm();
            this.Hide();
            nearbyBtn.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HanapKapeHome home = new HanapKapeHome();
            this.Hide();
            home.Show();
        }

        private void PriceCheckerFormButton_Click(object sender, EventArgs e)
        {
            PriceCheckerForm priceCheckherbtn = new PriceCheckerForm();
            this.Hide();
            priceCheckherbtn.Show();
        }

        private void RegisterFormButton_Click(object sender, EventArgs e)
        {
            GoogleMapLinkRegistration register = new GoogleMapLinkRegistration();
            this.Hide();
            register.Show();

        }

        private void UseApproximateLocationFormButton_Click(object sender, EventArgs e)
        {
            UseApproximateLocationForm approximateLoc = new UseApproximateLocationForm();
            this.Hide();
            approximateLoc.Show();
        }
    }
}
