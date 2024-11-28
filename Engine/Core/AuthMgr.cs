using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.ClassDB;

namespace Engine.Core
{
    internal static class AuthMgr
    {
        private static User LoggedUSer = new User();

        public enum ResultCode
        {
            SUCCESS = 0,
            USER_NAME_EMPTY = 1,
            USER_PASSWORD_EMPTY = 2,
            INVALID_USER_ID = 3,
            INVALID_USER_RANK = 4,
            INVALID_USER_STATE = 5,
            DISABLED_USER = 6,
            UNKNOW_ERROR = 7
        }

        public static ResultCode Login(User user)
        {
            ResultCode result = ValidateUser(user);

            if (result != ResultCode.SUCCESS)
            {
                return result;
            }

            // conexion a la base de datos

            if (user.ID < 0 || user.ID > User.MaxID)
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

            if (user.State == User.USER_STATE.INACTIVE)
            {
                return ResultCode.DISABLED_USER;
            }

            return ResultCode.SUCCESS;
        }

        private static ResultCode ValidateUser(User user)
        {
            if (user.Username == String.Empty)
            {
                return ResultCode.USER_NAME_EMPTY;
            }

            if (user.Password == String.Empty)
            {
                return ResultCode.USER_PASSWORD_EMPTY;
            }

            return ResultCode.SUCCESS;
        }
    }
}
