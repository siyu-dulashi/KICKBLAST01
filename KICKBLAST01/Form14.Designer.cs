namespace KICKBLAST01
{
    partial class Form14
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnComap = new System.Windows.Forms.Button();
            this.btnFee = new System.Windows.Forms.Button();
            this.btnComp = new System.Windows.Forms.Button();
            this.btnPcoach = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblAid = new System.Windows.Forms.Label();
            this.lblAtheltesR = new System.Windows.Forms.Label();
            this.gunaArrow = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblAname = new System.Windows.Forms.Label();
            this.txtAthletename = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.dgvReg = new System.Windows.Forms.DataGridView();
            this.txtAId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReg)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::KICKBLAST01.Properties.Resources.kick_blast_logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 58);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // btnComap
            // 
            this.btnComap.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnComap.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComap.Location = new System.Drawing.Point(67, 354);
            this.btnComap.Name = "btnComap";
            this.btnComap.Size = new System.Drawing.Size(223, 39);
            this.btnComap.TabIndex = 50;
            this.btnComap.Text = "Compatition Apply";
            this.btnComap.UseVisualStyleBackColor = false;
            this.btnComap.Click += new System.EventHandler(this.btnComap_Click);
            // 
            // btnFee
            // 
            this.btnFee.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFee.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFee.Location = new System.Drawing.Point(67, 434);
            this.btnFee.Name = "btnFee";
            this.btnFee.Size = new System.Drawing.Size(223, 39);
            this.btnFee.TabIndex = 49;
            this.btnFee.Text = "Monthly Fee";
            this.btnFee.UseVisualStyleBackColor = false;
            this.btnFee.Click += new System.EventHandler(this.btnFee_Click);
            // 
            // btnComp
            // 
            this.btnComp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnComp.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComp.Location = new System.Drawing.Point(67, 278);
            this.btnComp.Name = "btnComp";
            this.btnComp.Size = new System.Drawing.Size(223, 39);
            this.btnComp.TabIndex = 48;
            this.btnComp.Text = "Compatition";
            this.btnComp.UseVisualStyleBackColor = false;
            this.btnComp.Click += new System.EventHandler(this.btnComp_Click);
            // 
            // btnPcoach
            // 
            this.btnPcoach.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPcoach.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPcoach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPcoach.Location = new System.Drawing.Point(67, 197);
            this.btnPcoach.Name = "btnPcoach";
            this.btnPcoach.Size = new System.Drawing.Size(223, 39);
            this.btnPcoach.TabIndex = 47;
            this.btnPcoach.Text = "Private Coaching";
            this.btnPcoach.UseVisualStyleBackColor = false;
            this.btnPcoach.Click += new System.EventHandler(this.btnPcoach_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.OrangeRed;
            this.btnReg.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReg.Location = new System.Drawing.Point(67, 117);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(223, 39);
            this.btnReg.TabIndex = 46;
            this.btnReg.Text = "Atheltes Registration view";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(874, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 33);
            this.btnSearch.TabIndex = 71;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // lblAid
            // 
            this.lblAid.AutoSize = true;
            this.lblAid.BackColor = System.Drawing.Color.Transparent;
            this.lblAid.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAid.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblAid.Location = new System.Drawing.Point(403, 80);
            this.lblAid.Name = "lblAid";
            this.lblAid.Size = new System.Drawing.Size(87, 23);
            this.lblAid.TabIndex = 69;
            this.lblAid.Text = "Athlete ID";
            // 
            // lblAtheltesR
            // 
            this.lblAtheltesR.AutoSize = true;
            this.lblAtheltesR.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtheltesR.Location = new System.Drawing.Point(550, 30);
            this.lblAtheltesR.Name = "lblAtheltesR";
            this.lblAtheltesR.Size = new System.Drawing.Size(278, 27);
            this.lblAtheltesR.TabIndex = 68;
            this.lblAtheltesR.Text = "Atheltes Registration view";
            // 
            // gunaArrow
            // 
            this.gunaArrow.BackColor = System.Drawing.Color.Transparent;
            this.gunaArrow.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaArrow.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaArrow.Image = global::KICKBLAST01.Properties.Resources._888888;
            this.gunaArrow.ImageOffset = new System.Drawing.Point(0, 0);
            this.gunaArrow.ImageRotate = 0F;
            this.gunaArrow.Location = new System.Drawing.Point(0, 479);
            this.gunaArrow.Name = "gunaArrow";
            this.gunaArrow.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaArrow.Size = new System.Drawing.Size(92, 79);
            this.gunaArrow.TabIndex = 109;
            this.gunaArrow.Click += new System.EventHandler(this.gunaArrow_Click_1);
            // 
            // lblAname
            // 
            this.lblAname.AutoSize = true;
            this.lblAname.BackColor = System.Drawing.Color.Transparent;
            this.lblAname.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAname.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblAname.Location = new System.Drawing.Point(403, 115);
            this.lblAname.Name = "lblAname";
            this.lblAname.Size = new System.Drawing.Size(116, 23);
            this.lblAname.TabIndex = 110;
            this.lblAname.Text = "Athlete Name";
            // 
            // txtAthletename
            // 
            this.txtAthletename.Location = new System.Drawing.Point(555, 117);
            this.txtAthletename.Name = "txtAthletename";
            this.txtAthletename.Size = new System.Drawing.Size(268, 22);
            this.txtAthletename.TabIndex = 111;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(556, 151);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(169, 22);
            this.txtPassword.TabIndex = 113;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblPass.Location = new System.Drawing.Point(403, 151);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(133, 23);
            this.lblPass.TabIndex = 114;
            this.lblPass.Text = "Registration NO";
            // 
            // dgvReg
            // 
            this.dgvReg.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dgvReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReg.Location = new System.Drawing.Point(365, 246);
            this.dgvReg.Name = "dgvReg";
            this.dgvReg.RowHeadersWidth = 51;
            this.dgvReg.RowTemplate.Height = 24;
            this.dgvReg.Size = new System.Drawing.Size(708, 254);
            this.dgvReg.TabIndex = 115;
            // 
            // txtAId
            // 
            this.txtAId.Location = new System.Drawing.Point(555, 80);
            this.txtAId.Name = "txtAId";
            this.txtAId.Size = new System.Drawing.Size(89, 22);
            this.txtAId.TabIndex = 116;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KICKBLAST01.Properties.Resources.A6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 561);
            this.Controls.Add(this.txtAId);
            this.Controls.Add(this.dgvReg);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAthletename);
            this.Controls.Add(this.lblAname);
            this.Controls.Add(this.gunaArrow);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblAid);
            this.Controls.Add(this.lblAtheltesR);
            this.Controls.Add(this.btnComap);
            this.Controls.Add(this.btnFee);
            this.Controls.Add(this.btnComp);
            this.Controls.Add(this.btnPcoach);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form14";
            this.Text = "Athlete Reg View(U)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnComap;
        private System.Windows.Forms.Button btnFee;
        private System.Windows.Forms.Button btnComp;
        private System.Windows.Forms.Button btnPcoach;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblAid;
        private System.Windows.Forms.Label lblAtheltesR;
        private Guna.UI2.WinForms.Guna2ImageButton gunaArrow;
        private System.Windows.Forms.Label lblAname;
        private System.Windows.Forms.TextBox txtAthletename;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.DataGridView dgvReg;
        private System.Windows.Forms.TextBox txtAId;
    }
}