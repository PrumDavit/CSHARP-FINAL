using System;
using System.Drawing;
using System.IO;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace POS_BookShop
{
    public partial class frmDashboardAdmin : Form
    {
        public frmDashboardAdmin(string name)
        {
            InitializeComponent();
        }
        private Form activeForm;
        public frmDashboardAdmin(string name, string role, byte[] image)
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
        private void frmDashboardAdmin_Load(object sender, EventArgs e)
        {
            btndboard.PerformClick();
        }
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

        private void btncate_Click(object sender, EventArgs e)
        {

        }

        private void btnemp_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            lbshowfrm.Text = "Employee";
            frmEmployee frmEmployee = new frmEmployee();
            OpenChildForm(frmEmployee);
        }

        private void btnbook_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnexp_Click(object sender, EventArgs e)
        {

        }

        private void btnincome_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbshowfrm_Click(object sender, EventArgs e)
        {

        }

        private void displayRole_Click(object sender, EventArgs e)
        {

        }

        private void displayUname_Click(object sender, EventArgs e)
        {

        }

        private void profile_Click(object sender, EventArgs e)
        {

        }

        private void showbtnclick_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
