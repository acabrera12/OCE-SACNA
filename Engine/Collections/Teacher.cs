using OCESACNA.Engine.Collections.Abstract;
namespace OCESACNA.Engine.Collections
{
    public class Teacher : Entity
    {
        public int TeachID { get; set; }
        public string FullName { get; set; }
        public Course Course { get; set; }

        public Teacher()
        {
            this.TeachID = -1;
            this.FullName = string.Empty;
            this.Course = new Course();
        }

        public Teacher(int id, Course course, string fullname = "")
        {
            this.TeachID = id;
            this.FullName = fullname;
            this.Course = course;
        }
    }
}