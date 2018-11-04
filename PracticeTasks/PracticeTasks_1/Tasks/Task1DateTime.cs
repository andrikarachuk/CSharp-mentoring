using System;

namespace Tasks
{
    static class Task1DateTime
    {
        static DateTime localTime = DateTime.Now;
        static DateTime utcTime = DateTime.UtcNow;

        static public void PrintTime()
        {
            Console.WriteLine("Local time:");
            //Console.WriteLine("{0:MM'/'dd'/'yyyy}", localTime);
            Console.WriteLine(localTime.ToString("MM'/'dddd'/'yyyy"));

            // FYI: you also apply the needed formatting using method .ToString and passing a format as a parameter +
            //Console.WriteLine(localTime.ToString("MM'/'dd'/'yyyy"));

            Console.WriteLine(localTime.DayOfWeek + ", {0:dddd MMM yyyy}", localTime);
            Console.WriteLine(localTime.DayOfWeek + ", {0:dddd MMM yyyy hh:mm:ss}", localTime);

            Console.WriteLine("UTC time:");
            Console.WriteLine("{0:MM'/'dddd'/'yyyy}", utcTime);
            Console.WriteLine(localTime.DayOfWeek + ", {0:dddd MMM yyyy}", utcTime);
            Console.WriteLine(localTime.DayOfWeek + ", {0:dddd MMM yyyy hh:mm:ss}", utcTime);
        }

        // Comments:
        // 1. Row 12 - can be simplified and replaced with DateTime.UtcNow +
        // 2. Try to use for all names in C# camelCase notation i.e. instead of Task1_DateTime => Task1DateTime +
        // 3. You can use "dddd" format for the full name of the day of the week - rows 18, 19, 22, 23
        // 4. It would be a good idea to make this class static => as a result you won't have to create an instance of it in Main +

        // Questions:
        // 1. Why do you create variable localTime as static and utcTime as usual field? It doesn't make a lot of sense creating a static private field. +Resolved
    }
}
