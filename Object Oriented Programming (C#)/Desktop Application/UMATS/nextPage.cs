using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace UMATS
{
    public partial class nextPage : Form
    {
        public nextPage(string f1_value)
        {
            InitializeComponent();
            textBox3.Text = f1_value; //get the passing value
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Today");
            comboBox1.Items.Add("All");
            comboBox1.Items.Add("Custom");
        }
        public void aDatagrFuc1()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dataGridView1.Rows[i].Cells[0].Style.BackColor = System.Drawing.Color.LawnGreen;
                    dataGridView1.Rows[i].Cells[1].Style.BackColor = System.Drawing.Color.LawnGreen;

                }
                else
                {
                    dataGridView1.Rows[i].Cells[0].Style.BackColor = System.Drawing.Color.White;
                    dataGridView1.Rows[i].Cells[1].Style.BackColor = System.Drawing.Color.White;
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            aDone aDoneObj = new aDone();
            aDoneObj.aDoneFuc();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Today")
            {
                SqlConnection show_conn = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
                show_conn.Open();
                SqlCommand cmd = new SqlCommand("select * from login1 where id='" + textBox1.Text + "'and password='" + textBox2.Text + "'and pcode='" + textBox3.Text + "'", show_conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count += 1;
                }
                if (count == 1)
                {

                    //---------------------------------This is show person attendence list by dataGridView------------------------------------------------------//
                    SqlConnection retrive_DATA = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
                    retrive_DATA.Open();
                    string date_show = DateTime.Now.ToString("dd/MM/yyyy");
                    SqlCommand retrive_DATA_com = new SqlCommand("SELECT date as 'Date',time as 'Punch Time' From attendence1 where pcode='" + textBox3.Text + "' and date='" + date_show + "'", retrive_DATA);
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(retrive_DATA_com);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = ds.Tables[0].ToString();
                    dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Lavender;
                    dataGridView1.ClearSelection(); //This will not select the first coloumn



                    //###############

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            dataGridView1.Rows[i].Cells[0].Style.BackColor = System.Drawing.Color.LawnGreen;
                            dataGridView1.Rows[i].Cells[1].Style.BackColor = System.Drawing.Color.LawnGreen;

                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[0].Style.BackColor = System.Drawing.Color.White;
                            dataGridView1.Rows[i].Cells[1].Style.BackColor = System.Drawing.Color.White;
                        }
                    }

                    //###############


                    ////////////@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

                    SqlConnection count_con = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
                    count_con.Open();
                    string date_show1 = DateTime.Now.ToString("dd/MM/yyyy");
                    SqlCommand enter_com = new SqlCommand("SELECT COUNT(time) FROM attendence1 WHERE date='" + date_show1 + "'and pcode='" + textBox3.Text + "'", count_con);//this will count
                    Int32 count_result = (Int32)enter_com.ExecuteScalar();
                    count_con.Close();
                    if (count_result % 2 == 0)
                    {
                        MessageBox.Show("You did entry and exit today.");
                    }
                    else
                    {
                        MessageBox.Show("Exit time not available.");
                    }




                    ////////////@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@


                }
                else if (count > 0)
                {
                    MessageBox.Show("You got some duplicate password!!!");
                }
                else
                    MessageBox.Show("Wrong id or password");
            }
            else if (comboBox1.Text == "All")
            {
                SqlConnection show_conn = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
                show_conn.Open();
                SqlCommand cmd = new SqlCommand("select * from login1 where id='" + textBox1.Text + "'and password='" + textBox2.Text + "'and pcode='" + textBox3.Text + "'", show_conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count += 1;
                }
                if (count == 1)
                {

                    //---------------------------------This is show person attendence list by dataGridView------------------------------------------------------//
                    SqlConnection retrive_DATA = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
                    retrive_DATA.Open();
                    SqlCommand retrive_DATA_com = new SqlCommand("SELECT date as 'Date',time as 'Punch Time' From attendence1 where pcode='" + textBox3.Text + "'", retrive_DATA);
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(retrive_DATA_com);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = ds.Tables[0].ToString();
                    dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Lavender;
                    dataGridView1.ClearSelection(); //This will not select the first coloumn

                }
                else if (count > 0)
                {
                    MessageBox.Show("You got some duplicate password!!!");
                }
                else
                    MessageBox.Show("Wrong id or password");
            }
            else if (comboBox1.Text == "Custom")
            {
                //string input = Interaction.InputBox("Choose one", "Pick a date", "Date");
                //MessageBox.Show(input);
                SqlConnection show_conn = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
                show_conn.Open();
                SqlCommand cmd = new SqlCommand("select * from login1 where id='" + textBox1.Text + "'and password='" + textBox2.Text + "'and pcode='" + textBox3.Text + "'", show_conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count += 1;
                }
                if (count == 1)
                {
                    //There are two property if you want can use later.
                    string input_custom = Interaction.InputBox("Type the date you want to see record of\nInput format:DD/MM/YYYY", "Pick a date", "DD/MM/YYYY");


                    //---------------------------------This is show person attendence list by dataGridView------------------------------------------------------//
                    SqlConnection retrive_DATA = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
                    retrive_DATA.Open();
                    //string date_show = DateTime.Now.ToString("dd/MM/yyyy");
                    SqlCommand retrive_DATA_com = new SqlCommand("SELECT date as 'Date',time as 'Punch Time' From attendence1 where pcode='" + textBox3.Text + "'and date='" + input_custom + "'", retrive_DATA);
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(retrive_DATA_com);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = ds.Tables[0].ToString();
                    dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Lavender;
                    dataGridView1.ClearSelection(); //This will not select the first coloumn
                    //###############
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    {
                        if (j % 2 == 0)
                        {
                            dataGridView1.Rows[j].Cells[0].Style.BackColor = System.Drawing.Color.LawnGreen;
                            dataGridView1.Rows[j].Cells[1].Style.BackColor = System.Drawing.Color.LawnGreen;
                        }
                        else
                        {
                            dataGridView1.Rows[j].Cells[0].Style.BackColor = System.Drawing.Color.White;
                            dataGridView1.Rows[j].Cells[1].Style.BackColor = System.Drawing.Color.White;
                        }
                    }
                    //###############

                }
                else if (count > 0)
                {
                    MessageBox.Show("You got some duplicate password!!!");
                }
                else
                    MessageBox.Show("Wrong id or password");


            }
        }
    }
}
