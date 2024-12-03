using System;
using Engine.ClassDB.Asbtract;

namespace Engine.ClassDB
{
    public class User : Entity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public RANKING Rank { get; set; }
        public USER_STATE State { get; set; }
        
        public enum RANKING
        {
                NONE = 0,
                DEFAULT = 1,
                USER = 2,
                ADMIN = 3
        }

        public enum USER_STATE
        {
            NONE = 0,
            ACTIVE = 1,
            INACTIVE = 2
        }

        public User(string username, string password, RANKING rank = RANKING.NONE, USER_STATE state = USER_STATE.NONE, int id = -1)
        {
            this.ID = id;
            this.Username = username;
            this.Password = password;
            this.Rank = rank;
            this.State = state;
        }

        public User()
        {
            this.ID = -1;
            this.Username = string.Empty;
            this.Password = string.Empty;
            this.Rank = RANKING.NONE;
            this.State = USER_STATE.NONE;
        }
    }
}
