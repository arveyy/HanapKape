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
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            GoogleMapLinkRegistration RegisterForm = new GoogleMapLinkRegistration();
            this.Hide();
            RegisterForm.Show();
        }
    }
}
