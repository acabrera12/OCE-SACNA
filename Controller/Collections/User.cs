using OCESACNA.Model;
using System;
using System.Security.Cryptography;
using System.Text;
namespace OCESACNA.Controller
{
    /// <summary>
    /// Representa un usuario
    /// </summary>
    public class User : Entity
    {
        /// <summary>
        /// Obtiene o establece el ID
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre de usuario
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Obtiene o establece la contraseña
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Obtiene o esta el SHA de la contrasea
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Obtiene o establece la autoridad del usuario
        /// </summary>
        public Ranking Rank { get; set; }


        /// <summary>
        /// Obtiene o establece el estado del usuario
        /// </summary>
        public States State { get; set; }

        /// <summary>
        /// Rangos de usuario
        /// </summary>
        public enum Ranking
        {
            NONE = 0,
            DEFAULT = 1,
            USER = 2,
            ADMIN = 3
        }

        /// <summary>
        /// Estados de usuario
        /// </summary>
        public enum States
        {
            NONE = 0,
            ENABLED = 1,
            DISABLED = 2
        }

        /// <summary>
        /// Inicializa una instancia vacía de la clase <see cref="User"/>
        /// </summary>
        public User()
        {
            UserID = 0;
            UserName = string.Empty;
            Password = string.Empty;
            PasswordHash = string.Empty;
            Rank = Ranking.NONE;
            State = States.NONE;
        }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="User"/>
        /// </summary>
        public User(int id = 0, string username = "", string password = "", string passwordSHA = "", Ranking rank = 0, States state = 0)
        {
            UserID = id;
            UserName = username;
            Password = password;
            PasswordHash = passwordSHA;
            Rank = rank;
            State = state;
        }

        /// <summary>
        /// Obtiene el texto que representa el rango proporcionado
        /// </summary>
        /// <param name="ranking">Rango</param>
        /// <returns>una cadena que representa a <paramref name="ranking"/></returns>
        public static string GetRankingText(Ranking ranking)
        {
            switch (ranking)
            {
                case Ranking.NONE:
                    return "Ninguno";
                case Ranking.DEFAULT:
                    return "Predeterminado";
                case Ranking.USER:
                    return "Usuario";
                case Ranking.ADMIN:
                    return "Administrador";
                default:
                    return "Error";
            }
        }

        /// <summary>
        /// Obtiene el texto que representa el estado proporcionado
        /// </summary>
        /// <param name="states">Estado</param>
        /// <returns>una cadena que representa a <paramref name="states"/></returns>
        public static string GetStatesText(States states)
        {
            switch (states)
            {
                case States.NONE:
                    return "Ninguno";
                case States.ENABLED:
                    return "Activado";
                case States.DISABLED:
                    return "Desactivado";
                default:
                    return "Error";
            }
        }

        /// <summary>
        /// Genera datos seguros equivalentes a la contraseña proporcionada
        /// </summary>
        /// <param name="password"></param>
        public void GenerateSafePassword(string password)
        {
            Password = RandomSalt();

            PasswordHash = GeneratePasswordHash(password, Password);
        }

        /// <summary>
        /// Genera una secuencia Salt aleatoriamente
        /// </summary>
        /// <returns>Una cadena <see langword="string"/> con el salt generado</returns>
        public static string RandomSalt()
        {
            byte[] saltBytes = new byte[16];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }

            return Convert.ToBase64String(saltBytes);
        }

        /// <summary>
        /// Genera un Hash mediante el salt y contraseña proporcionados
        /// </summary>
        /// <param name="password">Contraseña</param>
        /// <param name="salt">Salt</param>
        /// <returns>Una cadena <see langword="string"/> con el hash generado</returns>
        public static string GeneratePasswordHash(string password, string salt)
        {
            string saltedPassword = password + salt;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
                return Convert.ToBase64String(hashBytes);
            }
        }

        /// <summary>
        /// Determina si la contraseña proporcionada es válida como hash
        /// </summary>
        /// <param name="pass">Contraeña</param>
        /// <returns><see langword="true"/> si el hash generado coincide con el almacenado en <see cref="PasswordHash"/>, <see langword="false"/> de lo contrario</returns>
        public bool IsValidPassword(string pass) => GeneratePasswordHash(pass, Password) == PasswordHash;

        /// <summary>
        /// <see cref="DBUser"/> -> <see cref="User"/>
        /// </summary>
        public static implicit operator User(DBUser DBuser)
        {
            return new User()
            {
                UserID = DBuser.UserID,
                UserName = DBuser.UserName,
                Password = DBuser.Password,
                PasswordHash = DBuser.PasswordHash,
                Rank = (Ranking)DBuser.Rank,
                State = (States)DBuser.State
            };
        }

        /// <summary>
        /// <see cref="User"/> -> <see cref="DBUser"/>
        /// </summary>
        public static implicit operator DBUser(User user)
        {
            return new DBUser()
            {
                UserID = user.UserID,
                UserName = user.UserName,
                Password = user.Password,
                PasswordHash = user.PasswordHash,
                Rank = (int)user.Rank,
                State = (int)user.State
            };
        }
    }
}
