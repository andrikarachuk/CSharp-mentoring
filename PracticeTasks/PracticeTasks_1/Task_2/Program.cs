using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int y = r.Next(-5, 5);
            int x;

            x = y ^ 2 + 2 * y + 1;

            Console.WriteLine(y);

            Console.ReadLine();
        }
    }
}
