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
            this.btn_place_order = new Guna.UI.WinForms.GunaGradientButton();
            this.dgw_order = new System.Windows.Forms.DataGridView();
            this.cmb_platter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_day = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_order)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_place_order
            // 
            this.btn_place_order.AnimationHoverSpeed = 0.07F;
            this.btn_place_order.AnimationSpeed = 0.03F;
            this.btn_place_order.BackColor = System.Drawing.Color.Transparent;
            this.btn_place_order.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btn_place_order.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btn_place_order.BorderColor = System.Drawing.Color.Black;
            this.btn_place_order.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_place_order.FocusedColor = System.Drawing.Color.Empty;
            this.btn_place_order.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_place_order.ForeColor = System.Drawing.Color.White;
            this.btn_place_order.Image = null;
            this.btn_place_order.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_place_order.Location = new System.Drawing.Point(748, 575);
            this.btn_place_order.Name = "btn_place_order";
            this.btn_place_order.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_place_order.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_place_order.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_place_order.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_place_order.OnHoverImage = null;
            this.btn_place_order.OnPressedColor = System.Drawing.Color.Black;
            this.btn_place_order.Radius = 20;
            this.btn_place_order.Size = new System.Drawing.Size(208, 54);
            this.btn_place_order.TabIndex = 32;
            this.btn_place_order.Text = "Place Order";
            this.btn_place_order.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_place_order.Click += new System.EventHandler(this.btn_place_order_Click);
            // 
            // dgw_order
            // 
            this.dgw_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_order.Location = new System.Drawing.Point(55, 123);
            this.dgw_order.Name = "dgw_order";
            this.dgw_order.RowHeadersWidth = 51;
            this.dgw_order.RowTemplate.Height = 24;
            this.dgw_order.Size = new System.Drawing.Size(901, 425);
            this.dgw_order.TabIndex = 31;
            // 
            // cmb_platter
            // 
            this.cmb_platter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_platter.FormattingEnabled = true;
            this.cmb_platter.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner"});
            this.cmb_platter.Location = new System.Drawing.Point(741, 35);
            this.cmb_platter.Name = "cmb_platter";
            this.cmb_platter.Size = new System.Drawing.Size(215, 36);
            this.cmb_platter.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(666, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 28);
            this.label3.TabIndex = 29;
            this.label3.Text = "Platter:";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner"});
            this.comboBox2.Location = new System.Drawing.Point(412, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 36);
            this.comboBox2.TabIndex = 28;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "Type:";
            // 
            // cmb_day
            // 
            this.cmb_day.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_day.FormattingEnabled = true;
            this.cmb_day.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Fridday",
            "Saturday"});
            this.cmb_day.Location = new System.Drawing.Point(102, 35);
            this.cmb_day.Name = "cmb_day";
            this.cmb_day.Size = new System.Drawing.Size(215, 36);
            this.cmb_day.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Day";
            // 
            // Nonres_Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 641);
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
    }
}