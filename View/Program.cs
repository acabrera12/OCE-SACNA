using OCESACNA.Controller;
using System;
using System.Windows.Forms;
using Settings = OCESACNA.View.Properties.Settings;
using Theme = OCESACNA.View.Collections.ColorTheme;

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
            CurrentTheme.SetDarkMode(Settings.ThemeDarkMode);

            // Inicializar controladores
            int attemps = 0;
            bool init = false;
            while (attemps < 3)
            {
                try
                {
                    DataController.Init(Settings.HostName, Settings.HostUser, Settings.HostPassword);
                    AuthController.Init();
                    init = true;
                    break;
                }
                catch (Exception ex)
                {
                    Handler = new Menu.HandlerMenu(ex);

                    Console.WriteLine($"{typeof(Program)}:A Exception was catched during Initialization: {ex.Message}");
                    MessageBox.Show($"Un error ha sido provocado durante la" +
                                    $"\ninicialización de la aplicación:" +
                                    $"\n{ex.Message}", "Error de inicialización",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Run(Handler);
                    attemps++;

                    if (Handler.ExitOnClose)
                        break;
                    else
                        continue;
                }
            }

            // Ejecutar
            if (attemps >= 3)
            {
                MessageBox.Show(
                    "No se ha podido inicializar el programa y se ha superado el límite de intentos",
                    "Error de inicialización",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                );
            }

            else if (init)
            {
                Application.Run(new Menu.AuthMenu());
            }

            // Se ejecuta luego de cerrar la aplicación
            Settings.Save();
        }
    }
}
