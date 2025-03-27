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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadProduct()
        {
            flowLayoutPanel1.Controls.Clear();
            try
            {
                string sql = "SELECT BookName,Price FROM tblBooks;";
                SqlCommand s = new SqlCommand(sql,DataConnection.DataCon);
                SqlDataReader r = s.ExecuteReader();
                while (r.Read()) {
                    frmOrder FO = new frmOrder
                    {
                        ProductName = r[0].ToString(),
                        Price = r[1] != DBNull.Value ? Convert.ToDecimal(r["price"]).ToString("C2") : "N/A",
                    };
                    FO.AddItem += ProductCateItem;
                    flowLayoutPanel1.Controls.Add(FO);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void ProductCateItem(object sender,EventArgs e)
        {
            if (!(sender is frmOrder Select_Product)||Select_Product ==null) {
                MessageBox.Show("Ïnvalid Product");
                return;
            }
            bool PExist=false;
            foreach (DataGridViewRow row in Display.Rows) {
                if(row.Cells[1].Value != null && row.Cells[1].Value.ToString() == Select_Product.ProductName)
                {
                    int currrent =Convert.ToInt32(row.Cells[1].Value);
                    currrent++;
                    row.Cells[1].Value = currrent;
                    string price=Select_Product.Price.Replace("$","").Trim();
                    if (decimal.TryParse(price, out decimal unitPrice))
                    {
                        row.Cells[4].Value = unitPrice * currrent;
                    }
                    PExist = true; 
                    break; 
                }
                if (PExist) {
                    Display.RowTemplate.Height = 50;
                    // Parse the unit price.
                    string priceText = Select_Product.Price.Replace("$", "").Replace("€", "").Trim();
                    decimal unitPrice = 0;
                    if (!decimal.TryParse(priceText, out unitPrice))
                    {
                        MessageBox.Show("Invalid product price format.");
                    }
                    int rowIndex = Display.Rows.Add();
                    DataGridViewRow newRow = Display.Rows[rowIndex];
                    // Set the "No." column value as the row index + 1.
                    newRow.Cells[0].Value = rowIndex + 1;
                    newRow.Cells[1].Value = Select_Product.ProductName;
                    newRow.Cells[2].Value = 1;
                    newRow.Cells[3].Value = Select_Product.Price;
                    newRow.Cells[4].Value = unitPrice;
                }
            }
            
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
