using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task2_plusForty
    {
        DateTime dateNow = DateTime.Now;

        public void printDate()
        {
            Console.WriteLine("Current date - {0:dd.MM.yyyy}", dateNow);
            Console.WriteLine("Date in 40 days - {0:dd.MM.yyyy}", dateNow.AddDays(40));
        }
        
    }
}
