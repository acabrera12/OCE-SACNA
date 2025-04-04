namespace OCESACNA.Model
{
    /// <summary>
    /// Representa un registro de un representante
    /// </summary>
    public struct DBRepresentative
    {
        /// <summary>
        /// Obtiene o establece el ID
        /// </summary>
        public int RprsentID { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre completo
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Obtiene o establece el número telefónico
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Obtiene o establece el E-Mail
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Inicializa una instancia de la estructura <see cref="DBRepresentative"/>
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="fullName">Nombre completo</param>
        /// <param name="phoneNumber">Número telefónico</param>
        /// <param name="email">E-Mail</param>
        public DBRepresentative(int id = -1, string fullName = "", string phoneNumber = "", string email = "")
        {
            RprsentID = id;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
