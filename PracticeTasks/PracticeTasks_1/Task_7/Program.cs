using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.Write("Input the Grade (E, V, G, A or F): ");
            s = Console.ReadLine();
            Grade(s);

            Console.ReadKey();

        }

        public static void Grade(String s) 
        {
            switch(s)
            {
                case "E":
                    Console.WriteLine("You have chosen: Excellent");
                    break;
                case "V":
                    Console.WriteLine("You have chosen: Very Good");
                    break;
                case "G":
                    Console.WriteLine("You have chosen: Good");
                    break;
                case "A":
                    Console.WriteLine("You have chosen: Average");
                    break;
                case "F":
                    Console.WriteLine("You have chosen: Fail");
                    break;
                default:
                    Console.WriteLine("You have chosen: There is no such grade");
                    break;
            }
        }
    }
}
