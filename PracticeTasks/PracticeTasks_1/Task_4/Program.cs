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
            Console.Write("Enter first digit: ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second digit: ");
            var b = Convert.ToInt32(Console.ReadLine());

            bool result = ((a + b) % 2 == 0);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        // What can be improved:
        // 1. Row 13 is redundant, it can be combined with rows 15 and 17 => var a = Convert.ToInt32(Console.ReadLine()); -> Checked
        // 2. Try to use ?: operator instead of if-else block -> Checked

        // Some comments:
        // 1. With current implementation ?: operator is not needed:)
    }
}
