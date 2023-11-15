using LearnVirtual.Controllers;

namespace LearnVirtual.Entities
{
    public class Courses
    {
        private string v1;
        private int v2;
        private Students students;

        public Courses(string v1, int v2, Students students)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.students = students;
        }

        public string CourseName { get; set; }
        public int CourseId { get; set; }
        public List<Students> StudentsInTheCourse { get; set; }


    }
}
