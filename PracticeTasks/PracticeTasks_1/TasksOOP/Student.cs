using System;

namespace TasksOOP
{
    public class Student
    {
        private string name;
        private string surname;
        private DateTime dateOfBirth;
        private int grade;
        private int _averageMark;
        public StudentSubjectMarks[] SubjectMarks;

        public Student (string name, string surname, DateTime dateOfBirth, int grade)
        {
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.grade = grade;
        }

        public void SetMarks(StudentSubjectMarks[] subjectMarks)
        {
            SubjectMarks = subjectMarks;
            GetAverageMark();
        }

        public int GetAverageMark()
        {
            for (int i = 0; i < SubjectMarks.GetLength(0); i++)
            {
                _averageMark += SubjectMarks[i].GetSubjectMark();
            }

            return _averageMark = _averageMark / SubjectMarks.GetLength(0);
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine("Student Info: \n" +
                $"Name {name} {surname} \n"   +
                $"Date Of Birth {dateOfBirth}\n" +
                $"Grade {grade}\n" +
                $"Average Mark {_averageMark}" + "\n");
        }

        
    }

    // Comments:
    // 1. Why does your class inherit from SchoolSubjects?
    // 2. Please specify access modifiers for defined fields
    // 3. Install Resharper and follow its hints
    // 4. Why do you store dateOfBirth as a string field? Maybe it's better to use DateTime type
}
