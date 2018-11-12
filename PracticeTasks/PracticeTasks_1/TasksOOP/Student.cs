using System;

namespace TasksOOP
{
    public class Student
    {
        private string name;
        private string surname;
        private DateTime dateOfBirth;
        private int grade;
        private SchoolSubjects subjects;
        
        
        public void SetMarks()
        {
            
            for (var number = SchoolSubjects.Maths; number <= SchoolSubjects.EnglishLiterature; number++)
            {
                grade = 4;
                number = (SchoolSubjects) grade;
            }
        }

        public Student (string name, string surname, DateTime dateOfBirth, int grade)
        {
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.grade = grade;
        }

        internal int GetAverageMark()
        {
            int avgMark = 0;
            return avgMark;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student {name} {surname} Info: \n" +
                $"Date Of Birth {dateOfBirth}\n" +
                $"Grade {grade}\n");
        }

        
    }

    // Comments:
    // 1. Why does your class inherit from SchoolSubjects?
    // 2. Please specify access modifiers for defined fields
    // 3. Install Resharper and follow its hints
    // 4. Why do you store dateOfBirth as a string field? Maybe it's better to use DateTime type
}
