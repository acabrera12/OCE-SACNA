using System;
using System.Windows.Forms;
using OCESACNA.Controller;
using OCESACNA.View;
using OCESACNA.View.Properties;

namespace OCESACNA.Core
{
    /// <summary>
    /// Representa el inicializador del programa
    /// </summary>
    public static class Startup
    {
        /// <summary>
        /// Inicializa el programa
        /// </summary>
        /// <param name="settings">Configuración del programa</param>
        /// <param name="handler">Menú de soporte. será usado en caso de un error durante la inicilización</param>
        public static bool Initialize(Settings settings, out Menu.HandlerMenu handler)
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
                handler = new Menu.HandlerMenu();

                Console.WriteLine($"{typeof(Startup)}: Exception during initialization: {ex.Message}");
                MessageBox.Show(
                    $"Un error ha sido provocado durante la\ninicialización de la aplicación:\n{ex.Message}",
                    "Error de inicialización",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }
    }
}