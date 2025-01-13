using OCESACNA.Engine.Collections;
using OCESACNA.Engine.Core;

namespace OCESACNA.Engine
{
    /// <summary>
    /// Controlador de los administradores
    /// </summary>
    public static class Controller
    {
        /// <summary>
        /// Inicializa todos los administradores
        /// </summary>
        public static void Initialize()
        {
            UpdateManager.Init();
            ConnectManager.Init("localhost");
            AuthManager.Init();
        }
    }
}
