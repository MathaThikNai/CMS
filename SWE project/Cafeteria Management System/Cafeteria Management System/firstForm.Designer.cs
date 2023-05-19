namespace Cafeteria_Management_System
{
    partial class firstForm
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
            this.btn_admin = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_stdnt = new Guna.UI.WinForms.GunaGradientButton();
            this.SuspendLayout();
            // 
            // btn_admin
            // 
            this.btn_admin.AnimationHoverSpeed = 0.07F;
            this.btn_admin.AnimationSpeed = 0.03F;
            this.btn_admin.BackColor = System.Drawing.Color.Transparent;
            this.btn_admin.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btn_admin.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btn_admin.BorderColor = System.Drawing.Color.Black;
            this.btn_admin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_admin.FocusedColor = System.Drawing.Color.Empty;
            this.btn_admin.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.ForeColor = System.Drawing.Color.White;
            this.btn_admin.Image = null;
            this.btn_admin.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_admin.Location = new System.Drawing.Point(12, 8);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_admin.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_admin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_admin.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_admin.OnHoverImage = null;
            this.btn_admin.OnPressedColor = System.Drawing.Color.Black;
            this.btn_admin.Radius = 20;
            this.btn_admin.Size = new System.Drawing.Size(342, 505);
            this.btn_admin.TabIndex = 18;
            this.btn_admin.Text = "Admin";
            this.btn_admin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_stdnt
            // 
            this.btn_stdnt.AnimationHoverSpeed = 0.07F;
            this.btn_stdnt.AnimationSpeed = 0.03F;
            this.btn_stdnt.BackColor = System.Drawing.Color.Transparent;
            this.btn_stdnt.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btn_stdnt.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btn_stdnt.BorderColor = System.Drawing.Color.Black;
            this.btn_stdnt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_stdnt.FocusedColor = System.Drawing.Color.Empty;
            this.btn_stdnt.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stdnt.ForeColor = System.Drawing.Color.White;
            this.btn_stdnt.Image = null;
            this.btn_stdnt.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_stdnt.Location = new System.Drawing.Point(429, 12);
            this.btn_stdnt.Name = "btn_stdnt";
            this.btn_stdnt.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_stdnt.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_stdnt.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_stdnt.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_stdnt.OnHoverImage = null;
            this.btn_stdnt.OnPressedColor = System.Drawing.Color.Black;
            this.btn_stdnt.Radius = 20;
            this.btn_stdnt.Size = new System.Drawing.Size(342, 505);
            this.btn_stdnt.TabIndex = 19;
            this.btn_stdnt.Text = "Student";
            this.btn_stdnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_stdnt.Click += new System.EventHandler(this.btn_stdnt_Click);
            // 
            // firstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.btn_stdnt);
            this.Controls.Add(this.btn_admin);
            this.Name = "firstForm";
            this.Text = "firstForm";
            this.Load += new System.EventHandler(this.firstForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton btn_admin;
        private Guna.UI.WinForms.GunaGradientButton btn_stdnt;
    }
}