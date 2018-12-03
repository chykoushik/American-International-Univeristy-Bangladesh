using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UMATSConsole
{
    class Attendance
    {
        public void AttendanceHome()
        {
            string option1;
            Console.WriteLine("\nAttendance Tracker");
            Console.WriteLine("\n1. Punch");
            Console.WriteLine("2. Show");
            Console.WriteLine("3. Exit");


            option1 = Console.ReadLine();
            switch (option1)
            {
                case "1":
                    Punch ph = new Punch();
                    ph.PunchHome();
                    break;
                case "2":
                    Show sh = new Show();
                    sh.ShowHome();
                    break;
                case "3":
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

    class Punch
    {
        public void PunchHome()
        {
            Console.WriteLine("Enter Pcode : ");
            string pcode = Console.ReadLine();
            SqlConnection enter_show = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
            enter_show.Open();
            SqlCommand enter_show_com = new SqlCommand("select time from attendence1 where pcode='" + pcode + "'", enter_show);
            enter_show_com.ExecuteNonQuery();
            string check = enter_show_com.ExecuteScalar().ToString();
            enter_show.Close();

            string sta = DateTime.Now.ToString("HH:mm");
            string date_only = DateTime.Now.ToString("dd/MM/yyyy");

            if (check != "")
            {

                SqlConnection con_enter = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
                con_enter.Open();
                SqlCommand enter_com = new SqlCommand("insert into attendence1 (time,date,pcode) values ('" + sta + "','" + date_only + "','" + pcode + "')", con_enter);
                enter_com.ExecuteNonQuery();
                con_enter.Close();
                //MessageBox.Show("Time recorded.");
                Console.Write("Time Recorded");
                //Console.Write(" ");
            }


            else if (check == "")
            {
                SqlConnection con_enter = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
                con_enter.Open();
                SqlCommand enter_com = new SqlCommand("UPDATE attendence1 SET time='" + sta + "',date='" + date_only + "' WHERE pcode='" + pcode + "'", con_enter);
                enter_com.ExecuteNonQuery();
                con_enter.Close();
                Console.Write("Time Recorded");
                //Console.Write(" ");
            }

            Admin adm_obj = new Admin();
            adm_obj.AdminHome(" ", " ");



        }
    }


    

    class Show
    {
        public void ShowHome()
        {
            string option2;
            Console.WriteLine("\n1. Today");
            Console.WriteLine("2. All");
            Console.WriteLine("3. Exit");


            option2 = Console.ReadLine();
            switch (option2)
            {
                case "1":


                    Console.Write("\nID No. : ");
                    string id = Console.ReadLine();
                    Console.Write("Password : ");
                    string password = Console.ReadLine();
                    Console.Write("PCode : ");
                    string pcode = Console.ReadLine();

                    SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("select * from login1 where id='" + id + "'and password='" + password + "'and pcode='" + pcode + "'", con);
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        try
                        {
                            SqlConnection con1 = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
                            con1.Open();
                            string date_show = DateTime.Now.ToString("dd/MM/yyyy");
                            string sql1 = "SELECT * From attendence1 where pcode='" + pcode + "' and date='" + date_show + "'";
                            SqlCommand view = new SqlCommand(sql1, con1);


                            SqlDataReader reader1 = view.ExecuteReader();


                            while (reader1.Read())
                            {
                                Console.WriteLine("\nUser Information");
                                Console.WriteLine("\nID = " + reader1.GetValue(0).ToString());
                                 Console.WriteLine("Time = " + reader1.GetValue(1).ToString());
                                Console.WriteLine("Date = " + reader1.GetValue(2).ToString());
                                Console.WriteLine("Pcode= " + reader1.GetValue(3).ToString());



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

                    //con.Close();


                    break;
                case "2":
                   
                    Console.Write("\nID No. : ");
                    string id1 = Console.ReadLine();
                    Console.Write("Password : ");
                    string password1 = Console.ReadLine();
                    Console.Write("PCode : ");
                    string pcode1 = Console.ReadLine();

                    SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
                    conn.Open();

                    SqlCommand cmdd = new SqlCommand("select * from login1 where id='" + id1 + "'and password='" + password1 + "'and pcode='" + pcode1 + "'", conn);
                    SqlDataReader reader2;
                    reader2 = cmdd.ExecuteReader();
                    while (reader2.Read())
                    {
                        try
                        {
                            SqlConnection con1 = new SqlConnection("Data Source=localhost;Initial Catalog=UMAT;Integrated Security=True");
                            con1.Open();
                            //string date_show = DateTime.Now.ToString("dd/MM/yyyy");
                            string sql5 = "SELECT * From attendence1 where pcode='" + pcode1 + "'";
                            SqlCommand view1 = new SqlCommand(sql5, con1);


                            SqlDataReader reader3 = view1.ExecuteReader();


                            while (reader3.Read())
                            {
                                Console.WriteLine("\nUser Information");
                                Console.WriteLine("\nID = " + reader3.GetValue(0).ToString());
                                Console.WriteLine("Time = " + reader3.GetValue(1).ToString());
                                Console.WriteLine("Date = " + reader3.GetValue(2).ToString());
                                Console.WriteLine("Pcode= " + reader3.GetValue(3).ToString());



                            }
                            Admin adm_obj = new Admin();
                            adm_obj.AdminHome(" ", " ");

                            conn.Close();
                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        Console.ReadLine();
                        //reader.Close();
                    }
                    break;
                case "3":
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


}





