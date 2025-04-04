using OCESACNA.Model;
namespace OCESACNA.Controller
{
    /// <summary>
    /// Representa un área de formación
    /// </summary>
    public class SubjectModule : Entity
    {
        /// <summary>
        /// Obtiene o establece el ID
        /// </summary>
        public int SbjetModuleID { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="SubjectModule"/>
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="name">Nombre</param>
        public SubjectModule(int id = -1, string name = "")
        {
            SbjetModuleID = id;
            Name = name;
        }

        /// <summary>
        /// <see cref="DBSubjectModule"/> -> <see cref="SubjectModule"/>
        /// </summary>
        public static implicit operator SubjectModule(DBSubjectModule DBSubjectModule)
        {
            return new SubjectModule()
            {
                SbjetModuleID = DBSubjectModule.SbjetModuleID,
                Name = DBSubjectModule.Name
            };
        }

        /// <summary>
        /// <see cref="SubjectModule"/> -> <see cref="DBSubjectModule"/>
        /// </summary>
        public static implicit operator DBSubjectModule(SubjectModule SubjectModule)
        {
            return new DBSubjectModule()
            {
                SbjetModuleID = SubjectModule.SbjetModuleID,
                Name = SubjectModule.Name
            };
        }
    }
}
