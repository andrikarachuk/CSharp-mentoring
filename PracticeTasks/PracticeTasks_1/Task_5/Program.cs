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
            Console.Write("Enter first digit: ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second digit: ");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third digit: ");
            var c = Convert.ToInt32(Console.ReadLine());

            Console.Write($"The greatest digit among three is {FindMax(a, b, c)}");
            Console.ReadKey();
        }

        private static int FindMax(int a, int b, int c)
        {
            int[] whereMax = new int[] {a, b, c};
            int max = whereMax[0];
            for (int i = 0; i < whereMax.Length-1; i++)
            {
                max = (whereMax[i] > whereMax[i + 1]) ? whereMax[i] : whereMax[i + 1];
            }
            return max; 
        }
    }

    // What can be improved:
    // 1. Method FindMax can be made private -> Checked
    // 2. You can combine variable definition and initialization - rows 13, 15, 17, 19 -> Checked
    // 3. You can use string interpolation - row 21 -> Checked

    // Things to do:
    // 1. You can try to implement finding max number in array on your own -> Checked
}
