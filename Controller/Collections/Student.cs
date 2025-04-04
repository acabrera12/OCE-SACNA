using OCESACNA.Model;
using System;

namespace OCESACNA.Controller
{
    /// <summary>
    /// Representa un estudiante
    /// </summary>
    public class Student : Entity
    {
        /// <summary>
        /// Obtiene o establece el ID
        /// </summary>
        public int StudentID { get; set; }

        /// <summary>
        /// Obtiene o establece la cédula
        /// </summary>
        public int Cedula { get; set; }

        /// <summary>
        /// Obtiene o establece los apellidos
        /// </summary>
        public string LastNames { get; set; }

        /// <summary>
        /// Obtiene o establece los nombres
        /// </summary>
        public string FirstNames { get; set; }

        /// <summary>
        /// Obtiene el nombre completo
        /// </summary>
        public string FullName
        {
            get
            {
                return $"{LastNames} {FirstNames}";
            }
        }

        /// <summary>
        /// Obtiene o establece la edad
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Obtiene o establece el sexo
        /// </summary>
        public Sexs Sex { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de nacimiento
        /// </summary>
        public DateTime Birthdate { get; set; }

        /// <summary>
        /// Obtiene o establece el lugar de nacimiento
        /// </summary>
        public string BirthPlace { get; set; }

        /// <summary>
        /// Obtiene o establece la entidad federal
        /// </summary>
        public string FederalEntty { get; set; }

        /// <summary>
        /// Obtiene o establece la dirección
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Obtiene o establece el número telefónico
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Obtiene o establece el E-Mail
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Obtiene o establece el ID del representante
        /// </summary>
        public Representative Representative { get; set; }

        /// <summary>
        /// Obtiene o establece el ID del curso
        /// </summary>
        public Course Course { get; set; }

        /// <summary>
        /// Sexos de estudiantes
        /// </summary>
        public enum Sexs
        {
            NONE = 0,
            M = 1,
            F = 2
        }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="DBStudent"/>
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="cedula">Cédula</param>
        /// <param name="lastNames">Apellidos</param>
        /// <param name="firstNames">Nombres</param>
        /// <param name="age">Edad</param>
        /// <param name="sex">Sexo</param>
        /// <param name="birthdate">Fecha de nacimiento</param>
        /// <param name="birthPlace">Lugar de nacimiento</param>
        /// <param name="federalEntity">Entidad federal</param>
        /// <param name="address">Dirección</param>
        /// <param name="phoneNumber">Número telefónico</param>
        /// <param name="email">E-Mail</param>
        /// <param name="representative">Representante</param>
        /// <param name="course">Curso</param>
        public Student(int id = -1, int cedula = -1, string lastNames = "", string firstNames = "", int age = -1, Sexs sex = Sexs.NONE, string birthdate = "01/01/0001", string birthPlace = "", string federalEntity = "", string address = "", string phoneNumber = "", string email = "", Representative representative = null, Course course = null)
        {
            StudentID = id;
            Cedula = cedula;
            LastNames = lastNames;
            FirstNames = firstNames;
            Age = age;
            Sex = sex;
            Birthdate = DateTime.Parse(birthdate);
            BirthPlace = birthPlace;
            FederalEntty = federalEntity;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            Representative = representative;
            Course = course;
        }

        /// <summary>
        /// Obtiene el texto que representa el sexo proporcionado
        /// </summary>
        /// <param name="sexs">Sexo</param>
        /// <returns>una cadena que representa a <paramref name="sexs"/></returns>
        public static string GetSexsText(Sexs sexs)
        {
            switch (sexs)
            {
                case Sexs.NONE:
                    return "Ninguno";
                case Sexs.M:
                    return "Masculino";
                case Sexs.F:
                    return "Femenino";
                default:
                    return "Error";
            }
        }

        /// <summary>
        /// <see cref="DBStudent"/> -> <see cref="Student"/>
        /// </summary>
        public static implicit operator Student(DBStudent DBStudent)
        {
            return new Student()
            {
                StudentID = DBStudent.StudentID,
                Cedula = DBStudent.Cedula,
                LastNames = DBStudent.LastNames,
                FirstNames = DBStudent.FirstNames,
                Age = DBStudent.Age,
                Sex = (Sexs)DBStudent.Sex,
                Birthdate = DBStudent.Birthdate,
                BirthPlace = DBStudent.BirthPlace,
                FederalEntty = DBStudent.FederalEntty,
                Address = DBStudent.Address,
                PhoneNumber = DBStudent.PhoneNumber,
                Email = DBStudent.Email,
                Representative = DataController.GetRepresentative(DBStudent.RprsentID),
                Course = DataController.GetCourse(DBStudent.CourseID)
            };
        }

        /// <summary>
        /// <see cref="Student"/> -> <see cref="DBStudent"/>
        /// </summary>
        public static implicit operator DBStudent(Student student)
        {
            return new DBStudent()
            {
                StudentID = student.StudentID,
                Cedula = student.Cedula,
                LastNames = student.LastNames,
                FirstNames = student.FirstNames,
                Age = student.Age,
                Sex = (int)student.Sex,
                Birthdate = student.Birthdate,
                BirthPlace = student.BirthPlace,
                FederalEntty = student.FederalEntty,
                Address = student.Address,
                PhoneNumber = student.PhoneNumber,
                Email = student.Email,
                RprsentID = student.Representative.RprsentID,
                CourseID = student.Course.CourseID
            };
        }
    }
}
