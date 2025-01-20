using System;
using System.Collections.Generic;

namespace OCESACNA.Engine.Collections
{
    /// <summary>
    /// Clase <see cref="Request"/> utilizada para el procesamiento de solicitudes a la base de datos
    /// </summary>
    public class Request : Abstract.RequestBase
    {
        /// <summary>
        /// Inicializa una instancia de la clase <see cref="Request"/> con <param name="keys">Llaves</param> aúxiliares
        /// </summary>
        /// <param name="query">sentencia MySQL</param>
        /// <param name="keys">Llave(s) aúxiliar(es)</param>
        public Request(string query, string[] keys)
        {
            Query = query;
            Keys = keys;
        }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="Request"/>
        /// </summary>
        /// <param name="query">Sentencia MySQL</param>
        public Request(string query)
        {
            Query = query;
            Keys = new string[0];
        }

        /// <summary>
        /// Delegado encargado del evento <see cref="Completed"/>
        /// </summary>
        public delegate void CompleEventHandle(Request sender, RequestEventArgs eventArgs);

        /// <summary>
        /// Evento <see cref="Completed"/> llamado al completar la solicitud
        /// </summary>
        public event CompleEventHandle Completed;

        /// <summary>
        /// Disparador del evento <see cref="Completed"/>
        /// </summary>
        /// <param name="eventArgs"></param>
        protected virtual void OnComplete(RequestEventArgs eventArgs)
        {
            Completed?.Invoke(this, eventArgs);
        }

        /// <summary>
        /// Dispara el evento <see cref="Completed"/> de la instancia
        /// </summary>
        /// <param name="eventArgs">Argumentos del evento</param>
        public void Complete(RequestEventArgs eventArgs)
        {
            OnComplete(eventArgs);
        }

        /// <summary>
        /// Subscribe la lamada <param name="callback">callback</param> al evento <see cref="Completed"/> de la instancia
        /// </summary>
        /// <param name="callback">Llamada a conectar</param>
        public void Connect(CompleEventHandle callback)
        {
            Completed += callback;
        }
    }

    /// <summary>
    /// Clase <see cref="RequestEventArgs"/> usada para la transmisión de datos mediante eventos de la clase <see cref="Request"/>
    /// </summary>
    public class RequestEventArgs : EventArgs
    {
        /// <summary>
        /// Obtiene o establece la Respuesta de la solicitud
        /// </summary>
        public List<Dictionary<string, dynamic>> Response { get; set; }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="RequestEventArgs"/>
        /// </summary>
        /// <param name="response">Respuesta de la solucitud</param>
        public RequestEventArgs(List<Dictionary<string, dynamic>> response)
        {
            this.Response = response;
        }
    }
}
