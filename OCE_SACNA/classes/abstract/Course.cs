using System;
using System.Linq;
using System.Collections.Generic;

namespace OCE_SACNA;

public class Course
{
    public int Year { get; set; }
    public int Mention { get; set; }
    public int Section { get; set; }

    public Course(int year = -1, int mention = -1, int section = -1)
    {
        this.Year = year;
        this.Mention = mention;
        this.Section = section;
    }
}
