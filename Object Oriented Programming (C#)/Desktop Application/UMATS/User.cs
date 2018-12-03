using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UMATS
{
    public partial class User : Form
    {
        SqlDataAdapter adapter; 
        public User(string userrole)
        {
            InitializeComponent();
            label1.Text = userrole;
        }
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");


        private void User_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            //SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM adduser", con);
            SqlDataAdapter SDA = new SqlDataAdapter("select * from adduser where userrole like 'Student' ", con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            //dataGridView1.DataSource = Data;
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                dataGridView1.Rows[n].Cells[10].Value = item[10].ToString();
                dataGridView1.Rows[n].Cells[11].Value = item[11].ToString();
                dataGridView1.Rows[n].Cells[12].Value = item[12].ToString();

            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
            
            /*dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            dataGridView1.SelectedRows[0].Cells[12].Value.ToString();*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           /* con.Open();
            adapter = new SqlDataAdapter("select * from adduser where idno like '" + textBox1.Text + "%'", con);
            DataTable Data = new DataTable();
            adapter.Fill(Data);
            dataGridView1.DataSource = Data;
            con.Close(); */
        }
    }
}
