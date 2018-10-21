using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task1_DateTime
    {
        static DateTime localTime = DateTime.Now;
        DateTime utcTime = localTime.ToUniversalTime();

        public void PrintTime()
        {
            Console.WriteLine("Local time:");
            Console.WriteLine("{0:MM'/'dd'/'yyyy}", localTime);
            Console.WriteLine(localTime.DayOfWeek + ", {0:dd MMM yyyy}", localTime);
            Console.WriteLine(localTime.DayOfWeek + ", {0:dd MMM yyyy hh:mm:ss}", localTime);

            Console.WriteLine("UTC time:");
            Console.WriteLine("{0:MM'/'dd'/'yyyy}", utcTime);
            Console.WriteLine(localTime.DayOfWeek + ", {0:dd MMM yyyy}", utcTime);
            Console.WriteLine(localTime.DayOfWeek + ", {0:dd MMM yyyy hh:mm:ss}", utcTime);
        }
    }
}
