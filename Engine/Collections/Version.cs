using OCESACNA.Engine.Collections.Abstract;
namespace OCESACNA.Engine.Collections
{
    /// <summary>
    /// Clase <see cref="Version2"/> que representa una versi�n "x.y"
    /// </summary>
    public class Version2 : VersionBase
    {
        /// <summary>
        /// Obtiene o establece la Sub versi�n
        /// </summary>
        public int SubVersion { get; set; }

        /// <summary>
        /// Obtiene una cadena que representa la versi�n
        /// </summary>
        public override string GetAsText()
        {
            return ConstructVer(Version, SubVersion);
        }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="Version2"/>
        /// </summary>
        /// <param name="version">Versi�n Primaria</param>
        /// <param name="subversion">Vesi�n Secundaria</param>
        public Version2(int version, int subversion)
        {
            this.Version = version;
            this.SubVersion = subversion;
        }
    }

    /// <summary>
    /// Clase <see cref="Version3"/> que representa una versi�n "x.y.z"
    /// </summary>
    public class Version3 : VersionBase
    {
        /// <summary>
        /// Obtiene o establece la Sub versi�n
        /// </summary>
        public int SubVersion { get; set; }

        /// <summary>
        /// Obtiene o establece la Modificaci�n
        /// </summary>
        public int Modification { get; set; }

        /// <summary>
        /// Obtiene una cadena que representa la versi�n
        /// </summary>
        public override string GetAsText()
        {
            return ConstructVer(Version, SubVersion, Modification);
        }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="Version3"/>
        /// </summary>
        /// <param name="version">Versi�n Principal</param>
        /// <param name="subversion">Versi�n Secundaria</param>
        /// <param name="modification">Modificai�n</param>
        public Version3(int version, int subversion, int modification)
        {
            this.Version = version;
            this.SubVersion = subversion;
            this.Modification = modification;
        }
    }
}