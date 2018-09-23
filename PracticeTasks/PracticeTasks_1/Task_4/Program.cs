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
    }
}
