namespace KICKBLAST01
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.link_Forget = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAId = new System.Windows.Forms.Label();
            this.txtAid = new System.Windows.Forms.TextBox();
            this.btn_Login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.linkwww = new System.Windows.Forms.LinkLabel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblKIck = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.gunaArrow = new Guna.UI2.WinForms.Guna2ImageButton();
            this.gunaClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(651, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Login";
            // 
            // chkShow
            // 
            this.chkShow.AutoSize = true;
            this.chkShow.BackColor = System.Drawing.Color.Transparent;
            this.chkShow.Location = new System.Drawing.Point(852, 400);
            this.chkShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(125, 20);
            this.chkShow.TabIndex = 9;
            this.chkShow.Text = "Show Password";
            this.chkShow.UseVisualStyleBackColor = false;
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);
            // 
            // link_Forget
            // 
            this.link_Forget.AutoSize = true;
            this.link_Forget.BackColor = System.Drawing.Color.Transparent;
            this.link_Forget.Location = new System.Drawing.Point(751, 435);
            this.link_Forget.Name = "link_Forget";
            this.link_Forget.Size = new System.Drawing.Size(116, 16);
            this.link_Forget.TabIndex = 8;
            this.link_Forget.TabStop = true;
            this.link_Forget.Text = "Forgot Password?";
            this.link_Forget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Forget_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(684, 362);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(277, 22);
            this.txtPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Navy;
            this.lblPassword.Location = new System.Drawing.Point(681, 317);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 24);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // lblAId
            // 
            this.lblAId.AutoSize = true;
            this.lblAId.BackColor = System.Drawing.Color.Transparent;
            this.lblAId.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAId.ForeColor = System.Drawing.Color.Navy;
            this.lblAId.Location = new System.Drawing.Point(681, 205);
            this.lblAId.Name = "lblAId";
            this.lblAId.Size = new System.Drawing.Size(91, 24);
            this.lblAId.TabIndex = 10;
            this.lblAId.Text = "Admin ID";
            // 
            // txtAid
            // 
            this.txtAid.Location = new System.Drawing.Point(684, 251);
            this.txtAid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAid.Name = "txtAid";
            this.txtAid.Size = new System.Drawing.Size(277, 22);
            this.txtAid.TabIndex = 11;
            // 
            // btn_Login
            // 
            this.btn_Login.AutoRoundedCorners = true;
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Login.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Login.FillColor = System.Drawing.Color.Lime;
            this.btn_Login.FillColor2 = System.Drawing.Color.Green;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(819, 501);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(170, 54);
            this.btn_Login.TabIndex = 19;
            this.btn_Login.Text = "Login";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // linkwww
            // 
            this.linkwww.AutoSize = true;
            this.linkwww.Location = new System.Drawing.Point(98, 559);
            this.linkwww.Name = "linkwww";
            this.linkwww.Size = new System.Drawing.Size(150, 16);
            this.linkwww.TabIndex = 24;
            this.linkwww.TabStop = true;
            this.linkwww.Text = "www.KickBlast judo.com";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(345, 559);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(168, 16);
            this.lblAddress.TabIndex = 23;
            this.lblAddress.Text = "N07,Colombo Road,Chilaw";
            // 
            // lblKIck
            // 
            this.lblKIck.AutoSize = true;
            this.lblKIck.Location = new System.Drawing.Point(345, 510);
            this.lblKIck.Name = "lblKIck";
            this.lblKIck.Size = new System.Drawing.Size(136, 16);
            this.lblKIck.TabIndex = 22;
            this.lblKIck.Text = "kickblast@gmail.com";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(98, 510);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(94, 16);
            this.lblNo.TabIndex = 21;
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
            this.gunaArrow.Location = new System.Drawing.Point(1, -2);
            this.gunaArrow.Name = "gunaArrow";
            this.gunaArrow.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaArrow.Size = new System.Drawing.Size(78, 83);
            this.gunaArrow.TabIndex = 111;
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
            this.gunaClose.Location = new System.Drawing.Point(1009, -4);
            this.gunaClose.Name = "gunaClose";
            this.gunaClose.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaClose.Size = new System.Drawing.Size(81, 85);
            this.gunaClose.TabIndex = 112;
            this.gunaClose.Click += new System.EventHandler(this.gunaClose_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KICKBLAST01.Properties.Resources.A2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 608);
            this.Controls.Add(this.gunaClose);
            this.Controls.Add(this.gunaArrow);
            this.Controls.Add(this.linkwww);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblKIck);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txtAid);
            this.Controls.Add(this.lblAId);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.link_Forget);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "ALogin";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.LinkLabel link_Forget;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAId;
        private System.Windows.Forms.TextBox txtAid;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Login;
        private System.Windows.Forms.LinkLabel linkwww;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblKIck;
        private System.Windows.Forms.Label lblNo;
        private Guna.UI2.WinForms.Guna2ImageButton gunaArrow;
        private Guna.UI2.WinForms.Guna2ImageButton gunaClose;
    }
}