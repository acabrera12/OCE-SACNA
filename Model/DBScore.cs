namespace OCESACNA.Model
{
    /// <summary>
    /// Representa un registro de una calificación
    /// </summary>
    public struct DBScore
    {
        /// <summary>
        /// Obtiene o establece el ID
        /// </summary>
        public int ScoreID { get; set; }

        /// <summary>
        /// Obtiene o establece el ID del estudiante
        /// </summary>
        public int StudentID { get; set; }

        /// <summary>
        /// Obtiene o establece el ID de la asignatura
        /// </summary>
        public int SubjetID { get; set; }

        /// <summary>
        /// Obtiene o establece la calificación del primer lapso
        /// </summary>
        public float First { get; set; }

        /// <summary>
        /// Obtiene o establece la calificación del segundo lapso
        /// </summary>
        public float Second { get; set; }

        /// <summary>
        /// Obtiene o establece la calificación del tercer lapso
        /// </summary>
        public float Third { get; set; }

        /// <summary>
        /// Obtiene o establece la calificación prodio
        /// </summary>
        public float Final { get; set; }

        /// <summary>
        /// Obtiene o establece las inasistencias totales
        /// </summary>
        public int Absences { get; set; }

        /// <summary>
        /// Inicializa una instancia de la estructura <see cref="DBScore"/>
        /// </summary>
        /// <param name="scoreID">ID</param>
        /// <param name="studentID">ID del estudiante</param>
        /// <param name="subjetID">ID de la asignatura</param>
        /// <param name="first">Calificación del primer lapso</param>
        /// <param name="second">Calificación del segundo lapso</param>
        /// <param name="third">Calificación del tercer lapso</param>
        /// <param name="final">Calificación del promedio lapso</param>
        /// <param name="absences">Inasistencias totales</param>
        public DBScore(int scoreID = -1, int studentID = -1, int subjetID = -1, float first = 0, float second = 0, float third = 0, float final = 0, int absences = 0)
        {
            ScoreID = scoreID;
            StudentID = studentID;
            SubjetID = subjetID;
            First = first;
            Second = second;
            Third = third;
            Final = final;
            Absences = absences;
        }
    }
}
