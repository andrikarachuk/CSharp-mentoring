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
            c.GetHashCode();
            bool b;

            b = c.ToUpper().GetHashCode() == c.GetHashCode();
            if (b)
            {
                Console.WriteLine("1");
            } else
            {
                Console.WriteLine(2);
            }

            Console.ReadKey();
        }
    }
}
