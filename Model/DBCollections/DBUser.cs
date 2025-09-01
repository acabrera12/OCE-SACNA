namespace OCESACNA.Model
{
    /// <summary>
    /// Representa un registro de un usuario
    /// </summary>
    public struct DBUser
    {
        /// <summary>
        /// Obtiene o establece el ID
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre de usuario
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Obtiene o establece el código Salt de la contraseña
        /// </summary>
        public string PasswordSalt { get; set; }

        /// <summary>
        /// Obtiene o establece el código Hash de la contraseña
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Obtiene o establece el estado
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Obtiene o establece el rango
        /// </summary>
        public int Ranking { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="DBUser"/>
        /// </summary>
        /// <param name="userID">ID del usuario</param>
        /// <param name="userName">Nombre de usuario</param>
        /// <param name="passwordSalt">Código salt de la contraseña</param>
        /// <param name="passwordHash">Código hash de la contraseña</param>
        /// <param name="isEnabled">Determina si el usuario está activado en el sistema</param>
        /// <param name="ranking">Rango del usuario</param>
        public DBUser(int userID, string userName, string passwordSalt, string passwordHash, bool isEnabled, int ranking)
        {
            UserID = userID;
            UserName = userName;
            PasswordSalt = passwordSalt;
            PasswordHash = passwordHash;
            IsEnabled = isEnabled;
            Ranking = ranking;
        }
    }
}
