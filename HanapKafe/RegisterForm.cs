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

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Guna.UI2.WinForms.Guna2TextBox tb)
                {
                    tb.FillColor = ThemeSettings.TextBoxBgColor;
                    tb.ForeColor = ThemeSettings.TextColor;
                    tb.BorderColor = ThemeSettings.BorderColor;
                }
            }
        }

        private void RegisterManuallyButton_Click(object sender, EventArgs e)
        {
            new ManualRegistrationForm().Show();
            this.Hide();
        }

        private void HomeLabelLink_Click(object sender, EventArgs e)
        {
            new HanapKapeHome().Show();
            this.Hide();
        }

        private void RegisterFormButton_Click(object sender, EventArgs e) { } // Already here

        private void PriceCheckerFormButton_Click(object sender, EventArgs e)
        {
            new PriceCheckerForm().Show();
            this.Hide();
        }

        private void NearbyFormButton_Click(object sender, EventArgs e)
        {
            new NearbyForm().Show();
            this.Hide();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            string googleMapsLink = GoogleLinkTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(googleMapsLink))
            {
                ParseGoogleMapsLink(googleMapsLink);
            }
        }

        private void ParseGoogleMapsLink(string link)
        {
            try
            {
                string shopName = "Coffee Shop";
                if (link.Contains("/place/"))
                {
                    int placeIndex = link.IndexOf("/place/");
                    string afterPlace = link.Substring(placeIndex + 7);
                    string[] placeParts = afterPlace.Split(new[] { '/', '?' }, StringSplitOptions.RemoveEmptyEntries);
                    if (placeParts.Length > 0)
                        shopName = Uri.UnescapeDataString(placeParts[0]).Replace('+', ' ');
                }

                ShopNameTextBox.Text = shopName;
                AddressTextBox.Text = "Manila"; 
                CoordinatesTextBox.Text = link;

                ExtractedLocationPanel.Visible = true;
                GoogleMapInstructionLabel.Visible = false;
                RegisterManuallyButton.Visible = false;
            }
            catch (Exception ex) { MessageBox.Show("Error parsing link: " + ex.Message); }
        }

        private void SubmitSuggestionButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    string name = ShopNameTextBox.Text.Trim();
                    string address = AddressTextBox.Text.Trim();
                    string mapLink = GoogleLinkTextBox.Text.Trim();
                    
                    // Simple default hours for this form
                    string hoursJson = "{\"Mon\":\"08:00-22:00\", \"Tue\":\"08:00-22:00\", \"Wed\":\"08:00-22:00\", \"Thu\":\"08:00-22:00\", \"Fri\":\"08:00-22:00\", \"Sat\":\"08:00-22:00\", \"Sun\":\"08:00-22:00\"}";

                    // OwnerID = 1
                    DatabaseHelper.InsertShop(1, name, address, mapLink, hoursJson);

                    MessageBox.Show("Shop registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    DatabaseHelper.LogError(ex.ToString());
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(ShopNameTextBox.Text))
            {
                MessageBox.Show("Shop name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(AddressTextBox.Text))
            {
                MessageBox.Show("Address cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string mapLink = GoogleLinkTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(mapLink))
            {
                MessageBox.Show("Map link is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!mapLink.StartsWith("https://maps.app.goo.gl/") && !mapLink.StartsWith("https://www.google.com/maps/"))
            {
                MessageBox.Show("Map link must be a valid Google Maps link.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void NewLinkButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            GoogleLinkTextBox.Clear();
            ShopNameTextBox.Clear();
            AddressTextBox.Clear();
            GoogleLinkTextBox.Focus();
        }
    }
}
