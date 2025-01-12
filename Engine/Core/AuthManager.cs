using OCESACNA.Engine.Collections;
using System;
using System.Collections.Generic;

namespace OCESACNA.Engine.Core
{
    public static class AuthManager
    {
        private static User LoggedUser = new User();
        private readonly static List<User> UserList = new List<User>();

        internal static void Init()
        {
            ConnectManager.GetAllUsers(GetDBUsers);
            ConnectManager.DataModified.Connect(UpdateData);
        }

        private static void UpdateData(object s, EventArgs e)
        {
            ConnectManager.GetAllUsers(GetDBUsers);
        }

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

            User DBUser = UserList.Find(x => x.UserName == user.UserName);

            if (DBUser == null)
            {
                return ResultCode.UNREGISTERED_USER;
            }

            if (DBUser.UserID > User.MaxID || user.UserID < 0)
            {
                return ResultCode.INVALID_USER_ID;
            }

            if (DBUser.Rank == User.RANKING.NONE)
            {
                return ResultCode.INVALID_USER_RANK;
            }

            if (DBUser.State == User.STATES.NONE)
            {
                return ResultCode.INVALID_USER_STATE;
            }

            if (DBUser.Password != user.Password)
            {
                return ResultCode.INCORRECT_PASSWORD;
            }

            if (DBUser.State == User.STATES.INACTIVE)
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
            if (LoggedUser.Rank == User.RANKING.ADMIN || LoggedUser.Rank == User.RANKING.DEFAULT)
            {
                return true;
            }

            return false;
        }
        public static string GetLoggedUsername()
        {
            return LoggedUser.UserName;
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

        private static void GetDBUsers(object sender, RequestEventArgs eventArgs)
        {
            List<Dictionary<string, dynamic>> list = eventArgs.Response;

            foreach (Dictionary<string, dynamic> dic in list)
            {
                User user = ConversionManager.DictionaryToUser(dic);

                UserList.Add(user);
            }
        }
    }
}