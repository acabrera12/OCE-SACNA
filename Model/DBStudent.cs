using System;

namespace OCESACNA.Model
{
    /// <summary>
    /// Representa un registro de un estudiante
    /// </summary>
    public struct DBStudent
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
        /// Obtiene o establece la edad
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Obtiene o establece el sexo
        /// </summary>
        public int Sex { get; set; }

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
        public int RprsentID { get; set; }

        /// <summary>
        /// Obtiene o establece el ID del curso
        /// </summary>
        public int CourseID { get; set; }

        /// <summary>
        /// Inicializa una instancia de la estructura <see cref="DBStudent"/>
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
        /// <param name="representID">ID del representante</param>
        /// <param name="courseID">ID del curso</param>
        public DBStudent(int id = -1, int cedula = -1, string lastNames = "", string firstNames = "", int age = -1, int sex = -1, string birthdate = "01/01/0001", string birthPlace = "", string federalEntity = "", string address = "", string phoneNumber = "", string email = "", int representID = -1, int courseID = -1)
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
            RprsentID = representID;
            CourseID = courseID;
        }
    }
}
