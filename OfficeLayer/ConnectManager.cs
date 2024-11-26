using Engine;

namespace OfficeLayer
{
    public static class ConnectManager
    {
        private static List<Connection> RequestQueue = new List<Connection>();

    }

    public class Connection
    {
        public string Command { get; set; }
        public string Data { get; set; }

        public Connection(string command, string data)
        {
            this.Command = command;
            this.Data = data;
        }
    }
}