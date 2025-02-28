using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_BookShop
{
    public partial class frmDashboardSale : Form
    {
        private Form activeForm;
        private void OpenChildForm(Form childForm)
        {
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.showbtnclick.Controls.Add(childForm);
            this.showbtnclick.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public frmDashboardSale()
        {
            InitializeComponent();
        }

        public frmDashboardSale(string name, string role, byte[] image)
        {
            InitializeComponent();
            displayUname.Text = name;
            displayRole.Text = role;
            if (image != null)
            {
                using (MemoryStream ms = new MemoryStream(image))
                {
                    System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                    profile.Image = img;
                }
            }
        }

        private void frmDashboardSale_Load(object sender, EventArgs e)
        {
            btndboard.PerformClick();
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

        private void showbtnclick_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            lbshowfrm.Text = "Dashboard";
            frmDashboard frmDashboard = new frmDashboard();
            OpenChildForm(frmDashboard);
        }
    }
}
