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
    public partial class firstForm : Form
    {
        public firstForm()
        {
            InitializeComponent();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_Form().Show();
        }


        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =cms.accdb");

        OleDbCommand cmd = new OleDbCommand();
        void fill_arr_of_stdnts()
        {

            conn.Close();

            management.arr_stdnt.Clear();

            try
            {


                conn.Open();


                string t = "Select * from st_table";

                cmd = new OleDbCommand(t, conn);
                OleDbDataReader dr;

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {


                    student st = new student(dr["name"].ToString(), Convert.ToInt32(dr["st_id"].ToString()), dr["status"].ToString(), dr["pass"].ToString());

                    management.arr_stdnt.Add(st);

                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_stdnt_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Login().Show();
        }

        private void firstForm_Load(object sender, EventArgs e)
        {
            fill_arr_of_stdnts();
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }
    }
}
