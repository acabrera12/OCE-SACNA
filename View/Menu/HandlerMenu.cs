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
        /// Obtiene o establece el valor de salida al guardar
        /// </summary>
        public bool ExitOnSave { get; private set; } = false;

        /// <summary>
        /// Inicializa una instancia del formulario <see cref="HandlerMenu"/>
        /// </summary>
        public HandlerMenu()
        {
            InitializeComponent();

            ApplyTheme(Program.CurrentTheme);

            Theme.ThemeChanged += Theme_ThemeChanged;
        }

        public void ApplyTheme(Theme theme)
        {
            // this
            BackColor = theme.BackColor;
            ForeColor = theme.ForeColor;
        }

        /// <summary>
        /// Es llamado cuando se cambia el tema del programa
        /// </summary>
        /// <param name="newTheme"></param>
        private void Theme_ThemeChanged(Theme newTheme)
        {
            ApplyTheme(newTheme);
        }
    }
}
