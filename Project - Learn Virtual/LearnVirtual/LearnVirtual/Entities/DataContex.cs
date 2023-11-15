namespace LearnVirtual.Entities
{
    public class DataContex
    {


        public List<Courses> coursesList { get; set; }

        public List<LearningMatirials> learningMatirialsList { get; set; }

        public List<Lecturers> lecturersList { get; set; }
        public List<Students> studentsList { get; set; }


        public List<Tasks> tasksList = new List<Tasks>();


        public DataContex()
        {
            coursesList = new List<Courses>();
            coursesList.Add(new Courses("Math", 1234, new Students("Sari", 1, true)));
            coursesList.Add(new Courses("Math", 1234, new Students("Sari", 1, true)));
            coursesList.Add(new Courses("Math", 1234, new Students("Sari", 1, true)));
            coursesList.Add(new Courses("Math", 1234, new Students("Sari", 1, true)));



            learningMatirialsList = new List<LearningMatirials>();
            learningMatirialsList.Add(new LearningMatirials(1, "this is"));
            learningMatirialsList.Add(new LearningMatirials(2, "this is"));
            learningMatirialsList.Add(new LearningMatirials(3, "this is"));
            learningMatirialsList.Add(new LearningMatirials(4, "this is"));
            learningMatirialsList.Add(new LearningMatirials(5, "this is"));
            learningMatirialsList.Add(new LearningMatirials(6, "this is"));
            learningMatirialsList.Add(new LearningMatirials(7, "this is"));

            lecturersList = new List<Lecturers>();
            lecturersList.Add(new Lecturers("tommy", 1, true));
            lecturersList.Add(new Lecturers("tommy", 2, true));
            lecturersList.Add(new Lecturers("tommy", 3, true));
            lecturersList.Add(new Lecturers("tommy", 4, true));
            lecturersList.Add(new Lecturers("tommy", 5, true));
            lecturersList.Add(new Lecturers("tommy", 6, true));

            studentsList = new List<Students>();
            studentsList.Add(new Students("sari", 1, true));
            studentsList.Add(new Students("sari", 1, true));
            studentsList.Add(new Students("sari", 1, true));
            studentsList.Add(new Students("sari", 1, true));
            studentsList.Add(new Students("sari", 1, true));
            studentsList.Add(new Students("sari", 1, true));



            tasksList = new List<Tasks>();
            tasksList.Add(new Tasks("to do it", "now", new DateTime(2023, 05, 12), 1));
            tasksList.Add(new Tasks("to do it", "now", new DateTime(2023, 05, 12), 2));
            tasksList.Add(new Tasks("to do it", "now", new DateTime(2023, 05, 12), 3));
            tasksList.Add(new Tasks("to do it", "now", new DateTime(2023, 05, 12), 4));
            tasksList.Add(new Tasks("to do it", "now", new DateTime(2023, 05, 12), 5));
            tasksList.Add(new Tasks("to do it", "now", new DateTime(2023, 05, 12), 6));

        }
    }
}



}
}
