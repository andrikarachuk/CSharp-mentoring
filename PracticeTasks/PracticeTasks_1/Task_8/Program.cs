using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element of array: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int j =+ arr[i];
                sum = sum + j;

                //Why following construction doesn't work?
                // sum =+ arr[i];

            }



            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
