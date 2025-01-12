using OCESACNA.Engine.Collections;
using OCESACNA.Engine.Core;

namespace OCESACNA.Engine
{
    public static class Controller
    {
        public static readonly Version3 MainEngineVersion = new Version3(0, 3, 0);
        public static void Initialize()
        {
            UpdateManager.Init();
            ConnectManager.Init("localhost");
            AuthManager.Init();
        }
    }
}
