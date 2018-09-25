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
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }

        }
    }

    // What can be improved:
    // 1. Try to use var - e.g. rows 16, 17, 30
    // 2. Try to use int.TryParse instead of Parse
    // 3. It's enough to just use quotation marks i.e. "", string interpolation is not used - row 23
    // 4. Articles in names are not needed - ReverseArray instead of ReverseAnArray
    // 5. You could have used randomizer to populate an array
    // 6. Try to format your code at the end of your work with the file using VS command - ctrl+K, ctrl+F
    // 7. Be attentive to the task problem i.e. "to reverse array consisting of natural numbers".
    // This means that we should store the reversed array to some variable
}
