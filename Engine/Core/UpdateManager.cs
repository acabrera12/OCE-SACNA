using OCESACNA.Engine.Collections;
using System;
using System.Threading.Tasks;

namespace OCESACNA.Engine.Core
{
    public static class UpdateManager
    {
        internal static Signal Updated = new Signal();

        internal static void Init()
        {
            Task.Run(() => StartUpdate());
        }

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
