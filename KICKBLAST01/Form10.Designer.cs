namespace KICKBLAST01
{
    partial class Form10
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
            this.btnFee = new System.Windows.Forms.Button();
            this.btnComp = new System.Windows.Forms.Button();
            this.btnPcoach = new System.Windows.Forms.Button();
            this.btnTraning = new System.Windows.Forms.Button();
            this.btnRview = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.lblPCoach = new System.Windows.Forms.Label();
            this.lblPrivate = new System.Windows.Forms.Label();
            this.cmbCoachID = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gunaArrow = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dgvCoaching = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.lblCname = new System.Windows.Forms.Label();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.lblAId = new System.Windows.Forms.Label();
            this.cmbAID = new System.Windows.Forms.ComboBox();
            this.lblPW = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoaching)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFee
            // 
            this.btnFee.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFee.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFee.Location = new System.Drawing.Point(80, 441);
            this.btnFee.Name = "btnFee";
            this.btnFee.Size = new System.Drawing.Size(223, 39);
            this.btnFee.TabIndex = 24;
            this.btnFee.Text = "Monthly Fee";
            this.btnFee.UseVisualStyleBackColor = false;
            this.btnFee.Click += new System.EventHandler(this.btnFee_Click);
            // 
            // btnComp
            // 
            this.btnComp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnComp.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComp.Location = new System.Drawing.Point(80, 375);
            this.btnComp.Name = "btnComp";
            this.btnComp.Size = new System.Drawing.Size(223, 39);
            this.btnComp.TabIndex = 23;
            this.btnComp.Text = "Competition";
            this.btnComp.UseVisualStyleBackColor = false;
            this.btnComp.Click += new System.EventHandler(this.btnComp_Click);
            // 
            // btnPcoach
            // 
            this.btnPcoach.BackColor = System.Drawing.Color.OrangeRed;
            this.btnPcoach.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPcoach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPcoach.Location = new System.Drawing.Point(80, 309);
            this.btnPcoach.Name = "btnPcoach";
            this.btnPcoach.Size = new System.Drawing.Size(223, 39);
            this.btnPcoach.TabIndex = 22;
            this.btnPcoach.Text = "Private Coaching";
            this.btnPcoach.UseVisualStyleBackColor = false;
            this.btnPcoach.Click += new System.EventHandler(this.btnPcoach_Click);
            // 
            // btnTraning
            // 
            this.btnTraning.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTraning.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraning.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTraning.Location = new System.Drawing.Point(80, 239);
            this.btnTraning.Name = "btnTraning";
            this.btnTraning.Size = new System.Drawing.Size(223, 39);
            this.btnTraning.TabIndex = 21;
            this.btnTraning.Text = "Training Plan";
            this.btnTraning.UseVisualStyleBackColor = false;
            this.btnTraning.Click += new System.EventHandler(this.btnTraning_Click);
            // 
            // btnRview
            // 
            this.btnRview.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRview.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRview.Location = new System.Drawing.Point(80, 168);
            this.btnRview.Name = "btnRview";
            this.btnRview.Size = new System.Drawing.Size(223, 39);
            this.btnRview.TabIndex = 20;
            this.btnRview.Text = "Athletes Registration view";
            this.btnRview.UseVisualStyleBackColor = false;
            this.btnRview.Click += new System.EventHandler(this.btnRview_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnReg.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReg.Location = new System.Drawing.Point(80, 101);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(223, 39);
            this.btnReg.TabIndex = 19;
            this.btnReg.Text = "Athletes Registration";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblPCoach
            // 
            this.lblPCoach.AutoSize = true;
            this.lblPCoach.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCoach.Location = new System.Drawing.Point(595, 9);
            this.lblPCoach.Name = "lblPCoach";
            this.lblPCoach.Size = new System.Drawing.Size(182, 27);
            this.lblPCoach.TabIndex = 25;
            this.lblPCoach.Text = "Private Coaching";
            // 
            // lblPrivate
            // 
            this.lblPrivate.AutoSize = true;
            this.lblPrivate.BackColor = System.Drawing.Color.Transparent;
            this.lblPrivate.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPrivate.Location = new System.Drawing.Point(412, 108);
            this.lblPrivate.Name = "lblPrivate";
            this.lblPrivate.Size = new System.Drawing.Size(80, 23);
            this.lblPrivate.TabIndex = 65;
            this.lblPrivate.Text = "Coach ID";
            // 
            // cmbCoachID
            // 
            this.cmbCoachID.FormattingEnabled = true;
            this.cmbCoachID.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbCoachID.Location = new System.Drawing.Point(567, 110);
            this.cmbCoachID.Name = "cmbCoachID";
            this.cmbCoachID.Size = new System.Drawing.Size(88, 24);
            this.cmbCoachID.TabIndex = 67;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClear.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(874, 49);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 39);
            this.btnClear.TabIndex = 92;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(719, 49);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 39);
            this.btnDelete.TabIndex = 91;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.OrangeRed;
            this.btnUpdate.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(567, 49);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 39);
            this.btnUpdate.TabIndex = 90;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::KICKBLAST01.Properties.Resources.kick_blast_logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 58);
            this.pictureBox2.TabIndex = 93;
            this.pictureBox2.TabStop = false;
            // 
            // gunaArrow
            // 
            this.gunaArrow.BackColor = System.Drawing.Color.Transparent;
            this.gunaArrow.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaArrow.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaArrow.Image = global::KICKBLAST01.Properties.Resources._888888;
            this.gunaArrow.ImageOffset = new System.Drawing.Point(0, 0);
            this.gunaArrow.ImageRotate = 0F;
            this.gunaArrow.Location = new System.Drawing.Point(0, 472);
            this.gunaArrow.Name = "gunaArrow";
            this.gunaArrow.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaArrow.Size = new System.Drawing.Size(83, 77);
            this.gunaArrow.TabIndex = 109;
            this.gunaArrow.Click += new System.EventHandler(this.gunaArrow_Click);
            // 
            // dgvCoaching
            // 
            this.dgvCoaching.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCoaching.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgvCoaching.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoaching.Location = new System.Drawing.Point(382, 195);
            this.dgvCoaching.Name = "dgvCoaching";
            this.dgvCoaching.RowHeadersWidth = 51;
            this.dgvCoaching.RowTemplate.Height = 24;
            this.dgvCoaching.Size = new System.Drawing.Size(680, 354);
            this.dgvCoaching.TabIndex = 110;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(418, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 39);
            this.btnAdd.TabIndex = 111;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudHours
            // 
            this.nudHours.Location = new System.Drawing.Point(922, 141);
            this.nudHours.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(88, 22);
            this.nudHours.TabIndex = 112;
            // 
            // lblCname
            // 
            this.lblCname.AutoSize = true;
            this.lblCname.BackColor = System.Drawing.Color.Transparent;
            this.lblCname.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCname.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCname.Location = new System.Drawing.Point(412, 143);
            this.lblCname.Name = "lblCname";
            this.lblCname.Size = new System.Drawing.Size(109, 23);
            this.lblCname.TabIndex = 113;
            this.lblCname.Text = "Coach Name";
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(567, 143);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(210, 22);
            this.txtCname.TabIndex = 114;
            // 
            // lblAId
            // 
            this.lblAId.AutoSize = true;
            this.lblAId.BackColor = System.Drawing.Color.Transparent;
            this.lblAId.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAId.Location = new System.Drawing.Point(798, 108);
            this.lblAId.Name = "lblAId";
            this.lblAId.Size = new System.Drawing.Size(87, 23);
            this.lblAId.TabIndex = 115;
            this.lblAId.Text = "Athlete ID";
            // 
            // cmbAID
            // 
            this.cmbAID.FormattingEnabled = true;
            this.cmbAID.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06"});
            this.cmbAID.Location = new System.Drawing.Point(922, 110);
            this.cmbAID.Name = "cmbAID";
            this.cmbAID.Size = new System.Drawing.Size(88, 24);
            this.cmbAID.TabIndex = 116;
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.BackColor = System.Drawing.Color.Transparent;
            this.lblPW.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPW.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPW.Location = new System.Drawing.Point(798, 163);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(82, 23);
            this.lblPW.TabIndex = 117;
            this.lblPW.Text = "Per Week";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(798, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 118;
            this.label1.Text = "Hours";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KICKBLAST01.Properties.Resources.A5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.cmbAID);
            this.Controls.Add(this.lblAId);
            this.Controls.Add(this.txtCname);
            this.Controls.Add(this.lblCname);
            this.Controls.Add(this.nudHours);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvCoaching);
            this.Controls.Add(this.gunaArrow);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbCoachID);
            this.Controls.Add(this.lblPrivate);
            this.Controls.Add(this.lblPCoach);
            this.Controls.Add(this.btnFee);
            this.Controls.Add(this.btnComp);
            this.Controls.Add(this.btnPcoach);
            this.Controls.Add(this.btnTraning);
            this.Controls.Add(this.btnRview);
            this.Controls.Add(this.btnReg);
            this.Name = "Form10";
            this.Text = "Private Coaching";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoaching)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFee;
        private System.Windows.Forms.Button btnComp;
        private System.Windows.Forms.Button btnPcoach;
        private System.Windows.Forms.Button btnTraning;
        private System.Windows.Forms.Button btnRview;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblPCoach;
        private System.Windows.Forms.Label lblPrivate;
        private System.Windows.Forms.ComboBox cmbCoachID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2ImageButton gunaArrow;
        private System.Windows.Forms.DataGridView dgvCoaching;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.Label lblCname;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.Label lblAId;
        private System.Windows.Forms.ComboBox cmbAID;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label label1;
    }
}