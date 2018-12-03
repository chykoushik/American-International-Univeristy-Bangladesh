using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace UMATS
{
    class aScan
    {
        public void aScanFunc(string rec_sub_msg)
        {
            string sub_msg = rec_sub_msg;
            SqlConnection enter_show = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
            enter_show.Open();
            SqlCommand enter_show_com = new SqlCommand("select time from attendence1 where pcode='" + sub_msg + "'", enter_show);
            enter_show_com.ExecuteNonQuery();
            string check = enter_show_com.ExecuteScalar().ToString();
            enter_show.Close();

            string sta = DateTime.Now.ToString("HH:mm");
            string date_only = DateTime.Now.ToString("dd/MM/yyyy");

            if (check != "")
            {

                SqlConnection con_enter = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
                con_enter.Open();
                SqlCommand enter_com = new SqlCommand("insert into attendence1 (time,date,pcode) values ('" + sta + "','" + date_only + "','" + sub_msg + "')", con_enter);
                enter_com.ExecuteNonQuery();
                con_enter.Close();
                MessageBox.Show("Time recorded.");
            }


            else if (check == "")
            {
                SqlConnection con_enter = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
                con_enter.Open();
                SqlCommand enter_com = new SqlCommand("UPDATE attendence1 SET time='" + sta + "',date='" + date_only + "' WHERE pcode='" + sub_msg + "'", con_enter);
                enter_com.ExecuteNonQuery();
                con_enter.Close();
                MessageBox.Show("Time recorded.");
                //-------------------------------------------------------------------------//
            }

        }
    }
}
