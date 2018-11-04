using System;

namespace Tasks
{
    internal static class Task3Compare2Dates
    {
        public static void CompareDates(DateTime firstDate, DateTime secondDate)
        {
            var result = DateTime.Compare(firstDate, secondDate);

            if (result < 0)
            {
                Console.WriteLine("First date is earlier");
            }
            else if (result > 0)
            {
                Console.WriteLine("Second date is earlier");
            }
            else
            {
                Console.WriteLine("Dates are the same");
            }
        }
    }

    // Comments:
    // 1. Please change class name to Task3Compare2Dates (camelcase notation) +
    // 2. Don't hardcode dates for comparison, just accept them as input parameters for compareDates method - rows 11, 12 +
    // 3. All method names should begin with a capital letter - CompareDates +
    // 4. Current class can be made static, it doesn't have any state +
    // 5. You can use var - row 16 +
}
