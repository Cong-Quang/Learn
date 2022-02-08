using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Drawing;
namespace Tools
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // VietNamese
            Console.SetWindowSize(35, 10); // set console size
            systemx();
            void systemx()
            {
                form(1,0); 
                try
                {
                    int if1 = Convert.ToInt32(Console.ReadLine());
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    if (if1 == 1)
                    {
                        SLdatabase(1, 0);
                    }
                    if (if1 ==2)
                    {
                        // Continue to be updated later
                        int if2 = Convert.ToInt32(Console.ReadLine());
                    }
                    systemx();
                }
                catch (Exception)
                {
                    form(10,0);
                    Console.ReadLine();
                    systemx();
                }
            }
        }
        static void SLdatabase(int if1, int if2)
        {
            int t1 = 0;
            string linkdata = @"D:\Nghề";
            string data = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + linkdata + @"\Database.accdb";
            try
            {
                OleDbConnection con = new OleDbConnection(data);
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT tk.tk, tk.mk FROM tk";
                cmd.ExecuteNonQuery();
                OleDbDataReader reader = cmd.ExecuteReader();
                        /*
                      | |data -> |
           check exit | |data -> | Perform functions
                      | |data -> |
                        */
                while (reader.Read())
                {
                    string tk = reader.GetString(0);
                    string mk = reader.GetString(1);
                    Thread t = new Thread(() =>
                    {
                        SystemChrom dt = new SystemChrom();
                        Thread y2 = new Thread(() =>
                        {
                            Thread.Sleep(1000);
                            //get data and login
                            dt.Usename = tk; dt.Password = mk;
                            dt.login();
                            //Perform functionality ( key down )
                            dt.Cif11 = if1; dt.Cif21 = if2;
                            dt.AcctionChrom();
                        });
                        y2.Start();
                        //check exit
                        while (true)
                        {
                            Thread.Sleep(1000); //create time off so as not to spill data
                            if (t1 == 1)
                            {
                                dt.QuitCH1 = false;
                                dt.QuitChrom();
                                t1 = 0; //Returns like old (* Important)
                            }
                        }
                    }); t.Start();
                }
                con.Close();
                Console.Clear();
                Console.Write("Enter để thoát all\n\t-> ");
                Console.ReadLine(); t1 = 1;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("|     Lỗi kết nối tới database    |");
                Console.WriteLine("-----------------------------------");
            }
        }
        static void form(int if1, int if2)
        {
            Console.Title = "Tools";
            switch (if1)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("| 1: Auto Lướt and random like    |");
                    Console.WriteLine("| 2: Auto report                  |");
                    Console.WriteLine("| 3:                              |");
                    Console.WriteLine("-----------------------------------");
                    Console.Write("\t-> ");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("| 1:                              |");
                    Console.WriteLine("| 2:                              |");
                    Console.WriteLine("| 3:                              |");
                    Console.WriteLine("| 4:                              |");
                    Console.WriteLine("| 5:                              |");
                    Console.WriteLine("| 6:                              |");
                    Console.WriteLine("-----------------------------------");
                    Console.Write("\t-> ");
                    switch (if2)
                    {
                        case 1:
                            Console.Clear();

                            break;
                        case 2:
                            Console.Clear();
                            break;
                        case 3:
                            Console.Clear();
                            break;
                        case 4:
                            Console.Clear();
                            break;
                        case 5:
                            Console.Clear();
                            break;
                        case 6:
                            Console.Clear();
                            break;
                        default:
                            break;
                    }
                    break;
                case 10:
                    Console.Clear();
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("|               Lỗi               |");
                    Console.WriteLine("-----------------------------------");
                    Console.Write("Enter ");
                    break;

                default:
                    break;
            }
        }

    }
}
