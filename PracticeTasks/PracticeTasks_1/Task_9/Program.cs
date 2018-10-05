using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write how long should be an array: ");
            var x = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[x];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter {i} element of array: ");
                if (int.TryParse(Console.ReadLine(), out var i1))
                {
                    arr[i] = i1;
                }
            }
            Console.WriteLine($"Max element of the array is {FindMax(arr)}");

            Console.ReadKey();
        }

        private static int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                max = (arr[i] > arr[i + 1]) ? arr[i] : arr[i + 1];
            }
            return max;
        }

        // Problems:
        // 1. "int[] whereMax" variable is redundant -> ??
        // 2. Iteration i=0 is redundant -> don't understand what to do

        // What can be improved:
        // 1. Try to use var
        // 2. Try to use int.TryParse instead of Parse -> checked

    }
}
