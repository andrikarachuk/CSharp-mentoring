using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTasks_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = new char[3] { 'b', 'a', 't' };
            char[] arrTemp = new char[array.Length];   // [Originally row 20] Attention: 3 arrTemp arrays are created as a result of this loop -> Checked

            for (int i = array.Length - 1, j = 0; i >= 0; i--, j++)  // Cool! I haven't known that each "for" loop section can have several statements
            {
                arrTemp[j] = array[i];

                Console.Write(arrTemp[j]);
            }

            Console.ReadKey();

        }

        // What can be improved:

        // 1. You can use var keyword;  -> ??unable to use
        // 2. arrayLength var is not needed -> Checked

        // Problems:
        // 1. See comment in row 20 -> Checked
    }
}
