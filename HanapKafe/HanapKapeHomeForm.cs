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
    public partial class HanapKapeHome : Form
    {
        public HanapKapeHome()
        {
            InitializeComponent();
            ApplyTheme();
            CenterControls();
        }

        private void ApplyTheme()
        {
            this.BackColor = ThemeSettings.BackColor;
            this.ForeColor = ThemeSettings.TextColor;
            label1.ForeColor = ThemeSettings.TextColor;
            GmailLink.LinkColor = ThemeSettings.TextColor;
        }

        private void HanapKapeHome_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;

            // Center PictureBox
            pictureBox1.Left = centerX - (pictureBox1.Width / 2);

            // Center Label
            label1.Left = centerX - (label1.Width / 2);

            // Center Buttons (side by side, centered as a group)
            int buttonGap = 20;
            int totalButtonsWidth = ExploreNearbyButton.Width + buttonGap + RegisterYourShopButton.Width;
            ExploreNearbyButton.Left = centerX - (totalButtonsWidth / 2);
            RegisterYourShopButton.Left = ExploreNearbyButton.Right + buttonGap;

            // Center Gmail Link
            GmailLink.Left = centerX - (GmailLink.Width / 2);
        }

        private void ExploreNearbyButton_Click(object sender, EventArgs e)
        {
            NearbyForm nearbyForm = new NearbyForm();
            this.Hide();
            nearbyForm.Show();
        }

        private void RegisterYourShopButton_Click(object sender, EventArgs e)
        {
            GoogleMapLinkRegistration registration = new GoogleMapLinkRegistration();
            this.Hide();
            registration.Show();
        }
    }
}
