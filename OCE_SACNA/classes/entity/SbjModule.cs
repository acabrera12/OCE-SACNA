using System;
using System.Linq;
using System.Collections.Generic;

namespace OCE_SACNA;

public class SbjModule : Entity
{
    public string Name { get; set; }

    public SbjModule(int id = -1,string name = "")
    {
        this.ID = id;
        this.Name = name;
    }
}
