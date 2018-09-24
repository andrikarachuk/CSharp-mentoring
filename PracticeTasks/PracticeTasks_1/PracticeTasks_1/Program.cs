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

            int arrayLength = array.Length;

            for (int i = arrayLength - 1, j = 0; i >= 0; i--, j++)  // Cool! I haven't known that each "for" loop section can have several statements
            {

                char[] arrTemp = new char[arrayLength];   // Attention: 3 arrTemp arrays are created as a result of this loop
                arrTemp[j] = array[i];

                Console.Write(arrTemp[j]);
            }

            Console.ReadKey();

        }

        // What can be improved:

        // 1. You can use var keyword; 
        // 2. arrayLength var is not needed

        // Problems:
        // 1. See comment in row 20
    }
}
