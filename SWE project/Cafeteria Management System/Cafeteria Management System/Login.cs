using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void reg_link_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            new Form1().Show();
        }



        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =cms.accdb");

        OleDbCommand cmd = new OleDbCommand();

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            for(int  i = 0; i < management.arr_stdnt.Count; i++)
            {

                if (Convert.ToInt32(txt_st_id.Text) == management.arr_stdnt[i].id && txt_pass.Text == management.arr_stdnt[i].password )
                {
                    this.Hide();

                    new dashboard().Show();
                }
            }
        }
    }
}
