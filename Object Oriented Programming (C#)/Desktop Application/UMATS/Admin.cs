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
    public partial class Admin : Form
    {
        SqlDataAdapter adapter; 
        public Admin()
        {
            InitializeComponent();
         }
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("INSERT INTO adduser(firstname,lastname,idno,password,dob,email,fathername,mothername,result,bloodgroup,department,address,userrole)VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + dateTimePicker1.Text + "', '" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + comboBox1.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + comboBox2.Text + "')", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Submitted");
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM adduser", con);
            DataTable Data = new DataTable();
            SDA.Fill(Data);
            dataGridView1.DataSource = Data;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("UPDATE adduser set firstname='" + textBox1.Text + "', lastname='" + textBox2.Text + "', password='" + textBox4.Text + "',dob='" + dateTimePicker1.Text + "', email='" + textBox5.Text + "', fathername='" + textBox6.Text + "', mothername='" + textBox7.Text + "', result='" + textBox8.Text + "',bloodgroup='"+comboBox1.Text+"', department='" + textBox9.Text + "', address='" + textBox10.Text + "',  userrole='" + comboBox2.Text + "'WHERE idno='" + textBox3.Text + "'", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM adduser", con);
            DataTable Data = new DataTable();
            SDA.Fill(Data);
            dataGridView2.DataSource = Data;
            con.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("DELETE FROM adduser WHERE idno='" + textBox3.Text + "' ", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted !!!!");
            //this.Controls.Clear();
            //this.InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            textBox6.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
            textBox7.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
            textBox8.Text = dataGridView2.SelectedRows[0].Cells[8].Value.ToString();
            comboBox1.Text = dataGridView2.SelectedRows[0].Cells[9].Value.ToString();
            textBox9.Text = dataGridView2.SelectedRows[0].Cells[10].Value.ToString();
            textBox10.Text = dataGridView2.SelectedRows[0].Cells[11].Value.ToString();
            comboBox2.Text = dataGridView2.SelectedRows[0].Cells[12].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminC ad = new AdminC();
            ad.logout();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            
            con.Open();
            adapter = new SqlDataAdapter("select * from adduser where idno like '" + textBox11.Text + "%'", con);
            DataTable Data = new DataTable();
            adapter.Fill(Data);
            dataGridView2.DataSource = Data;
            con.Close();  
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            adapter = new SqlDataAdapter("select * from adduser where idno like '" + textBox12.Text + "%'", con);
            DataTable Data = new DataTable();
            adapter.Fill(Data);
            dataGridView1.DataSource = Data;
            con.Close(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminC ad1 = new AdminC();
            ad1.Cal();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminC ad2 = new AdminC();
            ad2.mail();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminC ad3 = new AdminC();
            ad3.Map();
            Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
