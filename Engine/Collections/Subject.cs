using OCESACNA.Engine.Collections.Abstract;
namespace OCESACNA.Engine.Collections
{
    /// <summary>
    /// Entidad clase <c>Subject</c> que hace referencia a un registro de la base de datos
    /// </summary>
    public class Subject : Entity
    {
        /// <summary>
        /// ID correspondiente al registro
        /// </summary>
        public int SubjectID { get; set; }
        /// <summary>
        /// Área de formación asociada al registro
        /// </summary>
        public SubjectModule SbjetModule { get; set; }
        /// <summary>
        /// Nombre correspondiente al registro
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Docente asociado al registro
        /// </summary>
        public Teacher Teach { get; set; }
        /// <summary>
        /// Curso asociado al registro
        /// </summary>
        public Course Course { get; set; }

        /// <summary>
        /// Inicializa una instancia vacía del la entidad <c>Subjetc</c>
        /// </summary>
        public Subject()
        {
            this.SubjectID = -1;
            this.SbjetModule = new SubjectModule();
            this.Name = string.Empty;
            this.Teach = new Teacher();
            this.Course = new Course();
        }

        /// <summary>
        /// Inicializa una instancia de la entidad <c>Subject</c>
        /// </summary>
        /// <param name="id">ID del registro</param>
        /// <param name="module">Área de formación asociado</param>
        /// <param name="teach">Docente asociado</param>
        /// <param name="course">Curso asociado</param>
        /// <param name="name">Nombre del registro</param>
        public Subject(int id, SubjectModule module, Teacher teach, Course course, string name = "")
        {
            this.SubjectID = id;
            this.SbjetModule = module;
            this.Name = name;
            this.Teach = teach;
            this.Course = course;
        }
    }
}