using OCESACNA.Engine.Collections.Abstract;
using System;
namespace OCESACNA.Engine.Collections
{
    /// <summary>
    /// Entidad clase <see cref="Student"/> que hace referencia a un registro de la base de datos
    /// </summary>
    public class Student : Entity
    {
        /// <summary>
        /// Obtiene o establece el ID correspondiente a la instancia
        /// </summary>
        public int StudentID { get; set; }

        /// <summary>
        /// Obtiene o establecce la cédula correspondiente a la instancias
        /// </summary>
        public int Cedula { get; set; }

        /// <summary>
        /// Obtiene o establece los apellidos correspondientes a la instancia
        /// </summary>
        public string LastNames { get; set; }

        /// <summary>
        /// Obtiene o establece los nombres correspondientes a la instancia
        /// </summary>
        public string FirstNames { get; set; }

        /// <summary>
        /// Obtiene o establece la edad correspondiente a la instanciia
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Obtiene o establece el sexo correspondiente a la instancia
        /// </summary>
        public SEXS Sex { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de nacimiento correspondiente a la instancia
        /// </summary>
        public DateTime Birthdate { get; set; }

        /// <summary>
        /// Obtiene o establece el lugar de nacimiento correspondiente a la instancia
        /// </summary>
        public string BirthPlace { get; set; }

        /// <summary>
        /// Obtiene o establece la entidad federal correspondiente a la instancia
        /// </summary>
        public string FederalEntty { get; set; }

        /// <summary>
        /// Obtiene o establece la dirección correspondiente a la instancia
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Obtiene o establece el número telefónico correspondiente a la instancia
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Obtiene o establece el E-Mail correspondiente a la instancia
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Obtiene o establece el Representante correspondiente a la instancia
        /// </summary>
        public Representative Rprsent { get; set; }

        /// <summary>
        /// Obtiene o establece el Curso correspondiente a la instancia
        /// </summary>
        public Course Course { get; set; }

        /// <summary>
        /// Sexos disponibles
        /// </summary>
        public enum SEXS
        {
            N = 0,
            M = 1,
            F = 2
        }

        /// <summary>
        /// Inicializa una instancia vacía de la clase <see cref="Student"/>
        /// </summary>
        public Student()
        {
            this.StudentID = -1;
            this.Cedula = -1;
            this.LastNames = string.Empty;
            this.FirstNames = string.Empty;
            this.Age = -1;
            this.Sex = SEXS.N;
            this.Birthdate = DateTime.Now;
            this.BirthPlace = string.Empty;
            this.FederalEntty = string.Empty;
            this.Address = string.Empty;
            this.PhoneNumber = string.Empty;
            this.Email = string.Empty;
            this.Rprsent = new Representative();
            this.Course = new Course();
        }

        public Student(int id, DateTime birthdate, Representative rprsent, Course course, int cedula = -1, string lastnames = "", string firstnames = "", int age = -1, SEXS sex = SEXS.N, string birthplace = "", string federalentity = "", string address = "", string phone = "", string email = "")
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