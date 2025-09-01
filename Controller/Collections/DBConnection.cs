using MySql.Data.MySqlClient;

namespace OCESACNA.Controller
{
    /// <summary>
    /// Representa una conexión con la base de datos
    /// </summary>
    internal class DBConnection
    {
        /// <summary>
        /// Obtiene o establece la cadena de conexión
        /// </summary>
        private string ConnectionChain { get; set; }

        /// <summary>
        /// Conexión con la base de datos
        /// </summary>
        private MySqlConnection connection;

        /// <summary>
        /// Obtiene la conexión con la base de datos
        /// </summary>
        public MySqlConnection Connection
        {
            get
            {
                if (connection == null)
                    connection = new MySqlConnection(ConnectionChain);
                connection.Open();
                return connection;
            }
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="DBConnection"/>
        /// </summary>
        /// <param name="server">Dirección del servidor</param>
        /// <param name="hostUser">Usuario de acceso</param>
        /// <param name="hostPassword">Conrtraseña de acceso</param>
        /// <param name="useSystemDB">Determina si se establecerá conexión con la base de datos del sistema de SACNA</param>
        public DBConnection(string server, string hostUser, string hostPassword, bool useSystemDB = false)
        {
            ConnectionChain = $"Database={"ocesacna" + (useSystemDB ? "_system" : "")}; DataSource={server}; User Id={hostUser}; Password={hostPassword}";
        }
    }
}
