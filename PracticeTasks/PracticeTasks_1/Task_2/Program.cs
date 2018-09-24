using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;  

            for (int y = -5; y <= 5; y++)
            {
                
                x = y ^ 2 + 2 * y + 1;
                Console.WriteLine("For y = {0}, x = {1}", y, x);
            }

            Console.ReadLine();

            // Problems:
            // 1. x is incorrectly calculated (Hint: problem is with ^ operator)

            // What can be improved:
            // 1. "x" can be declared in for loop
            // 2. You can use string interpolation in row 19 - $"{}"
        }
    }
}
