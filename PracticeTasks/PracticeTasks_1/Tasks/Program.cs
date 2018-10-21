using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1CurrentDateTime task1 = new Task1CurrentDateTime();
            task1.PrintTime();

            Console.ReadKey();
        }
    }
    
}
