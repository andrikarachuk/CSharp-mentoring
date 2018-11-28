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
    // 1. Why does your class inherit from SchoolSubjects?  +
    // 2. Please specify access modifiers for defined fields +
    // 3. Install Resharper and follow its hints -
    // 4. Why do you store dateOfBirth as a string field? Maybe it's better to use DateTime type +

    // 5. Please follow one convention for naming fields i.e. either just starting with a small letter (1) or starting with _ (2)
    // 6. Resharper hints that some fields can be made readonly, such as name, surname, dateOfBirth, grade
    // 7. "SubjectMarks" is also a field, so it should be made private and should be named correspondingly. By the way you can simplify the name and call it just "marks"
    // 8. It's better to define a local variable (e.g. markSum) instead of assigning interim values to class field _averageMark - row 32
    // 9. Try to write shorter and simpler code i.e. isntead of GetLength(0) just length
    // 10. Actually you don't need "SetMarks" method, you can set "marks" field through a constructor as well. Moreover, "SetMarks" method does more than states its name.
    // It sets marks (1) and calculates average mark (2). You don't have to store averageMark as a class field, you can call GetAverageMark method from e.g. Main and display this value.
    // 11. Pay attention to GetAverageMark method, because the actual result of calculation is double, but it gets converted to int automatically. Now the average mark 2.8 is represented as 2. 


}
