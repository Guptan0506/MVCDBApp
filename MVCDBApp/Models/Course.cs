namespace MvcDBApp.Models
{
    public class Course
    {
        public int courseId { get; set; }
        public string courseName { get; set; }
        public string courseDescription { get; set; }

        public Course()
        {
        }

        public Course(int courseId, string courseName, string courseDescription)
        {
            this.courseId = courseId;
            this.courseName = courseName;
            this.courseDescription = courseDescription;
        }
    }
}