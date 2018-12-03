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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select userrole from adduser where idno='" + textBox1.Text + "'and password ='" + textBox2.Text + "'", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "Admin")
            {
                this.Hide();
                Login l = new Login();
                l.alogin();
                Close();
            }
            else if ((dt.Rows[0][0].ToString() == "Student"))
            {
                this.Hide();
                Login l1 = new Login();
                l1.slogin();
                Close();
            }
            else
            {
                this.Hide();
                User u2 = new User(dt.Rows[0][0].ToString());
                u2.ShowDialog();
                Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
