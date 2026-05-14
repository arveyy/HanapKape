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
    public partial class PriceCheckerForm : Form
    {
        public PriceCheckerForm()
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
            DarkModeLabel.ForeColor = ThemeSettings.TextColor;

            SearchCoffeeTextBox.FillColor = ThemeSettings.TextBoxBgColor;
            SearchCoffeeTextBox.ForeColor = ThemeSettings.TextColor;
            SearchCoffeeTextBox.BorderColor = ThemeSettings.BorderColor;

            DataGridViewCoffeeDisplay.BackgroundColor = ThemeSettings.BackColor;
            DataGridViewCoffeeDisplay.ThemeStyle.BackColor = ThemeSettings.BackColor;
            DataGridViewCoffeeDisplay.ThemeStyle.RowsStyle.BackColor = ThemeSettings.BackColor;
            DataGridViewCoffeeDisplay.ThemeStyle.RowsStyle.ForeColor = ThemeSettings.TextColor;
            DataGridViewCoffeeDisplay.ThemeStyle.AlternatingRowsStyle.BackColor = isDarkMode() ? Color.FromArgb(40, 40, 40) : Color.White;
        }

        private bool isDarkMode() => ThemeSettings.IsDarkMode;

        private void PriceCheckerForm_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;

            // Center Search Box and Add Button as a group
            int gap = 10;
            int totalWidth = SearchCoffeeTextBox.Width + gap + AddCoffeeButton.Width;
            SearchCoffeeTextBox.Left = centerX - (totalWidth / 2);
            AddCoffeeButton.Left = SearchCoffeeTextBox.Right + gap;

            // Center DataGridView
            DataGridViewCoffeeDisplay.Left = centerX - (DataGridViewCoffeeDisplay.Width / 2);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HanapKapeHome home = new HanapKapeHome();
            this.Hide();
            home.Show();
        }

        private void RegisterFormButton_Click(object sender, EventArgs e)
        {
            GoogleMapLinkRegistration register = new GoogleMapLinkRegistration();
            this.Hide();
            register.Show();
        }
    }
}
