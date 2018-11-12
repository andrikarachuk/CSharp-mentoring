using System;

namespace TasksOOP
{
    internal class Program
    {
        static void Main()
        {
            var student1 = new Student("Han", "Solo", new DateTime(1965, 5 ,4), 5);
            var student2 = new Student("Ben", "Kenobi", new DateTime(1899, 9, 8), 15);

            student1.SetMarks();

            student1.DisplayStudentInfo();
            student2.DisplayStudentInfo();

            Console.ReadKey();
        }
    }

    // Comments:
    // 1. You can use var - rows 13, 14
}
