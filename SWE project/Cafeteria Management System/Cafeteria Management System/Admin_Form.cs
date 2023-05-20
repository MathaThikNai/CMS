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
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new menu_update().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new firstForm().Show(); 
        }


        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =cms.accdb");

        OleDbCommand cmd = new OleDbCommand();


        OleDbDataAdapter adapter1 = new OleDbDataAdapter();

        DataTable dt1;



        void fill_res()
        {
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =cms.accdb");


                dt1 = new DataTable();


                adapter1 = new OleDbDataAdapter("SELECT * FROM order_table", conn);



                conn.Open();


                adapter1.Fill(dt1);

                dgw_res.DataSource = dt1;



                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        OleDbDataAdapter adapter2 = new OleDbDataAdapter();

        DataTable dt2;



        void fill_nonres()
        {
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =cms.accdb");


                dt2 = new DataTable();


                adapter2 = new OleDbDataAdapter("SELECT * FROM nonres_order_table", conn);



                conn.Open();


                adapter2.Fill(dt2);

                dgw_nonres.DataSource = dt2;



                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            fill_nonres();
            fill_res();
        }

        private void btn_clr_res_Click(object sender, EventArgs e)
        {
            try
            {


                conn.Open();


                string t = "DELETE * FROM order_table";

                cmd = new OleDbCommand(t, conn);




                cmd.ExecuteNonQuery();
                conn.Close();


                MessageBox.Show("DELETED!");

                fill_res();


            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_clr_nonres_Click(object sender, EventArgs e)
        {


            try
            {


                conn.Open();


                string t = "DELETE * FROM nonres_order_table";

                cmd = new OleDbCommand(t, conn);




                cmd.ExecuteNonQuery();
                conn.Close();


                MessageBox.Show("DELETED!");

                fill_nonres();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
