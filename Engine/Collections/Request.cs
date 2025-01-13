using System;
using System.Collections.Generic;

namespace OCESACNA.Engine.Collections
{
    /// <summary>
    /// Clase <c>Request</c> utilizada para el procesamiento de solicitudes a la base de datos
    /// </summary>
    public class Request
    {
        /// <summary>
        /// Almacena la sentencia MySQL que se ejecutará al procesar la solicitud
        /// </summary>
        public string Query { get; set; }
        /// <summary>
        /// Utilizada para aúxiliar al Gestor de Solicitudes para la conversion de datos
        /// </summary>
        public string[] Keys { get; set; }

        /// <summary>
        /// Inicializa una instancia de la clase <c>Request</c> con <c>Keys</c> aúxiliares
        /// </summary>
        /// <param name="query">sentencia MySQL</param>
        /// <param name="keys">Llave(S) aúxiliar(es)</param>
        public Request(string query, string[] keys)
        {
            Query = query;
            Keys = keys;
        }

        /// <summary>
        /// Inicializa una instancia de la clase <c>Request</c>
        /// </summary>
        /// <param name="query">Sentencia MySQL</param>
        public Request(string query)
        {
            Query = query;
            Keys = new string[0];
        }

        /// <summary>
        /// Delegado encargado del evento <c>Completed</c>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        public delegate void CompleEventHandle(Request sender, RequestEventArgs eventArgs);

        /// <summary>
        /// Evento <c>Completed</c> llamado al completar la solicitud
        /// </summary>
        public event CompleEventHandle Completed;

        /// <summary>
        /// Disparador del evento <c>Completed</c>
        /// </summary>
        /// <param name="eventArgs"></param>
        protected virtual void OnComplete(RequestEventArgs eventArgs)
        {
            Completed?.Invoke(this, eventArgs);
        }

        /// <summary>
        /// Dispara el evento <c>Completed</c> de la instancia
        /// </summary>
        /// <param name="eventArgs">Argumentos del evento</param>
        public void Complete(RequestEventArgs eventArgs)
        {
            OnComplete(eventArgs);
        }

        /// <summary>
        /// Subscribe la lamada <p>callback</p> al evento <c>Completed</c> de la instancia
        /// </summary>
        /// <param name="callback">Llamada a conectar</param>
        public void Connect(CompleEventHandle callback)
        {
            Completed += callback;
        }
    }

    /// <summary>
    /// Clase <c>RequestEventArgs</c> usada para la transmisión de datos mediante eventos de la clase <c>Request</c>
    /// </summary>
    public class RequestEventArgs : EventArgs
    {
        /// <summary>
        /// Respuesta de la solicitud
        /// </summary>
        public List<Dictionary<string, dynamic>> Response { get; set; }

        /// <summary>
        /// Inicializa una instancia de la clase <c>RequestEventArgs</c>
        /// </summary>
        /// <param name="response">Respuesta de la solucitud</param>
        public RequestEventArgs(List<Dictionary<string, dynamic>> response)
        {
            this.Response = response;
        }
    }
}
