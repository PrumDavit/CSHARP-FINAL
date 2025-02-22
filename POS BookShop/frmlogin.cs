using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS_BookShop
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            try
            {
                txtPassword.PasswordChar = '*';
                DataConnection.ConnectionDB();
                // Fetch roles and populate the comboBoxRole
                string queryRoles = "SELECT DISTINCT Roles FROM tblEmployees";
                using (SqlCommand scm = new SqlCommand(queryRoles, DataConnection.DataCon))
                {
                    using (SqlDataReader drRoles = scm.ExecuteReader())
                    {
                        cbbRole.Items.Clear();

                        while (drRoles.Read())
                        {
                            // Add each role to the comboBoxRole
                            cbbRole.Items.Add(drRoles["roles"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading roles: {ex.Message}");
            }
            cbbRole.SelectedIndex = 0;
        }
        public Image Image { get; private set; }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                string role = cbbRole.SelectedItem?.ToString();
                // Check if the username and password are correct
                string queryLogin = $"\tSELECT Name,Image,Username,Password,roles from tblEmployees WHERE Username='{username}' AND Password='{password}' AND Roles='{cbbRole.SelectedItem}'";
                using (SqlCommand s = new SqlCommand(queryLogin, DataConnection.DataCon))
                {
                    using (SqlDataReader dr = s.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            byte[] imageBytes = dr["Image"] as byte[];

                            if (imageBytes != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    Image = Image.FromStream(ms); //Display image in PictureBox
                                }
                            }
                            string name = dr["Name"]?.ToString();
                            //MessageBox.Show($"Welcome {name}");
                            // Use case-insensitive comparison
                            if (string.Equals(role, "Sale", StringComparison.OrdinalIgnoreCase))
                            {
                                frmDashboardSale dashboardSale = new frmDashboardSale(name, role, imageBytes);
                                dashboardSale.Show();
                                this.Hide();
                            }
                            else if (string.Equals(role, "Admin", StringComparison.OrdinalIgnoreCase))
                            {
                                frmDashboardAdmin dashbAdmin = new frmDashboardAdmin(name, role, imageBytes);
                                dashbAdmin.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Role not found!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password or role!");
                        }
                    }
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging in: {ex.Message}");
            }
        }

        private void checkShowHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowHidePassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                checkShowHidePassword.Text = "Hide Password";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                checkShowHidePassword.Text = "Show Password";

            }
        }
    }
}
