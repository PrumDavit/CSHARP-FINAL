namespace POS_BookShop
{
    partial class frmOrder
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbtPrice = new System.Windows.Forms.Label();
            this.PName = new System.Windows.Forms.Label();
            this.btnbuy = new Guna.UI2.WinForms.Guna2Button();
            this.PIcPro = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIcPro)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.lbtPrice);
            this.guna2Panel1.Controls.Add(this.PName);
            this.guna2Panel1.Controls.Add(this.btnbuy);
            this.guna2Panel1.Controls.Add(this.PIcPro);
            this.guna2Panel1.Location = new System.Drawing.Point(2, -3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(204, 226);
            this.guna2Panel1.TabIndex = 2;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // lbtPrice
            // 
            this.lbtPrice.AutoSize = true;
            this.lbtPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbtPrice.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtPrice.Location = new System.Drawing.Point(3, 152);
            this.lbtPrice.Name = "lbtPrice";
            this.lbtPrice.Size = new System.Drawing.Size(36, 19);
            this.lbtPrice.TabIndex = 4;
            this.lbtPrice.Text = "Price";
            // 
            // PName
            // 
            this.PName.AutoSize = true;
            this.PName.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PName.Location = new System.Drawing.Point(3, 133);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(83, 19);
            this.PName.TabIndex = 2;
            this.PName.Text = "Product Name";
            // 
            // btnbuy
            // 
            this.btnbuy.Animated = true;
            this.btnbuy.BorderRadius = 10;
            this.btnbuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnbuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnbuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnbuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnbuy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuy.ForeColor = System.Drawing.Color.White;
            this.btnbuy.Location = new System.Drawing.Point(26, 174);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(139, 49);
            this.btnbuy.TabIndex = 1;
            this.btnbuy.Text = "Buy";
            this.btnbuy.Click += new System.EventHandler(this.btnbuy_Click);
            // 
            // PIcPro
            // 
            this.PIcPro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PIcPro.Image = ((System.Drawing.Image)(resources.GetObject("PIcPro.Image")));
            this.PIcPro.ImageRotate = 0F;
            this.PIcPro.Location = new System.Drawing.Point(26, 3);
            this.PIcPro.Name = "PIcPro";
            this.PIcPro.Size = new System.Drawing.Size(156, 127);
            this.PIcPro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIcPro.TabIndex = 0;
            this.PIcPro.TabStop = false;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmOrder";
            this.Size = new System.Drawing.Size(209, 226);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIcPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbtPrice;
        private System.Windows.Forms.Label PName;
        private Guna.UI2.WinForms.Guna2Button btnbuy;
        private Guna.UI2.WinForms.Guna2PictureBox PIcPro;
    }
}
