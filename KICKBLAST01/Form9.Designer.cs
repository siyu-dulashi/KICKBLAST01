namespace KICKBLAST01
{
    partial class Form9
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
            this.lblAr = new System.Windows.Forms.Label();
            this.lblPlanID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTraningp = new System.Windows.Forms.Label();
            this.cmbPlanID = new System.Windows.Forms.ComboBox();
            this.txtPlanFee = new System.Windows.Forms.TextBox();
            this.cmbPlanName = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gunaArrow = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dgvTraningPlan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraningPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFee
            // 
            this.btnFee.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFee.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFee.Location = new System.Drawing.Point(91, 451);
            this.btnFee.Name = "btnFee";
            this.btnFee.Size = new System.Drawing.Size(223, 39);
            this.btnFee.TabIndex = 18;
            this.btnFee.Text = "Monthly Fee";
            this.btnFee.UseVisualStyleBackColor = false;
            this.btnFee.Click += new System.EventHandler(this.btnFee_Click);
            // 
            // btnComp
            // 
            this.btnComp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnComp.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComp.Location = new System.Drawing.Point(91, 383);
            this.btnComp.Name = "btnComp";
            this.btnComp.Size = new System.Drawing.Size(223, 39);
            this.btnComp.TabIndex = 17;
            this.btnComp.Text = "Competition";
            this.btnComp.UseVisualStyleBackColor = false;
            this.btnComp.Click += new System.EventHandler(this.btnComp_Click);
            // 
            // btnPcoach
            // 
            this.btnPcoach.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPcoach.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPcoach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPcoach.Location = new System.Drawing.Point(91, 318);
            this.btnPcoach.Name = "btnPcoach";
            this.btnPcoach.Size = new System.Drawing.Size(223, 39);
            this.btnPcoach.TabIndex = 16;
            this.btnPcoach.Text = "Private Coaching";
            this.btnPcoach.UseVisualStyleBackColor = false;
            this.btnPcoach.Click += new System.EventHandler(this.btnPcoach_Click);
            // 
            // btnTraning
            // 
            this.btnTraning.BackColor = System.Drawing.Color.OrangeRed;
            this.btnTraning.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraning.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTraning.Location = new System.Drawing.Point(91, 248);
            this.btnTraning.Name = "btnTraning";
            this.btnTraning.Size = new System.Drawing.Size(223, 39);
            this.btnTraning.TabIndex = 15;
            this.btnTraning.Text = "Training Plan";
            this.btnTraning.UseVisualStyleBackColor = false;
            this.btnTraning.Click += new System.EventHandler(this.btnTraning_Click);
            // 
            // btnRview
            // 
            this.btnRview.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRview.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRview.Location = new System.Drawing.Point(91, 177);
            this.btnRview.Name = "btnRview";
            this.btnRview.Size = new System.Drawing.Size(223, 39);
            this.btnRview.TabIndex = 14;
            this.btnRview.Text = "Athletes Registration view";
            this.btnRview.UseVisualStyleBackColor = false;
            this.btnRview.Click += new System.EventHandler(this.btnRview_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnReg.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReg.Location = new System.Drawing.Point(91, 110);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(223, 39);
            this.btnReg.TabIndex = 13;
            this.btnReg.Text = "Athletes Registration";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblAr
            // 
            this.lblAr.AutoSize = true;
            this.lblAr.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAr.Location = new System.Drawing.Point(555, 19);
            this.lblAr.Name = "lblAr";
            this.lblAr.Size = new System.Drawing.Size(140, 27);
            this.lblAr.TabIndex = 19;
            this.lblAr.Text = "Traning Plan";
            // 
            // lblPlanID
            // 
            this.lblPlanID.AutoSize = true;
            this.lblPlanID.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanID.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPlanID.Location = new System.Drawing.Point(409, 138);
            this.lblPlanID.Name = "lblPlanID";
            this.lblPlanID.Size = new System.Drawing.Size(65, 23);
            this.lblPlanID.TabIndex = 65;
            this.lblPlanID.Text = "Plan ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(409, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 66;
            this.label1.Text = "Traning Plan Name";
            // 
            // lblTraningp
            // 
            this.lblTraningp.AutoSize = true;
            this.lblTraningp.BackColor = System.Drawing.Color.Transparent;
            this.lblTraningp.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraningp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTraningp.Location = new System.Drawing.Point(409, 224);
            this.lblTraningp.Name = "lblTraningp";
            this.lblTraningp.Size = new System.Drawing.Size(188, 23);
            this.lblTraningp.TabIndex = 67;
            this.lblTraningp.Text = "Traning Plan Week Free";
            // 
            // cmbPlanID
            // 
            this.cmbPlanID.FormattingEnabled = true;
            this.cmbPlanID.Items.AddRange(new object[] {
            "01",
            "02",
            "03"});
            this.cmbPlanID.Location = new System.Drawing.Point(613, 137);
            this.cmbPlanID.Name = "cmbPlanID";
            this.cmbPlanID.Size = new System.Drawing.Size(116, 24);
            this.cmbPlanID.TabIndex = 68;
            // 
            // txtPlanFee
            // 
            this.txtPlanFee.Location = new System.Drawing.Point(613, 224);
            this.txtPlanFee.Name = "txtPlanFee";
            this.txtPlanFee.Size = new System.Drawing.Size(207, 22);
            this.txtPlanFee.TabIndex = 70;
            // 
            // cmbPlanName
            // 
            this.cmbPlanName.FormattingEnabled = true;
            this.cmbPlanName.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Elite"});
            this.cmbPlanName.Location = new System.Drawing.Point(613, 181);
            this.cmbPlanName.Name = "cmbPlanName";
            this.cmbPlanName.Size = new System.Drawing.Size(207, 24);
            this.cmbPlanName.TabIndex = 71;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClear.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(846, 69);
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
            this.btnDelete.Location = new System.Drawing.Point(696, 69);
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
            this.btnUpdate.Location = new System.Drawing.Point(547, 69);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 39);
            this.btnUpdate.TabIndex = 90;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(397, 69);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 39);
            this.btnAdd.TabIndex = 89;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::KICKBLAST01.Properties.Resources.kick_blast_logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1, 1);
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
            this.gunaArrow.Location = new System.Drawing.Point(1, 468);
            this.gunaArrow.Name = "gunaArrow";
            this.gunaArrow.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaArrow.Size = new System.Drawing.Size(84, 91);
            this.gunaArrow.TabIndex = 109;
            this.gunaArrow.Click += new System.EventHandler(this.gunaArrow_Click);
            // 
            // dgvTraningPlan
            // 
            this.dgvTraningPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTraningPlan.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgvTraningPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraningPlan.Location = new System.Drawing.Point(374, 272);
            this.dgvTraningPlan.Name = "dgvTraningPlan";
            this.dgvTraningPlan.RowHeadersWidth = 51;
            this.dgvTraningPlan.RowTemplate.Height = 24;
            this.dgvTraningPlan.Size = new System.Drawing.Size(693, 277);
            this.dgvTraningPlan.TabIndex = 110;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KICKBLAST01.Properties.Resources.A5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 561);
            this.Controls.Add(this.dgvTraningPlan);
            this.Controls.Add(this.gunaArrow);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbPlanName);
            this.Controls.Add(this.txtPlanFee);
            this.Controls.Add(this.cmbPlanID);
            this.Controls.Add(this.lblTraningp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlanID);
            this.Controls.Add(this.lblAr);
            this.Controls.Add(this.btnFee);
            this.Controls.Add(this.btnComp);
            this.Controls.Add(this.btnPcoach);
            this.Controls.Add(this.btnTraning);
            this.Controls.Add(this.btnRview);
            this.Controls.Add(this.btnReg);
            this.Name = "Form9";
            this.Text = "Traning Plan";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraningPlan)).EndInit();
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
        private System.Windows.Forms.Label lblAr;
        private System.Windows.Forms.Label lblPlanID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTraningp;
        private System.Windows.Forms.ComboBox cmbPlanID;
        private System.Windows.Forms.TextBox txtPlanFee;
        private System.Windows.Forms.ComboBox cmbPlanName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2ImageButton gunaArrow;
        private System.Windows.Forms.DataGridView dgvTraningPlan;
    }
}