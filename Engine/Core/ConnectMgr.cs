using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Engine.ClassDB;
using Engine.ClassDB.Asbtract;

namespace Engine.Core
{
    internal static class ConnectMgr
    {
        private static List<Connection> RequestQueue = new List<Connection>();
        private static bool IsRequesting = false;
        private static string Nonce = String.Empty;

        public static void Process()
        {
            if (IsRequesting || RequestQueue.Count() == 0)
            {
                return;
            }

            if (Nonce == String.Empty)
            {
                GetNonce();
                return;
            }

            IsRequesting = true;
            SendRequest(GetFirstQueueElement());
        }

        private static void GetNonce()
        {

        }

        private static void SendRequest(Connection request)
        {
            
        }

        private static void HttpRequestCompleted()
        {

        }

        private static Connection GetFirstQueueElement()
        {
            Connection r = new Connection("", "");

            r = RequestQueue[0];
            RequestQueue.RemoveAt(0);

            return r;
        }
    }
}