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
        /// Obtiene o establece la contraseña
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Obtiene o establece el código Hash de la contraseña
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Obtiene o establece el rango
        /// </summary>
        public int Rank { get; set; }

        /// <summary>
        /// Obtiene o establece el estado
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// Inicializa una instancia de la estructura <see cref="DBUser"/>
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="username">Nombre de usuario</param>
        /// <param name="password">Contraseña</param>
        /// <param name="passwordSHA">SHA de la contraseña</param>
        /// <param name="rank">Rango</param>
        /// <param name="state">Estado</param>
        public DBUser(int id = -1, string username = "", string password = "", string passwordSHA = "", int rank = -1, int state = -1)
        {
            this.UserID = id;
            this.UserName = username;
            this.Password = password;
            this.PasswordHash = passwordSHA;
            this.Rank = rank;
            this.State = state;
        }
    }
}
