using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_BookShop
{
    public partial class frmDashboardSale : Form
    {
        private string name;
        private string role;
        private byte[] imageBytes;

        public frmDashboardSale()
        {
            InitializeComponent();
        }

        public frmDashboardSale(string name, string role, byte[] imageBytes)
        {
            InitializeComponent();
            this.name = name;
            this.role = role;
            this.imageBytes = imageBytes;
        }

        private void frmDashboardSale_Load(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                new frmlogin().Show();
                this.Hide();
            }
            else
                return;
        }
    }
}
