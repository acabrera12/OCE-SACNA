using OCESACNA.Engine.Collections.Abstract;
namespace OCESACNA.Engine.Collections
{
    /// <summary>
    /// Entidad clase <c>SubjectModule</c> que hace referencia a un registro de la base de datos
    /// </summary>
    public class SubjectModule : Entity
    {
        /// <summary>
        /// ID correspondiente al registro
        /// </summary>
        public int SbjetModuleID { get; set; }
        /// <summary>
        /// Nombre correspondiente al registro
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa una instancia de la entidad <c>SubjectModule</c>
        /// </summary>
        /// <param name="id">ID del registro</param>
        /// <param name="name">Nombre del registro</param>
        public SubjectModule(int id = -1, string name = "")
        {
            this.SbjetModuleID = id;
            this.Name = name;
        }
    }
}