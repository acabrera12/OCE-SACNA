using System;

namespace OCESACNA.Model
{
    /// <summary>
    /// Representa un registro de un cambio en la base de datos
    /// </summary>
    public struct DBEventLog
    {
        /// <summary>
        /// Obtiene o establece el ID
        /// </summary>
        public int EventID { get; set; }

        /// <summary>
        /// Obtiene o establece el tiempo del registro
        /// </summary>
        public DateTime EventTime { get; set; }

        /// <summary>
        /// Obtiene o establece el ID del usuario quien lo registró
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Obtiene o establece el tipo de registro
        /// </summary>
        public int EventType { get; set; }

        /// <summary>
        /// Inicializa una instancia de la estructura <see cref="DBEventLog"/>
        /// </summary>
        /// <param name="eventID">ID del registro</param>
        /// <param name="eventTime">Hora en el que se registró. dejar vacío para usar la actual</param>
        /// <param name="userID">ID del usuario quien lo registró</param>
        /// <param name="eventType">Tipo de registro</param>
        public DBEventLog(int eventID = -1, string eventTime = "", int userID = -1, int eventType = -1)
        {
            EventID = eventID;
            EventTime = eventTime != string.Empty? DateTime.Parse(eventTime): DateTime.Now;
            UserID = userID;
            EventType = eventType;
        }
    }
}
