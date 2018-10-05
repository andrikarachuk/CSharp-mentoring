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
            Console.Write("Write how long should be an array: ");
            var x = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[x];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter {i} element of array: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            var sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
           
            Console.WriteLine($"Sum of the array is {sum}");

            Console.ReadKey();
        }
    }

    // Problems:
    // 1. The array length should be entered by user, it should not be hard-coded to 5 elements -> Checked
    // 2. Rows 24 and 25 are strange, either write sum = sum + arr[i] or sum += arr[i] -> Checked

    // What can be improved:
    // 1. Try to use var  -> Checked
    // 2. Try to use string interpolation => row 16 -> Checked
    // 3. It's better to use int.TryParse instead of Parse -> use Convert.ToInt32. TryParse doesn't work 
    // 4. Don't leave unnecessary empty rows -> Checked

    // Some comments:
    // 1. Still a lot of places where you can use var :)
    // 2. From existing code you can extract several methods -> ArrayPopulation - separate method, ArraySum - separate method

}
