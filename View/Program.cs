using OCESACNA.Controller;
using OCESACNA.Core;
using System;
using System.Windows.Forms;
using Settings = OCESACNA.View.Properties.Settings;
using Theme = OCESACNA.View.Collections.ColorTheme;

namespace OCESACNA.View
{
    /// <summary>
    /// Representa el Programa
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Configuración del programa
        /// </summary>
        public static Settings Settings { get; private set; } = new Settings();

        /// <summary>
        /// Tema actual del programa
        /// </summary>
        public static Theme CurrentTheme { get; private set; }

        /// <summary>
        /// Obtiene o establece el menú de soporte de SACNA
        /// </summary>
        public static Menu.HandlerMenu Handler { get; set; }

        /// <summary>
        /// Cantidad máxima de intentos de inicialización en caso de error
        /// </summary>
        private const int MaxRetries = 3;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InitializeTheme();

            bool Initialized = false;
            int retryCount = 0;

            while(!Initialized && retryCount < MaxRetries)
            {
                Initialized = Startup.Initialize(Settings, out var handler);

                if(!Initialized)
                {
                    Handler = handler;
                    Application.Run(Handler);

                    if((bool)(Handler?.CloseOnExit))
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            if (Initialized)
            {
                Application.Run(new Menu.AuthMenu());
            }
            else if (retryCount >= MaxRetries)
            {
                MessageBox.Show(
                    "Se alcanzó el número máximo de intentos de inicialización. \n" +
                    "Por seguridad, el programa terminará la ejecución. \n" +
                    "Puede volver a ejecutar el programa si lo desea.",
                    "Error crítico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            Settings.Save();
        }

        /// <summary>
        /// Iniciliza el tema del programa cargando el valor guardado en la configuración
        /// </summary>
        private static void InitializeTheme()
        {
            CurrentTheme = Theme.GetTheme((Theme.Themes)Settings.Theme);
            CurrentTheme.SetDarkMode(Settings.ThemeDarkMode);
        }
    }
}
