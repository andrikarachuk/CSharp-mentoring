using System;

namespace Tasks
{
    internal static class Task2PlusForty
    {
        private static readonly DateTime DateNow = DateTime.Now;

        public static void PrintDate()
        {
            Console.WriteLine("Current date - {0:dd.MM.yyyy}", DateNow);
            Console.WriteLine("Day in 40 days - {0:dddd}", DateNow.AddDays(40));
        }
    }

    // Comments:
    // 1. You can make this class and printDate method static +
    // 2. It's better to rename the class to "Task2PlusForty" (camelCase notation)+
    // 3. All method names should begin with capital letter i.e. PrintDate +
    // 4. Please install Resharper and follow its hints +
    // 5. "Write a C# program to calculate what day of the week is 40 days from this moment" - according to the problem you need to output what is the "day of the week" in 40 days from now 
}
