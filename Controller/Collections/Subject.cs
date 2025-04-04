using OCESACNA.Model;
namespace OCESACNA.Controller
{
    /// <summary>
    /// Representa una asignatura
    /// </summary>
    public class Subject : Entity
    {
        /// <summary>
        /// Obtiene o establece el ID
        /// </summary>
        public int SubjetID { get; set; }

        /// <summary>
        /// Obtiene o establece el área de formación
        /// </summary>
        public SubjectModule SubjectModule { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Obtiene o establece el docente
        /// </summary>
        public Teacher Teacher { get; set; }

        /// <summary>
        /// Obtiene o establece el curso
        /// </summary>
        public Course Course { get; set; }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="Subject"/>
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="subjectModule">Área de formación</param>
        /// <param name="name">Nombre</param>
        /// <param name="teacher">Docente</param>
        /// <param name="course">Curso</param>
        public Subject(int id = -1, SubjectModule subjectModule = null, string name = "", Teacher teacher = null, Course course = null)
        {
            SubjetID = id;
            SubjectModule = subjectModule;
            Name = name;
            Teacher = teacher;
            Course = course;
        }

        /// <summary>
        /// <see cref="DBSubject"/> -> <see cref="Subject"/>
        /// </summary>
        public static implicit operator Subject(DBSubject DBSubject)
        {
            return new Subject()
            {
                SubjetID = DBSubject.SubjetID,
                SubjectModule = DataController.GetSubjectModule(DBSubject.SbjetModuleID),
                Name = DBSubject.Name,
                Teacher = DataController.GetTeacher(DBSubject.TeachID),
                Course = DataController.GetCourse(DBSubject.CourseID)
            };
        }

        /// <summary>
        /// <see cref="Subject"/> -> <see cref="DBSubject"/>
        /// </summary>
        public static implicit operator DBSubject(Subject subject)
        {
            return new DBSubject()
            {
                SubjetID = subject.SubjetID,
                SbjetModuleID = subject.SubjectModule.SbjetModuleID,
                Name = subject.Name,
                TeachID = subject.Teacher.TeachID,
                CourseID = subject.Course.CourseID
            };
        }
    }
}
