using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_BookShop
{
    public partial class frmOrder : UserControl
    {
        public event EventHandler AddItem;
        public frmOrder()
        {
            InitializeComponent();
        }
        public new string ProductName
        {
            get =>PName.Text;
            set =>PName.Text = value;
        }
        public string Price
        {
            get => lbtPrice.Text;
            set => lbtPrice.Text = value;
        }
        public int BookID { get; set; }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            if (AddItem != null)
            {
                AddItem.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("No event handler attached to AddItem!");
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
