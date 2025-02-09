using OCESACNA.View.Menu;
using System;
using System.Windows.Forms;
using Settings = OCESACNA.View.Properties.Settings;
using Theme = OCESACNA.View.Collections.Theme;

namespace OCESACNA.View
{
    internal static class Program
    {
        /// <summary>
        /// Configuración de la aplicación
        /// </summary>
        public static Settings Settings { get; } = new Settings();

        /// <summary>
        /// Obtiene o establece el tema de la aplicación
        /// </summary>
        public static Theme CurrentTheme { get; set; }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Engine.Engine.Initialize(Settings.ServerHost);
            CurrentTheme = Theme.GetTheme((Theme.Themes)Settings.Theme);

            Application.Run(new AuthMenu());

            /// Se ejecuta luego de cerrar la aplicación

            Settings.Save();
        }
    }
}
