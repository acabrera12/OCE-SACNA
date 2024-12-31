namespace OCESACNA.Engine.DBCollections
{
    public class DBRepresentative
    {
        public int RprsentID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public DBRepresentative(int id = -1, string fullname = "", string phonenumber = "", string email = "")
        {
            this.RprsentID = id;
            this.FullName = fullname;
            this.PhoneNumber = phonenumber;
            this.Email = email;
        }
    }
}