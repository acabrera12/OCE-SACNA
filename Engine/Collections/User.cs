using OCESACNA.Engine.Collections.Abstract;
namespace OCESACNA.Engine.Collections
{
    /// <summary>
    /// Entidad clase <c>User</c> que hace referencia a un registro de la base de datos
    /// </summary>
    public class User : Entity
    {
        /// <summary>
        /// ID correspondiente al registro
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// Nombre de usuario correspondiente al registro
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Contrasseña correspondiente al registro
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Autoridad correspondiente al registro
        /// </summary>
        public RANKING Rank { get; set; }
        /// <summary>
        /// Estado del usuario correspondiente al registro
        /// </summary>
        public STATES State { get; set; }

        /// <summary>
        /// Autoridades posibles de la entidad <c>User</c>
        /// </summary>
        public enum RANKING
        {
            NONE = 0,
            DEFAULT = 1,
            USER = 2,
            ADMIN = 3
        }

        /// <summary>
        /// Estados posibled de la entidad <c>User</c>
        /// </summary>
        public enum STATES
        {
            NONE = 0,
            ACTIVE = 1,
            INACTIVE = 2
        }

        /// <summary>
        /// Inicializa una instancia de la entidad <c>User</c>
        /// </summary>
        /// <param name="id">ID del registro</param>
        /// <param name="username">Nombre de usuario del registro</param>
        /// <param name="password">Contraeña del registro</param>
        /// <param name="rank">Autoridad del registro</param>
        /// <param name="state">Estado del registro</param>
        public User(int id = -1, string username = "", string password = "", RANKING rank = RANKING.NONE, STATES state = STATES.NONE)
        {
            this.UserID = id;
            this.UserName = username;
            this.Password = password;
            this.Rank = rank;
            this.State = state;
        }

        /// <summary>
        /// Obtiene una cedena de texto acorde a la autoridad
        /// </summary>
        /// <param name="r">Autoridad</param>
        /// <returns>Una cadena que representa la autoridad del parámetro <c>r</c></returns>
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

        /// <summary>
        /// Obtiene una cadena de texto acorde al estado
        /// </summary>
        /// <param name="s">Estado</param>
        /// <returns>Una cadena que representa el estado del parámetro <c>s</c></returns>
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