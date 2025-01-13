using OCESACNA.Engine.Collections.Abstract;

namespace OCESACNA.Engine.Collections
{
    /// <summary>
    /// Entidad clase <c>Course</c> que hace referencia a un registro en la base de datos
    /// </summary>
    public class Course : Entity
    {
        /// <summary>
        /// ID correspondiente a la instancia
        /// </summary>
        public int CourseID { get; set; }
        /// <summary>
        /// Año correspondiente a la instancia
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// Mención correspondiente a la instancia
        /// </summary>
        public string Mention { get; set; }
        /// <summary>
        /// Sección correspondiente a la instancia
        /// </summary>
        public string Section { get; set; }

        /// <summary>
        /// Inicializa una instancia de la entidad <c>Course</c>
        /// </summary>
        /// <param name="id">ID del registro</param>
        /// <param name="year">Año del registro</param>
        /// <param name="mention">Mención del registro</param>
        /// <param name="section">Sección del registro</param>
        public Course(int id = -1, int year = -1, string mention = "", string section = "")
        {
            this.CourseID = id;
            this.Year = year;
            this.Mention = mention;
            this.Section = section;
        }
    }
}