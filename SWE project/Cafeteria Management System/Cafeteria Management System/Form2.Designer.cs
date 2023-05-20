namespace Cafeteria_Management_System
{
    partial class menu_update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_update));
            this.label1 = new System.Windows.Forms.Label();
            this.bac = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_platter1 = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.txt_platter2 = new System.Windows.Forms.TextBox();
            this.txt_platter3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Menu :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bac
            // 
            this.bac.AnimationHoverSpeed = 0.07F;
            this.bac.AnimationSpeed = 0.03F;
            this.bac.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.bac.BorderColor = System.Drawing.Color.Black;
            this.bac.CheckedBaseColor = System.Drawing.Color.Gray;
            this.bac.CheckedBorderColor = System.Drawing.Color.Black;
            this.bac.CheckedForeColor = System.Drawing.Color.White;
            this.bac.CheckedImage = ((System.Drawing.Image)(resources.GetObject("bac.CheckedImage")));
            this.bac.CheckedLineColor = System.Drawing.Color.DimGray;
            this.bac.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bac.FocusedColor = System.Drawing.Color.Empty;
            this.bac.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bac.ForeColor = System.Drawing.Color.White;
            this.bac.Image = null;
            this.bac.ImageSize = new System.Drawing.Size(20, 20);
            this.bac.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.bac.Location = new System.Drawing.Point(12, 8);
            this.bac.Name = "bac";
            this.bac.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.bac.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bac.OnHoverForeColor = System.Drawing.Color.White;
            this.bac.OnHoverImage = null;
            this.bac.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.bac.OnPressedColor = System.Drawing.Color.Black;
            this.bac.Size = new System.Drawing.Size(91, 38);
            this.bac.TabIndex = 22;
            this.bac.Text = "Back";
            this.bac.Click += new System.EventHandler(this.bac_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Platter 1";
            // 
            // txt_platter1
            // 
            this.txt_platter1.Location = new System.Drawing.Point(157, 134);
            this.txt_platter1.Name = "txt_platter1";
            this.txt_platter1.Size = new System.Drawing.Size(100, 22);
            this.txt_platter1.TabIndex = 24;
            this.txt_platter1.TextChanged += new System.EventHandler(this.platter_txt1_TextChanged);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(109, 289);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(59, 178);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(55, 16);
            this.label.TabIndex = 26;
            this.label.Text = "Platter 2";
            // 
            // txt_platter2
            // 
            this.txt_platter2.Location = new System.Drawing.Point(157, 178);
            this.txt_platter2.Name = "txt_platter2";
            this.txt_platter2.Size = new System.Drawing.Size(100, 22);
            this.txt_platter2.TabIndex = 27;
            // 
            // txt_platter3
            // 
            this.txt_platter3.Location = new System.Drawing.Point(157, 218);
            this.txt_platter3.Name = "txt_platter3";
            this.txt_platter3.Size = new System.Drawing.Size(100, 22);
            this.txt_platter3.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Platter 3";
            // 
            // menu_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_platter3);
            this.Controls.Add(this.txt_platter2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_platter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bac);
            this.Controls.Add(this.label1);
            this.Name = "menu_update";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton bac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_platter1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txt_platter2;
        private System.Windows.Forms.TextBox txt_platter3;
        private System.Windows.Forms.Label label4;
    }
}