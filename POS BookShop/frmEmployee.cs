using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POS_BookShop
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void Picture_Click(object sender, EventArgs e)
        {

        }
        public void Cleartxt()
        {
            txtName.Clear();
            txtusername.Clear();
            txtemail.Clear();   
            txtaddress.Clear();
            txtpassword.Clear();
            txtphone.Clear();
            txtsalary.Clear();
            //Picture.Dispose();
        }
        public byte[] Images { get; private set; }
        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Picture.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
                Images = File.ReadAllBytes(openFileDialog.FileName);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertEmployee", DataConnection.DataCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
                    cmd.Parameters.AddWithValue("@Sex", cbbgender.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@Image", (object)Images ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DOB", DOB.Value);
                    cmd.Parameters.AddWithValue("@Roles", cbbrole.Text);
                    cmd.Parameters.AddWithValue("@Hiredate", hiredate.Value);
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
                    cmd.Parameters.AddWithValue("@Salary", decimal.Parse(txtsalary.Text));
                    cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                    cmd.ExecuteNonQuery();
                }
                try
                {
                    DatagridviewEmp.Rows.Clear();
                    string QueryEmp = "SELECT * FROM tblEmployees;";
                    SqlCommand s = new SqlCommand(QueryEmp, DataConnection.DataCon);
                    SqlDataReader r = s.ExecuteReader();
                    DatagridviewEmp.RowTemplate.Height = 45;
                    while (r.Read())
                    {
                        string empid = r[0].ToString();
                        string name = r[1].ToString();
                        string username = r[2].ToString();
                        string password = r[3].ToString();
                        string sex = r[4].ToString();
                        byte[] imageData = null;
                        if (r[5] != DBNull.Value)
                        {
                            imageData = (byte[])r[5];
                        }
                        string dob = r[6].ToString();
                        string role = r[7].ToString();
                        string hiredate = r[8].ToString();
                        string email = r[9].ToString();
                        string phone = r[10].ToString();
                        string salary = r[11].ToString();
                        string address = r[12].ToString();
                        DatagridviewEmp.Rows.Add(empid, name, username, password, sex, imageData, dob, role, hiredate, email, phone, salary, address);
                    }
                    r.Close();
                    s.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                Cleartxt();
                MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            btndelete.Enabled = false;
            btnupdate.Enabled = false;
            try
            {
                DatagridviewEmp.Rows.Clear();
                string QueryEmp = "SELECT * FROM tblEmployees;";
                SqlCommand s = new SqlCommand(QueryEmp, DataConnection.DataCon);
                SqlDataReader r = s.ExecuteReader();
                DatagridviewEmp.RowTemplate.Height = 100;
                while (r.Read())
                {
                    string empid = r[0].ToString();
                    string name = r[1].ToString();
                    string username = r[2].ToString();
                    string password = r[3].ToString();
                    string sex = r[4].ToString();
                    byte[] imageData = null;
                    if (r[5] != DBNull.Value)
                    {
                        imageData = (byte[])r[5];
                    }
                    string dob = r[6].ToString();
                    string role = r[7].ToString();
                    string hiredate = r[8].ToString();
                    string email = r[9].ToString();
                    string phone = r[10].ToString();
                    string salary = r[11].ToString();
                    string address = r[12].ToString();
                    DatagridviewEmp.Rows.Add(empid, name, username, password, sex, imageData, dob, role, hiredate, email, phone, salary, address);
                    DatagridviewEmp.Columns[11].DefaultCellStyle.Format = "C";
                }
                r.Close();
                s.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        string empid;
        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM tblEmployees WHERE EmployeeID = @empid", DataConnection.DataCon);
                    cmd.Parameters.AddWithValue("@empid", int.Parse(empid));
                    cmd.ExecuteNonQuery();
                    try
                    {
                        DatagridviewEmp.Rows.Clear();
                        string QueryEmp = "SELECT * FROM tblEmployees;";
                        SqlCommand s = new SqlCommand(QueryEmp, DataConnection.DataCon);
                        SqlDataReader r = s.ExecuteReader();
                        DatagridviewEmp.RowTemplate.Height = 100;
                        while (r.Read())
                        {
                            string empid = r[0].ToString();
                            string name = r[1].ToString();
                            string username = r[2].ToString();
                            string password = r[3].ToString();
                            string sex = r[4].ToString();
                            byte[] imageData = null;
                            if (r[5] != DBNull.Value)
                            {
                                imageData = (byte[])r[5];
                            }
                            string dob = r[6].ToString();
                            string role = r[7].ToString();
                            string hiredate = r[8].ToString();
                            string email = r[9].ToString();
                            string phone = r[10].ToString();
                            string salary = r[11].ToString();
                            string address = r[12].ToString();

                            // Add row to DataGridView
                            DatagridviewEmp.Rows.Add(empid, name, username, password, sex, imageData, dob, role, hiredate, email, phone, salary, address);
                        }
                        r.Close();
                        s.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    Cleartxt();
                    btnupdate.Enabled = true;
                    btndelete.Enabled = true;
                    MessageBox.Show("Deleted Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_UpdateEmployee", DataConnection.DataCon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("EmployeeID",int.Parse(empid));  
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Username", txtusername.Text);
                        cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
                        cmd.Parameters.AddWithValue("@Sex", cbbgender.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@Image", (object)Images ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@DOB", DOB.Value);
                        cmd.Parameters.AddWithValue("@Roles", cbbrole.Text);
                        cmd.Parameters.AddWithValue("@Hiredate", hiredate.Value);
                        cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
                        cmd.Parameters.AddWithValue("@Salary", decimal.Parse(txtsalary.Text));
                        cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                        cmd.ExecuteNonQuery();
                    }
                    try
                    {
                        DatagridviewEmp.Rows.Clear();
                        string QueryEmp = "SELECT * FROM tblEmployees;";
                        SqlCommand s = new SqlCommand(QueryEmp, DataConnection.DataCon);
                        SqlDataReader r = s.ExecuteReader();
                        DatagridviewEmp.RowTemplate.Height = 100;
                        while (r.Read())
                        {
                            string empid = r[0].ToString();
                            string name = r[1].ToString();
                            string username = r[2].ToString();
                            string password = r[3].ToString();
                            string sex = r[4].ToString();
                            byte[] imageData = null;
                            if (r[5] != DBNull.Value)
                            {
                                imageData = (byte[])r[5];
                            }
                            string dob = r[6].ToString();
                            string role = r[7].ToString();
                            string hiredate = r[8].ToString();
                            string email = r[9].ToString();
                            string phone = r[10].ToString();
                            string salary = r[11].ToString();
                            string address = r[12].ToString();

                            // Add row to DataGridView
                            DatagridviewEmp.Rows.Add(empid, name, username, password, sex, imageData, dob, role, hiredate, email, phone, salary, address);
                        }
                        r.Close();
                        s.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    Cleartxt();
                    btnupdate.Enabled = true;
                    btndelete.Enabled = true;
                    MessageBox.Show("Employee Update successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DatagridviewEmp_Click(object sender, EventArgs e)
        {
            empid = DatagridviewEmp.SelectedRows[0].Cells["col_empid"].Value.ToString();
            string name = DatagridviewEmp.SelectedRows[0].Cells["col_name"].Value.ToString();
            txtName.Text = name;
            string username = DatagridviewEmp.SelectedRows[0].Cells["col_username"].Value.ToString();
            txtusername.Text = username;
            string password = DatagridviewEmp.SelectedRows[0].Cells["col_password"].Value.ToString();
            txtpassword.Text = password;
            string gender = DatagridviewEmp.SelectedRows[0].Cells["col_gender"].Value.ToString();
            cbbgender.Text = gender;
            DateTime dob = Convert.ToDateTime(DatagridviewEmp.SelectedRows[0].Cells["col_dob"].Value);
            DOB.Text = dob.ToString();
            string role = DatagridviewEmp.SelectedRows[0].Cells["col_role"].Value.ToString();
            cbbrole.Text = role;
            DateTime hireDate = Convert.ToDateTime(DatagridviewEmp.SelectedRows[0].Cells["col_hiredate"].Value);
            hiredate.Text = hireDate.ToString();
            string email = DatagridviewEmp.SelectedRows[0].Cells["col_email"].Value.ToString();
            txtemail.Text = email;
            string address = DatagridviewEmp.SelectedRows[0].Cells["col_address"].Value.ToString();
            txtaddress.Text = address.ToString();  
            string phoneNumber = DatagridviewEmp.SelectedRows[0].Cells["col_phone"].Value.ToString();
            txtphone.Text = phoneNumber;
            decimal salary = Convert.ToDecimal(DatagridviewEmp.SelectedRows[0].Cells["col_salary"].Value);
            txtsalary.Text = salary.ToString();
            byte[] image = DatagridviewEmp.SelectedRows[0].Cells["col_img"].Value as byte[];
            using(MemoryStream ms = new MemoryStream(image))
            {
                Picture.Image = Image.FromStream(ms);
            }
            btnupdate.Enabled = true;
            btndelete.Enabled = true;

        }

        private void txtsearchemp_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsearchemp.Text))
            {
                LoadAllEmployees(); 
            }
            else
            {
                SearchEmployee(txtsearchemp.Text.Trim()); 
            }
        }

        private void SearchEmployee(string searchby_name)
        {
            try
            {
                using (SqlCommand empsearch = new SqlCommand("SELECT * FROM tblEmployees WHERE Name LIKE @name", DataConnection.DataCon))
                {
                    empsearch.Parameters.Add("@name", SqlDbType.NVarChar).Value = "%" + searchby_name + "%";

                    if (DataConnection.DataCon.State == ConnectionState.Closed)
                    {
                        DataConnection.DataCon.Open();
                    }

                    using (SqlDataReader remp = empsearch.ExecuteReader())
                    {
                        DatagridviewEmp.Rows.Clear();
                        DatagridviewEmp.RowTemplate.Height = 100;

                        while (remp.Read())
                        {
                            DatagridviewEmp.Rows.Add(
                                remp[0].ToString(), remp[1].ToString(), remp[2].ToString(), remp[3].ToString(),
                                remp[4].ToString(), remp[5] != DBNull.Value ? (byte[])remp[5] : null,
                                remp[6].ToString(), remp[7].ToString(), remp[8].ToString(), remp[9].ToString(),
                                remp[10].ToString(), remp[11].ToString(), remp[12].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadAllEmployees()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblEmployees", DataConnection.DataCon))
                {
                    if (DataConnection.DataCon.State == ConnectionState.Closed)
                    {
                        DataConnection.DataCon.Open();
                    }

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        DatagridviewEmp.Rows.Clear();
                        DatagridviewEmp.RowTemplate.Height = 100;

                        while (r.Read())
                        {
                            DatagridviewEmp.Rows.Add(
                                r[0].ToString(), r[1].ToString(), r[2].ToString(), r[3].ToString(),
                                r[4].ToString(), r[5] != DBNull.Value ? (byte[])r[5] : null,
                                r[6].ToString(), r[7].ToString(), r[8].ToString(), r[9].ToString(),
                                r[10].ToString(), r[11].ToString(), r[12].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
