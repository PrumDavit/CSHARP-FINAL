namespace POS_BookShop
{
    partial class frmlogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkShowHidePassword = new System.Windows.Forms.CheckBox();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(631, 632);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Animated = true;
            this.txtUsername.AutoRoundedCorners = true;
            this.txtUsername.BorderRadius = 20;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.txtUsername.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtUsername.IconRight = ((System.Drawing.Image)(resources.GetObject("txtUsername.IconRight")));
            this.txtUsername.IconRightOffset = new System.Drawing.Point(13, 0);
            this.txtUsername.IconRightSize = new System.Drawing.Size(25, 25);
            this.txtUsername.Location = new System.Drawing.Point(771, 181);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtUsername.PlaceholderText = "Enter Your Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(328, 44);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(682, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome To BookShop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(884, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Log in";
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.AutoRoundedCorners = true;
            this.txtPassword.BorderRadius = 20;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.txtPassword.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtPassword.IconRight = ((System.Drawing.Image)(resources.GetObject("txtPassword.IconRight")));
            this.txtPassword.IconRightOffset = new System.Drawing.Point(13, 0);
            this.txtPassword.Location = new System.Drawing.Point(771, 254);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPassword.PlaceholderText = "Enter Your Pasword";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(328, 44);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // checkShowHidePassword
            // 
            this.checkShowHidePassword.AutoSize = true;
            this.checkShowHidePassword.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkShowHidePassword.Location = new System.Drawing.Point(970, 305);
            this.checkShowHidePassword.Name = "checkShowHidePassword";
            this.checkShowHidePassword.Size = new System.Drawing.Size(129, 27);
            this.checkShowHidePassword.TabIndex = 6;
            this.checkShowHidePassword.Text = "Show Password";
            this.checkShowHidePassword.UseVisualStyleBackColor = true;
            this.checkShowHidePassword.CheckedChanged += new System.EventHandler(this.checkShowHidePassword_CheckedChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.Animated = true;
            this.btnlogin.AutoRoundedCorners = true;
            this.btnlogin.BorderRadius = 21;
            this.btnlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlogin.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(771, 454);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(328, 44);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "Login";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(790, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Your Role";
            // 
            // cbbRole
            // 
            this.cbbRole.BackColor = System.Drawing.Color.Transparent;
            this.cbbRole.BorderRadius = 15;
            this.cbbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbRole.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbRole.ItemHeight = 30;
            this.cbbRole.Location = new System.Drawing.Point(771, 391);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(328, 36);
            this.cbbRole.TabIndex = 12;
            this.cbbRole.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 632);
            this.Controls.Add(this.cbbRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.checkShowHidePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.CheckBox checkShowHidePassword;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbbRole;
    }
}

