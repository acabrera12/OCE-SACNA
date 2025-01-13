using OCESACNA.Engine.Collections.Abstract;
namespace OCESACNA.Engine.Collections
{
    /// <summary>
    /// Entidad clase <c>Representative</c> que hace referencia a un registro de la base de datos
    /// </summary>
    public class Representative : Entity
    {
        /// <summary>
        /// ID correspondiente a la instancia
        /// </summary>
        public int RprsentID { get; set; }
        /// <summary>
        /// Nombre completo correspondiente a la instancia
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Número telefónico correspondiente a la instancia
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// E-Mail correspondiente a la instancia
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Inicializa una instancia de la entidad <c>Representative</c>
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