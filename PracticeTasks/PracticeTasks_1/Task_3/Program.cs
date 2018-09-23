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
    }
}
