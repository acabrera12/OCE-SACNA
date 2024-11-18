using System;
using System.Linq;
using System.Collections.Generic;

namespace OCE_SACNA;

public class Subject : Entity
{
    public string name { get; set; }
    public SbjModule module { get; set; }
    public Teacher teacher { get; set; }
    public Course course { get; set; }

    public Subject()
    {
        this.id = -1;
        this.name = string.Empty;
        this.module = new SbjModule();
        this.teacher = new Teacher();
        this.course = new Course();
    }

    public Subject(Course course, Teacher teacher, SbjModule module, int id = -1, string name = "")
    {
        this.id = id;
        this.name = name;
        this.module = module;
        this.teacher = teacher;
        this.course = course;
    }
}
