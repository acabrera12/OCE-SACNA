using System;

namespace OCESACNA.Engine.Collections
{
    public class Signal
    {
        public delegate void EmitEventHandler(object sender, EventArgs args);
        public event EmitEventHandler Emited;

        protected virtual void OnEmit(EventArgs args)
        {
            Emited?.Invoke(this, args);
        }

        public void Emit(EventArgs args)
        {
            OnEmit(args);
        }

        public void Connect(EmitEventHandler callback)
        {
            Emited += callback;
        }
    }
}
