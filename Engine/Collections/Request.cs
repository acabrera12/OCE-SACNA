using System;
using System.Collections.Generic;
using OCESACNA.Engine.DBCollections;

namespace OCESACNA.Engine.Collections
{
    public class Request
    {
        public string Command { get; set; }
        public object Data { get; set; }

        public Request(string command, object data)
        {
            this.Command = command;
            this.Data = data;
        }

        public Signal RequestCompleted = new Signal();
    }

    public class RequestEventArgs : EventArgs
    {
        DBResponse Response { get; set; }
        public RequestEventArgs(DBResponse response)
        {
            this.Response = response;
        }
    }
}
