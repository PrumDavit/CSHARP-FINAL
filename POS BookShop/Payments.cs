using System;
using System.Globalization;
using System.Windows.Forms;

namespace POS_BookShop
{
    public partial class Payments : Form
    {
        public decimal TotalsAmount { get; set; }
        public decimal DiscountPrice { get; set; }
        public int Discount { get; set; }
        public decimal TotalsPay { get; set; }
        public decimal Cash_Received { get; set; }
        public decimal CashReturned { get; set; }

        public Payments()
        {
            InitializeComponent();
        }

        private void btnpayments_Click(object sender, EventArgs e)
        {
            if (TotalsPay <= 0 || string.IsNullOrEmpty(txtCashReceived.Text))
            {
                MessageBox.Show("Total payment must be greater than zero!", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Cash_Received < TotalsPay)
            {
                MessageBox.Show("Insufficient cash received!", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Confirm Payment?", "Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            if (TotalsAmount > 0)
            {
                txtsubtotals.Text = TotalsAmount.ToString("C2");
                ApplyDiscount();
            }
            else
            {
                txtsubtotals.Text = "$0.00";
            }
        }

        private void ApplyDiscount()
        {
            if (Discount > 0)
            {
                DiscountPrice = (TotalsAmount * Discount) / 100m;
            }
            else
            {
                DiscountPrice = 0;
            }

            TotalsPay = TotalsAmount - DiscountPrice;
            txtDiscountAmount.Text = DiscountPrice.ToString("C2");
            txtTotalspayments.Text = TotalsPay.ToString("C2");
        }

        private void txtDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtDiscount.SelectedItem == null) return;

            string dis = txtDiscount.SelectedItem.ToString();
            bool isPercentage = dis.EndsWith("%");
            string numberPart = isPercentage ? dis.TrimEnd('%') : dis;

            if (int.TryParse(numberPart, out int parsedValue))
            {
                Discount = parsedValue;
                ApplyDiscount();
            }
            else
            {
                MessageBox.Show("Invalid discount format.");
                DiscountPrice = 0;
            }
        }

        private void txtCashReceived_KeyUp(object sender, KeyEventArgs e)
        {
            string cashReceivedStr = txtCashReceived.Text.Trim();

            if (string.IsNullOrEmpty(cashReceivedStr))
            {
                txtCashReturned.Text = "$0.00";
                return;
            }

            if (decimal.TryParse(cashReceivedStr, NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite,
                                 CultureInfo.CurrentCulture, out decimal cashReceived))
            {
                Cash_Received = cashReceived;
                decimal change = cashReceived - TotalsPay;

                if (change >= 0)
                {
                    txtCashReturned.Text = change.ToString("C2");
                }
                else
                {
                    txtCashReturned.Text = $"Due: {Math.Abs(change).ToString("C2")}";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid currency amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCashReceived.Text = string.Empty;
                txtCashReturned.Text = "$0.00";
            }
        }
    }
}
