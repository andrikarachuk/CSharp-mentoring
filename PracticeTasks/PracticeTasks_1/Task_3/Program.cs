using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string c;
            Console.Write("Write character in Upper or Lower case: ");
            c = Console.ReadLine();
            string[] arrCharLC = new string[] { "a", "e", "i", "o", "u" };
            string[] arrCharUC = new string[] { "A", "E", "I", "O", "U" };

            bool b;
            
            if(b = int.TryParse(c, out int i)) 
            {
                Console.WriteLine("Inputed symbol is a digit");
            }
            else if (b = arrCharLC.Contains(c))
            {
                Console.WriteLine("Inputed symbol is a lowercase vowel");
            }
            else if (b = arrCharUC.Contains(c))
            {
                Console.WriteLine("Inputed symbol is a uppercase vowel");
            }
            else
            {
                Console.WriteLine("Inputed symbol is any other symbol");
            }

            Console.ReadKey();
        }

        // Problems:
        // 1. It is better to create one array of characters instead of two arrays of strings.
        // 2. Use char.isLower and char.isUpper in order to reduce the number of if-else blocks and to have 1 array with vowels

        // What can be improved:
        // 1. Statements from rows 13 and 15 can be written in one statement i.e. variable declaration and initialization
        // 2. You can use var
        // 3. "Var b" is not needed => you should write "arrCharLC.Contains(c)" instead of "b = arrCharLC.Contains(c)"
        // 4. It's better to use char.IsDigit instead of int.TryParse(c, out int i)
    }
}
