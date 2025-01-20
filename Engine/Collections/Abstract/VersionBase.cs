namespace OCESACNA.Engine.Collections.Abstract
{
    /// <summary>
    /// Clase asbtracta <see cref="VersionBase"/> de la que derivan las clases <see cref="Version2"/> y <see cref="Version3"/>
    /// </summary>
    public abstract class VersionBase
    {
        /// <summary>
        /// Versi�n principal
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// Obtiene una cadena que representa la versi�n
        /// </summary>
        public virtual string GetAsText()
        {
            return ConstructVer(Version);
        }

        /// <summary>
        /// Construlle una cadena con el par�metro "args"
        /// </summary>
        /// <param name="args">Enteros que formar�n parte de la cadena</param>
        /// <returns>Una cadena con los par�metros unidos por '.'</returns>
        protected string ConstructVer(params int[] args)
        {
            string text = "";
            int index = 0;
            foreach (var ver in args)
            {
                text += ver.ToString();
                if (index != args.Length - 1)
                {
                    text += ".";
                }
                index++;
            }
            return text;
        }
    }
}