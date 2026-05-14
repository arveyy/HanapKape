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
        private double lastUserLat = 14.5995;
        private double lastUserLng = 120.9842;
        private bool isOpenNowFilter = false;

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

            // Update Guna Buttons
            OpenNowButton.FillColor = ThemeSettings.ButtonColor;
            OpenNowButton.ForeColor = ThemeSettings.TextColor;
            FavoritesFilterButton.FillColor = ThemeSettings.ButtonColor;
            FavoritesFilterButton.ForeColor = ThemeSettings.TextColor;

            // Update ComboBoxes
            BrandsComboBox.FillColor = ThemeSettings.PanelColor;
            BrandsComboBox.ForeColor = ThemeSettings.TextColor;
            ExploreComboBox.FillColor = ThemeSettings.PanelColor;
            ExploreComboBox.ForeColor = ThemeSettings.TextColor;

            // Update Map
            if (webViewMap.CoreWebView2 != null)
            {
                string theme = ThemeSettings.IsDarkMode ? "dark" : "light";
                await webViewMap.ExecuteScriptAsync($"setMapTheme('{theme}')");
            }

            // Refresh Shop List to apply theme to cards
            FindCoffeeShops(lastUserLat, lastUserLng);
        }

        private void NearbyForm_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;

            // Center Categorization (groupBox1)
            groupBox1.Left = centerX - (groupBox1.Width / 2);

            // Center Map
            webViewMap.Left = centerX - (webViewMap.Width / 2);

            // Center Shop Count Label
            ShopCountLabel.Left = centerX - (ShopCountLabel.Width / 2);

            // Center Shop List
            ShopListFlowPanel.Left = centerX - (ShopListFlowPanel.Width / 2);
        }

        private void OpenNowButton_Click(object sender, EventArgs e)
        {
            isOpenNowFilter = !isOpenNowFilter;
            OpenNowButton.Checked = isOpenNowFilter;
            FindCoffeeShops(lastUserLat, lastUserLng);
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            FindCoffeeShops(lastUserLat, lastUserLng);
        }

        private async void InitializeWebView()
        {
            try
            {
                await webViewMap.EnsureCoreWebView2Async(null);
                webViewMap.CoreWebView2.WebMessageReceived += CoreWebView2_WebMessageReceived;

                // Re-apply theme now that CoreWebView2 is ready
                ApplyTheme();

                string htmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "map.html");
                if (File.Exists(htmlPath))
                {
                    webViewMap.Source = new Uri(htmlPath);
                }
                else
                {
                    string devPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\map.html"));
                    if (File.Exists(devPath))
                    {
                        webViewMap.Source = new Uri(devPath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing WebView2: " + ex.Message);
            }
        }

        private void CoreWebView2_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            try 
            {
                string json = e.WebMessageAsJson;
                if (json.Contains("MAP_MOVE") || json.Contains("LOCATION_FOUND"))
                {
                    var coords = ParseCoords(json);
                    if (coords != null)
                    {
                        lastUserLat = coords.Item1;
                        lastUserLng = coords.Item2;
                        FindCoffeeShops(lastUserLat, lastUserLng);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error parsing message: " + ex.Message);
            }
        }

        private Tuple<double, double> ParseCoords(string json)
        {
            try
            {
                string clean = json.Replace("{", "").Replace("}", "").Replace("\"", "");
                string[] parts = clean.Split(',');
                double lat = 0, lng = 0;
                foreach (var part in parts)
                {
                    var kv = part.Split(':');
                    string key = kv[0].Trim().ToLower();
                    if (key == "lat") lat = double.Parse(kv[1].Trim());
                    if (key == "lng") lng = double.Parse(kv[1].Trim());
                }
                return Tuple.Create(lat, lng);
            }
            catch { return null; }
        }

        public async void FindCoffeeShops(double lat, double lng)
        {
            var shops = DataService.GetShops();
            TimeSpan now = DateTime.Now.TimeOfDay;

            if (isOpenNowFilter)
            {
                shops = shops.Where(s => IsShopOpen(s.OperatingHours, now)).ToList();
            }

            string selectedBrand = BrandsComboBox.SelectedItem?.ToString() ?? "All Brands";
            if (selectedBrand != "All Brands")
            {
                if (selectedBrand == "Local")
                {
                    string[] bigBrands = { "starbucks", "dunkin", "mccafe", "bo's coffee" };
                    shops = shops.Where(s => !bigBrands.Any(b => s.Name.ToLower().Contains(b))).ToList();
                }
                else
                {
                    shops = shops.Where(s => s.Name.ToLower().Contains(selectedBrand.ToLower())).ToList();
                }
            }

            string selectedDistance = ExploreComboBox.SelectedItem?.ToString() ?? "All Distance";
            double maxDist = 1000;
            if (selectedDistance != "All Distance")
            {
                if (selectedDistance.Contains("1km")) maxDist = 1;
                else if (selectedDistance.Contains("2km")) maxDist = 2;
                else if (selectedDistance.Contains("3km")) maxDist = 3;
                else if (selectedDistance.Contains("5km")) maxDist = 5;
                else if (selectedDistance.Contains("10km")) maxDist = 10;
                shops = shops.Where(s => CalculateDistance(lat, lng, s.Latitude, s.Longitude) <= maxDist).ToList();
            }

            if (FavoritesFilterButton.Checked)
            {
                shops = shops.Where(s => s.IsFavorite).ToList();
            }

            // Guard check for WebView2 initialization before map scripts
            if (webViewMap.CoreWebView2 != null)
            {
                await webViewMap.ExecuteScriptAsync("clearShops();");
                foreach (var shop in shops)
                {
                    string name = shop.Name.Replace("'", "\\'");
                    string address = shop.Address.Replace("'", "\\'");
                    string script = $"addShopMarker({shop.Latitude}, {shop.Longitude}, '{name}', '{address}');";
                    await webViewMap.ExecuteScriptAsync(script);
                }
            }

            ShopCountLabel.Text = $"{shops.Count} Shops Nearby";
            CenterControls();
            ShopListFlowPanel.Controls.Clear();

            foreach (var shop in shops)
            {
                double dist = CalculateDistance(lat, lng, shop.Latitude, shop.Longitude);
                bool isOpen = IsShopOpen(shop.OperatingHours, now);
                AddShopToList(shop, dist, isOpen);
            }
        }

        private void AddShopToList(CoffeeShop shop, double distance, bool isOpen)
        {
            Color cardBg = ThemeSettings.IsDarkMode ? Color.FromArgb(45, 45, 45) : Color.White;
            Color textColor = ThemeSettings.IsDarkMode ? Color.White : Color.Black;
            Color subTextColor = ThemeSettings.IsDarkMode ? Color.LightGray : Color.FromArgb(64, 64, 64);

            Guna.UI2.WinForms.Guna2Panel card = new Guna.UI2.WinForms.Guna2Panel();
            card.Size = new Size(350, 150);
            card.BorderRadius = 10;
            card.BorderThickness = 1;
            card.BorderColor = ThemeSettings.IsDarkMode ? Color.FromArgb(80, 80, 80) : Color.Gray;
            card.Margin = new Padding(10);
            card.FillColor = cardBg;

            Label nameLabel = new Label();
            nameLabel.Text = shop.Name + (isOpen ? " (OPEN)" : " (CLOSED)");
            nameLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            nameLabel.ForeColor = isOpen ? Color.LimeGreen : (ThemeSettings.IsDarkMode ? Color.Tomato : Color.Red);
            nameLabel.Location = new Point(10, 10);
            nameLabel.AutoSize = true;

            Label distLabel = new Label();
            distLabel.Text = $"Distance: {distance:F2} km";
            distLabel.ForeColor = textColor;
            distLabel.Location = new Point(10, 35);
            distLabel.AutoSize = true;

            Label hoursLabel = new Label();
            hoursLabel.Text = $"Hours: {shop.OperatingHours}";
            hoursLabel.ForeColor = subTextColor;
            hoursLabel.Location = new Point(10, 55);
            hoursLabel.AutoSize = true;

            Guna.UI2.WinForms.Guna2Button infoBtn = new Guna.UI2.WinForms.Guna2Button();
            infoBtn.Text = "Info";
            infoBtn.Size = new Size(60, 30);
            infoBtn.Location = new Point(10, 85);
            infoBtn.FillColor = ThemeSettings.IsDarkMode ? Color.FromArgb(70, 70, 70) : Color.Silver;
            infoBtn.ForeColor = textColor;
            infoBtn.Click += (s, e) => ShowShopInfo(shop);

            Guna.UI2.WinForms.Guna2Button favBtn = new Guna.UI2.WinForms.Guna2Button();
            favBtn.Text = shop.IsFavorite ? "❤" : "🤍";
            favBtn.Size = new Size(40, 30);
            favBtn.Location = new Point(80, 85);
            favBtn.FillColor = ThemeSettings.IsDarkMode ? Color.FromArgb(70, 70, 70) : Color.Silver;
            favBtn.ForeColor = textColor;
            favBtn.Click += (s, e) => {
                DataService.ToggleFavorite(shop.Name);
                FindCoffeeShops(lastUserLat, lastUserLng);
            };

            card.Controls.Add(nameLabel);
            card.Controls.Add(distLabel);
            card.Controls.Add(hoursLabel);
            card.Controls.Add(infoBtn);
            card.Controls.Add(favBtn);
            ShopListFlowPanel.Controls.Add(card);
        }

        private void ShowShopInfo(CoffeeShop shop)
        {
            Form infoForm = new Form();
            infoForm.Size = new Size(400, 500);
            infoForm.Text = shop.Name + " Details";
            infoForm.StartPosition = FormStartPosition.CenterParent;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Shop Name: {shop.Name}");
            sb.AppendLine($"Address: {shop.Address}");
            sb.AppendLine("");
            sb.AppendLine("Operating Hours:");
            sb.AppendLine($"Monday: {shop.MondayHours}");
            sb.AppendLine($"Tuesday: {shop.TuesdayHours}");
            sb.AppendLine($"Wednesday: {shop.WednesdayHours}");
            sb.AppendLine($"Thursday: {shop.ThursdayHours}");
            sb.AppendLine($"Friday: {shop.FridayHours}");
            sb.AppendLine($"Saturday: {shop.SaturdayHours}");
            sb.AppendLine($"Sunday: {shop.SundayHours}");

            Label details = new Label();
            details.Text = sb.ToString();
            details.Dock = DockStyle.Top;
            details.Height = 350;
            details.Padding = new Padding(10);

            Button navBtn = new Button();
            navBtn.Text = "Navigate to Shop";
            navBtn.Dock = DockStyle.Bottom;
            navBtn.Height = 50;
            navBtn.Click += (s, e) => {
                string url = $"https://www.google.com/maps/dir/?api=1&destination={shop.Latitude},{shop.Longitude}";
                try { System.Diagnostics.Process.Start(url); } catch { }
            };

            infoForm.Controls.Add(details);
            infoForm.Controls.Add(navBtn);
            infoForm.ShowDialog();
        }

        private bool IsShopOpen(string hours, TimeSpan now)
        {
            try
            {
                var parts = hours.Split('-');
                if (parts.Length != 2) return true;
                TimeSpan open = TimeSpan.Parse(parts[0]);
                TimeSpan close = TimeSpan.Parse(parts[1]);
                return now >= open && now <= close;
            }
            catch { return true; }
        }

        private double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            var R = 6371;
            var dLat = ToRadians(lat2 - lat1);
            var dLon = ToRadians(lon2 - lon1);
            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c;
        }

        private double ToRadians(double deg) => deg * (Math.PI / 180);

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

        private void UseApproximateLocationFormButton_Click(object sender, EventArgs e)
        {
            UseApproximateLocationForm approximateLoc = new UseApproximateLocationForm();
            this.Hide();
            approximateLoc.Show();
        }
    }
}
