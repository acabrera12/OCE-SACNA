using OCESACNA.Model;
using System;

namespace OCESACNA.Controller
{
    /// <summary>
    /// Representa un registro
    /// </summary>
    public class EventLog
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
        public LogEventType EventType { get; set; }

        /// <summary>
        /// Tipos de evento de registro
        /// </summary>
        public enum LogEventType
        {
            NONE = 0,
            SYNC = 1,
            ADD_ = 2,
            DEL_ = 3,
            UPDT = 4
        }

        /// <summary>
        /// Obtiene el texto que representa al tipo de evento proporcionado
        /// </summary>
        /// <param name="logEvent">Tipo de evento</param>
        /// <returns>Una cadena <see langword="string"/> que representa en tipo proporcionado</returns>
        public static string GetLogEventTypeText(LogEventType logEvent)
        {
            switch (logEvent)
            {
                case LogEventType.SYNC:
                    return "Sincronizar";
                case LogEventType.ADD_:
                    return "Agregar";
                case LogEventType.DEL_:
                    return "Eliminar";
                case LogEventType.UPDT:
                    return "Actualizar";
                default:
                    return "Error";
            }
        }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="EventLog"/>
        /// </summary>
        /// <param name="eventID">ID del registro</param>
        /// <param name="eventTime">Hora en el que se registró. dejar vacío para usar la actual</param>
        /// <param name="userID">ID del usuario quien lo registró</param>
        /// <param name="eventType">Tipo de registro</param>
        public EventLog(int eventID = -1, string eventTime = "", int userID = -1, LogEventType eventType = LogEventType.NONE)
        {
            EventID = eventID;
            EventTime = eventTime != string.Empty ? DateTime.Parse(eventTime) : DateTime.Now;
            UserID = userID;
            EventType = eventType;
        }

        /// <summary>
        /// <see cref="DBEventLog"/> -> <see cref="EventLog"/>
        /// </summary>
        public static implicit operator EventLog(DBEventLog eventLog)
        {
            return new EventLog()
            {
                EventID = eventLog.EventID,
                EventTime = eventLog.EventTime,
                EventType = (LogEventType)eventLog.EventType,
                UserID = eventLog.UserID
            };
        }

        /// <summary>
        /// <see cref="EventLog"/> -> <see cref="DBEventLog"/>
        /// </summary>
        public static implicit operator DBEventLog(EventLog eventLog)
        {
            return new DBEventLog()
            {
                EventID = eventLog.EventID,
                EventTime = eventLog.EventTime,
                EventType = (int)eventLog.EventType,
                UserID = eventLog.UserID
            };
        }
    }
}
