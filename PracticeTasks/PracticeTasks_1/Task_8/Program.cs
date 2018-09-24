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
                int j = + arr[i];
                sum = sum + j;

                //Why following construction doesn't work?
                // sum =+ arr[i];

                // Because the correct operator is "+="
                // = + works like =

            }



            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }

    // Problems:
    // 1. The array length should be entered by user, it should not be hard-coded to 5 elements
    // 2. Rows 24 and 25 are strange, either write sum = sum + arr[i] or sum += arr[i]

    // What can be improved:
    // 1. Try to use var
    // 2. Try to use string interpolation => row 16
    // 3. It's better to use int.TryParse instead of Parse
    // 4. Don't leave unnecessary empty rows
}
