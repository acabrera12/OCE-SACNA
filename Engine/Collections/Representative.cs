using OCESACNA.Engine.Collections.Abstract;
namespace OCESACNA.Engine.Collections
{
    public class Representative : Entity
    {
        public int RprsentID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Representative(int id = -1, string fullname = "", string phonenumber = "", string email = "")
        {
            this.RprsentID = id;
            this.FullName = fullname;
            this.PhoneNumber = phonenumber;
            this.Email = email;
        }
    }
}