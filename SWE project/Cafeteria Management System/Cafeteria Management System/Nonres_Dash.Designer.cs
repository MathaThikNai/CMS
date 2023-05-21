namespace Cafeteria_Management_System
{
    partial class Nonres_Dash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nonres_Dash));
            this.btn_place_order = new Guna.UI.WinForms.GunaGradientButton();
            this.dgw_order = new System.Windows.Forms.DataGridView();
            this.cmb_platter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_day = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back_ = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_platter1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_platter2 = new System.Windows.Forms.TextBox();
            this.txt_platter3 = new System.Windows.Forms.TextBox();
            this.btn_pay = new Guna.UI.WinForms.GunaGradientButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_order)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_place_order
            // 
            this.btn_place_order.AnimationHoverSpeed = 0.07F;
            this.btn_place_order.AnimationSpeed = 0.03F;
            this.btn_place_order.BackColor = System.Drawing.Color.Transparent;
            this.btn_place_order.BaseColor1 = System.Drawing.Color.Teal;
            this.btn_place_order.BaseColor2 = System.Drawing.Color.DarkSlateGray;
            this.btn_place_order.BorderColor = System.Drawing.Color.Black;
            this.btn_place_order.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_place_order.FocusedColor = System.Drawing.Color.Empty;
            this.btn_place_order.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_place_order.ForeColor = System.Drawing.Color.White;
            this.btn_place_order.Image = null;
            this.btn_place_order.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_place_order.Location = new System.Drawing.Point(773, 616);
            this.btn_place_order.Name = "btn_place_order";
            this.btn_place_order.OnHoverBaseColor1 = System.Drawing.Color.Teal;
            this.btn_place_order.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_place_order.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_place_order.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_place_order.OnHoverImage = null;
            this.btn_place_order.OnPressedColor = System.Drawing.Color.Black;
            this.btn_place_order.Radius = 15;
            this.btn_place_order.Size = new System.Drawing.Size(208, 54);
            this.btn_place_order.TabIndex = 32;
            this.btn_place_order.Text = "Place Order";
            this.btn_place_order.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_place_order.Click += new System.EventHandler(this.btn_place_order_Click);
            // 
            // dgw_order
            // 
            this.dgw_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_order.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgw_order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw_order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgw_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_order.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgw_order.Location = new System.Drawing.Point(30, 185);
            this.dgw_order.Name = "dgw_order";
            this.dgw_order.RowHeadersWidth = 51;
            this.dgw_order.RowTemplate.Height = 24;
            this.dgw_order.Size = new System.Drawing.Size(951, 425);
            this.dgw_order.TabIndex = 31;
            // 
            // cmb_platter
            // 
            this.cmb_platter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_platter.Font = new System.Drawing.Font("Eras Medium ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_platter.FormattingEnabled = true;
            this.cmb_platter.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner"});
            this.cmb_platter.Location = new System.Drawing.Point(412, 664);
            this.cmb_platter.Name = "cmb_platter";
            this.cmb_platter.Size = new System.Drawing.Size(215, 42);
            this.cmb_platter.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Eras Demi ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(299, 671);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 35);
            this.label3.TabIndex = 29;
            this.label3.Text = "Platter:";
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Eras Medium ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner"});
            this.comboBox2.Location = new System.Drawing.Point(412, 616);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 42);
            this.comboBox2.TabIndex = 28;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Eras Demi ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(314, 616);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 35);
            this.label2.TabIndex = 27;
            this.label2.Text = "Type:";
            // 
            // cmb_day
            // 
            this.cmb_day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_day.Font = new System.Drawing.Font("Eras Medium ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_day.FormattingEnabled = true;
            this.cmb_day.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Fridday",
            "Saturday"});
            this.cmb_day.Location = new System.Drawing.Point(287, 137);
            this.cmb_day.Name = "cmb_day";
            this.cmb_day.Size = new System.Drawing.Size(215, 42);
            this.cmb_day.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(213, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "Day:";
            // 
            // back_
            // 
            this.back_.AnimationHoverSpeed = 0.07F;
            this.back_.AnimationSpeed = 0.03F;
            this.back_.BackColor = System.Drawing.Color.Transparent;
            this.back_.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.back_.BorderColor = System.Drawing.Color.Black;
            this.back_.CheckedBaseColor = System.Drawing.Color.Gray;
            this.back_.CheckedBorderColor = System.Drawing.Color.Black;
            this.back_.CheckedForeColor = System.Drawing.Color.White;
            this.back_.CheckedImage = ((System.Drawing.Image)(resources.GetObject("back_.CheckedImage")));
            this.back_.CheckedLineColor = System.Drawing.Color.DimGray;
            this.back_.DialogResult = System.Windows.Forms.DialogResult.None;
            this.back_.FocusedColor = System.Drawing.Color.Empty;
            this.back_.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_.ForeColor = System.Drawing.Color.Black;
            this.back_.Image = null;
            this.back_.ImageSize = new System.Drawing.Size(20, 20);
            this.back_.LineColor = System.Drawing.Color.White;
            this.back_.Location = new System.Drawing.Point(12, 12);
            this.back_.Name = "back_";
            this.back_.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.back_.OnHoverBorderColor = System.Drawing.Color.Black;
            this.back_.OnHoverForeColor = System.Drawing.Color.White;
            this.back_.OnHoverImage = null;
            this.back_.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.back_.OnPressedColor = System.Drawing.Color.Black;
            this.back_.Radius = 10;
            this.back_.Size = new System.Drawing.Size(56, 38);
            this.back_.TabIndex = 34;
            this.back_.Text = "Back";
            this.back_.Click += new System.EventHandler(this.back__Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Eras Demi ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(1013, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 32);
            this.label4.TabIndex = 35;
            this.label4.Text = "Platter 1";
            // 
            // txt_platter1
            // 
            this.txt_platter1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_platter1.Font = new System.Drawing.Font("Eras Medium ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_platter1.Location = new System.Drawing.Point(1139, 118);
            this.txt_platter1.Multiline = true;
            this.txt_platter1.Name = "txt_platter1";
            this.txt_platter1.Size = new System.Drawing.Size(242, 137);
            this.txt_platter1.TabIndex = 36;
            this.txt_platter1.TextChanged += new System.EventHandler(this.txt_platter1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Eras Demi ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(1013, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 32);
            this.label5.TabIndex = 37;
            this.label5.Text = "Platter 2";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Eras Demi ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(1013, 540);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 32);
            this.label6.TabIndex = 38;
            this.label6.Text = "Platter 3";
            // 
            // txt_platter2
            // 
            this.txt_platter2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_platter2.Font = new System.Drawing.Font("Eras Medium ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_platter2.Location = new System.Drawing.Point(1139, 297);
            this.txt_platter2.Multiline = true;
            this.txt_platter2.Name = "txt_platter2";
            this.txt_platter2.Size = new System.Drawing.Size(242, 136);
            this.txt_platter2.TabIndex = 39;
            // 
            // txt_platter3
            // 
            this.txt_platter3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_platter3.Font = new System.Drawing.Font("Eras Medium ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_platter3.Location = new System.Drawing.Point(1139, 485);
            this.txt_platter3.Multiline = true;
            this.txt_platter3.Name = "txt_platter3";
            this.txt_platter3.Size = new System.Drawing.Size(242, 133);
            this.txt_platter3.TabIndex = 40;
            // 
            // btn_pay
            // 
            this.btn_pay.AnimationHoverSpeed = 0.07F;
            this.btn_pay.AnimationSpeed = 0.03F;
            this.btn_pay.BackColor = System.Drawing.Color.Transparent;
            this.btn_pay.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_pay.BaseColor2 = System.Drawing.Color.Teal;
            this.btn_pay.BorderColor = System.Drawing.Color.Black;
            this.btn_pay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_pay.FocusedColor = System.Drawing.Color.Empty;
            this.btn_pay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.ForeColor = System.Drawing.Color.White;
            this.btn_pay.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_pay.Image = null;
            this.btn_pay.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_pay.Location = new System.Drawing.Point(1155, 687);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.OnHoverBaseColor1 = System.Drawing.Color.Teal;
            this.btn_pay.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_pay.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_pay.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_pay.OnHoverImage = null;
            this.btn_pay.OnPressedColor = System.Drawing.Color.Black;
            this.btn_pay.OnPressedDepth = 15;
            this.btn_pay.Radius = 15;
            this.btn_pay.Size = new System.Drawing.Size(208, 54);
            this.btn_pay.TabIndex = 41;
            this.btn_pay.Text = "Payment";
            this.btn_pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(494, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(366, 75);
            this.label7.TabIndex = 42;
            this.label7.Text = "Quick Cafe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(692, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "Non-Residential Student";
            // 
            // Nonres_Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1393, 753);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.txt_platter3);
            this.Controls.Add(this.txt_platter2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_platter1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.back_);
            this.Controls.Add(this.btn_place_order);
            this.Controls.Add(this.dgw_order);
            this.Controls.Add(this.cmb_platter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_day);
            this.Controls.Add(this.label1);
            this.Name = "Nonres_Dash";
            this.Text = "Nonres_Dash";
            this.Load += new System.EventHandler(this.Nonres_Dash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton btn_place_order;
        private System.Windows.Forms.DataGridView dgw_order;
        private System.Windows.Forms.ComboBox cmb_platter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_day;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton back_;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_platter1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_platter2;
        private System.Windows.Forms.TextBox txt_platter3;
        private Guna.UI.WinForms.GunaGradientButton btn_pay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}