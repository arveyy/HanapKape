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
    public partial class UseApproximateLocationForm : Form
    {
        public UseApproximateLocationForm()
        {
            InitializeComponent();
            DarkModeToggle.Checked = ThemeSettings.IsDarkMode;
            ApplyTheme();
        }

        private void DarkModeToggle_CheckedChanged(object sender, EventArgs e)
        {
            ThemeSettings.IsDarkMode = DarkModeToggle.Checked;
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            this.BackColor = ThemeSettings.BackColor;
            this.ForeColor = ThemeSettings.TextColor;
            DarkModeLabel.ForeColor = ThemeSettings.TextColor;
        }

        private void UseApproximateLocationForm_Resize(object sender, EventArgs e)
        {
            // Add centering logic here if there are main controls to center
        }

        private void NearbyFormButton_Click(object sender, EventArgs e)
        {
            NearbyForm nearbyBtn = new NearbyForm();
            this.Hide();
            nearbyBtn.Show();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HanapKapeHome home = new HanapKapeHome();
            this.Hide();
            home.Show();
        }
    }
}
