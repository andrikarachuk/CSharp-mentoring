

namespace TasksOOP
{
    public class StudentSubjectMarks
    {
        private SchoolSubjects SubjectName { get; set; }
        private int SubjectMark { get; set; }


        public StudentSubjectMarks(SchoolSubjects subjectName, int subjectMark)
        {
            SubjectName = subjectName; 
            SubjectMark = subjectMark;
        }

        public int GetSubjectMark()
        {
            return SubjectMark;
        }

    }
}

// Comments:
// 1. It doesn't make sense to have private properties. If we want to hide some data about current object we can store it in a private field.
// So, it's better to make properties SubjectName and SubjectMark public. If you want you can add corresponding private fields i.e. subjectName and subjectMark
// 2. You can simplify class and its members' names i.e. "Mark" instead of "StudentSubjectMarks", "mark" or "value" instead of "SubjectMark"
// 3. Please install Resharper and follow its hints.
// 4. You don't need GetSubjectMark, use SubjectMark property getter instead.


