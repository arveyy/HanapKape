namespace HanapKafe
{
    partial class ManualRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualRegistrationForm));
            this.ShopLabel = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.MapLinkLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HomeLabelLink = new System.Windows.Forms.PictureBox();
            this.ShopNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddressLocationTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.MapLinkTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.StartHoursPicker = new System.Windows.Forms.DateTimePicker();
            this.EndHoursPicker = new System.Windows.Forms.DateTimePicker();
            this.SameHoursToggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.SubmitSuggestionButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.GoogleMapLinkButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RegisterFormButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PriceCheckerFormButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.NearbyFormButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.DarkModeToggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.DarkModeLabel = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.EndLabel = new System.Windows.Forms.Label();
            this.SameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HomeLabelLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShopLabel
            // 
            this.ShopLabel.AutoSize = true;
            this.ShopLabel.Location = new System.Drawing.Point(782, 140);
            this.ShopLabel.Name = "ShopLabel";
            this.ShopLabel.Size = new System.Drawing.Size(87, 16);
            this.ShopLabel.TabIndex = 21;
            this.ShopLabel.Text = "Shop Name *";
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(782, 220);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(127, 16);
            this.AdressLabel.TabIndex = 20;
            this.AdressLabel.Text = "Address / Location *";
            // 
            // MapLinkLabel
            // 
            this.MapLinkLabel.AutoSize = true;
            this.MapLinkLabel.Location = new System.Drawing.Point(782, 300);
            this.MapLinkLabel.Name = "MapLinkLabel";
            this.MapLinkLabel.Size = new System.Drawing.Size(69, 16);
            this.MapLinkLabel.TabIndex = 15;
            this.MapLinkLabel.Text = "Map Link *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(853, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Manual Shop Registration";
            // 
            // HomeLabelLink
            // 
            this.HomeLabelLink.Image = ((System.Drawing.Image)(resources.GetObject("HomeLabelLink.Image")));
            this.HomeLabelLink.Location = new System.Drawing.Point(17, 15);
            this.HomeLabelLink.Name = "HomeLabelLink";
            this.HomeLabelLink.Size = new System.Drawing.Size(165, 100);
            this.HomeLabelLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeLabelLink.TabIndex = 18;
            this.HomeLabelLink.TabStop = false;
            this.HomeLabelLink.Click += new System.EventHandler(this.HomeLabelLink_Click);
            // 
            // ShopNameTextBox
            // 
            this.ShopNameTextBox.BorderRadius = 15;
            this.ShopNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ShopNameTextBox.DefaultText = "";
            this.ShopNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ShopNameTextBox.Location = new System.Drawing.Point(781, 160);
            this.ShopNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShopNameTextBox.Name = "ShopNameTextBox";
            this.ShopNameTextBox.PlaceholderText = "";
            this.ShopNameTextBox.SelectedText = "";
            this.ShopNameTextBox.Size = new System.Drawing.Size(400, 45);
            this.ShopNameTextBox.TabIndex = 17;
            // 
            // AddressLocationTextBox
            // 
            this.AddressLocationTextBox.BorderRadius = 15;
            this.AddressLocationTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressLocationTextBox.DefaultText = "";
            this.AddressLocationTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddressLocationTextBox.Location = new System.Drawing.Point(781, 240);
            this.AddressLocationTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressLocationTextBox.Name = "AddressLocationTextBox";
            this.AddressLocationTextBox.PlaceholderText = "";
            this.AddressLocationTextBox.SelectedText = "";
            this.AddressLocationTextBox.Size = new System.Drawing.Size(400, 45);
            this.AddressLocationTextBox.TabIndex = 16;
            // 
            // MapLinkTextBox
            // 
            this.MapLinkTextBox.BorderRadius = 15;
            this.MapLinkTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MapLinkTextBox.DefaultText = "";
            this.MapLinkTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MapLinkTextBox.Location = new System.Drawing.Point(781, 320);
            this.MapLinkTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MapLinkTextBox.Name = "MapLinkTextBox";
            this.MapLinkTextBox.PlaceholderText = "Paste Google Maps / OSM link";
            this.MapLinkTextBox.SelectedText = "";
            this.MapLinkTextBox.Size = new System.Drawing.Size(400, 45);
            this.MapLinkTextBox.TabIndex = 14;
            // 
            // StartHoursPicker
            // 
            this.StartHoursPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartHoursPicker.Location = new System.Drawing.Point(781, 400);
            this.StartHoursPicker.Name = "StartHoursPicker";
            this.StartHoursPicker.ShowUpDown = true;
            this.StartHoursPicker.Size = new System.Drawing.Size(120, 22);
            this.StartHoursPicker.TabIndex = 4;
            // 
            // EndHoursPicker
            // 
            this.EndHoursPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndHoursPicker.Location = new System.Drawing.Point(920, 400);
            this.EndHoursPicker.Name = "EndHoursPicker";
            this.EndHoursPicker.ShowUpDown = true;
            this.EndHoursPicker.Size = new System.Drawing.Size(120, 22);
            this.EndHoursPicker.TabIndex = 2;
            // 
            // SameHoursToggle
            // 
            this.SameHoursToggle.Checked = true;
            this.SameHoursToggle.Location = new System.Drawing.Point(1060, 400);
            this.SameHoursToggle.Name = "SameHoursToggle";
            this.SameHoursToggle.Size = new System.Drawing.Size(40, 20);
            this.SameHoursToggle.TabIndex = 1;
            // 
            // SubmitSuggestionButton
            // 
            this.SubmitSuggestionButton.BorderRadius = 15;
            this.SubmitSuggestionButton.BorderThickness = 1;
            this.SubmitSuggestionButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.SubmitSuggestionButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.SubmitSuggestionButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SubmitSuggestionButton.ForeColor = System.Drawing.Color.Black;
            this.SubmitSuggestionButton.Location = new System.Drawing.Point(781, 450);
            this.SubmitSuggestionButton.Name = "SubmitSuggestionButton";
            this.SubmitSuggestionButton.Size = new System.Drawing.Size(400, 60);
            this.SubmitSuggestionButton.TabIndex = 13;
            this.SubmitSuggestionButton.Text = "Submit Suggestion";
            this.SubmitSuggestionButton.Click += new System.EventHandler(this.SubmitSuggestionButton_Click);
            // 
            // GoogleMapLinkButton
            // 
            this.GoogleMapLinkButton.BorderRadius = 15;
            this.GoogleMapLinkButton.BorderThickness = 1;
            this.GoogleMapLinkButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.GoogleMapLinkButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.GoogleMapLinkButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GoogleMapLinkButton.ForeColor = System.Drawing.Color.Black;
            this.GoogleMapLinkButton.Location = new System.Drawing.Point(1060, 520);
            this.GoogleMapLinkButton.Name = "GoogleMapLinkButton";
            this.GoogleMapLinkButton.Size = new System.Drawing.Size(120, 35);
            this.GoogleMapLinkButton.TabIndex = 12;
            this.GoogleMapLinkButton.Text = "Link Registration";
            this.GoogleMapLinkButton.Click += new System.EventHandler(this.GoogleMapLinkButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(785, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterFormButton
            // 
            this.RegisterFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterFormButton.Image = ((System.Drawing.Image)(resources.GetObject("RegisterFormButton.Image")));
            this.RegisterFormButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.RegisterFormButton.ImageRotate = 0F;
            this.RegisterFormButton.ImageSize = new System.Drawing.Size(64, 40);
            this.RegisterFormButton.Location = new System.Drawing.Point(1408, 15);
            this.RegisterFormButton.Name = "RegisterFormButton";
            this.RegisterFormButton.Size = new System.Drawing.Size(88, 64);
            this.RegisterFormButton.TabIndex = 10;
            this.RegisterFormButton.Click += new System.EventHandler(this.RegisterFormButton_Click);
            // 
            // PriceCheckerFormButton
            // 
            this.PriceCheckerFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceCheckerFormButton.Image = ((System.Drawing.Image)(resources.GetObject("PriceCheckerFormButton.Image")));
            this.PriceCheckerFormButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.PriceCheckerFormButton.ImageRotate = 0F;
            this.PriceCheckerFormButton.ImageSize = new System.Drawing.Size(64, 40);
            this.PriceCheckerFormButton.Location = new System.Drawing.Point(1494, 15);
            this.PriceCheckerFormButton.Name = "PriceCheckerFormButton";
            this.PriceCheckerFormButton.Size = new System.Drawing.Size(88, 64);
            this.PriceCheckerFormButton.TabIndex = 9;
            this.PriceCheckerFormButton.Click += new System.EventHandler(this.PriceCheckerFormButton_Click);
            // 
            // NearbyFormButton
            // 
            this.NearbyFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NearbyFormButton.Image = ((System.Drawing.Image)(resources.GetObject("NearbyFormButton.Image")));
            this.NearbyFormButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.NearbyFormButton.ImageRotate = 0F;
            this.NearbyFormButton.ImageSize = new System.Drawing.Size(64, 40);
            this.NearbyFormButton.Location = new System.Drawing.Point(1580, 15);
            this.NearbyFormButton.Name = "NearbyFormButton";
            this.NearbyFormButton.Size = new System.Drawing.Size(88, 64);
            this.NearbyFormButton.TabIndex = 8;
            this.NearbyFormButton.Click += new System.EventHandler(this.NearbyFormButton_Click);
            // 
            // DarkModeToggle
            // 
            this.DarkModeToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DarkModeToggle.Location = new System.Drawing.Point(1350, 35);
            this.DarkModeToggle.Name = "DarkModeToggle";
            this.DarkModeToggle.Size = new System.Drawing.Size(50, 25);
            this.DarkModeToggle.TabIndex = 7;
            this.DarkModeToggle.CheckedChanged += new System.EventHandler(this.DarkModeToggle_CheckedChanged);
            // 
            // DarkModeLabel
            // 
            this.DarkModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DarkModeLabel.AutoSize = true;
            this.DarkModeLabel.Location = new System.Drawing.Point(1250, 38);
            this.DarkModeLabel.Name = "DarkModeLabel";
            this.DarkModeLabel.Size = new System.Drawing.Size(74, 16);
            this.DarkModeLabel.TabIndex = 6;
            this.DarkModeLabel.Text = "Dark Mode";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(782, 380);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(68, 16);
            this.StartLabel.TabIndex = 5;
            this.StartLabel.Text = "Start Time";
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Location = new System.Drawing.Point(920, 380);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(65, 16);
            this.EndLabel.TabIndex = 3;
            this.EndLabel.Text = "End Time";
            // 
            // SameLabel
            // 
            this.SameLabel.AutoSize = true;
            this.SameLabel.Location = new System.Drawing.Point(1110, 402);
            this.SameLabel.Name = "SameLabel";
            this.SameLabel.Size = new System.Drawing.Size(82, 16);
            this.SameLabel.TabIndex = 0;
            this.SameLabel.Text = "Same Hours";
            // 
            // ManualRegistrationForm
            // 
            this.ClientSize = new System.Drawing.Size(1924, 798);
            this.Controls.Add(this.SameLabel);
            this.Controls.Add(this.SameHoursToggle);
            this.Controls.Add(this.EndHoursPicker);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.StartHoursPicker);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.DarkModeLabel);
            this.Controls.Add(this.DarkModeToggle);
            this.Controls.Add(this.NearbyFormButton);
            this.Controls.Add(this.PriceCheckerFormButton);
            this.Controls.Add(this.RegisterFormButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GoogleMapLinkButton);
            this.Controls.Add(this.SubmitSuggestionButton);
            this.Controls.Add(this.MapLinkTextBox);
            this.Controls.Add(this.MapLinkLabel);
            this.Controls.Add(this.AddressLocationTextBox);
            this.Controls.Add(this.ShopNameTextBox);
            this.Controls.Add(this.HomeLabelLink);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.ShopLabel);
            this.Name = "ManualRegistrationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.ManualRegistrationForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.HomeLabelLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label ShopLabel;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.Label MapLinkLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox HomeLabelLink;
        private Guna.UI2.WinForms.Guna2TextBox ShopNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox AddressLocationTextBox;
        private Guna.UI2.WinForms.Guna2TextBox MapLinkTextBox;
        private System.Windows.Forms.DateTimePicker StartHoursPicker;
        private System.Windows.Forms.DateTimePicker EndHoursPicker;
        private Guna.UI2.WinForms.Guna2ToggleSwitch SameHoursToggle;
        private Guna.UI2.WinForms.Guna2GradientButton SubmitSuggestionButton;
        private Guna.UI2.WinForms.Guna2GradientButton GoogleMapLinkButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton RegisterFormButton;
        private Guna.UI2.WinForms.Guna2ImageButton PriceCheckerFormButton;
        private Guna.UI2.WinForms.Guna2ImageButton NearbyFormButton;
        private Guna.UI2.WinForms.Guna2ToggleSwitch DarkModeToggle;
        private System.Windows.Forms.Label DarkModeLabel;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.Label SameLabel;
    }
}
