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
    public partial class HanapKapeHome : Form
    {
        public HanapKapeHome()
        {
            InitializeComponent();
        }

        private void RegisterYourShopButton_Click(object sender, EventArgs e)
        {
            GoogleMapLinkRegistration RegisterForm = new GoogleMapLinkRegistration();
            this.Hide();
            RegisterForm.Show();
        }

        private void ExploreNearbyButton_Click(object sender, EventArgs e)
        {
            NearbyForm nearbyForm = new NearbyForm();
            this.Hide();
            nearbyForm.Show();
        }
    }
}
