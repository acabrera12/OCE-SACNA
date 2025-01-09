using OCESACNA.Engine.Collections.Abstract;

namespace OCESACNA.Engine.Collections
{
    public class Course : Entity
    {
        public int CourseID { get; set; }
        public int Year { get; set; }
        public string Mention { get; set; }
        public string Section { get; set; }

        public Course(int id = -1, int year = -1, string mention = "", string section = "")
        {
            this.CourseID = id;
            this.Year = year;
            this.Mention = mention;
            this.Section = section;
        }
    }
}