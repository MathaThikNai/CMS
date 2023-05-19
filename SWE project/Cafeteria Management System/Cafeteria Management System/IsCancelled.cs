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
    public partial class IsCancelled : Form
    {
        public IsCancelled()
        {
            InitializeComponent();
        }



        private void IsCancelled_Load(object sender, EventArgs e)
        {

        }

        private void btn_place_Order_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new dashboard().Show();
        }

        private void btn_cancell_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show(); 
            MessageBox.Show("Your meal have been cancelled!");
        }
    }
}
