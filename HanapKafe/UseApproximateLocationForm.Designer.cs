namespace HanapKafe
{
    partial class UseApproximateLocationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UseApproximateLocationForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.NearbyFormButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PriceCheckerFormButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.RegisterFormButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.NightModeToggleButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.DarkModeToggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.DarkModeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // NearbyFormButton
            // 
            this.NearbyFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NearbyFormButton.ImageSize = new System.Drawing.Size(64, 40);
            this.NearbyFormButton.Location = new System.Drawing.Point(1719, 15);
            this.NearbyFormButton.Name = "NearbyFormButton";
            this.NearbyFormButton.Size = new System.Drawing.Size(88, 64);
            this.NearbyFormButton.TabIndex = 39;
            this.NearbyFormButton.Click += new System.EventHandler(this.NearbyFormButton_Click);
            // 
            // PriceCheckerFormButton
            // 
            this.PriceCheckerFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceCheckerFormButton.ImageSize = new System.Drawing.Size(64, 40);
            this.PriceCheckerFormButton.Location = new System.Drawing.Point(1623, 15);
            this.PriceCheckerFormButton.Name = "PriceCheckerFormButton";
            this.PriceCheckerFormButton.Size = new System.Drawing.Size(88, 64);
            this.PriceCheckerFormButton.TabIndex = 38;
            this.PriceCheckerFormButton.Click += new System.EventHandler(this.PriceCheckerFormButton_Click);
            // 
            // RegisterFormButton
            // 
            this.RegisterFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterFormButton.ImageSize = new System.Drawing.Size(64, 40);
            this.RegisterFormButton.Location = new System.Drawing.Point(1527, 15);
            this.RegisterFormButton.Name = "RegisterFormButton";
            this.RegisterFormButton.Size = new System.Drawing.Size(88, 64);
            this.RegisterFormButton.TabIndex = 37;
            this.RegisterFormButton.Click += new System.EventHandler(this.RegisterFormButton_Click);
            // 
            // DarkModeToggle
            // 
            this.DarkModeToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DarkModeToggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DarkModeToggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DarkModeToggle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.DarkModeToggle.Location = new System.Drawing.Point(1450, 35);
            this.DarkModeToggle.Name = "DarkModeToggle";
            this.DarkModeToggle.Size = new System.Drawing.Size(50, 25);
            this.DarkModeToggle.TabIndex = 41;
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
            this.DarkModeLabel.Location = new System.Drawing.Point(1350, 38);
            this.DarkModeLabel.Name = "DarkModeLabel";
            this.DarkModeLabel.Size = new System.Drawing.Size(86, 20);
            this.DarkModeLabel.TabIndex = 42;
            this.DarkModeLabel.Text = "Dark Mode";
            // 
            // UseApproximateLocationForm
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
            this.Controls.Add(this.pictureBox2);
            this.Name = "UseApproximateLocationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UseApproximateLocationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.UseApproximateLocationForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2ImageButton NearbyFormButton;
        private Guna.UI2.WinForms.Guna2ImageButton PriceCheckerFormButton;
        private Guna.UI2.WinForms.Guna2ImageButton RegisterFormButton;
        private Guna.UI2.WinForms.Guna2ImageButton NightModeToggleButton;
        private Guna.UI2.WinForms.Guna2ToggleSwitch DarkModeToggle;
        private System.Windows.Forms.Label DarkModeLabel;
    }
}
