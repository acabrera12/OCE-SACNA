namespace OCESACNA.Engine.DBCollections
{
    public class DBSubjectModule
    {
        public int SbjetModuleID { get; set; }
        public string Name { get; set; }

        public DBSubjectModule(int id = -1, string name = "")
        {
            this.SbjetModuleID = id;
            this.Name = name;
        }
    }
}