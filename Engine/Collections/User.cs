using OCESACNA.Engine.Collections.Abstract;
namespace OCESACNA.Engine.Collections
{
    public class User : Entity
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public RANKING Rank { get; set; }
        public STATES State { get; set; }

        public enum RANKING
        {
            NONE = 0,
            DEFAULT = 1,
            USER = 2,
            ADMIN = 3
        }

        public enum STATES
        {
            NONE = 0,
            ACTIVE = 1,
            INACTIVE = 2
        }

        public User(int id = -1, string username = "", string password = "", RANKING rank = RANKING.NONE, STATES state = STATES.NONE)
        {
            this.UserID = id;
            this.UserName = username;
            this.Password = password;
            this.Rank = rank;
            this.State = state;
        }

        public static string GetRankingText(RANKING r)
        {
            switch (r)
            {
                case RANKING.NONE:
                    return "Ninguno";
                case RANKING.DEFAULT:
                    return "Predeterminado";
                case RANKING.USER:
                    return "Usuarrio";
                case RANKING.ADMIN:
                    return "Administrador";
                default:
                    return "Nulo";
            }
        }

        public static string GetStateText(STATES s)
        {
            switch (s)
            {
                case STATES.NONE:
                    return "Ninguno";
                case STATES.ACTIVE:
                    return "Activo";
                case STATES.INACTIVE:
                    return "Inactivo";
                default:
                    return "Nulo";
            }
        }
    }
}