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
            label5.ForeColor = ThemeSettings.TextColor;
            ShopLabel.ForeColor = ThemeSettings.TextColor;
            AdressLabel.ForeColor = ThemeSettings.TextColor;
            OperatingLabel.ForeColor = ThemeSettings.TextColor;
            NotesLabel.ForeColor = ThemeSettings.TextColor;
            DarkModeLabel.ForeColor = ThemeSettings.TextColor;

            ShopNameTextBox.FillColor = ThemeSettings.TextBoxBgColor;
            ShopNameTextBox.ForeColor = ThemeSettings.TextColor;
            ShopNameTextBox.BorderColor = ThemeSettings.BorderColor;

            AddressLocationTextBox.FillColor = ThemeSettings.TextBoxBgColor;
            AddressLocationTextBox.ForeColor = ThemeSettings.TextColor;
            AddressLocationTextBox.BorderColor = ThemeSettings.BorderColor;

            OperatingHoursOptionalTextBox.FillColor = ThemeSettings.TextBoxBgColor;
            OperatingHoursOptionalTextBox.ForeColor = ThemeSettings.TextColor;
            OperatingHoursOptionalTextBox.BorderColor = ThemeSettings.BorderColor;

            NotesOptionalTextBox.FillColor = ThemeSettings.TextBoxBgColor;
            NotesOptionalTextBox.ForeColor = ThemeSettings.TextColor;
            NotesOptionalTextBox.BorderColor = ThemeSettings.BorderColor;
        }

        private void ManualRegistrationForm_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;

            // Center Header (pictureBox1 and label5 as a group)
            int headerGap = 10;
            int totalHeaderWidth = pictureBox1.Width + headerGap + label5.Width;
            pictureBox1.Left = centerX - (totalHeaderWidth / 2);
            label5.Left = pictureBox1.Right + headerGap;

            // Center Shop Name Group
            ShopLabel.Left = centerX - (ShopNameTextBox.Width / 2);
            ShopNameTextBox.Left = centerX - (ShopNameTextBox.Width / 2);

            // Center Address Group
            AdressLabel.Left = centerX - (AddressLocationTextBox.Width / 2);
            AddressLocationTextBox.Left = centerX - (AddressLocationTextBox.Width / 2);
            UseMyLocationButton.Left = AddressLocationTextBox.Left;

            // Center Operating Hours Group
            OperatingLabel.Left = centerX - (OperatingHoursOptionalTextBox.Width / 2);
            OperatingHoursOptionalTextBox.Left = centerX - (OperatingHoursOptionalTextBox.Width / 2);

            // Center Notes Group
            NotesLabel.Left = centerX - (NotesOptionalTextBox.Width / 2);
            NotesOptionalTextBox.Left = centerX - (NotesOptionalTextBox.Width / 2);

            // Center Submit Button
            SubmitSuggestionButton.Left = centerX - (SubmitSuggestionButton.Width / 2);

            // Center Google Map Link Button (align right with submit button)
            GoogleMapLinkButton.Left = SubmitSuggestionButton.Right - GoogleMapLinkButton.Width;
        }

        private void SubmitSuggestionButton_Click(object sender, EventArgs e)
        {
            string name = ShopNameTextBox.Text.Trim();
            string address = AddressLocationTextBox.Text.Trim();
            string hours = OperatingHoursOptionalTextBox.Text.Trim();
            if (string.IsNullOrEmpty(hours)) hours = "00:00-23:59";
            
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in both Shop Name and Address.");
                return;
            }

            var coords = DataService.Geocode(address);
            CoffeeShop newShop = new CoffeeShop(name, coords.lat, coords.lng, true, address, hours);
            DataService.AddShop(newShop);
            MessageBox.Show($"Success! '{name}' has been registered.");
            
            ShopNameTextBox.Clear();
            AddressLocationTextBox.Clear();
            OperatingHoursOptionalTextBox.Clear();
            NotesOptionalTextBox.Clear();
        }

        private void GoogleMapLinkButton_Click(object sender, EventArgs e)
        {
            GoogleMapLinkRegistration register = new GoogleMapLinkRegistration();
            this.Hide();
            register.Show();
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
