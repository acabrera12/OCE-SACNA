using MySql.Data.MySqlClient;
namespace OCESACNA.Engine.Collections
{
    internal class Connection
    {
        private MySqlConnection connection;
        private readonly string connectChain;
        private readonly string server;
        private readonly string database = "ocesacna";
        private readonly string user = "root";
        private readonly string password = "";

        public Connection(string server = "localhost")
        {
            this.server = server;

            connectChain = $"Database={database}; DataSource={this.server}; User Id={user}; Password={password}";
        }

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
