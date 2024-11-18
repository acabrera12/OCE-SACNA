using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace OCE_SACNA;

public class Student : Entity
{
    public int Cedula { get; set; }
    public string LastName { get; set; }
    public string FirsName { get; set; }
    public int Sex { get; set; }
    public int Age { get; set; }
    public DateTime Birthdate { get; set; }
    public string BirthPlace { get; set; }
    public string FederalEntity { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public Representative Representative { get; set; }
    public Course Course { get; set; }

    public Student(DateTime birthdate, Representative representative, Course course, int id = -1, int cedula = -1, string last_name = "", string firs_name = "", int sex = -1, int age = -1, string birth_place = "", string federal_entity = "", string phone_number = "", string email = "")
    {
        this.ID = id;
        this.Cedula = cedula;
        this.LastName = last_name;
        this.FirsName = firs_name;
        this.Sex = sex;
        this.Age = age;
        this.Birthdate = birthdate;
        this.BirthPlace = birth_place;
        this.FederalEntity = federal_entity;
        this.PhoneNumber = phone_number;
        this.Email = email;
        this.Representative = representative;
        this.Course = course;
    }
}
