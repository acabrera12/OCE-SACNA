namespace OCESACNA.Model
{
    /// <summary>
    /// Representa un registro de una asignatura
    /// </summary>
    public struct DBSubject
    {
        /// <summary>
        /// Obtiene o establece el ID
        /// </summary>
        public int SubjetID { get; set; }

        /// <summary>
        /// Obtiene o establece el ID del área de formación
        /// </summary>
        public int SbjetModuleID { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Obtiene o establece el ID del docente
        /// </summary>
        public int TeachID { get; set; }

        /// <summary>
        /// Obtiene o establece el ID del curso
        /// </summary>
        public int CourseID { get; set; }

        /// <summary>
        /// Inicializa una instancia de la estructura <see cref="DBSubject"/>
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="subjectModuleID">ID del área de formación</param>
        /// <param name="name">Nombre</param>
        /// <param name="teachID">ID del docente</param>
        /// <param name="courseID">ID del curso</param>
        public DBSubject(int id = -1, int subjectModuleID = -1, string name = "", int teachID = -1, int courseID = -1)
        {
            SubjetID = id;
            SbjetModuleID = subjectModuleID;
            Name = name;
            TeachID = teachID;
            CourseID = courseID;
        }
    }
}
