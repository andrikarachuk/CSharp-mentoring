using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task4_Difference
    {
        static DateTime currentTime = DateTime.Now;
        static DateTime oldDate = new DateTime(2000, 1, 1, 00, 00, 00);

        double difference = (currentTime - oldDate).TotalHours;
        public void printDifference()
        {
            Console.WriteLine($"Difference between two dates is {Math.Round(difference, 2)} hour(s)");

        }

    }
}
