using OCESACNA.View.Collections;
using System.Windows.Forms;

namespace OCESACNA.View.Menu
{
    /// <summary>
    /// Formulario de soporte
    /// </summary>
    public partial class HandlerMenu : Form, IColoreable
    {
        /// <summary>
        /// Obtiene o establece el valor que determina si se cierra el programa al salir del menú de ayuda
        /// </summary>
        public bool EndOnClose { get; private set; } = false;

        /// <summary>
        /// Inicializa una instancia del formulario <see cref="HandlerMenu"/>
        /// </summary>
        public HandlerMenu()
        {
            InitializeComponent();

            ApplyTheme(Program.CurrentTheme);

            ColorTheme.ThemeChanged += ColorTheme_ThemeChanged;
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
