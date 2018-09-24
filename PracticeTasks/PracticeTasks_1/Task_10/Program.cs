using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
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

            Console.Write($"Reversed array is: ");
            ReverseAnArray(arr);

            Console.ReadKey();
        }
        private static void ReverseAnArray(int[] arr)
        {
            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
            
        }
    }
}
