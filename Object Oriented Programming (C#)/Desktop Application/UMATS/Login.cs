using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMATS
{
    class Login
    {
        public void alogin()
        {
            Admin a1 = new Admin();
            //Admin a1 = new Admin(dt.Rows[0][0].ToString());
            a1.ShowDialog();
        }

        public void slogin()
        {
            Student s = new Student();
            s.ShowDialog();
        }

        
    }
}
