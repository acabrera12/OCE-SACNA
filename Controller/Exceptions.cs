using System;

namespace OCESACNA
{
    /// <summary>
    /// Representa un error de conexión con la base de datos
    /// </summary>
    public class DBConnectionException : Exception
    {
        /// <summary>
        /// Obtiene el mensaje que describe la excepción actual
        /// </summary>
        public new const string Message = "Error de conexión en la base de datos";
    }
}
