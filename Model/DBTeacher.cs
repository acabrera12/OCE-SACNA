namespace OCESACNA.Model
{
    /// <summary>
    /// Representa un registro de un docente
    /// </summary>
    public struct DBTeacher
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
        /// Obtiene o establece el ID del corso
        /// </summary>
        public int CourseID { get; set; }

        /// <summary>
        /// Inicializa una instancia de la estructura <see cref="DBTeacher"/>
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="fullname">Nombre completo</param>
        /// <param name="courseID">ID del curso</param>
        public DBTeacher(int id = -1, string fullname = "", int courseID = -1)
        {
            TeachID = id;
            FullName = fullname;
            CourseID = courseID;
        }
    }
}
