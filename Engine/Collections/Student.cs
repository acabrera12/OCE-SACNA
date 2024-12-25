using OCESACNA.Engine.Collections.Abstract;
using System;
namespace OCESACNA.Engine.Collections
{
    public class Student : Entity
    {
        public int StudentID { get; set; }
        public int Cedula { get; set; }
        public string LastNames { get; set; }
        public string FirstNames { get; set; }
        public int Age { get; set; }
        public bool Sex { get; set; }
        public DateTime Birthdate { get; set; }
        public string BirthPlace { get; set; }
        public string FederalEntty { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Representative Rprsent { get; set; }
        public Course Course { get; set; }

        public Student()
        {
            this.StudentID = -1;
            this.Cedula = -1;
            this.LastNames = string.Empty;
            this.FirstNames = string.Empty;
            this.Age = -1;
            this.Sex = false;
            this.Birthdate = DateTime.Now;
            this.BirthPlace = string.Empty;
            this.FederalEntty = string.Empty;
            this.Address = string.Empty;
            this.PhoneNumber = string.Empty;
            this.Email = string.Empty;
            this.Rprsent = new Representative();
            this.Course = new Course();
        }

        public Student(int id, DateTime birthdate, Representative rprsent, Course course, int cedula = -1, string lastnames = "", string firstnames = "", int age = -1, bool sex = false, string birthplace = "", string federalentity = "", string address = "", string phone = "", string email = "")
        {
            this.StudentID = id;
            this.Cedula = cedula;
            this.LastNames = lastnames;
            this.FirstNames = firstnames;
            this.Age = age;
            this.Sex = sex;
            this.Birthdate = birthdate;
            this.BirthPlace = birthplace;
            this.FederalEntty = federalentity;
            this.Address = address;
            this.PhoneNumber = phone;
            this.Email = email;
            this.Rprsent = rprsent;
            this.Course = course;
        }
    }
}