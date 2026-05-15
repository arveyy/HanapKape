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
    public partial class AddCoffeeForm : Form
    {
        private int _shopId;

        public AddCoffeeForm(int shopId)
        {
            InitializeComponent();
            _shopId = shopId;
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            this.BackColor = ThemeSettings.BackColor;
            this.ForeColor = ThemeSettings.TextColor;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label) ctrl.ForeColor = ThemeSettings.TextColor;
                if (ctrl is Guna.UI2.WinForms.Guna2TextBox tb)
                {
                    tb.FillColor = ThemeSettings.TextBoxBgColor;
                    tb.ForeColor = ThemeSettings.TextColor;
                    tb.BorderColor = ThemeSettings.BorderColor;
                }
                if (ctrl is Guna.UI2.WinForms.Guna2ComboBox cb)
                {
                    cb.FillColor = ThemeSettings.TextBoxBgColor;
                    cb.ForeColor = ThemeSettings.TextColor;
                    cb.BorderColor = ThemeSettings.BorderColor;
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    string name = CoffeeNameTextBox.Text.Trim();
                    decimal price = decimal.Parse(PriceTextBox.Text.Trim());
                    string size = SizeTextBox.Text.Trim();
                    string category = CategoryComboBox.SelectedItem?.ToString() ?? "Others";

                    DatabaseHelper.InsertCoffeeItem(_shopId, name, price, size, category);

                    MessageBox.Show("Coffee item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DatabaseHelper.LogError(ex.ToString());
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(CoffeeNameTextBox.Text))
            {
                MessageBox.Show("Coffee name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(PriceTextBox.Text.Trim(), out _))
            {
                MessageBox.Show("Price must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
