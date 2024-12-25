using System;
using System.Collections.Generic;
using OCESACNA.Engine.Collections;

namespace OCESACNA.Engine.Core
{
    public static class AuthManager
    {
        private static User LoggedUser = new User();
        private static List<User> UserList = new List<User>();

        public enum ResultCode
        {
            SUSSCES = 0,
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

        public static ResultCode TryLogginAs(User user)
        {
            ResultCode result = ValidateUser(user);

            if (result != ResultCode.SUSSCES)
            {
                return result;
            }

            /* Conectar a la base de datos para obtener la información,
            verificar que sea correcto (return {error} si no). si exite la info,
            crear {new User()} con la info, establecer user a {new user ()}
            */

            if (user.UserID < 0 || user.UserID > User.MaxID)
            {
                return ResultCode.INVALID_USER_ID;
            }

            if (user.Rank == User.RANKING.NONE)
            {
                return ResultCode.INVALID_USER_RANK;
            }

            if (user.State == User.STATES.NONE)
            {
                return ResultCode.INVALID_USER_STATE;
            }

            if (user.State == User.STATES.INACTIVE)
            {
                return ResultCode.DISABLED_USER;
            }

            LoggedUser = user;

            Console.WriteLine("Login successfull");

            return ResultCode.SUSSCES;
        }

        public static ResultCode Logout()
        {
            ResultCode result = ValidateUser(LoggedUser);

            if (result != ResultCode.SUSSCES)
            {
                Console.WriteLine($"Error trying to log out, error: {result}");
                return result;
            }

            LoggedUser = new User();

            Console.WriteLine("Successfull logout");

            return ResultCode.SUSSCES;
        }

        public static bool GetAdministratorAuthorization()
        {
            if (LoggedUser.Rank != User.RANKING.ADMIN || LoggedUser.Rank != User.RANKING.DEFAULT)
            {
                return false;
            }

            return true;
        }

        private static ResultCode ValidateUser(User user)
        {
            if (user.UserName == String.Empty)
            {
                return ResultCode.USER_NAME_EMPTY;
            }

            if (user.Password == String.Empty)
            {
                return ResultCode.USER_PASSWORD_EMPTY;
            }

            return ResultCode.SUSSCES;
        }
        public static string GetLoggedUsername()
        {
           return LoggedUser.UserName;
        }

        private static void GetUsers(object sender, EventArgs args)
        {
            Console.WriteLine(args);
        }

        internal static void Init()
        {
            ConnectManager.GetAllUsers(GetUsers);
        }
    }
}