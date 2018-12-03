using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMATSConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminLogin al = new AdminLogin();
            al.AdminL();
            /*string choice;
            Console.WriteLine("Welcome To User Management System");
            Console.WriteLine("\nWhat You Are(Admin/User)?");
            choice = Console.ReadLine().ToUpper();
            switch (choice)
            {
                case "ADMIN":
                    AdminLogin a1 = new AdminLogin();
                    a1.AdminL();
                    break;
                case "USER":
                    User u1 = new User();
                    u1.UserHome();
                    break;
                default:
                    Console.WriteLine("Something wrong..Try Again !!");
                    Console.WriteLine();
                    break;
            }   



            Console.Read();
        }*/
        }
    }
}
