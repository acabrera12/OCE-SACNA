using OCESACNA.Controller;
using System;
using System.Windows.Forms;
using Settings = OCESACNA.View.Properties.Settings;
using Theme = OCESACNA.View.Collections.Theme;

namespace OCESACNA.View
{
    /// <summary>
    /// Programa
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
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Pre-Inicialización de la aplicación
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Cargar el tema guardado en configuración
            CurrentTheme = Theme.GetTheme((Theme.Themes)Settings.Theme);

            // Inicializar controladores
            bool Error = false, ContinueExecution = true;

            try
            {
                DataController.Init(Settings.HostName, Settings.HostUser, Settings.HostPassword);
                AuthController.Init();
            }
            catch (Exception err)
            {
                Error = true;
                Handler = new Menu.HandlerMenu();

                Console.WriteLine($"{typeof(Program)}:A Exception was catched during Initialization: {err.Message}");
                MessageBox.Show($"Un error ha sido provocado durante la" +
                                $"\ninicialización de la aplicación:" +
                                $"\n{err.Message}", "Error de inicialización",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Run(Handler);
            }

            // Ejecución de la aplicación
            if (Error)
            {
                if ((bool)(Handler?.ExitOnSave))
                {
                    ContinueExecution = false;
                }
            }

            if (ContinueExecution)
            {
                Application.Run(new Menu.AuthMenu());
            }

            // Se ejecuta luego de cerrar la aplicación
            Settings.Save();
        }

        /// <summary>
        /// Cambia el tema actual del programa
        /// </summary>
        /// <param name="newTheme">Nuevo tema</param>
        public static void ChangeTheme(Theme newTheme)
        {
            CurrentTheme = newTheme;
            Settings.Theme = (int)newTheme.ThemeEnumeration;

            Theme.ChangeTheme(newTheme);
        }
    }
}
