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
        /// Obtiene o establece el ID del guía del curso
        /// </summary>
        public int GuideID { get; set; }

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
        /// <param name="id">ID del curso</param>
        /// <param name="guideID">ID del guía</param>
        /// <param name="year">Año</param>
        /// <param name="mention">Mención</param>
        /// <param name="section">Sección</param>
        public DBCourse(int id = -1, int guideID = -1, int year = -1, string mention = "", char section = '?')
        {
            CourseID = id;
            GuideID = guideID;
            Year = year;
            Mention = mention;
            Section = section;
        }
    }
}
