namespace POS_BookShop
{
    partial class frmEmployee
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
            this.btnbrowse = new Guna.UI2.WinForms.Guna2Button();
            this.Picture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbgender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hiredate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtphone = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbrole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Roles = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnadd = new Guna.UI2.WinForms.Guna2Button();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtsalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.DatagridviewEmp = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btndelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnupdate = new Guna.UI2.WinForms.Guna2Button();
            this.txtaddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.col_empid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_img = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hiredate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridviewEmp)).BeginInit();
            this.SuspendLayout();
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
            this.btnbrowse.Location = new System.Drawing.Point(1346, 257);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(194, 45);
            this.btnbrowse.TabIndex = 59;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.Transparent;
            this.Picture.BorderRadius = 15;
            this.Picture.ImageRotate = 0F;
            this.Picture.Location = new System.Drawing.Point(1346, 14);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(194, 237);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 58;
            this.Picture.TabStop = false;
            this.Picture.UseTransparentBackground = true;
            this.Picture.Click += new System.EventHandler(this.Picture_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(823, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Gender : ";
            // 
            // cbbgender
            // 
            this.cbbgender.BackColor = System.Drawing.Color.Transparent;
            this.cbbgender.BorderRadius = 10;
            this.cbbgender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbgender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbgender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbgender.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbgender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbgender.ItemHeight = 38;
            this.cbbgender.Items.AddRange(new object[] {
            "Male",
            "Felmale"});
            this.cbbgender.Location = new System.Drawing.Point(964, 15);
            this.cbbgender.Name = "cbbgender";
            this.cbbgender.Size = new System.Drawing.Size(279, 44);
            this.cbbgender.TabIndex = 40;
            this.cbbgender.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // txtName
            // 
            this.txtName.BorderRadius = 10;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(239, 14);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtName.PlaceholderText = "Enter Your Fullname";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(279, 45);
            this.txtName.TabIndex = 33;
            this.txtName.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fullname : ";
            // 
            // DOB
            // 
            this.DOB.Animated = true;
            this.DOB.BackColor = System.Drawing.Color.Transparent;
            this.DOB.BorderRadius = 10;
            this.DOB.Checked = true;
            this.DOB.FillColor = System.Drawing.Color.White;
            this.DOB.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DOB.IndicateFocus = true;
            this.DOB.Location = new System.Drawing.Point(239, 179);
            this.DOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DOB.Name = "DOB";
            this.DOB.ShowUpDown = true;
            this.DOB.Size = new System.Drawing.Size(279, 44);
            this.DOB.TabIndex = 42;
            this.DOB.UseTransparentBackground = true;
            this.DOB.Value = new System.DateTime(2025, 2, 8, 23, 48, 12, 381);
            // 
            // txtusername
            // 
            this.txtusername.BorderRadius = 10;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.DefaultText = "";
            this.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.Location = new System.Drawing.Point(239, 98);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtusername.PlaceholderText = "Enter Your Username";
            this.txtusername.SelectedText = "";
            this.txtusername.Size = new System.Drawing.Size(279, 45);
            this.txtusername.TabIndex = 62;
            this.txtusername.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 63;
            this.label3.Text = "Username : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(787, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 66;
            this.label5.Text = "Password : ";
            // 
            // txtpassword
            // 
            this.txtpassword.BorderRadius = 10;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.DefaultText = "";
            this.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.Location = new System.Drawing.Point(964, 98);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtpassword.PlaceholderText = "Enter Your Password";
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(279, 45);
            this.txtpassword.TabIndex = 65;
            this.txtpassword.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 23);
            this.label7.TabIndex = 67;
            this.label7.Text = "Date Of Birth : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(810, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 69;
            this.label4.Text = "Hire Date : ";
            // 
            // hiredate
            // 
            this.hiredate.Animated = true;
            this.hiredate.BackColor = System.Drawing.Color.Transparent;
            this.hiredate.BorderRadius = 10;
            this.hiredate.Checked = true;
            this.hiredate.FillColor = System.Drawing.Color.White;
            this.hiredate.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiredate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.hiredate.IndicateFocus = true;
            this.hiredate.Location = new System.Drawing.Point(964, 179);
            this.hiredate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.hiredate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.hiredate.Name = "hiredate";
            this.hiredate.ShowUpDown = true;
            this.hiredate.Size = new System.Drawing.Size(279, 44);
            this.hiredate.TabIndex = 68;
            this.hiredate.UseTransparentBackground = true;
            this.hiredate.Value = new System.DateTime(2025, 2, 8, 23, 48, 12, 381);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(829, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 23);
            this.label9.TabIndex = 73;
            this.label9.Text = "Phone : ";
            // 
            // txtphone
            // 
            this.txtphone.BorderRadius = 10;
            this.txtphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphone.DefaultText = "";
            this.txtphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphone.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphone.Location = new System.Drawing.Point(964, 257);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtphone.Name = "txtphone";
            this.txtphone.PasswordChar = '\0';
            this.txtphone.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtphone.PlaceholderText = "Enter Your Phone Number";
            this.txtphone.SelectedText = "";
            this.txtphone.Size = new System.Drawing.Size(279, 45);
            this.txtphone.TabIndex = 72;
            this.txtphone.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // cbbrole
            // 
            this.cbbrole.BackColor = System.Drawing.Color.Transparent;
            this.cbbrole.BorderRadius = 10;
            this.cbbrole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbrole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbrole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbrole.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.cbbrole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbrole.ItemHeight = 38;
            this.cbbrole.Items.AddRange(new object[] {
            "Admin",
            "Sale"});
            this.cbbrole.Location = new System.Drawing.Point(239, 336);
            this.cbbrole.Name = "cbbrole";
            this.cbbrole.Size = new System.Drawing.Size(279, 44);
            this.cbbrole.TabIndex = 74;
            this.cbbrole.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 23);
            this.label8.TabIndex = 71;
            this.label8.Text = "Email : ";
            // 
            // Roles
            // 
            this.Roles.AutoSize = true;
            this.Roles.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roles.Location = new System.Drawing.Point(93, 346);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(48, 23);
            this.Roles.TabIndex = 75;
            this.Roles.Text = "Role : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(816, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 23);
            this.label10.TabIndex = 77;
            this.label10.Text = "Address : ";
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
            this.btnadd.Location = new System.Drawing.Point(1049, 417);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(194, 45);
            this.btnadd.TabIndex = 78;
            this.btnadd.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtemail
            // 
            this.txtemail.BorderRadius = 10;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.DefaultText = "";
            this.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Location = new System.Drawing.Point(239, 257);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtemail.PlaceholderText = "Enter Your Email";
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(279, 45);
            this.txtemail.TabIndex = 79;
            this.txtemail.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(83, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 23);
            this.label11.TabIndex = 81;
            this.label11.Text = "Salary : ";
            // 
            // txtsalary
            // 
            this.txtsalary.BorderRadius = 10;
            this.txtsalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsalary.DefaultText = "";
            this.txtsalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsalary.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsalary.Location = new System.Drawing.Point(239, 417);
            this.txtsalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.PasswordChar = '\0';
            this.txtsalary.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtsalary.PlaceholderText = "Enter Your Salary";
            this.txtsalary.SelectedText = "";
            this.txtsalary.Size = new System.Drawing.Size(279, 45);
            this.txtsalary.TabIndex = 80;
            this.txtsalary.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // DatagridviewEmp
            // 
            this.DatagridviewEmp.AllowUserToAddRows = false;
            this.DatagridviewEmp.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DatagridviewEmp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridviewEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DatagridviewEmp.ColumnHeadersHeight = 40;
            this.DatagridviewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DatagridviewEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_empid,
            this.col_name,
            this.col_username,
            this.col_password,
            this.col_gender,
            this.col_img,
            this.col_dob,
            this.col_role,
            this.col_hiredate,
            this.col_email,
            this.col_phone,
            this.col_salary,
            this.col_address});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagridviewEmp.DefaultCellStyle = dataGridViewCellStyle3;
            this.DatagridviewEmp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DatagridviewEmp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DatagridviewEmp.Location = new System.Drawing.Point(0, 544);
            this.DatagridviewEmp.Name = "DatagridviewEmp";
            this.DatagridviewEmp.ReadOnly = true;
            this.DatagridviewEmp.RowHeadersVisible = false;
            this.DatagridviewEmp.Size = new System.Drawing.Size(1617, 389);
            this.DatagridviewEmp.TabIndex = 82;
            this.DatagridviewEmp.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DatagridviewEmp.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DatagridviewEmp.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DatagridviewEmp.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DatagridviewEmp.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DatagridviewEmp.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DatagridviewEmp.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DatagridviewEmp.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DatagridviewEmp.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DatagridviewEmp.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatagridviewEmp.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DatagridviewEmp.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DatagridviewEmp.ThemeStyle.HeaderStyle.Height = 40;
            this.DatagridviewEmp.ThemeStyle.ReadOnly = true;
            this.DatagridviewEmp.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DatagridviewEmp.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DatagridviewEmp.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatagridviewEmp.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DatagridviewEmp.ThemeStyle.RowsStyle.Height = 22;
            this.DatagridviewEmp.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DatagridviewEmp.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DatagridviewEmp.Click += new System.EventHandler(this.DatagridviewEmp_Click);
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
            this.btndelete.Location = new System.Drawing.Point(849, 417);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(194, 45);
            this.btndelete.TabIndex = 83;
            this.btndelete.Text = "Delete";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
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
            this.btnupdate.Location = new System.Drawing.Point(649, 417);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(194, 45);
            this.btnupdate.TabIndex = 84;
            this.btnupdate.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.BorderRadius = 10;
            this.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaddress.DefaultText = "";
            this.txtaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtaddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtaddress.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtaddress.Location = new System.Drawing.Point(964, 336);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtaddress.PlaceholderText = "Enter Your Address";
            this.txtaddress.SelectedText = "";
            this.txtaddress.Size = new System.Drawing.Size(279, 45);
            this.txtaddress.TabIndex = 85;
            this.txtaddress.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // col_empid
            // 
            this.col_empid.HeaderText = "EmpID";
            this.col_empid.Name = "col_empid";
            this.col_empid.ReadOnly = true;
            // 
            // col_name
            // 
            this.col_name.HeaderText = "Name";
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            // 
            // col_username
            // 
            this.col_username.HeaderText = "Username";
            this.col_username.Name = "col_username";
            this.col_username.ReadOnly = true;
            // 
            // col_password
            // 
            this.col_password.HeaderText = "Password";
            this.col_password.Name = "col_password";
            this.col_password.ReadOnly = true;
            // 
            // col_gender
            // 
            this.col_gender.HeaderText = "Gender";
            this.col_gender.Name = "col_gender";
            this.col_gender.ReadOnly = true;
            // 
            // col_img
            // 
            this.col_img.HeaderText = "Image";
            this.col_img.Name = "col_img";
            this.col_img.ReadOnly = true;
            // 
            // col_dob
            // 
            this.col_dob.HeaderText = "Daate Of Birth";
            this.col_dob.Name = "col_dob";
            this.col_dob.ReadOnly = true;
            // 
            // col_role
            // 
            this.col_role.HeaderText = "Role";
            this.col_role.Name = "col_role";
            this.col_role.ReadOnly = true;
            // 
            // col_hiredate
            // 
            this.col_hiredate.HeaderText = "HireDate";
            this.col_hiredate.Name = "col_hiredate";
            this.col_hiredate.ReadOnly = true;
            // 
            // col_email
            // 
            this.col_email.HeaderText = "Email";
            this.col_email.Name = "col_email";
            this.col_email.ReadOnly = true;
            // 
            // col_phone
            // 
            this.col_phone.HeaderText = "Phone";
            this.col_phone.Name = "col_phone";
            this.col_phone.ReadOnly = true;
            // 
            // col_salary
            // 
            this.col_salary.HeaderText = "Salary";
            this.col_salary.Name = "col_salary";
            this.col_salary.ReadOnly = true;
            // 
            // col_address
            // 
            this.col_address.HeaderText = "Address";
            this.col_address.Name = "col_address";
            this.col_address.ReadOnly = true;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 933);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.DatagridviewEmp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Roles);
            this.Controls.Add(this.cbbrole);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hiredate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbgender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridviewEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnbrowse;
        private Guna.UI2.WinForms.Guna2PictureBox Picture;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cbbgender;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DOB;
        private Guna.UI2.WinForms.Guna2TextBox txtusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker hiredate;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtphone;
        private Guna.UI2.WinForms.Guna2ComboBox cbbrole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Roles;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btnadd;
        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtsalary;
        private Guna.UI2.WinForms.Guna2DataGridView DatagridviewEmp;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Guna.UI2.WinForms.Guna2Button btnupdate;
        private Guna.UI2.WinForms.Guna2TextBox txtaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_empid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gender;
        private System.Windows.Forms.DataGridViewImageColumn col_img;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_role;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hiredate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_address;
    }
}