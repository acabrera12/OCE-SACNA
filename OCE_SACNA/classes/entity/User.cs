using System;
using System.Linq;
using System.Collections.Generic;
using OCE_SACNA;

namespace OCE_SACNA;

public class User : Entity
{
    public string Username { get; set; }
    public string Password { get; set; }
    public AuthManager.RANKING Rank { get; set; }
    public AuthManager.USER_STATUS Status { get; set; }

    public User(int id = -1, string username = "", AuthManager.RANKING rank = AuthManager.RANKING.UNASSIGNED, AuthManager.USER_STATUS status = AuthManager.USER_STATUS.UNASSIGNED, string password = "")
    {
        this.ID = id;
        this.Rank = rank;
        this.Status = status;
        this.Username = username;
        this.Password = password;
    }
}
