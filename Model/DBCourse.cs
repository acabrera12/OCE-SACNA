namespace OCESACNA.Model
{
    /// <summary>
    /// Representa un registro de un curso
    /// </summary>
    public struct DBCourse
    {
        /// <summary>
        /// Obtiene o establece el ID
        /// </summary>
        public int CourseID { get; set; }

        /// <summary>
        /// Obtiene o establece el Año
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Obtiene o establece la Mención
        /// </summary>
        public string Mention { get; set; }

        /// <summary>
        /// Obtiene o establece la Sección
        /// </summary>
        public char Section { get; set; }

        /// <summary>
        /// Inicializa una instancia de la estructura <see cref="DBCourse"/>
        /// </summary>
        /// <param name="id"></param>
        /// <param name="year"></param>
        /// <param name="mention"></param>
        /// <param name="section"></param>
        public DBCourse(int id = -1, int year = -1, string mention = "", char section = '?')
        {
            CourseID = id;
            Year = year;
            Mention = mention;
            Section = section;
        }
    }
}
