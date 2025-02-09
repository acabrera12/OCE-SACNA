using OCESACNA.Engine.Collections;
using System;
using System.Collections.Generic;

namespace OCESACNA.Engine.Core
{
    /// <summary>
    /// Administrador de identidad/autoridad clase <see cref="AuthManager"></see>
    /// </summary>
    public static class AuthManager
    {
        /// <summary>
        /// Obtiene o establece el usuario logeado
        /// </summary>
        private static User LogedUser { get; set; } = new User();

        /// <summary>
        /// Lista de usuarios
        /// </summary>
        private readonly static List<User> UserList = new List<User>();

        /// <summary>
        /// Inicializa el administrador
        /// </summary>
        internal static void Init()
        {
            ConnectManager.GetAllUsers(GetDBUsers);
            ConnectManager.DataModified.Connect(UpdateData);
        }

        /// <summary>
        /// Actualiza los datos
        /// </summary>
        /// <param name="s">Objeto que envía el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private static void UpdateData(object s, EventArgs e)
        {
            ConnectManager.GetAllUsers(GetDBUsers);
        }

        /// <summary>
        /// Obtiene los usuarios desde la base de datos
        /// </summary>
        /// <param name="sender">Objeto que envía el evento</param>
        /// <param name="eventArgs">Argumentos del evento</param>
        private static void GetDBUsers(object sender, RequestEventArgs eventArgs)
        {
            List<Dictionary<string, dynamic>> list = eventArgs.Response;

            foreach (Dictionary<string, dynamic> dic in list)
            {
                User user = ConversionManager.DictionaryToUser(dic);

                UserList.Add(user);
            }
        }

        /// <summary>
        /// Posibles Resultados de métodos del administrador
        /// </summary>
        public enum ResultCode
        {
            SUCCESS = 0,
            INVALID_USER_ID = 1,
            INVALID_USER_RANK = 2,
            INVALID_USER_STATE = 3,
            USER_NAME_EMPTY = 4,
            USER_PASSWORD_EMPTY = 5,
            UNREGISTERED_USER = 6,
            UNKNOWN_ERROR = 7,
            INCORRECT_PASSWORD = 8,
            DISABLED_USER = 9
        }

        /// <summary>
        /// Intenta iniciar sesión como el usuario indicado en <paramref name="user"/>
        /// </summary>
        /// <param name="user">Usuario</param>
        /// <returns>Un <see cref="ResultCode"/> correspondiente al resultado</returns>
        public static ResultCode TryLogginAs(User user)
        {
            ResultCode result = IsValidUser(user);

            if (result != ResultCode.SUCCESS)
            {
                return result;
            }

            User FoundUser = UserList.Find(x => x.UserName == user.UserName);

            if (FoundUser == null)
            {
                return ResultCode.UNREGISTERED_USER;
            }

            if (FoundUser.Password != user.Password)
            {
                return ResultCode.INCORRECT_PASSWORD;
            }

            if (FoundUser.State == User.STATES.INACTIVE)
            {
                return ResultCode.DISABLED_USER;
            }

            LogedUser = FoundUser;

            Console.WriteLine("Login successfull");

            return ResultCode.SUCCESS;
        }

        /// <summary>
        /// Cierra la sesión del usuario actual
        /// </summary>
        /// <returns>Un <see cref="ResultCode">Resultado del administrador</see></returns>
        public static ResultCode Logout()
        {
            LogedUser = new User();

            Console.WriteLine("Successfull logout");
            return ResultCode.SUCCESS;
        }

        /// <summary>
        /// Obtiene autorización de usuario administrador
        /// </summary>
        /// <returns><see langword="true"/> si el usuario logeado es administrador, <see langword="false"/> si no</returns>
        public static bool IsAdminUser()
        {
            if (LogedUser.Rank == User.RANKING.ADMIN || LogedUser.Rank == User.RANKING.DEFAULT)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Obtiene el nombre del usuario logeado
        /// </summary>
        /// <returns>(<see langword="string"/>) el nombre del usuario</returns>
        public static string GetLogedUserName()
        {
            return LogedUser.UserName;
        }

        /// <summary>
        /// Valida si el usuario proporcionado es válido
        /// </summary>
        /// <param name="user">usuario</param>
        /// <returns><see cref="ResultCode"/> acorde a la validéz de <paramref name="user"/></returns>
        private static ResultCode IsValidUser(User user)
        {
            if (user == null)
            {
                throw new NullReferenceException();
            }

            if (user.UserName == string.Empty)
            {
                return ResultCode.USER_NAME_EMPTY;
            }

            if (user.Password == string.Empty)
            {
                return ResultCode.USER_PASSWORD_EMPTY;
            }

            if (user.Rank == User.RANKING.NONE)
            {
                return ResultCode.INVALID_USER_RANK;
            }

            if (user.State == User.STATES.NONE)
            {
                return ResultCode.INVALID_USER_STATE;
            }

            if (!Collections.Abstract.Entity.IsValidID(user.UserID))
            {
                return ResultCode.INVALID_USER_ID;
            }

            return ResultCode.SUCCESS;
        }
    }
}