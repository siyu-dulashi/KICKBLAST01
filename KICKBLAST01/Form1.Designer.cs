namespace KICKBLAST01
{
    partial class Form1
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
            this.guna_Startbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // guna_Startbtn
            // 
            this.guna_Startbtn.AutoRoundedCorners = true;
            this.guna_Startbtn.BackColor = System.Drawing.Color.Transparent;
            this.guna_Startbtn.BorderColor = System.Drawing.Color.DimGray;
            this.guna_Startbtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna_Startbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna_Startbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna_Startbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna_Startbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna_Startbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna_Startbtn.FillColor = System.Drawing.Color.LightSeaGreen;
            this.guna_Startbtn.FillColor2 = System.Drawing.Color.DarkGray;
            this.guna_Startbtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna_Startbtn.ForeColor = System.Drawing.Color.Lavender;
            this.guna_Startbtn.Location = new System.Drawing.Point(35, 336);
            this.guna_Startbtn.Name = "guna_Startbtn";
            this.guna_Startbtn.Size = new System.Drawing.Size(328, 42);
            this.guna_Startbtn.TabIndex = 1;
            this.guna_Startbtn.Text = "GET STAETED";
            this.guna_Startbtn.Click += new System.EventHandler(this.guna_Startbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KICKBLAST01.Properties.Resources.p11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 561);
            this.Controls.Add(this.guna_Startbtn);
            this.Name = "Form1";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton guna_Startbtn;
    }
}

