using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    internal class Form
    {
        public Form()
        {

        }
        public void Show(int if1, int if2)
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
