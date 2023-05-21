namespace Cafeteria_Management_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_st_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.btn_register = new Guna.UI.WinForms.GunaGradientButton();
            this.label5 = new System.Windows.Forms.Label();
            this.login_link_label = new System.Windows.Forms.LinkLabel();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(180, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(92, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.Azure;
            this.txt_name.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(97, 267);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(342, 30);
            this.txt_name.TabIndex = 2;
            // 
            // txt_st_id
            // 
            this.txt_st_id.BackColor = System.Drawing.Color.Azure;
            this.txt_st_id.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_st_id.Location = new System.Drawing.Point(97, 349);
            this.txt_st_id.Name = "txt_st_id";
            this.txt_st_id.Size = new System.Drawing.Size(342, 30);
            this.txt_st_id.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(92, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(92, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Student Status :";
            // 
            // cmb_status
            // 
            this.cmb_status.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Residential",
            "Non-Residential"});
            this.cmb_status.Location = new System.Drawing.Point(97, 429);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(342, 31);
            this.cmb_status.TabIndex = 6;
            // 
            // btn_register
            // 
            this.btn_register.AnimationHoverSpeed = 0.07F;
            this.btn_register.AnimationSpeed = 0.03F;
            this.btn_register.BackColor = System.Drawing.Color.Transparent;
            this.btn_register.BaseColor1 = System.Drawing.Color.LightSeaGreen;
            this.btn_register.BaseColor2 = System.Drawing.Color.DarkSlateGray;
            this.btn_register.BorderColor = System.Drawing.Color.Black;
            this.btn_register.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_register.FocusedColor = System.Drawing.Color.Empty;
            this.btn_register.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_register.Image = null;
            this.btn_register.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_register.Location = new System.Drawing.Point(97, 590);
            this.btn_register.Name = "btn_register";
            this.btn_register.OnHoverBaseColor1 = System.Drawing.Color.Aqua;
            this.btn_register.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_register.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_register.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_register.OnHoverImage = null;
            this.btn_register.OnPressedColor = System.Drawing.Color.Black;
            this.btn_register.Radius = 20;
            this.btn_register.Size = new System.Drawing.Size(343, 84);
            this.btn_register.TabIndex = 7;
            this.btn_register.Text = "Register";
            this.btn_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Eras Light ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label5.Location = new System.Drawing.Point(207, 701);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Already have an Account?";
            // 
            // login_link_label
            // 
            this.login_link_label.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.login_link_label.AutoSize = true;
            this.login_link_label.BackColor = System.Drawing.Color.Transparent;
            this.login_link_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_link_label.LinkColor = System.Drawing.Color.Teal;
            this.login_link_label.Location = new System.Drawing.Point(375, 724);
            this.login_link_label.Name = "login_link_label";
            this.login_link_label.Size = new System.Drawing.Size(61, 28);
            this.login_link_label.TabIndex = 9;
            this.login_link_label.TabStop = true;
            this.login_link_label.Text = "Login";
            this.login_link_label.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_link_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_link_label_LinkClicked);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(97, 511);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(342, 30);
            this.txt_pass.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(92, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(553, 856);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.login_link_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_st_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_st_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_status;
        private Guna.UI.WinForms.GunaGradientButton btn_register;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel login_link_label;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label6;
    }
}

