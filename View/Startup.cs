using OCESACNA.Controller;
using OCESACNA.View.Properties;
using System;
using System.Windows.Forms;

namespace OCESACNA.View
{
    /// <summary>
    /// Representa el inicializador del programa
    /// </summary>
    internal static class Startup
    {
        /// <summary>
        /// Inicializa el programa
        /// </summary>
        /// <param name="settings">Configuración del programa</param>
        /// <param name="handler">Menú de soporte. será usado en caso de un error durante la inicilización</param>
        internal static bool Initialize(Settings settings, out View.Menu.HandlerMenu handler)
        {
            handler = null;

            try
            {
                DataController.Init(settings.HostName, settings.HostUser, settings.HostPassword);
                AuthController.Init();
                return true;
            }
            catch (Exception ex)
            {
                handler = new View.Menu.HandlerMenu();

                Console.WriteLine($"{typeof(Startup)}: Exception during initialization: {ex.Message}");
                MessageBox.Show(
                    $"Un error ha sido ocurrido durante la inicialización\nde la aplicación:\n{ex.Message}",
                    "Error de inicialización",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }
    }
}