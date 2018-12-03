using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UMATSConsole
{
    class AdminLogin
    {
        public void AdminL()
        {
            //Console.WriteLine("\nType Your ID & Password");
            Console.Write("\nYour ID No. : ");
            string idno = Console.ReadLine();
            Console.Write("Your Password: ");
            string password = Console.ReadLine();
             Alogin l1 = new Alogin();
            l1.authentication(idno, password);
        }
    }
    class Alogin{
    public void authentication(string idno, string password)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from adduser where idno='" + idno + "' and password='" + password + "'", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Admin a1 = new Admin();
                a1.AdminHome(idno, password);
            }
            //Console.WriteLine("Try Again");

        }
    }
}

