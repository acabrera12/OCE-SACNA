using System;
using System.Linq;
using System.Collections.Generic;

namespace OCE_SACNA;

public class SbjModule : Entity
{
    public string name { get; set; }

    public SbjModule()
    {
        this.name = string.Empty;
    }

    public SbjModule(string name = "")
    {
        this.name = name;
    }
}
