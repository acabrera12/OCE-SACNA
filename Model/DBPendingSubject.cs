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
        /// Obtiene o establece el nombre
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa una instancia de la estructura <see cref="DBPendingSubject"/>
        /// </summary>
        /// <param name="pendingSbjetID">ID</param>
        /// <param name="studentID">ID del estudiante</param>
        /// <param name="name">Nombre</param>
        public DBPendingSubject(int pendingSbjetID = -1, int studentID = -1, string name = "")
        {
            PendingSbjetID = pendingSbjetID;
            StudentID = studentID;
            Name = name;
        }
    }
}
