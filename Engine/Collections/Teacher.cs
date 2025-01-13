using OCESACNA.Engine.Collections.Abstract;
namespace OCESACNA.Engine.Collections
{
    /// <summary>
    /// Entidad clase <c>Teacher</c> que hace referencia a un registro de la base de datos
    /// </summary>
    public class Teacher : Entity
    {
        /// <summary>
        /// ID correspondiente al registro
        /// </summary>
        public int TeachID { get; set; }
        /// <summary>
        /// Nombre Completo correspondiente al registro
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Curso asociado al registro
        /// </summary>
        public Course Course { get; set; }

        /// <summary>
        /// Inicializa una instancia vacía de la entidad <c>Teacher</c>
        /// </summary>
        public Teacher()
        {
            this.TeachID = -1;
            this.FullName = string.Empty;
            this.Course = new Course();
        }

        /// <summary>
        /// Inicializa una instancia de la entidad <c>Teacher</c>
        /// </summary>
        /// <param name="id">ID del registro</param>
        /// <param name="course">Curso asociado</param>
        /// <param name="fullname">Nombre completo del registro</param>
        public Teacher(int id, Course course, string fullname = "")
        {
            this.TeachID = id;
            this.FullName = fullname;
            this.Course = course;
        }
    }
}