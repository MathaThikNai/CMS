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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =cms.accdb");

        OleDbCommand cmd = new OleDbCommand();

        private void btn_register_Click(object sender, EventArgs e)
        {
            student st = new student(txt_name.Text, Convert.ToInt32(txt_st_id.Text), cmb_status.Text, txt_pass.Text);
            
            management.arr_stdnt.Add(st);

            try
            {


                conn.Open();


                string t = "INSERT INTO st_table(name,st_id,status,pass) VALUES" + "(@name,@std,@stat,@password)";

                cmd = new OleDbCommand(t, conn);

                cmd.Parameters.AddWithValue("@name",st.name);

                cmd.Parameters.AddWithValue("@std",st.id);

                cmd.Parameters.AddWithValue("@stat",st.status );

                cmd.Parameters.AddWithValue("@password",st.password); 


                cmd.ExecuteNonQuery();
                conn.Close();


                MessageBox.Show("You've Registered in the System Successfully!");


                txt_name.Clear();
                txt_pass.Clear();
                txt_st_id.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void login_link_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            new Login().Show();
        }

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
        private void Form1_Load(object sender, EventArgs e)
        {
            fill_arr_of_stdnts();


        }
    }
}
