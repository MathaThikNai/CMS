namespace Cafeteria_Management_System
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_day = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cmb_platter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgw_order = new System.Windows.Forms.DataGridView();
            this.btn_place_order = new Guna.UI.WinForms.GunaGradientButton();
            this.back_reg = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_platter3r = new System.Windows.Forms.TextBox();
            this.txt_platter2r = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_platter1r = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_order)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Day";
            // 
            // cmb_day
            // 
            this.cmb_day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_day.Font = new System.Drawing.Font("Eras Medium ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_day.FormattingEnabled = true;
            this.cmb_day.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Fridday",
            "Saturday"});
            this.cmb_day.Location = new System.Drawing.Point(252, 200);
            this.cmb_day.Name = "cmb_day";
            this.cmb_day.Size = new System.Drawing.Size(215, 39);
            this.cmb_day.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 676);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Type:";
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Eras Medium ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner"});
            this.comboBox2.Location = new System.Drawing.Point(408, 676);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 39);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmb_platter
            // 
            this.cmb_platter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_platter.Font = new System.Drawing.Font("Eras Medium ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_platter.FormattingEnabled = true;
            this.cmb_platter.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner"});
            this.cmb_platter.Location = new System.Drawing.Point(408, 721);
            this.cmb_platter.Name = "cmb_platter";
            this.cmb_platter.Size = new System.Drawing.Size(215, 39);
            this.cmb_platter.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Eras Medium ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 724);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "Platter:";
            // 
            // dgw_order
            // 
            this.dgw_order.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgw_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_order.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgw_order.Location = new System.Drawing.Point(12, 245);
            this.dgw_order.Name = "dgw_order";
            this.dgw_order.RowHeadersWidth = 51;
            this.dgw_order.RowTemplate.Height = 24;
            this.dgw_order.Size = new System.Drawing.Size(978, 425);
            this.dgw_order.TabIndex = 23;
            // 
            // btn_place_order
            // 
            this.btn_place_order.AnimationHoverSpeed = 0.07F;
            this.btn_place_order.AnimationSpeed = 0.03F;
            this.btn_place_order.BackColor = System.Drawing.Color.Transparent;
            this.btn_place_order.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_place_order.BaseColor2 = System.Drawing.Color.Teal;
            this.btn_place_order.BorderColor = System.Drawing.Color.Black;
            this.btn_place_order.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_place_order.FocusedColor = System.Drawing.Color.Empty;
            this.btn_place_order.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_place_order.ForeColor = System.Drawing.Color.White;
            this.btn_place_order.Image = null;
            this.btn_place_order.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_place_order.Location = new System.Drawing.Point(782, 676);
            this.btn_place_order.Name = "btn_place_order";
            this.btn_place_order.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_place_order.OnHoverBaseColor2 = System.Drawing.Color.Teal;
            this.btn_place_order.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_place_order.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_place_order.OnHoverImage = null;
            this.btn_place_order.OnPressedColor = System.Drawing.Color.Black;
            this.btn_place_order.Radius = 15;
            this.btn_place_order.Size = new System.Drawing.Size(208, 54);
            this.btn_place_order.TabIndex = 24;
            this.btn_place_order.Text = "Place Order";
            this.btn_place_order.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_place_order.Click += new System.EventHandler(this.btn_place_order_Click);
            // 
            // back_reg
            // 
            this.back_reg.AnimationHoverSpeed = 0.07F;
            this.back_reg.AnimationSpeed = 0.03F;
            this.back_reg.BackColor = System.Drawing.Color.Transparent;
            this.back_reg.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.back_reg.BorderColor = System.Drawing.Color.Black;
            this.back_reg.CheckedBaseColor = System.Drawing.Color.Gray;
            this.back_reg.CheckedBorderColor = System.Drawing.Color.Black;
            this.back_reg.CheckedForeColor = System.Drawing.Color.White;
            this.back_reg.CheckedImage = ((System.Drawing.Image)(resources.GetObject("back_reg.CheckedImage")));
            this.back_reg.CheckedLineColor = System.Drawing.Color.DimGray;
            this.back_reg.DialogResult = System.Windows.Forms.DialogResult.None;
            this.back_reg.FocusedColor = System.Drawing.Color.Empty;
            this.back_reg.Font = new System.Drawing.Font("Eras Demi ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_reg.ForeColor = System.Drawing.Color.Black;
            this.back_reg.Image = null;
            this.back_reg.ImageSize = new System.Drawing.Size(20, 20);
            this.back_reg.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.back_reg.Location = new System.Drawing.Point(12, 12);
            this.back_reg.Name = "back_reg";
            this.back_reg.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.back_reg.OnHoverBorderColor = System.Drawing.Color.Black;
            this.back_reg.OnHoverForeColor = System.Drawing.Color.White;
            this.back_reg.OnHoverImage = null;
            this.back_reg.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.back_reg.OnPressedColor = System.Drawing.Color.Black;
            this.back_reg.Radius = 10;
            this.back_reg.Size = new System.Drawing.Size(62, 38);
            this.back_reg.TabIndex = 25;
            this.back_reg.Text = "Back";
            this.back_reg.Click += new System.EventHandler(this.back_reg_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(679, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 15);
            this.label8.TabIndex = 45;
            this.label8.Text = "Residential Student";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(462, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(366, 75);
            this.label7.TabIndex = 44;
            this.label7.Text = "Quick Cafe";
            // 
            // txt_platter3r
            // 
            this.txt_platter3r.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_platter3r.Font = new System.Drawing.Font("Eras Medium ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_platter3r.Location = new System.Drawing.Point(1141, 567);
            this.txt_platter3r.Multiline = true;
            this.txt_platter3r.Name = "txt_platter3r";
            this.txt_platter3r.Size = new System.Drawing.Size(242, 133);
            this.txt_platter3r.TabIndex = 51;
            // 
            // txt_platter2r
            // 
            this.txt_platter2r.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_platter2r.Font = new System.Drawing.Font("Eras Medium ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_platter2r.Location = new System.Drawing.Point(1141, 379);
            this.txt_platter2r.Multiline = true;
            this.txt_platter2r.Name = "txt_platter2r";
            this.txt_platter2r.Size = new System.Drawing.Size(242, 136);
            this.txt_platter2r.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Eras Demi ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(1015, 622);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 32);
            this.label6.TabIndex = 49;
            this.label6.Text = "Platter 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Eras Demi ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(1015, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 32);
            this.label5.TabIndex = 48;
            this.label5.Text = "Platter 2";
            // 
            // txt_platter1r
            // 
            this.txt_platter1r.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_platter1r.Font = new System.Drawing.Font("Eras Medium ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_platter1r.Location = new System.Drawing.Point(1141, 200);
            this.txt_platter1r.Multiline = true;
            this.txt_platter1r.Name = "txt_platter1r";
            this.txt_platter1r.Size = new System.Drawing.Size(242, 137);
            this.txt_platter1r.TabIndex = 47;
            this.txt_platter1r.TextChanged += new System.EventHandler(this.txt_platter1r_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Eras Demi ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(1015, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 32);
            this.label4.TabIndex = 46;
            this.label4.Text = "Platter 1";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1405, 787);
            this.Controls.Add(this.txt_platter3r);
            this.Controls.Add(this.txt_platter2r);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_platter1r);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.back_reg);
            this.Controls.Add(this.btn_place_order);
            this.Controls.Add(this.dgw_order);
            this.Controls.Add(this.cmb_platter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_day);
            this.Controls.Add(this.label1);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_day;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cmb_platter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgw_order;
        private Guna.UI.WinForms.GunaGradientButton btn_place_order;
        private Guna.UI.WinForms.GunaAdvenceButton back_reg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_platter3r;
        private System.Windows.Forms.TextBox txt_platter2r;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_platter1r;
        private System.Windows.Forms.Label label4;
    }
}