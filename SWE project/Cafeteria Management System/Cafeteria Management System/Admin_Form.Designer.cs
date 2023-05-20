namespace Cafeteria_Management_System
{
    partial class Admin_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaImageReplaceColor1 = new Guna.UI.WinForms.GunaImageReplaceColor(this.components);
            this.gunaGradientTileButton1 = new Guna.UI.WinForms.GunaGradientTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.back = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgw_res = new System.Windows.Forms.DataGridView();
            this.dgw_nonres = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_res)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_nonres)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(513, 24);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(148, 50);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Admin ";
            // 
            // gunaImageReplaceColor1
            // 
            this.gunaImageReplaceColor1.Image = null;
            this.gunaImageReplaceColor1.NewColor = System.Drawing.Color.Empty;
            this.gunaImageReplaceColor1.OldColor = System.Drawing.Color.White;
            // 
            // gunaGradientTileButton1
            // 
            this.gunaGradientTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientTileButton1.AnimationSpeed = 0.03F;
            this.gunaGradientTileButton1.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientTileButton1.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientTileButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientTileButton1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaGradientTileButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientTileButton1.Image = null;
            this.gunaGradientTileButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaGradientTileButton1.Location = new System.Drawing.Point(63, 123);
            this.gunaGradientTileButton1.Name = "gunaGradientTileButton1";
            this.gunaGradientTileButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientTileButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientTileButton1.OnHoverImage = null;
            this.gunaGradientTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton1.Size = new System.Drawing.Size(409, 60);
            this.gunaGradientTileButton1.TabIndex = 1;
            this.gunaGradientTileButton1.Text = "Update Menu";
            this.gunaGradientTileButton1.Click += new System.EventHandler(this.gunaGradientTileButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order Meals";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resident";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(678, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Non-Resident";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(583, 256);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(11, 425);
            this.gunaPictureBox1.TabIndex = 3;
            this.gunaPictureBox1.TabStop = false;
            // 
            // back
            // 
            this.back.AnimationHoverSpeed = 0.07F;
            this.back.AnimationSpeed = 0.03F;
            this.back.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.back.BorderColor = System.Drawing.Color.Black;
            this.back.CheckedBaseColor = System.Drawing.Color.Gray;
            this.back.CheckedBorderColor = System.Drawing.Color.Black;
            this.back.CheckedForeColor = System.Drawing.Color.White;
            this.back.CheckedImage = ((System.Drawing.Image)(resources.GetObject("back.CheckedImage")));
            this.back.CheckedLineColor = System.Drawing.Color.DimGray;
            this.back.DialogResult = System.Windows.Forms.DialogResult.None;
            this.back.FocusedColor = System.Drawing.Color.Empty;
            this.back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Image = null;
            this.back.ImageSize = new System.Drawing.Size(20, 20);
            this.back.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.back.OnHoverBorderColor = System.Drawing.Color.Black;
            this.back.OnHoverForeColor = System.Drawing.Color.White;
            this.back.OnHoverImage = null;
            this.back.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.back.OnPressedColor = System.Drawing.Color.Black;
            this.back.Size = new System.Drawing.Size(91, 38);
            this.back.TabIndex = 22;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dgw_res
            // 
            this.dgw_res.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_res.Location = new System.Drawing.Point(32, 307);
            this.dgw_res.Name = "dgw_res";
            this.dgw_res.RowHeadersWidth = 51;
            this.dgw_res.RowTemplate.Height = 24;
            this.dgw_res.Size = new System.Drawing.Size(522, 374);
            this.dgw_res.TabIndex = 23;
            // 
            // dgw_nonres
            // 
            this.dgw_nonres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_nonres.Location = new System.Drawing.Point(622, 307);
            this.dgw_nonres.Name = "dgw_nonres";
            this.dgw_nonres.RowHeadersWidth = 51;
            this.dgw_nonres.RowTemplate.Height = 24;
            this.dgw_nonres.Size = new System.Drawing.Size(522, 374);
            this.dgw_nonres.TabIndex = 24;
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 713);
            this.Controls.Add(this.dgw_nonres);
            this.Controls.Add(this.dgw_res);
            this.Controls.Add(this.back);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaGradientTileButton1);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "Admin_Form";
            this.Text = "Admin_Form";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_res)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_nonres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaImageReplaceColor gunaImageReplaceColor1;
        private Guna.UI.WinForms.GunaGradientTileButton gunaGradientTileButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaAdvenceButton back;
        private System.Windows.Forms.DataGridView dgw_res;
        private System.Windows.Forms.DataGridView dgw_nonres;
    }
}