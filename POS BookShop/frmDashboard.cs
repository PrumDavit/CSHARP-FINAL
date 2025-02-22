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

        private void frmDashboard_Load(object sender, EventArgs e)
        {
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
            string countsold = "select count(*) from tblSales;";
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
        }
    }
}
