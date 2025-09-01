using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCESACNA.Model
{
    /// <summary>
    /// Representa la base de un usuario
    /// </summary>
    public abstract class User
    {
        /// <summary>
        /// Rangos de usuario
        /// </summary>
        public enum Ranks
        {
            /// <summary>
            /// Ningún rango
            /// </summary>
            None = -1,

            /// <summary>
            /// Rango de usuario
            /// </summary>
            User = 0,

            /// <summary>
            /// Rango de Administrador
            /// </summary>
            Admin = 1,

            /// <summary>
            /// Rango de usuario predeterminado
            /// </summary>
            Default = 2
        }

        /// <summary>
        /// Obtiene o establece el ID
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre de usuario
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Obtiene o establece el código Salt de la contraseña
        /// </summary>
        public string PasswordSalt { get; set; }

        /// <summary>
        /// Obtiene o establece el código Hash de la contraseña
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Obtiene o establece el estado
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Obtiene o establece el rango
        /// </summary>
        public Ranks Ranking { get; set; }

        /// <summary>
        /// Obtiene una cadena de texto que representa al rango proporcionado en <paramref name="rank"/>
        /// </summary>
        /// <param name="rank">Rango de usuario</param>
        /// <returns>Una cadena localizable de <paramref name="rank"/></returns>
        public static string RankToString(Ranks rank)
        {
            switch (rank)
            {
                default: return Resources.Error;
                case Ranks.None: return Resources.User_RankString_None;
                case Ranks.User: return Resources.User_RankString_User;
                case Ranks.Admin: return Resources.User_RankString_Admin;
                case Ranks.Default: return Resources.User_RankString_Default;
            }
        }

        /// <summary>
        /// Obtiene una cadena de texto que representa al rango del usuario
        /// </summary>
        /// <returns>Una cadena localizable de <see cref="Ranking"/></returns>
        public string RankToString()
        {
            return RankToString(Ranking);
        }
    }
}
