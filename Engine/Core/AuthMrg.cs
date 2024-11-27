using System;
using Engine.ClassDB;

namespace Engine.Core
{
    internal static class AuthMgr
    {
        private static User LoggedUser = new User();

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
            /*conectar a la base de datos, obtener coincidencias
            establecer {user} si se encuentra
            si no, return ResultCode.UNREGISTETED_USER*/
            
            ResultCode result = ValidateUser(user);

            if (result != ResultCode.SUSSCES)
            {
                Console.WriteLine($"Error trying to verify user, error: {result}");
                return result;
            }

            LoggedUser = user;

            Console.WriteLine("Login successful");

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

            Console.WriteLine("Successful logout");

            return ResultCode.SUSSCES;
        }

        public static bool GetAdministratorAuthorization()
        {
            if (LoggedUser.Rank != User.RANKING.ADMIN || LoggedUser.Rank != User.Rank.DEFAULT)
            {
                return false;
            }

            return true;
        }

        private static ResultCode ValidateUser(User user)
        {
            if (user.ID > User.MaxID || user.ID < 0)
            {
                return ResultCode.INVALID_USER_ID;
            }

            if (user.Rank == User.RANKING.NONE)
            {
                return ResultCode.INVALID_USER_RANK;
            }

            if (user.State == User.USER_STATE.NONE)
            {
                return ResultCode.INVALID_USER_STATE;
            }

            if (user.Username == String.Empty)
            {
                return ResultCode.USER_NAME_EMPTY;
            }

            if (user.Password == String.Empty)
            {
                return ResultCode.USER_PASSWORD_EMPTY;
            }

            return ResultCode.SUSSCES;
        }
    }
}