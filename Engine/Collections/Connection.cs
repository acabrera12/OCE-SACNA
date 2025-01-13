using MySql.Data.MySqlClient;
namespace OCESACNA.Engine.Collections
{
    /// <summary>
    /// Clase interna <c>Connection</c> usada para conectar con la base de datos
    /// </summary>
    internal class Connection
    {
        private MySqlConnection connection;
        private readonly string connectChain;
        private readonly string server;
        private readonly string database = "ocesacna";
        private readonly string user = "root";
        private readonly string password = "";

        /// <summary>
        /// Inicializa una instancia de la clase <c>Connection</c>
        /// </summary>
        /// <param name="server"><c>URI</c> del host de la base de datos</param>
        public Connection(string server = "localhost")
        {
            this.server = server;

            connectChain = $"Database={database}; DataSource={this.server}; User Id={user}; Password={password}";
        }

        /// <summary>
        /// Obtiene la conexión con la base de datos de la instancia
        /// </summary>
        /// <returns>Una conexión <c>MySqlConnection</c></returns>
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
