using OCESACNA.Engine.Collections.Abstract;
namespace OCESACNA.Engine.Collections
{
    /// <summary>
    /// Clase <c>Version2</c> que representa una versión "x.y"
    /// </summary>
    public class Version2 : VersionBase
    {
        /// <summary>
        /// Sub versión
        /// </summary>
        public int SubVersion { get; set; }

        /// <summary>
        /// Obtiene una cadena que representa la versión
        /// </summary>
        public override string GetAsText()
        {
            return ConstructVer(Version, SubVersion);
        }

        /// <summary>
        /// Inicializa una instancia de la clase <c>Version2</c>
        /// </summary>
        /// <param name="version">Versión Primaria</param>
        /// <param name="subversion">Vesión Secundaria</param>
        public Version2(int version, int subversion)
        {
            this.Version = version;
            this.SubVersion = subversion;
        }
    }

    /// <summary>
    /// Clase <c>Version3</c> que representa una versión "x.y.z"
    /// </summary>
    public class Version3 : VersionBase
    {
        /// <summary>
        /// Sub versión
        /// </summary>
        public int SubVersion { get; set; }
        /// <summary>
        /// Modificación
        /// </summary>
        public int Modification { get; set; }

        /// <summary>
        /// Obtiene una cadena que representa la versión
        /// </summary>
        public override string GetAsText()
        {
            return ConstructVer(Version, SubVersion, Modification);
        }

        /// <summary>
        /// Inicializa una instancia de la clase <c>Version3</c>
        /// </summary>
        /// <param name="version">Versión Principal</param>
        /// <param name="subversion">Versión Secundaria</param>
        /// <param name="modification">Modificaión</param>
        public Version3(int version, int subversion, int modification)
        {
            this.Version = version;
            this.SubVersion = subversion;
            this.Modification = modification;
        }
    }
}