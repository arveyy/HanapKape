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
            DarkModeToggle.Checked = ThemeSettings.IsDarkMode;
            ApplyTheme();
            CenterControls();
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
            label2.ForeColor = ThemeSettings.TextColor;
            GoogleMapInstructionLabel.ForeColor = ThemeSettings.TextColor;
            DarkModeLabel.ForeColor = ThemeSettings.TextColor;

            GoogleLinkTextBox.FillColor = ThemeSettings.TextBoxBgColor;
            GoogleLinkTextBox.ForeColor = ThemeSettings.TextColor;
            GoogleLinkTextBox.BorderColor = ThemeSettings.BorderColor;
        }

        private void GoogleMapLinkRegistration_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;

            // Center Header (pictureBox1 and label2 as a group)
            int headerGap = 10;
            int totalHeaderWidth = pictureBox1.Width + headerGap + label2.Width;
            pictureBox1.Left = centerX - (totalHeaderWidth / 2);
            label2.Left = pictureBox1.Right + headerGap;

            // Center Textbox and Generate Button as a group
            int mainGap = 10;
            int totalMainWidth = GoogleLinkTextBox.Width + mainGap + GenerateButton.Width;
            GoogleLinkTextBox.Left = centerX - (totalMainWidth / 2);
            GenerateButton.Left = GoogleLinkTextBox.Right + mainGap;

            // Center Register Manually Button (align with textbox right)
            RegisterManuallyButton.Left = GoogleLinkTextBox.Right - RegisterManuallyButton.Width;

            // Center Instruction Label
            GoogleMapInstructionLabel.Left = centerX - (GoogleMapInstructionLabel.Width / 2);
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
