using OCESACNA.View.Collections;
using System;
using System.Windows.Forms;

namespace OCESACNA.View.Menu
{
    /// <summary>
    /// Formulario de soporte
    /// </summary>
    public partial class HandlerMenu : Form, IColoreable
    {
        /// <summary>
        /// Obtiene o establece el valor que determina si se cierra al salir del menú de ayuda
        /// </summary>
        public bool ExitOnClose { get; private set; } = false;

        /// <summary>
        /// Inicializa una instancia del formulario <see cref="HandlerMenu"/>
        /// </summary>
        public HandlerMenu(Exception ex)
        {
            InitializeComponent();

            ApplyTheme(Program.CurrentTheme);
            ColorTheme.ThemeChanged += ColorTheme_ThemeChanged;

            exceptionLabel.Text = ex.GetType().Name;
            exceptionDetails.Text = ex.Message + "\n" + ex.StackTrace;

            exitOnCloseBtton.CheckedChanged += (object s, EventArgs ea) =>
            {
                ExitOnClose = exitOnCloseBtton.Checked;
            };
        }

        public void ApplyTheme(ColorTheme theme)
        {
            // this
            theme.ApplyBackgroundStyle(this);
        }

        public void ColorTheme_DarkModeChanged(bool value)
        {
            ApplyTheme(Program.CurrentTheme);
        }

        /// <summary>
        /// Es llamado cuando se cambia el tema del programa
        /// </summary>
        /// <param name="newTheme"></param>
        public void ColorTheme_ThemeChanged(ColorTheme newTheme)
        {
            ApplyTheme(newTheme);
        }
    }
}
