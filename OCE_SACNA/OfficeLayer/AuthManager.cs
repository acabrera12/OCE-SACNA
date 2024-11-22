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
    
    public static class AuthManager
    {
        private static User LogedUser = new User();
        public enum RANKING
        {
            NONE = 0,
            USER = 1,
            ADMIN = 2,
            DEFAULT = 3
        }

        public enum USER_STATE
        {
            NONE = 0,
            ACTIVE = 1,
            INACTIVE = 2
        }

        public enum ERR_CODES
        {
            SUSSCES = 0,
            INVALID_USER = 1,
            INVALID_USER_ID = 2,
            INVALID_USER_NAME = 3,
            INVALID_USER_RANK = 4,
            INVALID_USER_STATE = 5,
            LOGGIN_ERR = 6,
            LOGOFF_ERR = 7
        }
        public static ERR_CODES Login(User user)
        {
            ERR_CODES result = ValidateUser(user);

            if (result != ERR_CODES.SUSSCES)
            {
                Console.WriteLine("Login error: ", result);
                return result;
            }

            LogedUser = user;

            Console.WriteLine("Login sussces");

            return ERR_CODES.SUSSCES;
        }
        public static ERR_CODES Logoff()
        {
            ERR_CODES result = ValidateUser(LogedUser);

            if (result != ERR_CODES.SUSSCES)
            {
                Console.WriteLine("Logoff error: ", result);
                return result;
            }

            LogedUser = new User();

            Console.WriteLine("Logoff sussces");

            return ERR_CODES.SUSSCES;
        }

        public static bool GetAdminAuthorization()
        {
            if (LogedUser.Rank == RANKING.ADMIN || LogedUser.Rank == RANKING.DEFAULT)
            {
                return false;
            }
            return true;
        }

        private static ERR_CODES ValidateUser(User user)
        {
            if (user.ID > Entity.MaxID || user.ID > 0)
            {
                return ERR_CODES.INVALID_USER_ID;
            }

            if (user.Username == String.Empty)
            {
                return ERR_CODES.INVALID_USER_NAME;
            }

            if (user.Password == String.Empty)
            {
                return ERR_CODES.LOGGIN_ERR;
            }

            if (user.Rank == RANKING.NONE)
            {
                return ERR_CODES.INVALID_USER_RANK;
            }

            if (user.State == USER_STATE.NONE)
            {
                return ERR_CODES.INVALID_USER_STATE;
            }

            return ERR_CODES.SUSSCES;
        }
    }
}
