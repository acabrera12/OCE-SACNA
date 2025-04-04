using OCESACNA.Model;
namespace OCESACNA.Controller
{
    /// <summary>
    /// Representa un representante
    /// </summary>
    public class Representative : Entity
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
        /// Inicializa una instancia de la clase <see cref="Representative"/>
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="fullName">Nombre completo</param>
        /// <param name="phoneNumber">Número telefónico</param>
        /// <param name="email">E-Mail</param>
        public Representative(int id = -1, string fullName = "", string phoneNumber = "", string email = "")
        {
            RprsentID = id;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// <see cref="DBRepresentative"/> -> <see cref="Representative"/>
        /// </summary>
        public static implicit operator Representative(DBRepresentative DBRprsent)
        {
            return new Representative()
            {
                RprsentID = DBRprsent.RprsentID,
                FullName = DBRprsent.FullName,
                PhoneNumber = DBRprsent.PhoneNumber,
                Email = DBRprsent.Email
            };
        }

        /// <summary>
        /// <see cref="Representative"/> -> <see cref="DBRepresentative"/>
        /// </summary>
        public static implicit operator DBRepresentative(Representative Rprsent)
        {
            return new DBRepresentative()
            {
                RprsentID = Rprsent.RprsentID,
                FullName = Rprsent.FullName,
                PhoneNumber = Rprsent.PhoneNumber,
                Email = Rprsent.Email
            };
        }
    }
}
