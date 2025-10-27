using OCESACNA.Model;

namespace OCESACNA.Controller
{
    /// <summary>
    /// Representa una asignatura pendiente
    /// </summary>
    public class PendingSubject : Entity
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
        /// Inicializa una instancia de la clase <see cref="PendingSubject"/>
        /// </summary>
        /// <param name="pendingSbjetID">ID</param>
        /// <param name="studentID">ID del estudiante</param>
        /// <param name="subjetID">ID de la asignatura</param>
        public PendingSubject(int pendingSbjetID = -1, int studentID = -1, int subjetID = -1)
        {
            PendingSbjetID = pendingSbjetID;
            StudentID = studentID;
            SubjetID = subjetID;
        }

        /// <summary>
        /// <see cref="DBPendingSubject"/> -> <see cref="PendingSubject"/>
        /// </summary>
        public static implicit operator PendingSubject(DBPendingSubject DBPendingSubject)
        {
            return new PendingSubject()
            {
                PendingSbjetID = DBPendingSubject.PendingSbjetID,
                StudentID = DBPendingSubject.StudentID,
                SubjetID = DBPendingSubject.SubjetID
            };
        }

        /// <summary>
        /// <see cref="PendingSubject"/> -> <see cref="DBPendingSubject"/>
        /// </summary>
        public static implicit operator DBPendingSubject(PendingSubject pendingSubject)
        {
            return new DBPendingSubject()
            {
                PendingSbjetID = pendingSubject.PendingSbjetID,
                StudentID = pendingSubject.StudentID,
                SubjetID = pendingSubject.SubjetID
            };
        }
    }
}
