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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if(comboBox2.Text=="Breakfast")
            { cmb_platter.Items.Clear();
                cmb_platter.Items.Add("Platter1");
                cmb_platter.Items.Add("Platter2");
            }
            else if (comboBox2.Text=="Lunch")
            {
                cmb_platter.Items.Clear();
                cmb_platter.Items.Add("Platter3");
                cmb_platter.Items.Add("Platter4");
            }
            else
            {
                cmb_platter.Items.Clear();
                cmb_platter.Items.Add("Platter5");
                cmb_platter.Items.Add("Platter6");
            }
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =cms.accdb");

        OleDbCommand cmd = new OleDbCommand();


        OleDbDataAdapter adapter1 = new OleDbDataAdapter();

        DataTable dt1;
        void fill_order()
        {
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =cms.accdb");


                dt1 = new DataTable();


                adapter1 = new OleDbDataAdapter("SELECT * FROM order_table", conn);



                conn.Open();


                adapter1.Fill(dt1);

                dgw_order.DataSource = dt1;
                


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_place_order_Click(object sender, EventArgs e)
        {
            Order od = new Order(cmb_day.Text, comboBox2.Text, cmb_platter.Text);

            management.arr_order.Add(od);


            try
            {

                string query = "INSERT INTO order_table (dayy,typee,pltr) VALUES" + "(@day,@type,@plater)";


                cmd = new OleDbCommand(query, conn);

                cmd.Parameters.AddWithValue("@day", od.day);

                cmd.Parameters.AddWithValue("@type", od.type);

                cmd.Parameters.AddWithValue("@plater", od.menu);

             





                conn.Open();


                cmd.ExecuteNonQuery();


                conn.Close();
            
                
                fill_order();

                MessageBox.Show("Order placed!");

               


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            fill_order();
        }
    }
}
