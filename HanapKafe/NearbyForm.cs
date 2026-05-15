using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            InitializeWebView();
            DarkModeToggle.Checked = ThemeSettings.IsDarkMode;
            ApplyTheme();
            CenterControls();
        }

        private void DarkModeToggle_CheckedChanged(object sender, EventArgs e)
        {
            ThemeSettings.IsDarkMode = DarkModeToggle.Checked;
            ApplyTheme();
        }

        private async void ApplyTheme()
        {
            this.BackColor = ThemeSettings.BackColor;
            this.ForeColor = ThemeSettings.TextColor;
            groupBox1.ForeColor = ThemeSettings.TextColor;
            ShopCountLabel.ForeColor = ThemeSettings.TextColor;
            DarkModeLabel.ForeColor = ThemeSettings.TextColor;

            SearchNearbyTextBox.FillColor = ThemeSettings.TextBoxBgColor;
            SearchNearbyTextBox.ForeColor = ThemeSettings.TextColor;
            SearchNearbyTextBox.BorderColor = ThemeSettings.BorderColor;

            if (webViewMap.CoreWebView2 != null)
            {
                string theme = ThemeSettings.IsDarkMode ? "dark" : "light";
                await webViewMap.ExecuteScriptAsync($"setMapTheme('{theme}')");
            }

            FindCoffeeShops(SearchNearbyTextBox.Text.Trim());
        }

        private void NearbyForm_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;
            if (groupBox1 != null) groupBox1.Left = centerX - (groupBox1.Width / 2);
            if (webViewMap != null) webViewMap.Left = centerX - (webViewMap.Width / 2);
            if (ShopCountLabel != null) ShopCountLabel.Left = centerX - (ShopCountLabel.Width / 2);
            if (ShopListFlowPanel != null) ShopListFlowPanel.Left = centerX - (ShopListFlowPanel.Width / 2);
            if (SearchNearbyTextBox != null) SearchNearbyTextBox.Left = centerX - (SearchNearbyTextBox.Width / 2);
        }

        private void SearchNearbyTextBox_TextChanged(object sender, EventArgs e)
        {
            FindCoffeeShops(SearchNearbyTextBox.Text.Trim());
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            FindCoffeeShops(SearchNearbyTextBox.Text.Trim());
        }

        private void OpenNowButton_Click(object sender, EventArgs e)
        {
            // Placeholder: currently no operating hours in new SQL schema
            FindCoffeeShops(SearchNearbyTextBox.Text.Trim());
        }

        private async void InitializeWebView()
        {
            try
            {
                await webViewMap.EnsureCoreWebView2Async(null);
                
                string htmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "map.html");
                if (File.Exists(htmlPath)) webViewMap.Source = new Uri(htmlPath);
                else
                {
                    string devPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\map.html"));
                    if (File.Exists(devPath)) webViewMap.Source = new Uri(devPath);
                }

                webViewMap.NavigationCompleted += (s, e) => {
                    ApplyTheme();
                };
            }
            catch (Exception ex) { DatabaseHelper.LogError(ex.Message); }
        }

        public async void FindCoffeeShops(string searchQuery = "")
        {
            try
            {
                DataTable dt = DatabaseHelper.UnifiedSearch(searchQuery);

                if (webViewMap.CoreWebView2 != null)
                {
                    await webViewMap.ExecuteScriptAsync("clearShops();");
                    foreach (DataRow row in dt.Rows)
                    {
                        int id = Convert.ToInt32(row["ShopID"]);
                        string name = row["ShopName"].ToString().Replace("'", "\\'");
                        string address = row["Address"].ToString().Replace("'", "\\'");
                        string mapLink = row["MapLink"].ToString();
                        
                        // Parse Hours JSON (simple summary)
                        string hours = GetHoursSummary(row["OperatingHoursJSON"].ToString());

                        DataTable bevDt = DatabaseHelper.FetchCoffeeItemsByShop(id);
                        StringBuilder bevList = new StringBuilder("<b>Coffee Items:</b><br>");
                        foreach (DataRow bevRow in bevDt.Rows)
                            bevList.Append($"- {bevRow["CoffeeName"]} (₱{bevRow["Price"]})<br>");

                        try 
                        {
                            var coords = await DatabaseHelper.ExtractCoordinatesAsync(mapLink);
                            if (coords != null)
                            {
                                string popup = $"<b>{name}</b><br>{address}<br>Hours: {hours}<br><br>{bevList.ToString()}";
                                string script = $"addShopMarker({coords.Item1}, {coords.Item2}, '{name}', '{popup}');";
                                await webViewMap.ExecuteScriptAsync(script);
                            }
                        }
                        catch (Exception ex)
                        {
                            DatabaseHelper.LogError($"Unable to fetch coordinates for {name}: " + ex.Message);
                        }
                    }
                }

                ShopCountLabel.Text = dt.Rows.Count > 0 ? $"{dt.Rows.Count} Shops Found" : "No shops found.";
                ShopListFlowPanel.Controls.Clear();
                foreach (DataRow row in dt.Rows) AddShopToList(row);
            }
            catch (Exception ex) { DatabaseHelper.LogError("Search error: " + ex.Message); }
        }

        private string GetHoursSummary(string json)
        {
            // Simple parsing for display
            if (json.Contains("Mon")) return "View in Shop Profile";
            return "Not available";
        }

        private void AddShopToList(DataRow row)
        {
            Guna.UI2.WinForms.Guna2Panel card = new Guna.UI2.WinForms.Guna2Panel();
            card.Size = new Size(350, 100);
            card.BorderRadius = 10;
            card.BorderThickness = 1;
            card.Margin = new Padding(10);
            card.FillColor = ThemeSettings.IsDarkMode ? Color.FromArgb(45, 45, 45) : Color.White;

            Label nameLabel = new Label { Text = row["ShopName"].ToString(), Font = new Font("Segoe UI", 10, FontStyle.Bold), AutoSize = true, Location = new Point(10, 10), ForeColor = ThemeSettings.TextColor };
            Label addrLabel = new Label { Text = row["Address"].ToString(), AutoSize = true, Location = new Point(10, 35), ForeColor = ThemeSettings.TextColor };

            card.Controls.Add(nameLabel);
            card.Controls.Add(addrLabel);
            ShopListFlowPanel.Controls.Add(card);
        }

        private void NearbyFormButton_Click(object sender, EventArgs e) { new NearbyForm().Show(); this.Hide(); }
        private void pictureBox2_Click(object sender, EventArgs e) { new HanapKapeHome().Show(); this.Hide(); }
        private void PriceCheckerFormButton_Click(object sender, EventArgs e) { new PriceCheckerForm().Show(); this.Hide(); }
        private void RegisterFormButton_Click(object sender, EventArgs e) { new GoogleMapLinkRegistration().Show(); this.Hide(); }
    }
}
