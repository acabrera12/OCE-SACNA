using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCESACNA.Engine.Collections;

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
