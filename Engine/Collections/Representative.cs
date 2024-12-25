using OCESACNA.Engine.Collections.Abstract;
namespace OCESACNA.Engine.Collections
{
    public class Representative : Entity
    {
        public int RprsentID { get; set; }
        public string FullName { get; set; }

        public Representative(int id = -1, string fullname = "")
        {
            this.RprsentID = id;
            this.FullName = fullname;
        }
    }
}