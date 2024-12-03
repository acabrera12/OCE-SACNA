using Engine.ClassDB.Asbtract;

namespace Engine.ClassDB
{
    public class Student : Entity
    {
        public int Cedula { get; set; }
        public string LastName { get; set; }
        public string FirsName { get; set; }
        public int Sex { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string FederalEntity { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Representative Representative { get; set; }
        public Course Course { get; set; }

        public Student(int id, int cedula, string lastName, string firsName, int sex, int age, DateTime birthDate, string birthPlace, string federalEntity, string phoneNumber, string email, Representative representative, Course course)
        {
            this.ID = id;
            this.Cedula = cedula;
            this.LastName = lastName;
            this.FirsName = firsName;
            this.Sex = sex;
            this.Age = age;
            this.BirthDate = birthDate;
            this.BirthPlace = birthPlace;
            this.FederalEntity = federalEntity;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Representative = representative;
            this.Course = course;
        }
    }
}
