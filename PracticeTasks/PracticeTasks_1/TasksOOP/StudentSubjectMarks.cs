

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
