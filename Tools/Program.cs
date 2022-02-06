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
                try
                {
                    form.ifd(1, 0);
                    int ifp1 = Convert.ToInt32(Console.ReadLine());
                    
                    if (ifp1 == 1)
                    {
                        SLdatabase(ifp1, 0);
                    }
                    if (ifp1 == 2)
                    {
                        form.ifd(ifp1, 0);
                        int ifp2 = Convert.ToInt32(Console.ReadLine());
                        
                        SLdatabase(ifp1, ifp2);
                    }

                    Console.ReadLine();
                    systemx();
                }
                catch (Exception)
                {
                    form.ifd(10, 0);
                    Console.ReadLine();
                    systemx();
                }
            }

        }
        static void SLdatabase(int if1, int if2)
        {
            SystemChrom dt = new SystemChrom();
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
                        
                        dt.kq(tk, mk,if1,if2);

                    }); t.Start();
                }
                con.Close();
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