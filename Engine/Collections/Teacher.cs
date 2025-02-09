using OCESACNA.Engine.Collections.Abstract;
namespace OCESACNA.Engine.Collections
{
    /// <summary>
    /// Entidad clase <see cref="Teacher"/> que hace referencia a un registro de la base de datos
    /// </summary>
    public class Teacher : Entity
    {
        /// <summary>
        /// Obtiene o establece el ID correspondiente a la instancia
        /// </summary>
        public int TeachID { get; set; }

        /// <summary>
        /// Obtiene o establece el Nombre Completo correspondiente a la instancia
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Obtiene o establece el Curso asociado al registro
        /// </summary>
        public Course Course { get; set; }

        /// <summary>
        /// Inicializa una instancia vacía de la entidad <see cref="Teacher"/>
        /// </summary>
        public Teacher()
        {
            this.TeachID = -1;
            this.FullName = string.Empty;
            this.Course = new Course();
        }

        /// <summary>
        /// Inicializa una instancia de la entidad <see cref="Teacher"/>
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