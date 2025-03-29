using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace POS_BookShop
{
    public partial class frmOrders : Form
    {
        private decimal TotalAmount { get; set; }
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
                string sql = "SELECT BookID,BookName,Price FROM tblBooks;";
                SqlCommand s = new SqlCommand(sql, DataConnection.DataCon);
                SqlDataReader r = s.ExecuteReader();
                while (r.Read()) {
                    frmOrder FO = new frmOrder
                    {
                        BookID = Convert.ToInt32(r[0]),
                        ProductName = r[1].ToString(),
                        Price = r[2] != DBNull.Value ? Convert.ToDecimal(r["price"]).ToString("C2") : "N/A",
                    };
                    FO.AddItem += ProductCateItem;
                    flowLayoutPanel1.Controls.Add(FO);
                }
                s.Dispose();
                r.Close();
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void ProductCateItem(object sender, EventArgs e)
        {
            if (!(sender is frmOrder Select_Product) || Select_Product == null)
            {
                return;
            }

            bool PExist = false;
            foreach (DataGridViewRow row in Display.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == Select_Product.ProductName)
                {
                    int currentQty = Convert.ToInt32(row.Cells[2].Value); // Correct column for quantity
                    currentQty++;
                    row.Cells[2].Value = currentQty;

                    string priceText = Select_Product.Price.Replace("$", "").Replace("€", "").Trim();
                    if (decimal.TryParse(priceText, out decimal unitPrice))
                    {
                        row.Cells[4].Value = unitPrice * currentQty;
                    }

                    PExist = true;
                    break;
                }
            }
            int BookID = Select_Product.BookID;
            // If product doesn't exist, add a new row
            if (!PExist)
            {
                Display.RowTemplate.Height = 50;

                string priceText = Select_Product.Price.Replace("$", "").Replace("€", "").Trim();
                if (!decimal.TryParse(priceText, out decimal unitPrice))
                {
                    MessageBox.Show("Invalid product price format.");
                    return;
                }

                int rowIndex = Display.Rows.Add();
                DataGridViewRow newRow = Display.Rows[rowIndex];

                newRow.Cells[0].Value = rowIndex + 1; // No.
                newRow.Cells[1].Value = Select_Product.ProductName; // Product Name
                newRow.Cells[2].Value = 1; // Quantity
                newRow.Cells[3].Value = Select_Product.Price; // Unit Price (formatted)
                newRow.Cells[4].Value = unitPrice; // Total Price
                newRow.Cells[6].Value = BookID; // BookID
            }
            CalculateTotal();
        }


        private void frmOrders_Load(object sender, EventArgs e)
        {
            ProductCateItem(sender, e);
            LoadProduct();
        }
        private void CalculateTotal()
        {
            decimal SubTotal = 0;
            decimal TAX = 0;
            decimal Total = 0;

            foreach (DataGridViewRow row in Display.Rows)
            {
                if (row.Cells[4].Value != null && decimal.TryParse(row.Cells[4].Value.ToString(), out decimal rowAmount))
                {
                    SubTotal += rowAmount; // Summing up "Amount" column, not "Price"
                }
            }

            // Display SubTotal
            totalssub.Text = SubTotal.ToString("C2");

            // Calculate 10% Tax
            TAX = SubTotal * 0.1m;
            taxs.Text = TAX.ToString("C2");

            // Calculate Total
            Total = SubTotal + TAX;
            Amounts.Text = Total.ToString("C2");
        }
        private void UpdateStock()
        {
            foreach (DataGridViewRow row in Display.Rows)
            {
                int BookID = Convert.ToInt32(row.Cells[6].Value);
                int Qty = Convert.ToInt32(row.Cells[2].Value);

                // Correct SQL Query: Update Stock by subtracting the sold quantity
                string Query = "UPDATE tblBooks SET Stock = Stock - @Qty WHERE BookID = @ID;";

                using (SqlCommand cmd = new SqlCommand(Query,DataConnection.DataCon))
                {
                    cmd.Parameters.AddWithValue("@Qty", Qty);
                    cmd.Parameters.AddWithValue("@ID", BookID);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Stock Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private int InsertSalle(int Discount,decimal DisAmount,decimal TotalsAmount)
        {
            int SaleID = 0;
            try
            {
                string EmpID = frmlogin.EmpID;
                DateTime saleDate = DateTime.Now;

                string Query = @"
                INSERT INTO tblSales (SaleDate, Discount, DiscountAmount, TotalAmount, EmployeeID) 
                VALUES (@OrdDate, @Discount, @DiscountAmount, @TotalsAmount, @EmpID);
                SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(Query, DataConnection.DataCon))
                {
                    cmd.Parameters.AddWithValue("@OrdDate", saleDate);
                    cmd.Parameters.AddWithValue("@Discount", Discount);
                    cmd.Parameters.AddWithValue("@DiscountAmount",DisAmount);
                    cmd.Parameters.AddWithValue("@TotalsAmount", TotalsAmount);
                    cmd.Parameters.AddWithValue("@EmpID", EmpID);
                    cmd.ExecuteNonQuery();
                    SaleID = Convert.ToInt32(cmd.ExecuteScalar());

                }
                MessageBox.Show("Sale Inserted Successfully! Sale ID: " + SaleID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return SaleID;
        }
        private void InsertOrderDetails(int OrdID)
        {
            try
            {
                foreach (DataGridViewRow row in Display.Rows)
                {
                    int BookID = Convert.ToInt32(row.Cells[6].Value);
                    int Qty = Convert.ToInt32(row.Cells[2].Value);
                    decimal Price = Convert.ToDecimal(row.Cells[4].Value);

                    string Query = @"
                    INSERT INTO tblSaleDetails (SaleID,BookID,Quantity) VALUES (@SID,@BID,@Qty);";
                    using (SqlCommand cmd = new SqlCommand(Query, DataConnection.DataCon))
                    {
                        cmd.Parameters.AddWithValue("@SID", OrdID);
                        cmd.Parameters.AddWithValue("@BID", BookID);
                        cmd.Parameters.AddWithValue("@Qty", Qty);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Order Details Inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void InsertIncome(int SaleID,decimal Amount)
        {
            string Sql = "INSERT INTO tblIncome (DateIncome,Amount,SaleID) VALUES(@DI,@AN,@SD);";
            using (SqlCommand cmd =new SqlCommand(Sql, DataConnection.DataCon))
            {
                cmd.Parameters.AddWithValue("@DI", DateTime.Now);
                cmd.Parameters.AddWithValue("@AN", Amount);
                cmd.Parameters.AddWithValue("@SD", SaleID);
                cmd.ExecuteNonQuery();
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            Payments p = new Payments();

            // Remove unwanted characters and parse the total amount
            string amountText = Amounts.Text.Replace("$", "").Replace(",", "").Trim();
            if (decimal.TryParse(amountText, out decimal total))
            {
                p.TotalsAmount = total;
            }
            else
            {
                MessageBox.Show("Invalid total amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            p.ShowDialog();
            if (p.DialogResult == DialogResult.OK)
            {

                int SaleID = InsertSalle(p.Discount, p.DiscountPrice, p.TotalsPay);

                if (SaleID > 0) // Ensure the SaleID is valid
                {
                    UpdateStock();
                    InsertOrderDetails(SaleID);
                    InsertIncome(SaleID, p.TotalsPay);
                }
                else
                {
                    MessageBox.Show("Failed to insert sale!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Display.Rows.Clear();

            }
        }

    }
}
