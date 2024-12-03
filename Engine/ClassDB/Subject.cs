using Engine.ClassDB.Asbtract;

namespace Engine.ClassDB
{
    public class Subject : Entity
    {
        public string Name { get; set; }
        public SbjModule Module { get; set; }
        public Teacher Teacher { get; set; }
        public Course Course { get; set; }

        public Subject(SbjModule module, Teacher teacher, Course course, int ID = -1, string name = "")
        {
            this.ID = ID;
            this.Module = module;
            this.Name = name;
            this.Teacher = teacher;
            this.Course = course;
        }
    }

    public class SbjModule : Entity
    {
        public string Name { get; set; }

        public SbjModule(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}
