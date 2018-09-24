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
            for (int y = -5; y <= 5; y++)
            {
                var x = Math.Pow(y,2) + 2 * y + 1;
                Console.WriteLine($"For y = {x}, x = {y}");
            }

            Console.ReadLine();

            // Problems:
            // 1. x is incorrectly calculated (Hint: problem is with ^ operator) -> Checked

            // What can be improved:
            // 1. "x" can be declared in for loop -> Checked
            // 2. You can use string interpolation in row 19 - $"{}"  -> Checked
        }
    }
}
