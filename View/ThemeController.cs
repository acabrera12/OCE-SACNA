using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OCESACNA.View.Collections;

namespace OCESACNA.Controller
{
    /// <summary>
    /// Controlador de Temas
    /// </summary>
    public static class ThemeController
    {
        /// <summary>
        /// Obtiene o establece la instancia del tema actual
        /// </summary>
        public static Theme CurrentTheme { get; private set; }

        /// <summary>
        /// Obtiene o establece el valor que determina si se usará el tema oscuro
        /// </summary>
        public static bool DarkMode { get; private set; } = false;

        /// <summary>
        /// Se produce cuando se modifica <see cref="CurrentTheme"/>
        /// </summary>
        public static event EventHandler ThemeChanged;

        /// <summary>
        /// Se produce cuando se modifica <see cref="DarkMode"/>
        /// </summary>
        public static event EventHandler DarkModeChanged;

        /// <summary>
        /// Establece el tema actual y produce un evento <see cref="ThemeChanged"/>
        /// </summary>
        /// <param name="theme">Nuevo tema</param>
        public static void SetTheme(Theme theme)
        {
            CurrentTheme = theme;
            ThemeChanged?.Invoke(null, EventArgs.Empty);
        }

        /// <summary>
        /// Establece el modo oscuro del tema actual y produce un evento <see cref="DarkModeChanged"/>
        /// </summary>
        /// <param name="value">Nuevo valor</param>
        public static void SetDarkMode(bool value)
        {
            if (DarkMode == value)
            {
                return;
            }
            DarkMode = value;
            DarkModeChanged?.Invoke(null, EventArgs.Empty);
        }
    }
}
