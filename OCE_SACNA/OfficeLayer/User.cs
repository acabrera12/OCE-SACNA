using EntityLayer;

namespace OfficeLayer
{
    public class User : Entity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public AuthManager.RANKING Rank { get; set; }
        public AuthManager.USER_STATE State { get; set; }

        public User(string Username = "", string Password = "", AuthManager.RANKING Rank = AuthManager.RANKING.NONE, AuthManager.USER_STATE State = AuthManager.USER_STATE.NONE)
        {
            this.Username = Username;
            this.Password = Password;
            this.State = State;
            this.Rank = Rank;
        }
    }
}
