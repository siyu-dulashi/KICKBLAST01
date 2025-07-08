namespace KICKBLAST01
{
    partial class Form3
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
            this.lblUname = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.link_Forgetpass = new System.Windows.Forms.LinkLabel();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.linkwww = new System.Windows.Forms.LinkLabel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblKIck = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.gunaArrow = new Guna.UI2.WinForms.Guna2ImageButton();
            this.gunaClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.BackColor = System.Drawing.Color.Transparent;
            this.lblUname.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUname.ForeColor = System.Drawing.Color.Navy;
            this.lblUname.Location = new System.Drawing.Point(686, 208);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(96, 24);
            this.lblUname.TabIndex = 0;
            this.lblUname.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Navy;
            this.lblPassword.Location = new System.Drawing.Point(692, 317);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 24);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(690, 249);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(259, 24);
            this.txtUname.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(690, 357);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(261, 24);
            this.txtPassword.TabIndex = 3;
            // 
            // link_Forgetpass
            // 
            this.link_Forgetpass.AutoSize = true;
            this.link_Forgetpass.BackColor = System.Drawing.Color.Transparent;
            this.link_Forgetpass.Location = new System.Drawing.Point(757, 450);
            this.link_Forgetpass.Name = "link_Forgetpass";
            this.link_Forgetpass.Size = new System.Drawing.Size(131, 18);
            this.link_Forgetpass.TabIndex = 4;
            this.link_Forgetpass.TabStop = true;
            this.link_Forgetpass.Text = "Forgot Password?";
            this.link_Forgetpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Forgetpass_LinkClicked);
            // 
            // chkShow
            // 
            this.chkShow.AutoSize = true;
            this.chkShow.BackColor = System.Drawing.Color.Transparent;
            this.chkShow.Location = new System.Drawing.Point(863, 402);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(139, 22);
            this.chkShow.TabIndex = 5;
            this.chkShow.Text = "Show Password";
            this.chkShow.UseVisualStyleBackColor = false;
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Lime;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Green;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(819, 498);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(168, 49);
            this.guna2GradientButton1.TabIndex = 7;
            this.guna2GradientButton1.Text = "Login";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // linkwww
            // 
            this.linkwww.AutoSize = true;
            this.linkwww.Location = new System.Drawing.Point(88, 559);
            this.linkwww.Name = "linkwww";
            this.linkwww.Size = new System.Drawing.Size(173, 18);
            this.linkwww.TabIndex = 17;
            this.linkwww.TabStop = true;
            this.linkwww.Text = "www.KickBlast judo.com";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(337, 559);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(189, 18);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "N07,Colombo Road,Chilaw";
            // 
            // lblKIck
            // 
            this.lblKIck.AutoSize = true;
            this.lblKIck.Location = new System.Drawing.Point(337, 508);
            this.lblKIck.Name = "lblKIck";
            this.lblKIck.Size = new System.Drawing.Size(150, 18);
            this.lblKIck.TabIndex = 15;
            this.lblKIck.Text = "kickblast@gmail.com";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(88, 508);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(109, 18);
            this.lblNo.TabIndex = 14;
            this.lblNo.Text = "+94 710745651";
            // 
            // gunaArrow
            // 
            this.gunaArrow.BackColor = System.Drawing.Color.Transparent;
            this.gunaArrow.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaArrow.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaArrow.Image = global::KICKBLAST01.Properties.Resources._888888;
            this.gunaArrow.ImageOffset = new System.Drawing.Point(0, 0);
            this.gunaArrow.ImageRotate = 0F;
            this.gunaArrow.Location = new System.Drawing.Point(-1, -1);
            this.gunaArrow.Name = "gunaArrow";
            this.gunaArrow.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaArrow.Size = new System.Drawing.Size(79, 88);
            this.gunaArrow.TabIndex = 110;
            this.gunaArrow.Click += new System.EventHandler(this.gunaArrow_Click);
            // 
            // gunaClose
            // 
            this.gunaClose.BackColor = System.Drawing.Color.Transparent;
            this.gunaClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaClose.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaClose.Image = global::KICKBLAST01.Properties.Resources.c2;
            this.gunaClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.gunaClose.ImageRotate = 0F;
            this.gunaClose.Location = new System.Drawing.Point(1011, -1);
            this.gunaClose.Name = "gunaClose";
            this.gunaClose.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaClose.Size = new System.Drawing.Size(79, 88);
            this.gunaClose.TabIndex = 111;
            this.gunaClose.Click += new System.EventHandler(this.gunaClose_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KICKBLAST01.Properties.Resources.A21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 608);
            this.Controls.Add(this.gunaClose);
            this.Controls.Add(this.gunaArrow);
            this.Controls.Add(this.linkwww);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblKIck);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.link_Forgetpass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel link_Forgetpass;
        private System.Windows.Forms.CheckBox chkShow;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.LinkLabel linkwww;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblKIck;
        private System.Windows.Forms.Label lblNo;
        private Guna.UI2.WinForms.Guna2ImageButton gunaArrow;
        private Guna.UI2.WinForms.Guna2ImageButton gunaClose;
    }
}