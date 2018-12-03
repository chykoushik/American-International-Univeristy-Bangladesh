using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UMATSConsole
{
    class Admin
    {
        public void AdminHome(string idno, string password)
        {
            string option;
            Console.WriteLine("\nWELCOME");
            Console.WriteLine("\n1. Add User");
            Console.WriteLine("2. Update User");
            Console.WriteLine("3. Remove User");
            Console.WriteLine("4. View");
            Console.WriteLine("5. Attendance Tracker");
            Console.WriteLine("6. Exit");
            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    AddUser ad = new AddUser();
                    ad.AddUserHome();
                    break;
                case "2":
                    Update u1 = new Update();
                    u1.UpdateHome();
                    break;
                case "3":
                    Delete r = new Delete();
                    r.DeleteHome();
                    break;
                case "4":
                    View v1 = new View();
                    v1.ViewHome();
                    break;
                case "5":
                    Attendance at = new Attendance();
                    at.AttendanceHome();
                    break;

                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Something wrong..Try Again !!");
                    Console.WriteLine();
                    Admin adm_obj1 = new Admin();
                    adm_obj1.AdminHome(" ", " ");
                    break;
            }   

        }
    }

    class AddUser{
        public void AddUserHome()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
            con.Open();
            //SqlDataAdapter SDA = new SqlDataAdapter("INSERT INTO adduser(firstname,lastname,idno,password,dob,email,fathername,mothername,result,bloodgroup,department,address,userrole)VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + dateTimePicker1.Text + "', '" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + comboBox1.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + comboBox2.Text + "')", con);
            //SDA.SelectCommand.ExecuteNonQuery();
            //con.Close();
            Console.Write("\nFirst Name : ");
            string firstname = Console.ReadLine();
            Console.Write("Last Name : ");
            string lastname = Console.ReadLine();
            Console.Write("ID No. : ");
            string idno = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.Write("Dob(Friday, December 25,2015) : ");
            string dob = Console.ReadLine();
            Console.Write("Email : ");
            string email = Console.ReadLine();
            Console.Write("Father Name : ");
            string fathername = Console.ReadLine();
            Console.Write("Mother Name : ");
            string mothername = Console.ReadLine();
            Console.Write("Result: ");
            string result = Console.ReadLine();
            Console.Write("Blodd group : ");
            string bloodgroup = Console.ReadLine();
            Console.Write("Departname : ");
            string department = Console.ReadLine();
            Console.Write("Address : ");
            string address = Console.ReadLine();
            Console.Write("User Role : ");
            string userrole = Console.ReadLine();

            string sql="INSERT INTO adduser(firstname,lastname,idno,password,dob,email,fathername,mothername,result,bloodgroup,department,address,userrole)VALUES('" + firstname + "', '" + lastname + "', '" + idno + "', '" + password + "', '" + dob + "', '" + email + "','" + fathername + "','" + mothername + "','" + result + "','" + bloodgroup + "','" + department + "','" + address + "','" + userrole + "')";
            SqlCommand cmd=new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            Console.WriteLine("\nSuccessfully Submitted");

            Admin adm_obj1 = new Admin();
            adm_obj1.AdminHome(" ", " ");
        }


    }

    class View
    {
        public void ViewHome()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
                con.Open();
                //SqlCommand cmd = new SqlCommand("SELECT * FROM adduser", con);
                string sql1 = "SELECT * FROM adduser";
                SqlCommand view = new SqlCommand(sql1, con);
                //view.ExecuteNonQuery();

                SqlDataReader reader = view.ExecuteReader();


                while (reader.Read())
                {
                    Console.WriteLine("\nUser Information");
                    Console.WriteLine("\nFirst Name = " + reader.GetValue(0).ToString());
                    Console.WriteLine("Last Name = " + reader.GetValue(1).ToString());
                    Console.WriteLine("ID No. = " + reader.GetValue(2).ToString());
                    Console.WriteLine("Password = " + reader.GetValue(3).ToString());
                    Console.WriteLine("Dob = " + reader.GetValue(4).ToString());
                    Console.WriteLine("Email = " + reader.GetValue(5).ToString());
                    Console.WriteLine("Father Name = " + reader.GetValue(6).ToString());
                    Console.WriteLine("Mother Name = " + reader.GetValue(7).ToString());
                    Console.WriteLine("Result = " + reader.GetValue(8).ToString());
                    Console.WriteLine("Blood Group = " + reader.GetValue(9).ToString());
                    Console.WriteLine("Department = " + reader.GetValue(10).ToString());
                    Console.WriteLine("Address = " + reader.GetValue(11).ToString());
                    Console.WriteLine("User Role = " + reader.GetValue(12).ToString());
                   
                   

                }
                Admin adm_obj = new Admin();
                adm_obj.AdminHome(" ", " ");

                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            //reader.Close();
            }
        }

    class Delete
    {
        public void DeleteHome()
        {
           //Console.Write("ID Number : ");
           //string idno = Console.ReadLine();

           SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
           con.Open();
           Console.Write("ID No. : ");
           string idno = Console.ReadLine();
           string sql2 = "DELETE FROM adduser WHERE idno='" + idno + "' ";
           SqlCommand delete = new SqlCommand(sql2, con);
           delete.ExecuteNonQuery();
           Console.WriteLine("Deleted");

          Admin adm_obj1 = new Admin();
          adm_obj1.AdminHome(" ", " ");
        }
        
    }


    class Update
    {
        public void UpdateHome()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
            con.Open();
            Console.Write("ID No. : ");
            string idno = Console.ReadLine();
            Console.Write("User Role : ");
            string userrole = Console.ReadLine();
            string sql3 = "UPDATE adduser set idno='" + idno + "', userrole='" + userrole+"' ";
            SqlCommand update = new SqlCommand(sql3, con);
            update.ExecuteNonQuery();
            Console.WriteLine("Updated");
            Admin adm_obj1 = new Admin();
            adm_obj1.AdminHome(" ", " ");
        }
    }


    

}

