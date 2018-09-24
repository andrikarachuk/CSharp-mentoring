using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter first digit: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second digit: ");
            b = Convert.ToInt32(Console.ReadLine());

            if ((a+b)%2 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Console.ReadKey();
        }

        // What can be improved:
        // 1. Row 13 is redundant, it can be combined with rows 15 and 17 => var a = Convert.ToInt32(Console.ReadLine());
        // 2. Try to use ?: operator instead of if-else block
    }
}
