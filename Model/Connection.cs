using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;

namespace OCESACNA.Model
{
    /// <summary>
    /// Representa una conexión con la base de datos
    /// </summary>
    public class Connection
    {
        private MySqlConnection connection;
        private readonly string connectChain;

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="Connection"/>
        /// </summary>
        /// <param name="server"><c>URI</c> del host de la base de datos</param>
        /// <param name="hostUser">Nombre del usuario de la base de datos</param>
        /// <param name="hostPass">Contraseña de acceso de la base de datos</param>
        public Connection(string server = "localhost", string hostUser = "OCESACNA", string hostPass = "password", string database = "ocesacna")
        {
            connectChain = $"Database={database}; DataSource={server}; User Id={hostUser}; Password={hostPass}";
        }

        /// <summary>
        /// Obtiene la conexión con la base de datos de la instancia
        /// </summary>
        /// <returns>Una conexión <see cref="MySqlConnection"/></returns>
        public MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(connectChain);
                connection.Open();
            }

            return connection;
        }
    }
}
