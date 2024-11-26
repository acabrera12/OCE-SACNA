using Engine.ClassDB.Asbtract;

namespace Engine.ClassDB
{

    public class Representative : Entity
    {
        public string FullName = string.Empty;
        public string PhoneNumber = string.Empty;
        public string Email = string.Empty;

        public Representative(int ID = -1, string FullName = "", string PhoneNumber = "", string Email = "")
        {
            this.ID = ID;
            this.FullName = FullName;
            this.PhoneNumber = PhoneNumber;
            this.PhoneNumber = PhoneNumber;
        }
    }
}