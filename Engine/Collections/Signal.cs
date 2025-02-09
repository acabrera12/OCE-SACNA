using System;

namespace OCESACNA.Engine.Collections
{
    /// <summary>
    /// Clase <see cref="Signal"/> usada para crear eventos
    /// </summary>
    public class Signal
    {
        /// <summary>
        /// Delegado encargado de la señal
        /// </summary>
        /// <param name="sender">instancia de la clase que lo envía</param>
        /// <param name="args">Argumentos del Evento</param>
        public delegate void EmitEventHandler(object sender, EventArgs args);

        /// <summary>
        /// Evento llamado cuando se emite la señal
        /// </summary>
        public event EmitEventHandler Emited;

        /// <summary>
        /// Disparador de la señal
        /// </summary>
        /// <param name="args">Argumentos del evento</param>
        protected virtual void OnEmit(EventArgs args)
        {
            Emited?.Invoke(this, args);
        }

        /// <summary>
        /// Dispara el evento <see cref="Emited"/>
        /// </summary>
        /// <param name="args"></param>
        public void Emit(EventArgs args)
        {
            OnEmit(args);
        }

        /// <summary>
        /// Subscribe <paramref name="callback"/> al evento de la señal
        /// </summary>
        /// <param name="callback">Llamada a conectar</param>
        public void Connect(EmitEventHandler callback)
        {
            Emited += callback;
        }
    }
}
