using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_BookShop
{
    public partial class frmExpense : Form
    {
        public frmExpense()
        {
            InitializeComponent();
        }
        public void GetExpense()
        {
            btndelete.Enabled = false;
            btnupdate.Enabled = false;
            try
            {
                DatagridviewExp.Rows.Clear();
                string QueryEmp = "SELECT * FROM tblExpense;";
                SqlCommand se = new SqlCommand(QueryEmp, DataConnection.DataCon);
                SqlDataReader re = se.ExecuteReader();
                DatagridviewExp.RowTemplate.Height = 100;
                while (re.Read())
                {
                    string expid = re[0].ToString();
                    string datetime = re[1].ToString();
                    string amount = re[2].ToString();
                    string des = re[3].ToString();
                    string empid = re[4].ToString();
                    DatagridviewExp.Rows.Add(expid, datetime, amount,des,empid );
                }
                re.Close();
                se.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO tblExpense (Date, Amount, Description, EmployeeID) VALUES (@date, @amount, @des, @empid);";
                DateTime dateTime = DateTime.Now;
                string empid = frmlogin.EmpID;
                using (SqlCommand cadd = new SqlCommand(query, DataConnection.DataCon))
                {

                    cadd.Parameters.AddWithValue("@amount", txtamount.Text.Trim());
                    cadd.Parameters.AddWithValue("@des", txtdes.Text.Trim());
                    cadd.Parameters.AddWithValue("@date", dateTime);
                    cadd.Parameters.AddWithValue("@empid", empid);
                    cadd.ExecuteNonQuery();
                }

                txtamount.Clear();
                txtdes.Clear();
                GetExpense();
                MessageBox.Show("Expense added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmExpense_Load(object sender, EventArgs e)
        {
            GetExpense();
        }

        private void DatagridviewExp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string expid;
        private void DatagridviewExp_Click(object sender, EventArgs e)
        {
            btnupdate.Enabled = true;
            btndelete.Enabled = true;
            expid = DatagridviewExp.SelectedRows[0].Cells["expenseid"].Value.ToString();
            string des = DatagridviewExp.SelectedRows[0].Cells["description"].Value.ToString();
            txtdes.Text = des;
            string amount = DatagridviewExp.SelectedRows[0].Cells["amount"].Value.ToString();
            txtamount.Text = amount;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("update tblExpense set Date = @date, Description = @Description , Amount = @amount Where ExpenseID = @ExpenseID;", DataConnection.DataCon))
                    {
                        cmd.Parameters.AddWithValue("ExpenseID", expid);
                        DateTime date = DateTime.Now;
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@Description", txtdes.Text);
                        cmd.Parameters.AddWithValue("@amount", txtamount.Text);
                        cmd.ExecuteNonQuery();
                    }
                    GetExpense();
                    MessageBox.Show("Update successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtdes.Text = "";
                    txtamount.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM tblExpense WHERE ExpenseID = @expid", DataConnection.DataCon);
                    cmd.Parameters.AddWithValue("@expid", int.Parse(expid));
                    cmd.ExecuteNonQuery();
                    GetExpense();
                    txtamount.Clear();
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
    }
}
