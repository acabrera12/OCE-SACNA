using System;
using System.Linq;
using System.Collections.Generic;

namespace OCE_SACNA;

public class Representative
{
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public Representative(int ID = -1, string FullName = "", string PhoneNumber = "", string Email = "")
    {
        this.ID = ID;
        this.FullName = Fullname;
        this.PhoneNumber = PhoneNumber;
        this.Email = Email;
    }
}