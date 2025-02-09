using OCESACNA.Engine.Collections.Abstract;
namespace OCESACNA.Engine.Collections
{
    /// <summary>
    /// Entidad clase <see cref="SubjectModule"/> que hace referencia a un registro de la base de datos
    /// </summary>
    public class SubjectModule : Entity
    {
        /// <summary>
        /// Obtiene o establece eñ ID correspondiente a la instancia
        /// </summary>
        public int SbjetModuleID { get; set; }

        /// <summary>
        /// Obtiene o establece el Nombre correspondiente a la instancia
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa una instancia de la entidad <see cref="SubjectModule"/>
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