using System;
using System.Collections.Generic;

namespace OCESACNA.Engine.Collections
{
    public class Request
    {
        public string Query { get; set; }
        public string[] Keys { get; set; }

        public Request(string query, string[] keys)
        {
            Query = query;
            Keys = keys;
        }

        public Request(string query)
        {
            Query = query;
            Keys = new string[0];
        }

        public delegate void CompleEventHandle(Request sender, RequestEventArgs eventArgs);

        public event CompleEventHandle Completed;

        protected virtual void OnComplete(RequestEventArgs eventArgs)
        {
            Completed?.Invoke(this, eventArgs);
        }

        public void Complete(RequestEventArgs eventArgs)
        {
            OnComplete(eventArgs);
        }

        public void Connect(CompleEventHandle callback)
        {
            Completed += callback;
        }
    }

    public class RequestEventArgs : EventArgs
    {
        public List<Dictionary<string, dynamic>> Response { get; set; }

        public RequestEventArgs(List<Dictionary<string, dynamic>> response)
        {
            this.Response = response;
        }
    }
}
