using System.Windows.Forms;
using OCESACNA.View.Collections;
using OCESACNA.View.Properties;

namespace OCESACNA.View.Module
{
    /// <summary>
    /// Módulo de SACNA
    /// </summary>
    public partial class SACNAModule : Form, IColoreable
    {
        /// <summary>
        /// Inicializa una instancia del formulario
        /// </summary>
        public SACNAModule()
        {
            InitializeComponent();
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

        public void ColorTheme_ThemeChanged(ColorTheme theme)
        {
            ApplyTheme(theme);
        }
    }
}
