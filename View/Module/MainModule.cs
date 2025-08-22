using System.Windows.Forms;
using OCESACNA.Controller;
using OCESACNA.View.Collections;

namespace OCESACNA.View.Module
{
    /// <summary>
    /// Representa el fomulario de inicio del programa
    /// </summary>
    public partial class MainModule : Form, IColoreable
    {
        /// <summary>
        /// Obtiene o establece el menú principal
        /// </summary>
        internal static Menu.MainMenu MainMenu { get; set; }

        /// <summary>
        /// Inicializa una instancia del formulario
        /// </summary>
        public MainModule()
        {
            InitializeComponent();
            ApplyTheme(Program.CurrentTheme);

            ColorTheme.ThemeChanged += ColorTheme_ThemeChanged;
            Program.CurrentTheme.DarkModeChanged += ColorTheme_DarkModeChanged;

            UsernameLabel.Text = AuthController.LogedUserName;
            UserRankLabel.Text = User.GetRankingText(AuthController.LogedUserRank);
        }

        public void ApplyTheme(ColorTheme theme)
        {
            // this
            theme.ApplyBackgroundStyle(this);

            // top panel
            theme.ApplyForeStyle(TopPanel);
        }

        public void ColorTheme_DarkModeChanged(bool value)
        {
            ApplyTheme(Program.CurrentTheme);
        }

        public void ColorTheme_ThemeChanged(ColorTheme theme)
        {
            ApplyTheme(theme);
        }

        /// <summary>
        /// Es llamado al presionar el botón <see cref="ExitButton"/>
        /// </summary>
        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("¿Quiere cerrar sesión?", "Confirmación", MessageBoxButtons.YesNo)
                != DialogResult.Yes)
            {
                return;
            }

            MainMenu.Hide();
            AuthController.Logout();
            MainMenu.Close();
        }
    }
}
