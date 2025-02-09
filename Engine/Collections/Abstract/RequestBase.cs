using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCESACNA.Engine.Collections.Abstract
{
    /// <summary>
    /// Clase base para la creación de Solicitudes
    /// </summary>
    public abstract class RequestBase
    {
        /// <summary>
        /// Obtiene o establece una la sentencia MySql que se debe ejecutar
        /// </summary>
        public string Query { get; set; }
        /// <summary>
        /// Obtiene o establece un arreglo <see cref="string"/>[] que serán usadas para la conversión de datos
        /// </summary>
        public string[] Keys { get; set; } = new string[0];
    }
}
