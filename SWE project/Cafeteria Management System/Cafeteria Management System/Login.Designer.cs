namespace Cafeteria_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_st_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new Guna.UI.WinForms.GunaGradientButton();
            this.reg_link_label = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.back_login = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Eras Medium ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.Aquamarine;
            this.txt_pass.Location = new System.Drawing.Point(253, 275);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(409, 31);
            this.txt_pass.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 40);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password :";
            // 
            // txt_st_id
            // 
            this.txt_st_id.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_st_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_st_id.Font = new System.Drawing.Font("Eras Medium ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_st_id.ForeColor = System.Drawing.Color.Aquamarine;
            this.txt_st_id.Location = new System.Drawing.Point(253, 178);
            this.txt_st_id.Name = "txt_st_id";
            this.txt_st_id.Size = new System.Drawing.Size(409, 31);
            this.txt_st_id.TabIndex = 13;
            this.txt_st_id.TextChanged += new System.EventHandler(this.txt_st_id_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "Student ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 50);
            this.label1.TabIndex = 16;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_login
            // 
            this.btn_login.AnimationHoverSpeed = 0.07F;
            this.btn_login.AnimationSpeed = 0.03F;
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BaseColor1 = System.Drawing.Color.DarkCyan;
            this.btn_login.BaseColor2 = System.Drawing.Color.DarkSlateGray;
            this.btn_login.BorderColor = System.Drawing.Color.Black;
            this.btn_login.BorderSize = 1;
            this.btn_login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_login.FocusedColor = System.Drawing.Color.Empty;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Image = null;
            this.btn_login.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_login.Location = new System.Drawing.Point(310, 375);
            this.btn_login.Name = "btn_login";
            this.btn_login.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_login.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_login.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_login.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_login.OnHoverImage = null;
            this.btn_login.OnPressedColor = System.Drawing.Color.Black;
            this.btn_login.Radius = 20;
            this.btn_login.Size = new System.Drawing.Size(307, 43);
            this.btn_login.TabIndex = 17;
            this.btn_login.Text = "Login";
            this.btn_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // reg_link_label
            // 
            this.reg_link_label.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.reg_link_label.AutoSize = true;
            this.reg_link_label.BackColor = System.Drawing.Color.Transparent;
            this.reg_link_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_link_label.LinkColor = System.Drawing.Color.Black;
            this.reg_link_label.Location = new System.Drawing.Point(580, 332);
            this.reg_link_label.Name = "reg_link_label";
            this.reg_link_label.Size = new System.Drawing.Size(82, 28);
            this.reg_link_label.TabIndex = 19;
            this.reg_link_label.TabStop = true;
            this.reg_link_label.Text = "Register";
            this.reg_link_label.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reg_link_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reg_link_label_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Don\'t have an Account yet?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // back_login
            // 
            this.back_login.AnimationHoverSpeed = 0.07F;
            this.back_login.AnimationSpeed = 0.03F;
            this.back_login.BaseColor = System.Drawing.Color.DarkSlateGray;
            this.back_login.BorderColor = System.Drawing.Color.Black;
            this.back_login.CheckedBaseColor = System.Drawing.Color.Gray;
            this.back_login.CheckedBorderColor = System.Drawing.Color.Black;
            this.back_login.CheckedForeColor = System.Drawing.Color.White;
            this.back_login.CheckedImage = null;
            this.back_login.CheckedLineColor = System.Drawing.Color.DimGray;
            this.back_login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.back_login.FocusedColor = System.Drawing.Color.Empty;
            this.back_login.Font = new System.Drawing.Font("Eras Demi ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_login.ForeColor = System.Drawing.Color.White;
            this.back_login.Image = null;
            this.back_login.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.back_login.ImageSize = new System.Drawing.Size(20, 20);
            this.back_login.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.back_login.Location = new System.Drawing.Point(12, 12);
            this.back_login.Name = "back_login";
            this.back_login.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.back_login.OnHoverBorderColor = System.Drawing.Color.Black;
            this.back_login.OnHoverForeColor = System.Drawing.Color.White;
            this.back_login.OnHoverImage = null;
            this.back_login.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.back_login.OnPressedColor = System.Drawing.Color.Black;
            this.back_login.Size = new System.Drawing.Size(91, 34);
            this.back_login.TabIndex = 20;
            this.back_login.Text = "   Back";
            this.back_login.Click += new System.EventHandler(this.back_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(904, 483);
            this.Controls.Add(this.back_login);
            this.Controls.Add(this.reg_link_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_st_id);
            this.Controls.Add(this.label3);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_st_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGradientButton btn_login;
        private System.Windows.Forms.LinkLabel reg_link_label;
        private Guna.UI.WinForms.GunaAdvenceButton back_login;
        public System.Windows.Forms.Label label5;
    }
}