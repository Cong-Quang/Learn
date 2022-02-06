using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tools
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.SetWindowSize(35, 10);
           
            systemx();
            void systemx()
            {
                Form form = new Form();
                form.show(1,0);

                try
                {
                    int if1 = Convert.ToInt32(Console.ReadLine());

                    if (if1 == 1)
                    {
                        SLdatabase(1,0);
                    }
                    if (if1 ==2)
                    {
                        int if2 = Convert.ToInt32(Console.ReadLine());
                    }
                    systemx();
                }
                catch (Exception)
                {
                    form.show(10, 0);
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
                while (reader.Read())
                {
                    string tk = reader.GetString(0);
                    string mk = reader.GetString(1);

                    Thread t = new Thread(() =>
                    {
                        SystemChrom dt = new SystemChrom();
                        Thread y2 = new Thread(() =>
                        {
                            dt.Usename = tk; dt.Password = mk;
                            dt.login();
                            dt.Cif11 = if1; dt.Cif21 = if2;
                            dt.AcctionChrom();
                        });
                        y2.Start();
                        while (true)
                        {
                            if (t1 == 1)
                            {
                                dt.QuitCH1 = false;
                                dt.QuitChrom();
                            }
                        }
                    }); t.Start();

                }
                con.Close();
                Console.Clear();
                Console.Write("Enter để thoát all\n\t-> ");
                Console.ReadLine();
                t1 = 1;
                
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("|     Lỗi kết nối tới database    |");
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}