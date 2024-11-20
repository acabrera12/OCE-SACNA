using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeLayer
{
    public static class AuthManager
    {
        private User LoggedUSer;
        public enum RANKING
        {
            NONE = 0,
            USER = 1,
            ADMIN = 2,
            DEFAULT = 3
        }

        public enum USER_STATE
        {
            NONE = 0,
            ACTIVE = 1,
            INACTIVE = 2
        }

        public enum ERR_CODES
        {
            SUSSCES = 0,
            INVALID_USER = 1,
            INVALID_USER_ID = 2,
            INVALID_USER_NAME = 3,
            INVALID_USER_RANK = 4,
            INVALID_USER_STATE = 5,
            LOGGIN_ERR = 6,
            LOGOFF_ERR = 7
        }
    }
}
