using System;
using System.Linq;
using System.Collections.Generic;

namespace OCE_SACNA;

public class Teacher : Entity
{
    public string FullName { get; set; }

    public Teacher(int id = -1, string full_name = "")
    {
        this.ID = id;
        this.FullName = full_name;
    }
}
