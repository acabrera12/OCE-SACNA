using OCESACNA.Model;
namespace OCESACNA.Controller
{
    /// <summary>
    /// Representa un docente
    /// </summary>
    public class Teacher : Entity
    {
        /// <summary>
        /// Obtiene o establece el ID
        /// </summary>
        public int TeachID { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre completo
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Obtiene o establece el curso
        /// </summary>
        public Course Course { get; set; }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="Teacher"/>
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="fullName">Nombre completo</param>
        /// <param name="course">Curso</param>
        public Teacher(int id = -1, string fullName = "", Course course = null)
        {
            TeachID = id;
            FullName = fullName;
            Course = course;
        }

        /// <summary>
        /// <see cref="DBTeacher"/> -> <see cref="Teacher"/>
        /// </summary>
        public static implicit operator Teacher(DBTeacher DBTeacher)
        {
            return new Teacher()
            {
                TeachID = DBTeacher.TeachID,
                FullName = DBTeacher.FullName,
                Course = DataController.GetCourse(DBTeacher.CourseID)
            };
        }

        /// <summary>
        /// <see cref="Teacher"/> -> <see cref="DBTeacher"/>
        /// </summary>
        public static implicit operator DBTeacher(Teacher teacher)
        {
            return new DBTeacher()
            {
                TeachID = teacher.TeachID,
                FullName = teacher.FullName,
                CourseID = teacher.Course.CourseID
            };
        }
    }
}
