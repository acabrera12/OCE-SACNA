using OCESACNA.Engine.Collections;
using System;
using System.Threading.Tasks;

namespace OCESACNA.Engine.Core
{
    /// <summary>
    /// Administrador de actualización/procesamiento
    /// </summary>
    public static class UpdateManager
    {
        /// <summary>
        /// Señal emitida cuando se actualiza
        /// </summary>
        internal static Signal Updated = new Signal();

        /// <summary>
        /// Inicializa el administrador
        /// </summary>
        internal static void Init()
        {
            Task.Run(() => StartUpdate());
        }

        /// <summary>
        /// Empieza con el proceso de actualización
        /// </summary>
        private static async Task StartUpdate()
        {
            while (true)
            {
                Updated.Emit(EventArgs.Empty);
                await Task.Delay(100);
            }
        }
    }
}
