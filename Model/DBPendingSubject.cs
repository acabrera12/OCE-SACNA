namespace OCESACNA.Model
{
    /// <summary>
    /// Representa un registro de una asignatura pendiente
    /// </summary>
    public struct DBPendingSubject
    {
        /// <summary>
        /// Obtiene o establece el ID
        /// </summary>
        public int PendingSbjetID { get; set; }

        /// <summary>
        /// Obtiene o establece el ID del estudiante
        /// </summary>
        public int StudentID { get; set; }

        /// <summary>
        /// Obtiene o establece el ID de la asignatura
        /// </summary>
        public int SubjetID { get; set; }

        /// <summary>
        /// Inicializa una instancia de la estructura <see cref="DBPendingSubject"/>
        /// </summary>
        /// <param name="pendingSbjetID">ID</param>
        /// <param name="studentID">ID del estudiante</param>
        /// <param name="subjetID">ID de la asignatura</param>
        public DBPendingSubject(int pendingSbjetID = -1, int studentID = -1, int subjetID = -1)
        {
            PendingSbjetID = pendingSbjetID;
            StudentID = studentID;
            SubjetID = subjetID;
        }
    }
}
