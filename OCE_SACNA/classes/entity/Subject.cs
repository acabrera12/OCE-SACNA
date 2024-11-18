using System;
using System.Linq;
using System.Collections.Generic;

namespace OCE_SACNA;

public class Subject : Entity
{
    public string Name { get; set; }
    public SbjModule Module { get; set; }
    public Teacher Teacher { get; set; }
    public Course Course { get; set; }

    public Subject(Course course, Teacher teacher, SbjModule module, int id = -1, string name = "")
    {
        this.ID = id;
        this.Name = name;
        this.Module = module;
        this.Teacher = teacher;
        this.Course = course;
    }
}
