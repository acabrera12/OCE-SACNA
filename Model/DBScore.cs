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
        /// Obtiene o establece la calificación definitiva del primer lapso
        /// </summary>
        public float FirstDef { get; set; }

        /// <summary>
        /// Obtiene o establece las inasistencias del primer lapso
        /// </summary>
        public int FirstInas { get; set; }

        /// <summary>
        /// Obtiene o establece la calificación del segundo lapso
        /// </summary>
        public float Second { get; set; }

        /// <summary>
        /// Obtiene o establece la calificación definitiva del segundo lapso
        /// </summary>
        public float SecondDef { get; set; }

        /// <summary>
        /// Obtiene o establece las inasistencias del segundo lapso
        /// </summary>
        public int SecondInas { get; set; }

        /// <summary>
        /// Obtiene o establece la calificación del tercer lapso
        /// </summary>
        public float Third { get; set; }

        /// <summary>
        /// Obtiene o establece la calificación definitiva del tercer lapso
        /// </summary>
        public float ThirdDef { get; set; }

        /// <summary>
        /// Obtiene o establece las inasistencias del tercer lapso
        /// </summary>
        public int ThirdInas { get; set; }

        /// <summary>
        /// Obtiene o establece la calificación prodio
        /// </summary>
        public float Final { get; set; }

        /// <summary>
        /// Obtiene o establece la calificación definitiva prodio
        /// </summary>
        public float FinalDef { get; set; }

        /// <summary>
        /// Obtiene o establece las inasistencias totales
        /// </summary>
        public int FinalInas { get; set; }

        /// <summary>
        /// Inicializa una instancia de la estructura <see cref="DBScore"/>
        /// </summary>
        /// <param name="scoreID">ID</param>
        /// <param name="studentID">ID del estudiante</param>
        /// <param name="subjetID">ID de la asignatura</param>
        /// <param name="first">Calificación del primer lapso</param>
        /// <param name="firstDef">Calificación definitiva del primer lapso</param>
        /// <param name="firstInas">Inasistencias del primer lapso</param>
        /// <param name="second">Calificación del segundo lapso</param>
        /// <param name="secondDef">Calificación definitiva del segundo lapso</param>
        /// <param name="secondInas">Inasistencias del segundo lapso</param>
        /// <param name="third">Calificación del tercer lapso</param>
        /// <param name="thirdDef">Calificación definitiva del tercer lapso</param>
        /// <param name="thirdInas">Inasistencias del tercer lapso</param>
        /// <param name="final">Calificación del promedio lapso</param>
        /// <param name="finalDef">Calificación definitiva del promedio lapso</param>
        /// <param name="finalInas">Inasistencias totales</param>
        public DBScore(int scoreID = -1, int studentID = -1, int subjetID = -1, float first = -1, float firstDef = -1, int firstInas = -1, float second = -1, float secondDef = -1, int secondInas = -1, float third = -1, float thirdDef = -1, int thirdInas = -1, float final = -1, float finalDef = -1, int finalInas = -1)
        {
            ScoreID = scoreID;
            StudentID = studentID;
            SubjetID = subjetID;
            First = first;
            FirstDef = firstDef;
            FirstInas = firstInas;
            Second = second;
            SecondDef = secondDef;
            SecondInas = secondInas;
            Third = third;
            ThirdDef = thirdDef;
            ThirdInas = thirdInas;
            Final = final;
            FinalDef = finalDef;
            FinalInas = finalInas;
        }
    }
}
