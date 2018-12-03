using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMATS
{
    class MailC
    {
        public void logout()
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }
        public void Back()
        {
            Admin a2 = new Admin();
            a2.ShowDialog();
        }
    }
}
