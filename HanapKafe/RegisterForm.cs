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
    public partial class GoogleMapLinkRegistration : Form
    {
        public GoogleMapLinkRegistration()
        {
            InitializeComponent();
        }

        private void RegisterManuallyButton_Click(object sender, EventArgs e)
        {
            ManualRegistrationForm ManualRegistration = new ManualRegistrationForm();
            this.Hide();
            ManualRegistration.Show();
        }

        private void HomeLabelLink_Click(object sender, EventArgs e)
        {
            HanapKapeHome Home = new HanapKapeHome();
            this.Hide();
            Home.Show();
        }

        private void RegisterFormButton_Click(object sender, EventArgs e)
        {
            GoogleMapLinkRegistration register = new GoogleMapLinkRegistration();
            this.Hide();
            register.Show();
        }

        private void PriceCheckerFormButton_Click(object sender, EventArgs e)
        {
            PriceCheckerForm priceCheckherbtn = new PriceCheckerForm();
            this.Hide();
            priceCheckherbtn.Show();
        }

        private void NearbyFormButton_Click(object sender, EventArgs e)
        {
            NearbyForm nearbyBtn = new NearbyForm();
            this.Hide();
            nearbyBtn.Show();
        }
    }
}
