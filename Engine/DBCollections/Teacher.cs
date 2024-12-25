namespace OCESACNA.Engine.DBCollections
{
    public class DBTeacher
    {
        public int TeachID { get; set; }
        public string FullName { get; set; }
        public int CourseID { get; set; }

        public DBTeacher(int id = -1, string fullname = "", int courseid = -1)
        {
            this.TeachID = id;
            this.FullName = fullname;
            this.CourseID = CourseID;
        }
    }
}