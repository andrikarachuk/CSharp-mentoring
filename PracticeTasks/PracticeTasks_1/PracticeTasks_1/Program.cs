using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTasks_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String b, a, t;

            Console.Write("Enter letter b: ");
            b = Console.ReadLine();

            Console.Write("Enter letter a: ");
            a = Console.ReadLine();

            Console.Write("Enter letter t: ");
            t = Console.ReadLine();

            Console.WriteLine(t + a + b);

            Console.ReadKey();

            

        }
    }
}
