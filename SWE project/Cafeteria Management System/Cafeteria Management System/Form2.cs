using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria_Management_System
{
    public partial class menu_update : Form
    {
        public menu_update()
        {
            InitializeComponent();
        }

        private void bac_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_Form().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void platter_txt1_TextChanged(object sender, EventArgs e)
        {
           
        }

        public static string f;
        public static string g;
        public static string h;
        private void btn_update_Click(object sender, EventArgs e)
        {
            f = txt_platter1.Text;
            g = txt_platter2.Text;
            h = txt_platter3.Text;
          

            MessageBox.Show("Menu Has Been Updated");
        }

        private void menu_update_Load(object sender, EventArgs e)
        {

        }
    }
}
