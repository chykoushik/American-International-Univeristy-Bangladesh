using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UMATS
{
    class AdminC
    {
        public void logout()
        {
            //this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            //Close();
            //SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
            
        }
        public void Cal()
        {
            Calculator C = new Calculator();
            C.ShowDialog();
        }

        public void mail()
        {
            Mail m = new Mail();
            m.ShowDialog();
        }

        public void Map()
        {
            Map m1 = new Map();
            m1.ShowDialog();
        }

       
    }
}
