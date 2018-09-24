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
            Console.Write("Write character in Upper or Lower case: ");
            var c = char.Parse(Console.ReadLine());
            char[] arrCharLC = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            if(char.IsDigit(c)) 
            {
                Console.WriteLine("Inputed symbol is a digit");
            }
            else if (arrCharLC.Contains(c))
            {
                if (char.IsLower(c))
                {
                Console.WriteLine("Inputed symbol is a lowercase vowel");
                }
                else
                {
                    Console.WriteLine("Inputed symbol is a uppercase vowel");
                }
            }
            else
            {
                Console.WriteLine("Inputed symbol is any other symbol");
            }

            Console.ReadKey();
        }

        // Problems:
        // 1. It is better to create one array of characters instead of two arrays of strings. -> Checked
        // 2. Use char.isLower and char.isUpper in order to reduce the number of if-else blocks and to have 1 array with vowels  -> Checked

        // What can be improved:
        // 1. Statements from rows 13 and 15 can be written in one statement i.e. variable declaration and initialization -> Checked
        // 2. You can use var -> Checked
        // 3. "Var b" is not needed => you should write "arrCharLC.Contains(c)" instead of "b = arrCharLC.Contains(c)" -> Checked
        // 4. It's better to use char.IsDigit instead of int.TryParse(c, out int i) -> Checked
    }
}
