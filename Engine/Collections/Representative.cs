using OCESACNA.Engine.Collections.Abstract;
namespace OCESACNA.Engine.Collections
{
    /// <summary>
    /// Entidad clase <see cref="Representative"/> que hace referencia a un registro de la base de datos
    /// </summary>
    public class Representative : Entity
    {
        /// <summary>
        /// Obtiene o establece el ID correspondiente a la instancia
        /// </summary>
        public int RprsentID { get; set; }
        /// <summary>
        /// Obtiene o establece el Nombre completo correspondiente a la instancia
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Obtiene o establece el Número telefónico correspondiente a la instancia
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Obtiene o establece el E-Mail correspondiente a la instancia
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Inicializa una instancia de la entidad <see cref="Representative"/>
        /// </summary>
        /// <param name="id">ID del registro</param>
        /// <param name="fullname">Nombre Completo del registro</param>
        /// <param name="phonenumber">Número Telefónico del registro</param>
        /// <param name="email">E-Mail del registro</param>
        public Representative(int id = -1, string fullname = "", string phonenumber = "", string email = "")
        {
            this.RprsentID = id;
            this.FullName = fullname;
            this.PhoneNumber = phonenumber;
            this.Email = email;
        }
    }
}