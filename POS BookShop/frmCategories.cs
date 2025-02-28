using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace POS_BookShop
{
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }
        public void Getcate()
        {
            btndelete.Enabled = false;
            btnupdate.Enabled = false;
            try
            {
                DatagridviewCate.Rows.Clear();
                string QueryEmp = "SELECT * FROM tblCategories;";
                SqlCommand s = new SqlCommand(QueryEmp, DataConnection.DataCon);
                SqlDataReader r = s.ExecuteReader();
                DatagridviewCate.RowTemplate.Height = 100;
                while (r.Read())
                {
                    string cateid = r[0].ToString();
                    string catename = r[1].ToString();
                    string des = r[2].ToString();
                    byte[] imageData = null;
                    if (r[3] != DBNull.Value)
                    {
                        imageData = (byte[])r[3];
                    }
                    DatagridviewCate.Rows.Add(cateid, catename, des, imageData);
                }
                r.Close();
                s.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void frmCategories_Load(object sender, EventArgs e)
        {
            Getcate();
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
                string query = "INSERT INTO tblCategories (Name, Description, Image) VALUES (@catename, @des, @image);";

                using (SqlCommand cadd = new SqlCommand(query, DataConnection.DataCon))
                {
                    cadd.Parameters.AddWithValue("@catename", txtcatename.Text.Trim());
                    cadd.Parameters.AddWithValue("@des", txtdes.Text.Trim());
                    cadd.Parameters.AddWithValue("@image", Images ?? (object)DBNull.Value);
                    cadd.ExecuteNonQuery();
                }

                txtcatename.Clear();
                txtdes.Clear();
                Getcate();
                MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        string cateid;
        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM tblCategories WHERE CategoryID = @cateid", DataConnection.DataCon);
                    cmd.Parameters.AddWithValue("@cateid", int.Parse(cateid));
                    cmd.ExecuteNonQuery();
                    Getcate();
                    txtcatename.Clear();
                    txtdes.Clear();
                    btnupdate.Enabled = true;
                    btndelete.Enabled = true;
                    MessageBox.Show("Deleted Successfully!");
                    btnupdate.Enabled = false;
                    btndelete.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void DatagridviewCate_Click(object sender, EventArgs e)
        {
            cateid = DatagridviewCate.SelectedRows[0].Cells["col_cateid"].Value.ToString();
            string name = DatagridviewCate.SelectedRows[0].Cells["col_catename"].Value.ToString();
            txtcatename.Text = name;
            string des = DatagridviewCate.SelectedRows[0].Cells["col_des"].Value.ToString();
            txtdes.Text = des;
            byte[] image = DatagridviewCate.SelectedRows[0].Cells["col_image"].Value as byte[];
            using (MemoryStream ms = new MemoryStream(image))
            {
                Picture.Image = System.Drawing.Image.FromStream(ms);
            }
            btnupdate.Enabled = true;
            btndelete.Enabled = true;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("update tblCategories set Name = @Name, Description = @Description, Image = @Image Where CategoryID = @CategoryID;", DataConnection.DataCon))
                    {
                        cmd.Parameters.AddWithValue("CategoryID", int.Parse(cateid));
                        cmd.Parameters.AddWithValue("@Name", txtcatename.Text);
                        cmd.Parameters.AddWithValue("@Description", txtdes.Text);
                        cmd.Parameters.AddWithValue("@Image", (object)Images ?? DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                    Getcate();
                    MessageBox.Show("Employee Update successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtdes.Text = "";
                    txtcatename.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string search_name = txtsearch.Text.Trim();
                    using (SqlCommand csearch = new SqlCommand("SELECT * FROM tblCategories WHERE Name LIKE @name", DataConnection.DataCon))
                    {
                        csearch.Parameters.Add("@name", SqlDbType.NVarChar).Value = "%" + search_name + "%";

                        if (DataConnection.DataCon.State == ConnectionState.Closed)
                        {
                            DataConnection.DataCon.Open();
                        }

                        using (SqlDataReader rcate = csearch.ExecuteReader())
                        {
                            DatagridviewCate.Rows.Clear();
                            DatagridviewCate.RowTemplate.Height = 100;

                            while (rcate.Read())
                            {
                                string cateid = rcate[0].ToString();
                                string catename = rcate[1].ToString();
                                string des = rcate[2].ToString();
                                byte[] imageData = null;

                                if (rcate[3] != DBNull.Value)
                                {
                                    imageData = (byte[])rcate[3];
                                }

                                DatagridviewCate.Rows.Add(cateid, catename, des, imageData);
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
        private void LoadAllCategories()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblCategories", DataConnection.DataCon))
                {
                    if (DataConnection.DataCon.State == ConnectionState.Closed)
                    {
                        DataConnection.DataCon.Open();
                    }

                    using (SqlDataReader rcate = cmd.ExecuteReader())
                    {
                        DatagridviewCate.Rows.Clear();
                        DatagridviewCate.RowTemplate.Height = 100;

                        while (rcate.Read())
                        {
                            string cateid = rcate[0].ToString();
                            string catename = rcate[1].ToString();
                            string des = rcate[2].ToString();
                            byte[] imageData = null;

                            if (rcate[3] != DBNull.Value)
                            {
                                imageData = (byte[])rcate[3];
                            }

                            DatagridviewCate.Rows.Add(cateid, catename, des, imageData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsearch.Text))
            {
                LoadAllCategories();
            }
            else
            {
                Getcate();
            }
        }
    }
}
