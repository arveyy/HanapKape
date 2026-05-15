namespace HanapKafe
{
    partial class AddCoffeeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCoffeeForm));
            this.CoffeeNameLabel = new System.Windows.Forms.Label();
            this.CoffeeNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.SizeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AddButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // CoffeeNameLabel
            // 
            this.CoffeeNameLabel.AutoSize = true;
            this.CoffeeNameLabel.Location = new System.Drawing.Point(30, 30);
            this.CoffeeNameLabel.Name = "CoffeeNameLabel";
            this.CoffeeNameLabel.Size = new System.Drawing.Size(94, 16);
            this.CoffeeNameLabel.TabIndex = 20;
            this.CoffeeNameLabel.Text = "Coffee Name *";
            // 
            // CoffeeNameTextBox
            // 
            this.CoffeeNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CoffeeNameTextBox.DefaultText = "";
            this.CoffeeNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CoffeeNameTextBox.Location = new System.Drawing.Point(150, 25);
            this.CoffeeNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CoffeeNameTextBox.Name = "CoffeeNameTextBox";
            this.CoffeeNameTextBox.PlaceholderText = "";
            this.CoffeeNameTextBox.SelectedText = "";
            this.CoffeeNameTextBox.Size = new System.Drawing.Size(250, 30);
            this.CoffeeNameTextBox.TabIndex = 19;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(30, 185);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(46, 16);
            this.PriceLabel.TabIndex = 14;
            this.PriceLabel.Text = "Price *";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTextBox.DefaultText = "";
            this.PriceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PriceTextBox.Location = new System.Drawing.Point(150, 180);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.PlaceholderText = "";
            this.PriceTextBox.SelectedText = "";
            this.PriceTextBox.Size = new System.Drawing.Size(120, 30);
            this.PriceTextBox.TabIndex = 13;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(30, 135);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(33, 16);
            this.SizeLabel.TabIndex = 16;
            this.SizeLabel.Text = "Size";
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SizeTextBox.DefaultText = "";
            this.SizeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SizeTextBox.Location = new System.Drawing.Point(150, 130);
            this.SizeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.PlaceholderText = "";
            this.SizeTextBox.SelectedText = "";
            this.SizeTextBox.Size = new System.Drawing.Size(120, 30);
            this.SizeTextBox.TabIndex = 15;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(30, 80);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(62, 16);
            this.CategoryLabel.TabIndex = 18;
            this.CategoryLabel.Text = "Category";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.BackColor = System.Drawing.Color.Transparent;
            this.CategoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.CategoryComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CategoryComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CategoryComboBox.ItemHeight = 30;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "Hot",
            "Cold",
            "Frappe",
            "Brewed",
            "Others"});
            this.CategoryComboBox.Location = new System.Drawing.Point(150, 75);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(250, 36);
            this.CategoryComboBox.TabIndex = 17;
            // 
            // AddButton
            // 
            this.AddButton.BorderThickness = 1;
            this.AddButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.AddButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddButton.ForeColor = System.Drawing.Color.Black;
            this.AddButton.Location = new System.Drawing.Point(150, 240);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 40);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Save Item";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BorderThickness = 1;
            this.BtnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.BtnCancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCancel.ForeColor = System.Drawing.Color.Black;
            this.BtnCancel.Location = new System.Drawing.Point(280, 240);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(120, 40);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddCoffeeForm
            // 
            this.ClientSize = new System.Drawing.Size(430, 300);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.SizeTextBox);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CoffeeNameTextBox);
            this.Controls.Add(this.CoffeeNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCoffeeForm";
            this.Text = "Add Coffee Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label CoffeeNameLabel;
        private Guna.UI2.WinForms.Guna2TextBox CoffeeNameTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private Guna.UI2.WinForms.Guna2TextBox PriceTextBox;
        private System.Windows.Forms.Label SizeLabel;
        private Guna.UI2.WinForms.Guna2TextBox SizeTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private Guna.UI2.WinForms.Guna2ComboBox CategoryComboBox;
        private Guna.UI2.WinForms.Guna2GradientButton AddButton;
        private Guna.UI2.WinForms.Guna2GradientButton BtnCancel;
    }
}
