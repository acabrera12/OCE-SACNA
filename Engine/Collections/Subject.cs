using OCESACNA.Engine.Collections.Abstract;
namespace OCESACNA.Engine.Collections
{
    public class Subject : Entity
    {
        public int SubjectID { get; set; }
        public SubjectModule SbjetModule { get; set; }
        public string Name { get; set; }
        public Teacher Teach { get; set; }
        public Course Course { get; set; }

        public Subject()
        {
            this.SubjectID = -1;
            this.SbjetModule = new SubjectModule();
            this.Name = string.Empty;
            this.Teach = new Teacher();
            this.Course = new Course();
        }

        public Subject(int id, SubjectModule module, Teacher teach, Course course, string name = "")
        {
            this.SubjectID = id;
            this.SbjetModule = module;
            this.Name = name;
            this.Teach = teach;
            this.Course = course;
        }
    }
}