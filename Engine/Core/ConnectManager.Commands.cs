using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using OCESACNA.Engine.Collections;
using OCESACNA.Engine.DBCollections;

namespace OCESACNA.Engine.Core
{
    public static partial class ConnectManager
    {
        public static void GetAllUsers(Signal.EmitEventHandler callback)
        {
            Request request = new Request("GetAllUsers", new Dictionary<string, string>());
            request.RequestCompleted.Connect(callback);

            AddToQueue(request);
        }

        public static void GetUserByID(int id, Signal.EmitEventHandler callback)
        {
            Request request = new Request("GetUserByID", new DBUser(id));
            request.RequestCompleted.Connect(callback);

            AddToQueue(request);
        }
    }
}
