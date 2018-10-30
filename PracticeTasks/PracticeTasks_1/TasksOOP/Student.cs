using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksOOP
{
    public class Student : SchoolSubjects
    {
        string name;
        string surname;
        string dateOfBirth;
        int grade;
        //int marks;  

        public Student (string name, string surname,string dateOfBirth, int grade, int marks)
        {
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.grade = grade;
           // this.marks = marks;
        }

        int GetAverageMark()
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
