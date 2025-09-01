using OCESACNA.Controller.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OCESACNA.Controller
{
    /// <summary>
    /// 
    /// </summary>
    public static class DataController
    {
        /// <summary>
        /// Obtiene o establece la conexión con la base de datos
        /// </summary>
        private static DBConnection DBConnection { get; set; }

        /// <summary>
        /// Obtiene o establece la conexión con la base de datos del sistema de sacna
        /// </summary>
        private static DBConnection SysDBConnection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static void Initialize()
        {
            Settings.CreateGlobalSettings(false);

            SysDBConnection = new DBConnection(
                Settings.GlobalSettings.Server_Host,
                Settings.GlobalSettings.Server_User,
                Settings.GlobalSettings.Server_Password,
                true
            );

            if (SysDBConnection.Connection == null)
                throw new Exception(Resources.Database_ConnectionError);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Finish()
        {

        }
    }
}
