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
    public partial class PriceCheckerForm : Form
    {
        private Dictionary<string, int> ownerShops = new Dictionary<string, int>();

        public PriceCheckerForm()
        {
            InitializeComponent();
            DarkModeToggle.Checked = ThemeSettings.IsDarkMode;
            ApplyTheme();
            InitializeDataGridView();
            LoadOwnerShops();
        }

        private void LoadOwnerShops()
        {
            try
            {
                // Assuming OwnerID = 1 for the current session
                DataTable dt = DatabaseHelper.FetchShopsByOwner(1);
                ShopSelectComboBox.Items.Clear();
                ownerShops.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    string name = row["ShopName"].ToString();
                    int id = Convert.ToInt32(row["ShopID"]);
                    ShopSelectComboBox.Items.Add(name);
                    ownerShops[name] = id;
                }

                if (ShopSelectComboBox.Items.Count > 0)
                    ShopSelectComboBox.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error loading shops: " + ex.Message); }
        }

        private void LoadCoffeeItems(string searchQuery = "")
        {
            if (ShopSelectComboBox.SelectedItem == null) return;

            try
            {
                int shopId = ownerShops[ShopSelectComboBox.SelectedItem.ToString()];
                DataTable dt;
                
                if (string.IsNullOrEmpty(searchQuery))
                    dt = DatabaseHelper.FetchCoffeeItemsByShop(shopId);
                else
                    dt = DatabaseHelper.SearchCoffeeItems(shopId, searchQuery);

                DataGridViewBeverages.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    DataGridViewBeverages.Rows.Add(
                        row["CoffeeName"],
                        row["Category"],
                        row["Size"],
                        string.Format("₱{0:N2}", row["Price"])
                    );
                }

                if (dt.Rows.Count == 0 && !string.IsNullOrEmpty(searchQuery))
                {
                    // requirement says show "No results found"
                    // but for real-time search, an empty grid is usually preferred.
                    // I'll add a label or tooltip if needed, but for now simple grid.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message);
                DatabaseHelper.LogError(ex.ToString());
            }
        }

        private void ShopSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCoffeeItems(SearchCoffeeTextBox.Text.Trim());
        }

        private void SearchCoffeeTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadCoffeeItems(SearchCoffeeTextBox.Text.Trim());
        }

        private void AddBeverageButton_Click(object sender, EventArgs e)
        {
            if (ShopSelectComboBox.SelectedItem == null)
            {
                MessageBox.Show("Select a shop before adding items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int shopId = ownerShops[ShopSelectComboBox.SelectedItem.ToString()];
            AddCoffeeForm addForm = new AddCoffeeForm(shopId);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadCoffeeItems();
            }
        }

        private void InitializeDataGridView()
        {
            DataGridViewBeverages.Columns.Clear();
            DataGridViewBeverages.Columns.Add("CoffeeName", "Coffee Name");
            DataGridViewBeverages.Columns.Add("Category", "Category");
            DataGridViewBeverages.Columns.Add("Size", "Size");
            DataGridViewBeverages.Columns.Add("Price", "Price");
            
            DataGridViewBeverages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewBeverages.AllowUserToAddRows = false;
            DataGridViewBeverages.ReadOnly = true;
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
            ShopSelectLabel.ForeColor = ThemeSettings.TextColor;

            SearchCoffeeTextBox.FillColor = ThemeSettings.TextBoxBgColor;
            SearchCoffeeTextBox.ForeColor = ThemeSettings.TextColor;
            SearchCoffeeTextBox.BorderColor = ThemeSettings.BorderColor;

            ShopSelectComboBox.FillColor = ThemeSettings.TextBoxBgColor;
            ShopSelectComboBox.ForeColor = ThemeSettings.TextColor;
            ShopSelectComboBox.BorderColor = ThemeSettings.BorderColor;

            DataGridViewBeverages.BackgroundColor = ThemeSettings.BackColor;
            DataGridViewBeverages.ThemeStyle.BackColor = ThemeSettings.BackColor;
            DataGridViewBeverages.ThemeStyle.RowsStyle.BackColor = ThemeSettings.BackColor;
            DataGridViewBeverages.ThemeStyle.RowsStyle.ForeColor = ThemeSettings.TextColor;
        }

        private void PriceCheckerForm_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;
            SearchCoffeeTextBox.Left = centerX - 500;
            AddBeverageButton.Left = SearchCoffeeTextBox.Right + 10;
            ShopSelectLabel.Left = AddBeverageButton.Right + 50;
            ShopSelectComboBox.Left = ShopSelectLabel.Right + 5;
        }

        private void PriceCheckerFormButton_Click(object sender, EventArgs e) { new PriceCheckerForm().Show(); this.Hide(); }
        private void NearbyFormButton_Click(object sender, EventArgs e) { new NearbyForm().Show(); this.Hide(); }
        private void pictureBox2_Click(object sender, EventArgs e) { new HanapKapeHome().Show(); this.Hide(); }
        private void RegisterFormButton_Click(object sender, EventArgs e) { new GoogleMapLinkRegistration().Show(); this.Hide(); }
    }
}
