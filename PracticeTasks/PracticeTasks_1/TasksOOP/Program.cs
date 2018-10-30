using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Han", "Solo", "1965/5/4", 5, 12);
            Student student2 = new Student("Ben", "Kenobi", "1899/9/8", 15, 99);

            student1.DisplayStudentInfo();
            student2.DisplayStudentInfo();

            Console.ReadKey();
        }
    }

    // Comments:
    // 1. You can use var - rows 13, 14
}
