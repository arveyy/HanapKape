namespace HanapKafe
{
    partial class HanapKapeHome
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
            this.ExploreNBtn = new System.Windows.Forms.Button();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.GmailLink = new System.Windows.Forms.LinkLabel();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExploreNBtn
            // 
            this.ExploreNBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExploreNBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExploreNBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.ExploreNBtn.ForeColor = System.Drawing.Color.White;
            this.ExploreNBtn.Location = new System.Drawing.Point(50, 308);
            this.ExploreNBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExploreNBtn.Name = "ExploreNBtn";
            this.ExploreNBtn.Size = new System.Drawing.Size(137, 46);
            this.ExploreNBtn.TabIndex = 0;
            this.ExploreNBtn.Text = "📍Explore Nearby";
            this.ExploreNBtn.UseVisualStyleBackColor = false;
            // 
            // Registerbtn
            // 
            this.Registerbtn.BackColor = System.Drawing.Color.Transparent;
            this.Registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Registerbtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Registerbtn.Location = new System.Drawing.Point(249, 308);
            this.Registerbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(142, 46);
            this.Registerbtn.TabIndex = 1;
            this.Registerbtn.Text = "✍Register your Shop";
            this.Registerbtn.UseVisualStyleBackColor = false;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // GmailLink
            // 
            this.GmailLink.ActiveLinkColor = System.Drawing.SystemColors.Control;
            this.GmailLink.AutoSize = true;
            this.GmailLink.LinkColor = System.Drawing.Color.Black;
            this.GmailLink.Location = new System.Drawing.Point(177, 479);
            this.GmailLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GmailLink.Name = "GmailLink";
            this.GmailLink.Size = new System.Drawing.Size(88, 13);
            this.GmailLink.TabIndex = 2;
            this.GmailLink.TabStop = true;
            this.GmailLink.Text = "✉︎Connect Gmail";
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Titlelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Titlelabel.Location = new System.Drawing.Point(125, 20);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(216, 189);
            this.Titlelabel.TabIndex = 5;
            this.Titlelabel.Text = "Hanap\r\n☕︎Kape\r\n\r\n";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.WelcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WelcomeLabel.Location = new System.Drawing.Point(71, 225);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(329, 32);
            this.WelcomeLabel.TabIndex = 6;
            this.WelcomeLabel.Text = "Welcome to HanapKape";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(108, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Discover coffee near you";
            // 
            // HanapKapeHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(442, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.GmailLink);
            this.Controls.Add(this.Registerbtn);
            this.Controls.Add(this.ExploreNBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HanapKapeHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HanapKape";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExploreNBtn;
        private System.Windows.Forms.Button Registerbtn;
        private System.Windows.Forms.LinkLabel GmailLink;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label label1;
    }
}

