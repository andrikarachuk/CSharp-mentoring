using System;

namespace Tasks
{
    internal static class Task4Difference
    {
        private static readonly DateTime CurrentTime = DateTime.Now;

        public static void Difference(DateTime oldDate)
        {
            var difference = (CurrentTime - oldDate).TotalHours;
            Console.WriteLine($"Difference between two dates is {Math.Round(difference, 2)} hour(s)");
        }
    }

    // Comments:
    // 1. Install Resharper and follow its hints +
    // 2. Please rename the class to Task4Difference (camelcase notation) +
    // 3. Private static fields don't make a lot of sense +
    // 4.1 Please rename the method to PrintDifference or CalculateDateDifference (camelcase notation).+
    // 4.2 Actually you can have 2 methods - one for calculation, another for printing -
    // 5. You should have an empty line between fields and methods for better readability +
    // 6. Avoid unnecessary empty lines +
    // 7. If you want to enhance this class and method, you can make oldDate - an input parameter for PrintDifference method +

    // Problems:
    // 1. The logic that you implement is better to put inside the method, not in class fields +
}
