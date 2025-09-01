using OCESACNA.View.Properties;
using System;
using System.Windows.Forms;
using OCESACNA.Controller;

namespace OCESACNA.View
{
    /// <summary>
    /// Representa el inicializador de la aplicación
    /// </summary>
    static class Startup
    {
        /// <summary>
        /// Inicializa la aplicación
        /// </summary>
        /// <param name="settings">Configuración de la aplicación</param>
        /// <param name="handler">Menú de soporte integrado</param>
        /// <returns><see langword="true"/> si se ha iniciado correctamente, de lo contrario <see langword="false"/></returns>
        public static bool Initialize(Settings settings, out Menus.HandlerMenu handler)
        {
            handler = null;
            try
            {
                DataController.Initialize();
                return true;
            }
            catch (Exception e)
            {
                handler = new Menus.HandlerMenu(e);

                Console.WriteLine(Resources.Messages_InitializationError.Replace("err", e.Message));
                MessageBox.Show(
                    Resources.Messages_InitializationError.Replace("{err}", e.Message),
                    Resources.Titles_InitializationError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
        }

        /// <summary>
        /// Finaliza la aplicación
        /// </summary>
        /// <param name="settings">Configuración de la aplicación</param>
        public static void Finalize(Settings settings)
        {
            DataController.Finish();

            settings.Save();
        }
    }
}
