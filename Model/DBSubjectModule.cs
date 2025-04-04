namespace OCESACNA.Model
{
    /// <summary>
    /// Representa un registro de un área de formación
    /// </summary>
    public struct DBSubjectModule
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
        /// Inicializa una instancia de la estructura <see cref="DBSubjectModule"/>
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="name">Nombre</param>
        public DBSubjectModule(int id = -1, string name = "")
        {
            SbjetModuleID = id;
            Name = name;
        }
    }
}
