using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCESACNA.Engine.Collections
{
    public class Request
    {
        public string query { get; set; }
        public string[] keys { get; set; }

        public Request(string query, string[] keys)
        {
            this.query = query;
            this.keys = keys;
        }

        public delegate void CompleEventHandle(Request sender, RequestEventArgs eventArgs);

        public event CompleEventHandle Completed;

        protected virtual void OnComplete(RequestEventArgs eventArgs)
        {
            if (Completed != null)
            {
                Completed(this, eventArgs);
            }
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
        public List<Dictionary<string, dynamic>> response { get; set; }

        public RequestEventArgs(List<Dictionary<string, dynamic>> response)
        {
            this.response = response;
        }
    }
}
