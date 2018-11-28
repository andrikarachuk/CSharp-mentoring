using System;

namespace TasksOOP
{
    internal class Program
    {
        static void Main()
        {
            var student1 = new Student("Han", "Solo", new DateTime(1965, 5 ,4), 5);
            var student2 = new Student("Ben", "Kenobi", new DateTime(1899, 9, 8), 15);

            student1.SetMarks(new[] {
                new StudentSubjectMarks(SchoolSubjects.Biology, 2),
                new StudentSubjectMarks(SchoolSubjects.Maths, 3),
                new StudentSubjectMarks(SchoolSubjects.Chemistry, 4),
                new StudentSubjectMarks(SchoolSubjects.Physics, 4),
                new StudentSubjectMarks(SchoolSubjects.Literature, 1)
            });

            student2.SetMarks(new[] {
                new StudentSubjectMarks(SchoolSubjects.Biology, 5),
                new StudentSubjectMarks(SchoolSubjects.Maths, 5),
                new StudentSubjectMarks(SchoolSubjects.Chemistry, 5),
                new StudentSubjectMarks(SchoolSubjects.Physics, 5),
                new StudentSubjectMarks(SchoolSubjects.Literature, 5)
            });

            student1.DisplayStudentInfo();
            student2.DisplayStudentInfo();

            Console.ReadKey();
        }
    }

    // Comments:
    // 1. You can use var - rows 13, 14 +
}
