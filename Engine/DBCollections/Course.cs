namespace OCESACNA.Engine.DBCollections
{
    public class DBCourse
    {
        public int CourseID { get; set; }
        public int Year { get; set; }
        public int Mention { get; set; }
        public char Section { get; set; }

        public DBCourse(int id = -1, int year = -1, int mention = -1, char section = '!')
        {
            this.CourseID = id;
            this.Year = year;
            this.Mention = mention;
            this.Section = section;
        }
    }
}