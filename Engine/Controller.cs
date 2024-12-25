using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCESACNA.Engine.Collections;
using OCESACNA.Engine.Core;

namespace OCESACNA.Engine
{
    public static class Controller
    {
        public static readonly Version3 MainEngineVersion = new Version3(0,3,0);
        public static void Initialize()
        {
            AuthManager.Init();
        }
    }
}
