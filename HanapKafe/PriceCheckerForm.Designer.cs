namespace HanapKafe
{
    partial class PriceCheckerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceCheckerForm));
            this.SearchCoffeeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddBeverageButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DataGridViewBeverages = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DarkModeToggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.DarkModeLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RegisterFormButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PriceCheckerFormButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.NearbyFormButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ShopSelectComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ShopSelectLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBeverages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchCoffeeTextBox
            // 
            this.SearchCoffeeTextBox.BorderRadius = 15;
            this.SearchCoffeeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchCoffeeTextBox.DefaultText = "";
            this.SearchCoffeeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchCoffeeTextBox.Location = new System.Drawing.Point(50, 130);
            this.SearchCoffeeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchCoffeeTextBox.Name = "SearchCoffeeTextBox";
            this.SearchCoffeeTextBox.PlaceholderText = "Search Coffee Item...";
            this.SearchCoffeeTextBox.SelectedText = "";
            this.SearchCoffeeTextBox.Size = new System.Drawing.Size(350, 40);
            this.SearchCoffeeTextBox.TabIndex = 10;
            this.SearchCoffeeTextBox.TextChanged += new System.EventHandler(this.SearchCoffeeTextBox_TextChanged);
            // 
            // AddBeverageButton
            // 
            this.AddBeverageButton.BorderRadius = 15;
            this.AddBeverageButton.BorderThickness = 1;
            this.AddBeverageButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.AddBeverageButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.AddBeverageButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.AddBeverageButton.ForeColor = System.Drawing.Color.Black;
            this.AddBeverageButton.Location = new System.Drawing.Point(410, 130);
            this.AddBeverageButton.Name = "AddBeverageButton";
            this.AddBeverageButton.Size = new System.Drawing.Size(150, 40);
            this.AddBeverageButton.TabIndex = 9;
            this.AddBeverageButton.Text = "+ Add Item";
            this.AddBeverageButton.Click += new System.EventHandler(this.AddBeverageButton_Click);
            // 
            // DataGridViewBeverages
            // 
            this.DataGridViewBeverages.AllowUserToAddRows = false;
            this.DataGridViewBeverages.AllowUserToDeleteRows = false;
            this.DataGridViewBeverages.AllowUserToResizeColumns = false;
            this.DataGridViewBeverages.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewBeverages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewBeverages.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewBeverages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewBeverages.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewBeverages.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewBeverages.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewBeverages.Location = new System.Drawing.Point(370, 203);
            this.DataGridViewBeverages.Name = "DataGridViewBeverages";
            this.DataGridViewBeverages.RowHeadersVisible = false;
            this.DataGridViewBeverages.RowHeadersWidth = 51;
            this.DataGridViewBeverages.RowTemplate.Height = 35;
            this.DataGridViewBeverages.Size = new System.Drawing.Size(1100, 500);
            this.DataGridViewBeverages.TabIndex = 8;
            this.DataGridViewBeverages.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewBeverages.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewBeverages.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewBeverages.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewBeverages.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewBeverages.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewBeverages.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewBeverages.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewBeverages.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewBeverages.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewBeverages.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewBeverages.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewBeverages.ThemeStyle.HeaderStyle.Height = 40;
            this.DataGridViewBeverages.ThemeStyle.ReadOnly = false;
            this.DataGridViewBeverages.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewBeverages.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewBeverages.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewBeverages.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewBeverages.ThemeStyle.RowsStyle.Height = 35;
            this.DataGridViewBeverages.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewBeverages.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // DarkModeToggle
            // 
            this.DarkModeToggle.Location = new System.Drawing.Point(1450, 35);
            this.DarkModeToggle.Name = "DarkModeToggle";
            this.DarkModeToggle.Size = new System.Drawing.Size(50, 25);
            this.DarkModeToggle.TabIndex = 7;
            this.DarkModeToggle.CheckedChanged += new System.EventHandler(this.DarkModeToggle_CheckedChanged);
            // 
            // DarkModeLabel
            // 
            this.DarkModeLabel.AutoSize = true;
            this.DarkModeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DarkModeLabel.Location = new System.Drawing.Point(1350, 38);
            this.DarkModeLabel.Name = "DarkModeLabel";
            this.DarkModeLabel.Size = new System.Drawing.Size(86, 20);
            this.DarkModeLabel.TabIndex = 6;
            this.DarkModeLabel.Text = "Dark Mode";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // RegisterFormButton
            // 
            this.RegisterFormButton.Image = ((System.Drawing.Image)(resources.GetObject("RegisterFormButton.Image")));
            this.RegisterFormButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.RegisterFormButton.ImageRotate = 0F;
            this.RegisterFormButton.ImageSize = new System.Drawing.Size(64, 40);
            this.RegisterFormButton.Location = new System.Drawing.Point(1527, 15);
            this.RegisterFormButton.Name = "RegisterFormButton";
            this.RegisterFormButton.Size = new System.Drawing.Size(88, 64);
            this.RegisterFormButton.TabIndex = 4;
            this.RegisterFormButton.Click += new System.EventHandler(this.RegisterFormButton_Click);
            // 
            // PriceCheckerFormButton
            // 
            this.PriceCheckerFormButton.Image = ((System.Drawing.Image)(resources.GetObject("PriceCheckerFormButton.Image")));
            this.PriceCheckerFormButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.PriceCheckerFormButton.ImageRotate = 0F;
            this.PriceCheckerFormButton.ImageSize = new System.Drawing.Size(64, 40);
            this.PriceCheckerFormButton.Location = new System.Drawing.Point(1623, 15);
            this.PriceCheckerFormButton.Name = "PriceCheckerFormButton";
            this.PriceCheckerFormButton.Size = new System.Drawing.Size(88, 64);
            this.PriceCheckerFormButton.TabIndex = 3;
            this.PriceCheckerFormButton.Click += new System.EventHandler(this.PriceCheckerFormButton_Click);
            // 
            // NearbyFormButton
            // 
            this.NearbyFormButton.Image = ((System.Drawing.Image)(resources.GetObject("NearbyFormButton.Image")));
            this.NearbyFormButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.NearbyFormButton.ImageRotate = 0F;
            this.NearbyFormButton.ImageSize = new System.Drawing.Size(64, 40);
            this.NearbyFormButton.Location = new System.Drawing.Point(1719, 15);
            this.NearbyFormButton.Name = "NearbyFormButton";
            this.NearbyFormButton.Size = new System.Drawing.Size(88, 64);
            this.NearbyFormButton.TabIndex = 2;
            this.NearbyFormButton.Click += new System.EventHandler(this.NearbyFormButton_Click);
            // 
            // ShopSelectComboBox
            // 
            this.ShopSelectComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ShopSelectComboBox.BorderRadius = 15;
            this.ShopSelectComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ShopSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShopSelectComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.ShopSelectComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ShopSelectComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ShopSelectComboBox.ItemHeight = 30;
            this.ShopSelectComboBox.Location = new System.Drawing.Point(750, 130);
            this.ShopSelectComboBox.Name = "ShopSelectComboBox";
            this.ShopSelectComboBox.Size = new System.Drawing.Size(300, 36);
            this.ShopSelectComboBox.TabIndex = 1;
            this.ShopSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.ShopSelectComboBox_SelectedIndexChanged);
            // 
            // ShopSelectLabel
            // 
            this.ShopSelectLabel.AutoSize = true;
            this.ShopSelectLabel.Location = new System.Drawing.Point(650, 138);
            this.ShopSelectLabel.Name = "ShopSelectLabel";
            this.ShopSelectLabel.Size = new System.Drawing.Size(95, 16);
            this.ShopSelectLabel.TabIndex = 0;
            this.ShopSelectLabel.Text = "Manage Shop:";
            // 
            // PriceCheckerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 798);
            this.Controls.Add(this.ShopSelectLabel);
            this.Controls.Add(this.ShopSelectComboBox);
            this.Controls.Add(this.NearbyFormButton);
            this.Controls.Add(this.PriceCheckerFormButton);
            this.Controls.Add(this.RegisterFormButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DarkModeLabel);
            this.Controls.Add(this.DarkModeToggle);
            this.Controls.Add(this.DataGridViewBeverages);
            this.Controls.Add(this.AddBeverageButton);
            this.Controls.Add(this.SearchCoffeeTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PriceCheckerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price Checker - Coffee Items";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.PriceCheckerForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBeverages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna.UI2.WinForms.Guna2TextBox SearchCoffeeTextBox;
        private Guna.UI2.WinForms.Guna2GradientButton AddBeverageButton;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewBeverages;
        private Guna.UI2.WinForms.Guna2ToggleSwitch DarkModeToggle;
        private System.Windows.Forms.Label DarkModeLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2ImageButton RegisterFormButton;
        private Guna.UI2.WinForms.Guna2ImageButton PriceCheckerFormButton;
        private Guna.UI2.WinForms.Guna2ImageButton NearbyFormButton;
        private Guna.UI2.WinForms.Guna2ComboBox ShopSelectComboBox;
        private System.Windows.Forms.Label ShopSelectLabel;
    }
}
