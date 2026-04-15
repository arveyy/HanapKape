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
    public partial class ManualRegistrationForm : Form
    {
        public ManualRegistrationForm()
        {
            InitializeComponent();
        }

        private void HomeLabelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HanapKapeHome Home = new HanapKapeHome();
            this.Hide();
            Home.Show();
        }

        private void GoogleMapsLinkButton_Click(object sender, EventArgs e)
        {
            GoogleMapLinkRegistration GoogleMapLinkRegistration = new GoogleMapLinkRegistration();
            this.Hide();
            GoogleMapLinkRegistration.Show();
        }
    }
}
