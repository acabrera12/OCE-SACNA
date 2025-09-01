using OCESACNA.Model;

namespace OCESACNA.Controller
{
    /// <summary>
    /// Representa a un usuario
    /// </summary>
    public class User : Model.User
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="User"/>
        /// </summary>
        /// <param name="userID">ID del usuario</param>
        /// <param name="userName">Nombre de usuario</param>
        /// <param name="passwordSalt">Código salt de la contraseña</param>
        /// <param name="passwordHash">Código hash de la contraseña</param>
        /// <param name="isEnabled">Determina si el usuario está activado en el sistema</param>
        /// <param name="ranking">Rango del usuario</param>
        public User(int userID = -1, string userName = "", string passwordSalt = "", string passwordHash = "", bool isEnabled = true, Ranks ranking = Ranks.None)
        {
            UserID = userID;
            UserName = userName;
            PasswordSalt = passwordSalt;
            PasswordHash = passwordHash;
            IsEnabled = isEnabled;
            Ranking = ranking;
        }

        /// <summary>
        /// De un registro de usuario a usuario
        /// </summary>
        /// <param name="dbu">Registro</param>
        public static implicit operator User(DBUser dbu)
        {
            return new User()
            {
                UserID = dbu.UserID,
                UserName = dbu.UserName,
                PasswordSalt = dbu.PasswordSalt,
                PasswordHash = dbu.PasswordHash,
                IsEnabled = dbu.IsEnabled,
                Ranking = (Ranks)dbu.Ranking
            };
        }

        /// <summary>
        /// De un usuario a un registro de usuario
        /// </summary>
        /// <param name="u">Usuario</param>
        public static implicit operator DBUser(User u)
        {
            return new DBUser()
            {
                UserID = u.UserID,
                UserName = u.UserName,
                PasswordSalt = u.PasswordSalt,
                PasswordHash = u.PasswordHash,
                IsEnabled = u.IsEnabled,
                Ranking = (int)u.Ranking
            };
        }
    }
}
