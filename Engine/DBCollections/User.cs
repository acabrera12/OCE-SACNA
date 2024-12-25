namespace OCESACNA.Engine.DBCollections
{
    public class DBUser
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Rank { get; set; }
        public int State { get; set; }

        public DBUser(int id = -1, string username = "", string password = "", int rank = -1, int state = -1)
        {
            this.UserID = id;
            this.UserName = username;
            this.Password = password;
            this.Rank = rank;
            this.State = state;
        }
    }
}