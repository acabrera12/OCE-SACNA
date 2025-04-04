using OCESACNA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace OCESACNA.Controller
{
    /// <summary>
    /// Controlador de Autenticación
    /// </summary>
    public static class AuthController
    {
        /// <summary>
        /// Obtiene o establece el usuario autenticado
        /// </summary>
        private static User LogedUser { get; set; }

        /// <summary>
        /// Obtiene o establece la lista de usuarios
        /// </summary>
        private static List<User> UsersList { get; set; } = new List<User>();

        /// <summary>
        /// Obtiene el nombre de usuario del usuario autenticado
        /// </summary>
        public static string LogedUserName
        {
            get
            {
                if (LogedUser == null)
                {
                    return string.Empty;
                }

                return LogedUser.UserName;
            }
        }

        /// <summary>
        /// Obtiene el rango del usuario autenticado
        /// </summary>
        public static User.Ranking LogedUserRank
        {
            get
            {
                if (LogedUser == null)
                {
                    return User.Ranking.NONE;
                }

                return LogedUser.Rank;
            }
        }

        /// <summary>
        /// Obtiene <see langword="true"/> si el usuario autenticado es administrador, de lo contrario <see langword="false"/>
        /// </summary>
        public static bool LogedUserIsAdmin
        {
            get
            {
                if (LogedUser == null)
                {
                    return false;
                }

                if (LogedUser.Rank == User.Ranking.ADMIN || LogedUser.Rank == User.Ranking.DEFAULT)
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Obtiene <see langword="true"/> si hay un usuario autenticado, de lo contrario <see langword="false"/>
        /// </summary>
        public static bool IsUserLoged
        {
            get
            {
                if (LogedUser == null)
                {
                    return false;
                }

                return true;
            }
        }

        /// <summary>
        /// Resultados del controlador
        /// </summary>
        public enum Error
        {
            OK = 0,
            INVALID_USER_ID = 1,
            INVALID_USER_RANK = 2,
            INVALID_USER_STATE = 3,
            INVALID_USER_NAME_OR_PASSWORD = 4,
            USER_DISABLED = 5,
            UNKNOWED_ERROR = 6
        }

        /// <summary>
        /// Inicializa el controlador
        /// </summary>
        public static void Init()
        {
            foreach (DBUser user in DataController.GetAllUsers())
            {
                UsersList.Add(user);
            }
        }

        /// <summary>
        /// Inicia sesión con el usuario y contraseña proporcionado
        /// </summary>
        /// <param name="username">Nombre de usuario</param>
        /// <param name="password">Contraseña</param>
        /// <returns>un <see cref="Error"/> acorde al resultado</returns>
        public static Error Login(string username, string password)
        {
            User user = null;

            user = UsersList.Find(t => t.UserName == username);

            if (user == null)
            {
                return Error.INVALID_USER_NAME_OR_PASSWORD;
            }

            if (!user.IsValidPassword(password))
            {
                return Error.INVALID_USER_NAME_OR_PASSWORD;
            }

            if (!Entity.IsValidID(user.UserID))
            {
                return Error.INVALID_USER_ID;
            }

            if (user.Rank == User.Ranking.NONE)
            {
                return Error.INVALID_USER_RANK;
            }

            if (user.State == User.States.NONE)
            {
                return Error.INVALID_USER_STATE;
            }

            if (user.State == User.States.DISABLED)
            {
                return Error.USER_DISABLED;
            }

            LogedUser = user;
            user = null;

            Console.WriteLine($"{typeof(AuthController)}: Login success");

            return Error.OK;
        }

        /// <summary>
        /// Ciera la sesión del usuario autenticado
        /// </summary>
        public static void Logout()
        {
            LogedUser = null;

            Console.WriteLine($"{typeof(AuthController)}: Logout success");

            return;
        }

        public static void GenerateHash()
        {

        }
    }
}
