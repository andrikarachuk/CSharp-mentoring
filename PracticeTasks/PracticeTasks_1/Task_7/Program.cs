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

    // What can be improved:
    // 1. Try to give meaningful names to local variables, method names and method parameters => e.g. "Grade, s," are bad names
    // 2. You can combine variable declarationa and initialization - rows 13 and 15
    // 3. Method Grade has 2 responsibilities, it's better to make it responsible only for string description determination
    // 4. Try to use short type names if they exist, e.g. string instead of String
    // 5. Method Grade can be made private
}
