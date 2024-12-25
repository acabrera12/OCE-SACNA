namespace OCESACNA.Engine.DBCollections
{
    public class DBRepresentative
    {
        public int RprsentID { get; set; }
        public string FullName { get; set; }

        public DBRepresentative(int id = -1, string fullname = "")
        {
            this.RprsentID = id;
            this.FullName = fullname;
        }
    }
}