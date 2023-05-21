namespace Cafeteria_Management_System
{
    partial class IsCancelled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsCancelled));
            this.btn_cancell = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_place_Order = new Guna.UI.WinForms.GunaGradientButton();
            this.SuspendLayout();
            // 
            // btn_cancell
            // 
            this.btn_cancell.AnimationHoverSpeed = 0.07F;
            this.btn_cancell.AnimationSpeed = 0.03F;
            this.btn_cancell.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancell.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancell.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cancell.BorderColor = System.Drawing.Color.Black;
            this.btn_cancell.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_cancell.FocusedColor = System.Drawing.Color.Empty;
            this.btn_cancell.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancell.ForeColor = System.Drawing.Color.White;
            this.btn_cancell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_cancell.Image = null;
            this.btn_cancell.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_cancell.Location = new System.Drawing.Point(12, 37);
            this.btn_cancell.Name = "btn_cancell";
            this.btn_cancell.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_cancell.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_cancell.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_cancell.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_cancell.OnHoverImage = null;
            this.btn_cancell.OnPressedColor = System.Drawing.Color.Black;
            this.btn_cancell.Radius = 20;
            this.btn_cancell.Size = new System.Drawing.Size(377, 506);
            this.btn_cancell.TabIndex = 25;
            this.btn_cancell.Text = "Cancel Meal ";
            this.btn_cancell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_cancell.Click += new System.EventHandler(this.btn_cancell_Click);
            // 
            // btn_place_Order
            // 
            this.btn_place_Order.AnimationHoverSpeed = 0.07F;
            this.btn_place_Order.AnimationSpeed = 0.03F;
            this.btn_place_Order.BackColor = System.Drawing.Color.Transparent;
            this.btn_place_Order.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_place_Order.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_place_Order.BorderColor = System.Drawing.Color.Black;
            this.btn_place_Order.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_place_Order.FocusedColor = System.Drawing.Color.Empty;
            this.btn_place_Order.Font = new System.Drawing.Font("Eras Demi ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_place_Order.ForeColor = System.Drawing.Color.White;
            this.btn_place_Order.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_place_Order.Image = null;
            this.btn_place_Order.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_place_Order.Location = new System.Drawing.Point(417, 37);
            this.btn_place_Order.Name = "btn_place_Order";
            this.btn_place_Order.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_place_Order.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_place_Order.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_place_Order.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_place_Order.OnHoverImage = null;
            this.btn_place_Order.OnPressedColor = System.Drawing.Color.Black;
            this.btn_place_Order.Radius = 20;
            this.btn_place_Order.Size = new System.Drawing.Size(371, 506);
            this.btn_place_Order.TabIndex = 26;
            this.btn_place_Order.Text = "Place Order";
            this.btn_place_Order.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_place_Order.Click += new System.EventHandler(this.btn_place_Order_Click_1);
            // 
            // IsCancelled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(806, 560);
            this.Controls.Add(this.btn_place_Order);
            this.Controls.Add(this.btn_cancell);
            this.Name = "IsCancelled";
            this.Text = "IsCancelled";
            this.Load += new System.EventHandler(this.IsCancelled_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton btn_cancell;
        private Guna.UI.WinForms.GunaGradientButton btn_place_Order;
    }
}