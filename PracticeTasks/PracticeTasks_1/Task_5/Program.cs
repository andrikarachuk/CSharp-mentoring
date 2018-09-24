using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Enter first digit: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second digit: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third digit: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.Write("The greatest digit among three is {0}", FindMax(a, b, c));
            Console.ReadKey();
        }

        public static int FindMax(int a, int b, int c)
        {
            int[] whereMax = new int[] {a, b, c};
            return whereMax.Max();
        }
    }

    // What can be improved:
    // 1. Method FindMax can be made private
    // 2. You can combine variable definition and initialization - rows 13, 15, 17, 19
    // 3. You can use string interpolation - row 21

    // Things to do:
    // 1. You can try to implement finding max number in array on your own
}
