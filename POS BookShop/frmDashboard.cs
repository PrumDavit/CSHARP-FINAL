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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        public void Getsale()
        {
            try
            {
                DatagridviewSale.Rows.Clear();
                string Querysale = "SELECT * FROM tblSales;";
                using (SqlCommand sale = new SqlCommand(Querysale, DataConnection.DataCon))
                {
                    if (sale.Connection.State == System.Data.ConnectionState.Open)
                    {
                        sale.Connection.Close();
                    }
                    sale.Connection.Open();
                    using (SqlDataReader rsale = sale.ExecuteReader())
                    {
                        DatagridviewSale.RowTemplate.Height = 30;
                        while (rsale.Read())
                        {
                            string saleid = rsale[0].ToString();
                            string saledate = rsale[1].ToString();
                            string dis = rsale[2].ToString();
                            string disamount = rsale[3].ToString();
                            string totalamount = rsale[4].ToString();
                            string empid = rsale[5].ToString();
                            DatagridviewSale.Rows.Add(saleid, saledate, dis, disamount, totalamount, empid);
                        }
                        rsale.Close();
                        sale.Dispose();
                    }
                }
                
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void GeteIncome()
        {
            try
            {
                DatagridviewSale.Rows.Clear();
                string QueryIncome = "SELECT * FROM tblIncome;";
                using (SqlCommand income = new SqlCommand(QueryIncome, DataConnection.DataCon))
                {
                    if (income.Connection.State == System.Data.ConnectionState.Open)
                    {
                        income.Connection.Close();
                    }
                    income.Connection.Open();
                    using (SqlDataReader rincome = income.ExecuteReader())
                    {
                        DatagridviewSale.RowTemplate.Height = 30;
                        while (rincome.Read())
                        {
                            string incomeid = rincome[0].ToString();
                            string dateincome = rincome[1].ToString();
                            string amount = rincome[2].ToString();
                            string saleid = rincome[3].ToString();
                            Datagridviewincome.Rows.Add(incomeid, dateincome, amount, saleid);
                        }
                        rincome.Close();
                        income.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            GeteIncome();
            Getsale();
            string countemp = "select count(*) from tblEmployees;";
            using (SqlCommand semp = new SqlCommand(countemp,DataConnection.DataCon))
            {
                if (semp.Connection.State == System.Data.ConnectionState.Open)
                {
                    semp.Connection.Close();
                }
                semp.Connection.Open();
                using (SqlDataReader remp = semp.ExecuteReader()) {
                    if (remp.Read())
                    {
                        string resualtemp = remp[0].ToString();
                         lbtotalemp.Text = resualtemp;
                    }
                }
            }
            string countpro = "select count(*) from tblBooks;";
            using (SqlCommand sbook = new SqlCommand(countpro, DataConnection.DataCon))
            {
                if (sbook.Connection.State == System.Data.ConnectionState.Open)
                {
                    sbook.Connection.Close();
                }
                sbook.Connection.Open();
                using (SqlDataReader rbook = sbook.ExecuteReader())
                {
                    if (rbook.Read())
                    {
                        string resualtbook = rbook[0].ToString();
                        lbtotalbook.Text = resualtbook;
                    }
                }
            }
            string countcate = "select count(*) from tblCategories;";
            using (SqlCommand scate = new SqlCommand(countcate, DataConnection.DataCon))
            {
                if (scate.Connection.State == System.Data.ConnectionState.Open)
                {
                    scate.Connection.Close();
                }
                scate.Connection.Open();
                using (SqlDataReader rcate = scate.ExecuteReader())
                {
                    if (rcate.Read())
                    {
                        string resualtcate = rcate[0].ToString();
                        lbtotalcate.Text = resualtcate;
                    }
                }
            }
            string countsold = "select sum(Quantity) from tblSaleDetails;";
            using (SqlCommand ssold = new SqlCommand(countsold, DataConnection.DataCon))
            {
                if (ssold.Connection.State == System.Data.ConnectionState.Open)
                {
                    ssold.Connection.Close();
                }
                ssold.Connection.Open();
                using (SqlDataReader rsold = ssold.ExecuteReader())
                {
                    if (rsold.Read())
                    {
                        string resualtsold = rsold[0].ToString();
                        lbtotalsold.Text = resualtsold;
                    }
                }
            }
            string countstock = "select sum(Stock) from tblBooks;";
            using (SqlCommand sstock = new SqlCommand(countstock, DataConnection.DataCon))
            {
                if (sstock.Connection.State == System.Data.ConnectionState.Open)
                {
                    sstock.Connection.Close();
                }
                sstock.Connection.Open();
                using (SqlDataReader rstock = sstock.ExecuteReader())
                {
                    if (rstock.Read())
                    {
                        string resualtstock = rstock[0].ToString();
                        lbstock.Text = resualtstock;
                        if (int.Parse(resualtstock) < 145) 
                        { 
                            MessageBox.Show("Low Stock!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
