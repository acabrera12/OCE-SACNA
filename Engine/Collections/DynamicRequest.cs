using System;
using System.Collections.Generic;

namespace OCESACNA.Engine.Collections
{
    /// <summary>
    /// Clase <see cref="DynamicRequest"/> utilizada para el procesamiento dinámico de datos
    /// </summary>
    public class DynamicRequest : Abstract.RequestBase
    {
        /// <summary>
        /// Obtiene o establece el método de procesamiento de la solicitud
        /// </summary>
        public METHODS Method { get; set; }

        /// <summary>
        /// Métodos disponibles para solicitudes
        /// </summary>
        public enum METHODS
        {
            INSERT = 0,
            SELECT = 1,
            UPDATE = 2,
            DELETE = 3
        }

        /// <summary>
        /// Tablas disponibles de la base de datos
        /// </summary>
        public enum TABLES
        {
            Users = 0,
            Courses = 1,
            Representatives = 2,
            Teachers = 3,
            SubjectModules = 4,
            Subjects = 5,
            Students = 6,
            Scores = 7
        }

        public enum ResultCode
        {
            SUCCESS = 0
        }

        /// <summary>
        /// Clase <see cref="Methods"/> usada como referencia par la generación de secuencias MySQL
        /// </summary>
        private static class Methods
        {
            public static string Insert = "INSERT";
            public static string Select = "SELECT";
            public static string Update = "UPDATE";
            public static string Delete = "DELETE";

            static readonly string[] methods = new string[] { Insert, Select, Update, Delete};

            internal static string GetMethodString(METHODS method)
            {
                return methods[Convert.ToInt32(method)];
            }
        }

        /// <summary>
        /// Clase <see cref="Tables"/> usada como referencia para la generación de secuencias MySQL
        /// </summary>
        private static class Tables
        {
            public const string Users = "users";
            public const string Courses = "courses";
            public const string Representatives = "representatives";
            public const string Teachers = "teachers";
            public const string SubjectModules = "subjectmodules";
            public const string Subjects = "subjects";
            public const string Students = "students";
            public const string Scores = "scores";

            static readonly string[] tables = new string[] { Users, Courses, Representatives, Teachers, SubjectModules, Subjects, Students, Scores };

            internal static string GetTableString(TABLES table)
            {
                return tables[Convert.ToInt32(table)];
            }
        }

        /// <summary>
        /// Evento llamado cuando se completa la solicitud
        /// </summary>
        public event CompleteEventHandle Completed;

        /// <summary>
        /// Delegado del evento <see cref="Completed"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="EventArgs">Argumentos del evento</param>
        public delegate void CompleteEventHandle(object sender, DynamicRequestEventArgs EventArgs);

        /// <summary>
        /// Disparador del evento <see cref="Completed"/>
        /// </summary>
        protected void OnComplete(object sender, DynamicRequestEventArgs e)
        {
            Completed?.Invoke(sender, e);
        }

        /// <summary>
        /// Dispara el evento <see cref="Completed"/>
        /// </summary>
        /// <param name="sender"><see langword="object"/> que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        public void CompleteRequest(object sender, DynamicRequestEventArgs e)
        {
            OnComplete(sender, e);
        }
    }

    //<see/>
    /// <summary>
    /// CLase <see cref="DynamicRequestEventArgs"/> usada para la transmisión de información mediante eventos
    /// </summary>
    public class DynamicRequestEventArgs
    {
        /// <summary>
        /// Método CRUD usado en la consulta
        /// </summary>
        public DynamicRequest.METHODS Method {get;set;}

        /// <summary>
        /// Código resultado de la solicitud
        /// </summary>
        public DynamicRequest.ResultCode ResultCode { get; set; }

        /// <summary>
        /// Respuesta de la consulta
        /// </summary>
        public Dictionary<string, dynamic>[] Response { get; set; }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="DynamicRequestEventArgs"/>
        /// </summary>
        /// <param name="method">método de la solicitud</param>
        /// <param name="resultCode">código del resultado</param>
        /// <param name="response">Resultado</param>
        public DynamicRequestEventArgs(DynamicRequest.METHODS method, Dictionary<string, dynamic>[] response, DynamicRequest.ResultCode resultCode = DynamicRequest.ResultCode.SUCCESS)
        {
            this.Method = method;
            this.ResultCode = resultCode;
            this.Response = response;
        }
    }
}
