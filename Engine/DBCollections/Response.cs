using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCESACNA.Engine.DBCollections
{
    public class DBResponse
    {
        public string error { get; set; }
        public string command { get; set; }
        public object response { get; set; }

        public DBResponse(string err, string command, object response)
        {
            this.error = err;
            this.command = command;
            this.response = response;
        }
    }
}
