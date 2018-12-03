using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMATS
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string location = textBox1.Text;

            StringBuilder add = new StringBuilder("http://maps.google.com/maps?q=");

            add.Append(location);
            webBrowser1.Navigate(add.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapC mp = new MapC();
            mp.Back();
            Close();
        }
    }
}
