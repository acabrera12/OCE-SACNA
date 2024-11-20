namespace OfficeLayer
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public AuthManager.RANKING Rank { get; set; }
        public AuthManager.USER_STATE State { get; set; }
        public User()
        {

        }
    }
}
