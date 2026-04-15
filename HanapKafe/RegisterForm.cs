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

        private void GoogleMapTxtBox_TextChanged(object sender, EventArgs e)
        {
            GoogleMapLabel.Visible = false;
        }

        private void HomeLabelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           HanapKapeHome Home = new HanapKapeHome();
           this.Hide();
           Home.Show();
        }

        private void ManualButton_Click(object sender, EventArgs e)
        {
            ManualRegistrationForm ManualRegistration = new ManualRegistrationForm();
            this.Hide();
            ManualRegistration.Show();
        }
    }
}
