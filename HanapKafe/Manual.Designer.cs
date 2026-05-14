namespace HanapKafe
{
    partial class ManualRegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualRegistrationForm));
            this.ShopLabel = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.OperatingLabel = new System.Windows.Forms.Label();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HomeLabelLink = new System.Windows.Forms.PictureBox();
            this.ShopNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddressLocationTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UseMyLocationButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.OperatingHoursOptionalTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NotesOptionalTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SubmitSuggestionButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.GoogleMapLinkButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RegisterFormButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PriceCheckerFormButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.NearbyFormButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.DarkModeToggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.DarkModeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HomeLabelLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShopLabel
            // 
            this.ShopLabel.AutoSize = true;
            this.ShopLabel.Enabled = false;
            this.ShopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ShopLabel.Location = new System.Drawing.Point(777, 143);
            this.ShopLabel.Name = "ShopLabel";
            this.ShopLabel.Size = new System.Drawing.Size(91, 17);
            this.ShopLabel.TabIndex = 6;
            this.ShopLabel.Text = "Shop Name *";
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Enabled = false;
            this.AdressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AdressLabel.Location = new System.Drawing.Point(777, 235);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(135, 17);
            this.AdressLabel.TabIndex = 7;
            this.AdressLabel.Text = "Address / Location *";
            // 
            // OperatingLabel
            // 
            this.OperatingLabel.AutoSize = true;
            this.OperatingLabel.Enabled = false;
            this.OperatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.OperatingLabel.Location = new System.Drawing.Point(778, 368);
            this.OperatingLabel.Name = "OperatingLabel";
            this.OperatingLabel.Size = new System.Drawing.Size(197, 17);
            this.OperatingLabel.TabIndex = 8;
            this.OperatingLabel.Text = "🕓 Operating Hours (optional)";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Enabled = false;
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.NotesLabel.Location = new System.Drawing.Point(777, 458);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(109, 17);
            this.NotesLabel.TabIndex = 9;
            this.NotesLabel.Text = "Notes (optional)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(853, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Manual Shop Registration";
            // 
            // HomeLabelLink
            // 
            this.HomeLabelLink.Image = ((System.Drawing.Image)(resources.GetObject("HomeLabelLink.Image")));
            this.HomeLabelLink.Location = new System.Drawing.Point(17, 15);
            this.HomeLabelLink.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.HomeLabelLink.Name = "HomeLabelLink";
            this.HomeLabelLink.Size = new System.Drawing.Size(165, 100);
            this.HomeLabelLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeLabelLink.TabIndex = 21;
            this.HomeLabelLink.TabStop = false;
            this.HomeLabelLink.Click += new System.EventHandler(this.HomeLabelLink_Click);
            // 
            // ShopNameTextBox
            // 
            this.ShopNameTextBox.BorderColor = System.Drawing.Color.Black;
            this.ShopNameTextBox.BorderRadius = 15;
            this.ShopNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ShopNameTextBox.DefaultText = "";
            this.ShopNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ShopNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ShopNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ShopNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ShopNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShopNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ShopNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShopNameTextBox.Location = new System.Drawing.Point(781, 162);
            this.ShopNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShopNameTextBox.Name = "ShopNameTextBox";
            this.ShopNameTextBox.PlaceholderText = "";
            this.ShopNameTextBox.SelectedText = "";
            this.ShopNameTextBox.Size = new System.Drawing.Size(405, 53);
            this.ShopNameTextBox.TabIndex = 22;
            // 
            // AddressLocationTextBox
            // 
            this.AddressLocationTextBox.BorderColor = System.Drawing.Color.Black;
            this.AddressLocationTextBox.BorderRadius = 15;
            this.AddressLocationTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressLocationTextBox.DefaultText = "";
            this.AddressLocationTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddressLocationTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddressLocationTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressLocationTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressLocationTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressLocationTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddressLocationTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressLocationTextBox.Location = new System.Drawing.Point(780, 255);
            this.AddressLocationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddressLocationTextBox.Name = "AddressLocationTextBox";
            this.AddressLocationTextBox.PlaceholderText = "";
            this.AddressLocationTextBox.SelectedText = "";
            this.AddressLocationTextBox.Size = new System.Drawing.Size(405, 53);
            this.AddressLocationTextBox.TabIndex = 23;
            // 
            // UseMyLocationButton
            // 
            this.UseMyLocationButton.BorderRadius = 15;
            this.UseMyLocationButton.BorderThickness = 1;
            this.UseMyLocationButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UseMyLocationButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UseMyLocationButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UseMyLocationButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UseMyLocationButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UseMyLocationButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.UseMyLocationButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.UseMyLocationButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.UseMyLocationButton.ForeColor = System.Drawing.Color.Black;
            this.UseMyLocationButton.Location = new System.Drawing.Point(780, 317);
            this.UseMyLocationButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UseMyLocationButton.Name = "UseMyLocationButton";
            this.UseMyLocationButton.Size = new System.Drawing.Size(152, 31);
            this.UseMyLocationButton.TabIndex = 24;
            this.UseMyLocationButton.Text = "Use My Location";
            // 
            // OperatingHoursOptionalTextBox
            // 
            this.OperatingHoursOptionalTextBox.BorderColor = System.Drawing.Color.Black;
            this.OperatingHoursOptionalTextBox.BorderRadius = 15;
            this.OperatingHoursOptionalTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OperatingHoursOptionalTextBox.DefaultText = "";
            this.OperatingHoursOptionalTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OperatingHoursOptionalTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OperatingHoursOptionalTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OperatingHoursOptionalTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OperatingHoursOptionalTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OperatingHoursOptionalTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OperatingHoursOptionalTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OperatingHoursOptionalTextBox.Location = new System.Drawing.Point(780, 390);
            this.OperatingHoursOptionalTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OperatingHoursOptionalTextBox.Name = "OperatingHoursOptionalTextBox";
            this.OperatingHoursOptionalTextBox.PlaceholderText = "";
            this.OperatingHoursOptionalTextBox.SelectedText = "";
            this.OperatingHoursOptionalTextBox.Size = new System.Drawing.Size(405, 53);
            this.OperatingHoursOptionalTextBox.TabIndex = 25;
            // 
            // NotesOptionalTextBox
            // 
            this.NotesOptionalTextBox.BorderColor = System.Drawing.Color.Black;
            this.NotesOptionalTextBox.BorderRadius = 15;
            this.NotesOptionalTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NotesOptionalTextBox.DefaultText = "";
            this.NotesOptionalTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NotesOptionalTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NotesOptionalTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NotesOptionalTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NotesOptionalTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NotesOptionalTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NotesOptionalTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NotesOptionalTextBox.Location = new System.Drawing.Point(781, 480);
            this.NotesOptionalTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NotesOptionalTextBox.Name = "NotesOptionalTextBox";
            this.NotesOptionalTextBox.PlaceholderText = "";
            this.NotesOptionalTextBox.SelectedText = "";
            this.NotesOptionalTextBox.Size = new System.Drawing.Size(405, 113);
            this.NotesOptionalTextBox.TabIndex = 26;
            // 
            // SubmitSuggestionButton
            // 
            this.SubmitSuggestionButton.BorderRadius = 15;
            this.SubmitSuggestionButton.BorderThickness = 1;
            this.SubmitSuggestionButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SubmitSuggestionButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SubmitSuggestionButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SubmitSuggestionButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SubmitSuggestionButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SubmitSuggestionButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.SubmitSuggestionButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.SubmitSuggestionButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitSuggestionButton.ForeColor = System.Drawing.Color.Black;
            this.SubmitSuggestionButton.Location = new System.Drawing.Point(780, 611);
            this.SubmitSuggestionButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SubmitSuggestionButton.Name = "SubmitSuggestionButton";
            this.SubmitSuggestionButton.Size = new System.Drawing.Size(405, 68);
            this.SubmitSuggestionButton.TabIndex = 27;
            this.SubmitSuggestionButton.Text = "Submit Suggestion";
            // 
            // GoogleMapLinkButton
            // 
            this.GoogleMapLinkButton.BorderRadius = 15;
            this.GoogleMapLinkButton.BorderThickness = 1;
            this.GoogleMapLinkButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GoogleMapLinkButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GoogleMapLinkButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GoogleMapLinkButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GoogleMapLinkButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GoogleMapLinkButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.GoogleMapLinkButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.GoogleMapLinkButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.GoogleMapLinkButton.ForeColor = System.Drawing.Color.Black;
            this.GoogleMapLinkButton.Location = new System.Drawing.Point(1064, 698);
            this.GoogleMapLinkButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GoogleMapLinkButton.Name = "GoogleMapLinkButton";
            this.GoogleMapLinkButton.Size = new System.Drawing.Size(122, 39);
            this.GoogleMapLinkButton.TabIndex = 28;
            this.GoogleMapLinkButton.Text = "Google Map Link";
            this.GoogleMapLinkButton.Click += new System.EventHandler(this.GoogleMapLinkButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(785, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterFormButton
            // 
            this.RegisterFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterFormButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.RegisterFormButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.RegisterFormButton.Image = ((System.Drawing.Image)(resources.GetObject("RegisterFormButton.Image")));
            this.RegisterFormButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.RegisterFormButton.ImageRotate = 0F;
            this.RegisterFormButton.ImageSize = new System.Drawing.Size(64, 40);
            this.RegisterFormButton.Location = new System.Drawing.Point(1408, 15);
            this.RegisterFormButton.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterFormButton.Name = "RegisterFormButton";
            this.RegisterFormButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.RegisterFormButton.Size = new System.Drawing.Size(88, 64);
            this.RegisterFormButton.TabIndex = 30;
            this.RegisterFormButton.Click += new System.EventHandler(this.RegisterFormButton_Click);
            // 
            // PriceCheckerFormButton
            // 
            this.PriceCheckerFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceCheckerFormButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.PriceCheckerFormButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.PriceCheckerFormButton.Image = ((System.Drawing.Image)(resources.GetObject("PriceCheckerFormButton.Image")));
            this.PriceCheckerFormButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.PriceCheckerFormButton.ImageRotate = 0F;
            this.PriceCheckerFormButton.ImageSize = new System.Drawing.Size(64, 40);
            this.PriceCheckerFormButton.Location = new System.Drawing.Point(1494, 15);
            this.PriceCheckerFormButton.Margin = new System.Windows.Forms.Padding(4);
            this.PriceCheckerFormButton.Name = "PriceCheckerFormButton";
            this.PriceCheckerFormButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.PriceCheckerFormButton.Size = new System.Drawing.Size(88, 64);
            this.PriceCheckerFormButton.TabIndex = 31;
            this.PriceCheckerFormButton.Click += new System.EventHandler(this.PriceCheckerFormButton_Click);
            // 
            // NearbyFormButton
            // 
            this.NearbyFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NearbyFormButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.NearbyFormButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.NearbyFormButton.Image = ((System.Drawing.Image)(resources.GetObject("NearbyFormButton.Image")));
            this.NearbyFormButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.NearbyFormButton.ImageRotate = 0F;
            this.NearbyFormButton.ImageSize = new System.Drawing.Size(64, 40);
            this.NearbyFormButton.Location = new System.Drawing.Point(1580, 15);
            this.NearbyFormButton.Margin = new System.Windows.Forms.Padding(4);
            this.NearbyFormButton.Name = "NearbyFormButton";
            this.NearbyFormButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.NearbyFormButton.Size = new System.Drawing.Size(88, 64);
            this.NearbyFormButton.TabIndex = 32;
            this.NearbyFormButton.Click += new System.EventHandler(this.NearbyFormButton_Click);
            // 
            // DarkModeToggle
            // 
            this.DarkModeToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DarkModeToggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DarkModeToggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DarkModeToggle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.DarkModeToggle.Location = new System.Drawing.Point(1350, 35);
            this.DarkModeToggle.Name = "DarkModeToggle";
            this.DarkModeToggle.Size = new System.Drawing.Size(50, 25);
            this.DarkModeToggle.TabIndex = 35;
            this.DarkModeToggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DarkModeToggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DarkModeToggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.DarkModeToggle.CheckedChanged += new System.EventHandler(this.DarkModeToggle_CheckedChanged);
            // 
            // DarkModeLabel
            // 
            this.DarkModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DarkModeLabel.AutoSize = true;
            this.DarkModeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DarkModeLabel.Location = new System.Drawing.Point(1250, 38);
            this.DarkModeLabel.Name = "DarkModeLabel";
            this.DarkModeLabel.Size = new System.Drawing.Size(86, 20);
            this.DarkModeLabel.TabIndex = 36;
            this.DarkModeLabel.Text = "Dark Mode";
            // 
            // ManualRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1924, 798);
            this.Controls.Add(this.DarkModeLabel);
            this.Controls.Add(this.DarkModeToggle);
            this.Controls.Add(this.NearbyFormButton);
            this.Controls.Add(this.PriceCheckerFormButton);
            this.Controls.Add(this.RegisterFormButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GoogleMapLinkButton);
            this.Controls.Add(this.SubmitSuggestionButton);
            this.Controls.Add(this.NotesOptionalTextBox);
            this.Controls.Add(this.OperatingHoursOptionalTextBox);
            this.Controls.Add(this.UseMyLocationButton);
            this.Controls.Add(this.AddressLocationTextBox);
            this.Controls.Add(this.ShopNameTextBox);
            this.Controls.Add(this.HomeLabelLink);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.OperatingLabel);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.ShopLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManualRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.ManualRegistrationForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.HomeLabelLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ShopLabel;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.Label OperatingLabel;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox HomeLabelLink;
        private Guna.UI2.WinForms.Guna2TextBox ShopNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox AddressLocationTextBox;
        private Guna.UI2.WinForms.Guna2GradientButton UseMyLocationButton;
        private Guna.UI2.WinForms.Guna2TextBox OperatingHoursOptionalTextBox;
        private Guna.UI2.WinForms.Guna2TextBox NotesOptionalTextBox;
        private Guna.UI2.WinForms.Guna2GradientButton SubmitSuggestionButton;
        private Guna.UI2.WinForms.Guna2GradientButton GoogleMapLinkButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton RegisterFormButton;
        private Guna.UI2.WinForms.Guna2ImageButton PriceCheckerFormButton;
        private Guna.UI2.WinForms.Guna2ImageButton NearbyFormButton;
        private Guna.UI2.WinForms.Guna2ToggleSwitch DarkModeToggle;
        private System.Windows.Forms.Label DarkModeLabel;
    }
}
