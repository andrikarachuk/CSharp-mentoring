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
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Max element of the array is {FindMax(arr)}");

            Console.ReadKey();
        }

        private static int FindMax(int[] arr)
        {
            int[] whereMax = arr;
            
            int max = whereMax[0];
            for (int i = 0; i < whereMax.Length - 1; i++)
            {
                max = (whereMax[i] > whereMax[i + 1]) ? whereMax[i] : whereMax[i + 1];
            }
            return max;
        }
    }
}
