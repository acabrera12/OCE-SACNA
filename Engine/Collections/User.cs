using OCESACNA.Engine.Collections.Abstract;
using System.Collections.Generic;

namespace OCESACNA.Engine.Collections
{
    /// <summary>
    /// Entidad clase <see cref="User"/> que hace referencia a un registro de la base de datos
    /// </summary>
    public class User : Entity
    {
        /// <summary>
        /// Obtiene o establece el ID correspondiente a la instancia
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Obtiene o establece el Nombre de usuario correspondiente a la instancia
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Obtiene o establece la Contrasseña correspondiente a la instancia
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Obtiene o establece la Autoridad correspondiente a la instancia
        /// </summary>
        public RANKING Rank { get; set; }

        /// <summary>
        /// Obtiene o establece el Estado del usuario correspondiente a la instancia
        /// </summary>
        public STATES State { get; set; }

        /// <summary>
        /// Autoridades posibles de la entidad <see cref="User"/>
        /// </summary>
        public enum RANKING
        {
            NONE = 0,
            DEFAULT = 1,
            USER = 2,
            ADMIN = 3
        }

        /// <summary>
        /// Estados posibled de la entidad <see cref="User"/>
        /// </summary>
        public enum STATES
        {
            NONE = 0,
            ACTIVE = 1,
            INACTIVE = 2
        }

        /// <summary>
        /// Inicializa una instancia de la entidad <see cref="User"/>
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

        private static readonly Dictionary<RANKING, string> RankingString = new Dictionary<RANKING, string>()
        {
            {RANKING.NONE, "Ninguno" },
            {RANKING.DEFAULT, "Predeterminado" },
            {RANKING.USER, "Usuario" },
            {RANKING.ADMIN, "Administrador" }
        };

        /// <summary>
        /// Obtiene una cedena de texto acorde a la autoridad
        /// </summary>
        /// <param name="r">Autoridad</param>
        /// <returns>Una cadena que representa la autoridad del parámetro <paramref name="r"/></returns>
        public static string GetRankingText(RANKING r)
        {
            if (!RankingString.ContainsKey(r))
            {
                throw new System.ArgumentOutOfRangeException();
            }
            return RankingString[r];
        }

        private static readonly Dictionary<STATES, string> StatesString = new Dictionary<STATES, string>()
        {
            {STATES.NONE, "Ninguno" },
            {STATES.ACTIVE, "Activo" },
            {STATES.INACTIVE, "Suspendido" }
        };

        /// <summary>
        /// Obtiene una cadena de texto acorde al estado
        /// </summary>
        /// <param name="s">Estado</param>
        /// <returns>Una cadena que representa el estado del parámetro <paramref name="s"/></returns>
        public static string GetStateText(STATES s)
        {
            if (!StatesString.ContainsKey(s))
            {
                throw new System.ArgumentOutOfRangeException();
            }
            return StatesString[s];
        }
    }
}