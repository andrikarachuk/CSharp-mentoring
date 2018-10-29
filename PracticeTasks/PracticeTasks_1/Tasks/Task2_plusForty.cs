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

    // Comments:
    // 1. You can make this class and printDate method static
    // 2. It's better to rename the class to "Task2PlusForty" (camelCase notation)
    // 3. All method names should begin with capital letter i.e. PrintDate
    // 4. Please install Resharper and follow its hints
    // 5. "Write a C# program to calculate what day of the week is 40 days from this moment" - according to the problem you need to output what is the "day of the week" in 40 days from now 
}
