using OCESACNA.Engine.Collections.Abstract;
namespace OCESACNA.Engine.Collections
{
    public class SubjectModule : Entity
    {
        public int SbjetModuleID { get; set; }
        public string Name { get; set; }

        public SubjectModule(int id = -1, string name = "")
        {
            this.SbjetModuleID = id;
            this.Name = name;
        }
    }
}