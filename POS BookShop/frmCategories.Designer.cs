namespace POS_BookShop
{
    partial class frmCategories
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategories));
            this.DatagridviewCate = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_cateid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_catename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtcatename = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdes = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnupdate = new Guna.UI2.WinForms.Guna2Button();
            this.btndelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnadd = new Guna.UI2.WinForms.Guna2Button();
            this.btnbrowse = new Guna.UI2.WinForms.Guna2Button();
            this.Picture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridviewCate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatagridviewCate
            // 
            this.DatagridviewCate.AllowUserToAddRows = false;
            this.DatagridviewCate.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DatagridviewCate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridviewCate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DatagridviewCate.ColumnHeadersHeight = 40;
            this.DatagridviewCate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DatagridviewCate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cateid,
            this.col_catename,
            this.col_des,
            this.col_image});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagridviewCate.DefaultCellStyle = dataGridViewCellStyle3;
            this.DatagridviewCate.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DatagridviewCate.Location = new System.Drawing.Point(143, 389);
            this.DatagridviewCate.Name = "DatagridviewCate";
            this.DatagridviewCate.ReadOnly = true;
            this.DatagridviewCate.RowHeadersVisible = false;
            this.DatagridviewCate.Size = new System.Drawing.Size(1411, 491);
            this.DatagridviewCate.TabIndex = 83;
            this.DatagridviewCate.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DatagridviewCate.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DatagridviewCate.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DatagridviewCate.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DatagridviewCate.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DatagridviewCate.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DatagridviewCate.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DatagridviewCate.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DatagridviewCate.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DatagridviewCate.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatagridviewCate.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DatagridviewCate.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DatagridviewCate.ThemeStyle.HeaderStyle.Height = 40;
            this.DatagridviewCate.ThemeStyle.ReadOnly = true;
            this.DatagridviewCate.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DatagridviewCate.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DatagridviewCate.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatagridviewCate.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DatagridviewCate.ThemeStyle.RowsStyle.Height = 22;
            this.DatagridviewCate.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DatagridviewCate.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DatagridviewCate.Click += new System.EventHandler(this.DatagridviewCate_Click);
            // 
            // col_cateid
            // 
            this.col_cateid.HeaderText = "CategoriesID";
            this.col_cateid.Name = "col_cateid";
            this.col_cateid.ReadOnly = true;
            // 
            // col_catename
            // 
            this.col_catename.HeaderText = "CategoriesName";
            this.col_catename.Name = "col_catename";
            this.col_catename.ReadOnly = true;
            // 
            // col_des
            // 
            this.col_des.HeaderText = "Description";
            this.col_des.Name = "col_des";
            this.col_des.ReadOnly = true;
            // 
            // col_image
            // 
            this.col_image.HeaderText = "Image";
            this.col_image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_image.Name = "col_image";
            this.col_image.ReadOnly = true;
            // 
            // txtcatename
            // 
            this.txtcatename.BorderRadius = 10;
            this.txtcatename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcatename.DefaultText = "";
            this.txtcatename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcatename.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcatename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcatename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcatename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcatename.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcatename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcatename.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcatename.Location = new System.Drawing.Point(316, 155);
            this.txtcatename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcatename.Name = "txtcatename";
            this.txtcatename.PasswordChar = '\0';
            this.txtcatename.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtcatename.PlaceholderText = "Enter CategoriesName";
            this.txtcatename.SelectedText = "";
            this.txtcatename.Size = new System.Drawing.Size(279, 45);
            this.txtcatename.TabIndex = 85;
            this.txtcatename.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 84;
            this.label2.Text = "CategoriesName : ";
            // 
            // txtdes
            // 
            this.txtdes.BorderRadius = 10;
            this.txtdes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdes.DefaultText = "";
            this.txtdes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdes.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtdes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdes.Location = new System.Drawing.Point(316, 262);
            this.txtdes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdes.Name = "txtdes";
            this.txtdes.PasswordChar = '\0';
            this.txtdes.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtdes.PlaceholderText = "Enter Description";
            this.txtdes.SelectedText = "";
            this.txtdes.Size = new System.Drawing.Size(279, 45);
            this.txtdes.TabIndex = 87;
            this.txtdes.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 86;
            this.label1.Text = "Description : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(683, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 77);
            this.label3.TabIndex = 88;
            this.label3.Text = "Add Categories";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnupdate
            // 
            this.btnupdate.Animated = true;
            this.btnupdate.BorderRadius = 15;
            this.btnupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnupdate.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnupdate.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(985, 262);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(194, 45);
            this.btnupdate.TabIndex = 91;
            this.btnupdate.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Animated = true;
            this.btndelete.BorderRadius = 15;
            this.btndelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndelete.FillColor = System.Drawing.Color.Red;
            this.btndelete.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(985, 324);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(194, 45);
            this.btndelete.TabIndex = 90;
            this.btndelete.Text = "Delete";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Animated = true;
            this.btnadd.BorderRadius = 15;
            this.btnadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnadd.FillColor = System.Drawing.Color.MediumBlue;
            this.btnadd.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(1360, 262);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(194, 45);
            this.btnadd.TabIndex = 89;
            this.btnadd.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnbrowse
            // 
            this.btnbrowse.Animated = true;
            this.btnbrowse.BorderRadius = 15;
            this.btnbrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnbrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnbrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnbrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnbrowse.FillColor = System.Drawing.Color.SlateBlue;
            this.btnbrowse.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse.ForeColor = System.Drawing.Color.White;
            this.btnbrowse.Location = new System.Drawing.Point(630, 324);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(194, 45);
            this.btnbrowse.TabIndex = 93;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.Transparent;
            this.Picture.BorderRadius = 15;
            this.Picture.ImageRotate = 0F;
            this.Picture.Location = new System.Drawing.Point(630, 97);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(194, 221);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 92;
            this.Picture.TabStop = false;
            this.Picture.UseTransparentBackground = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1676, 91);
            this.panel1.TabIndex = 94;
            // 
            // txtsearch
            // 
            this.txtsearch.BorderRadius = 10;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.DefaultText = "";
            this.txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.txtsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtsearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtsearch.IconRight")));
            this.txtsearch.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtsearch.IconRightSize = new System.Drawing.Size(15, 15);
            this.txtsearch.Location = new System.Drawing.Point(1275, 324);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtsearch.PlaceholderText = "Search";
            this.txtsearch.SelectedText = "";
            this.txtsearch.Size = new System.Drawing.Size(279, 45);
            this.txtsearch.TabIndex = 95;
            this.txtsearch.TextOffset = new System.Drawing.Point(15, 0);
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyDown);
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 892);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcatename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatagridviewCate);
            this.Name = "frmCategories";
            this.Text = "frmCategories";
            this.Load += new System.EventHandler(this.frmCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridviewCate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DatagridviewCate;
        private Guna.UI2.WinForms.Guna2TextBox txtcatename;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtdes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnupdate;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Guna.UI2.WinForms.Guna2Button btnadd;
        private Guna.UI2.WinForms.Guna2Button btnbrowse;
        private Guna.UI2.WinForms.Guna2PictureBox Picture;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cateid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_catename;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_des;
        private System.Windows.Forms.DataGridViewImageColumn col_image;
    }
}