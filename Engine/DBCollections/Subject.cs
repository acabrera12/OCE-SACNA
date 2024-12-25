namespace OCESACNA.Engine.DBCollections
{
    public class DBSubject
    {
        public int SubjectID { get; set; }
        public int SbjetModuleID { get; set; }
        public string Name { get; set; }
        public int TeachID { get; set; }
        public int CourseID { get; set; }

        public DBSubject(int id = -1, int sbjetmoduleid = -1, string name = "", int teachid = -1, int courseid = -1)
        {
            this.SubjectID = id;
            this.SbjetModuleID = sbjetmoduleid;
            this.Name = name;
            this.TeachID = teachid;
            this.CourseID = courseid;
        }
    }
}