using OCESACNA.Controller;
using OCESACNA.View.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OCESACNA.View.Menu
{
    /// <summary>
    /// Formulario de Autenticación
    /// </summary>
    public partial class AuthMenu : Form, IColoreable
    {
        /// <summary>
        /// Obtiene los mensaje de error
        /// </summary>
        private static Dictionary<AuthController.Error, string> ErrorMessages { get; } = new Dictionary<AuthController.Error, string>()
        {
            { AuthController.Error.INVALID_USER_ID, "ID inválido" },
            { AuthController.Error.INVALID_USER_RANK, "Rango inválido" },
            { AuthController.Error.INVALID_USER_STATE, "Estado inválido" },
            { AuthController.Error.INVALID_USER_NAME_OR_PASSWORD, "Usuario y/o contraseña inválidos" },
            { AuthController.Error.USER_DISABLED, "Usuario inhabilitado" }
        };

        /// <summary>
        /// Inicializa una instancia del formulario <see cref="AuthMenu"/>
        /// </summary>
        public AuthMenu()
        {
            InitializeComponent();

            ApplyTheme(Program.CurrentTheme);

            ColorTheme.ThemeChanged += ColorTheme_ThemeChanged;
        }

        public void ColorTheme_ThemeChanged(ColorTheme newTheme)
        {
            ApplyTheme(newTheme);
        }

        public void ApplyTheme(ColorTheme theme)
        {
            // this
            theme.ApplyBackgroundStyle(this);

            // leftPanel
            theme.ApplyHightlineStyle(LeftPanel);

            // toptTitleLabel
            theme.ApplyContrastedFontStyle(ColorTheme.BackgroundType.HightlineBackground, TopTitleLabel);

            // keyIcon
            KeyIcon.IconColor = theme.ContrastedFontColor;

            // usernameLabel / passwordLabel
            theme.ApplyFontStyle(ColorTheme.BackgroundType.Background, UsernameLabel, PasswordLabel);

            // aceptBtn
            theme.ApplyHightlineButtonStyle(AceptBtn);

            // cancelBtn
            theme.ApplyButtonStyle(CancelBtn);

            // passwordWarningIcon
            PasswordWarningIcon.BackColor = theme.BackgroundColor;
            PasswordWarningIcon.IconColor = theme.FontColor;
        }

        public void ColorTheme_DarkModeChanged(bool value)
        {
            ApplyTheme(Program.CurrentTheme);
        }

        /// <summary>
        /// Es llamado al momento de hacer click en el botón <see cref="AceptBtn"/>
        /// </summary>
        private void AceptBtn_Click(object sender, System.EventArgs e)
        {
            AceptBtn.Enabled = false;

            UsernameBox.Text = UsernameBox.Text.Replace(" ", "");
            PasswordBox.Text = PasswordBox.Text.Replace(" ", "");

            if (UsernameBox.Text == string.Empty || PasswordBox.Text == string.Empty)
            {
                MessageBox.Show("No deje campos vacíos");
                AceptBtn.Enabled = true;
                return;
            }

            AuthController.Error err = AuthController.Login(UsernameBox.Text, PasswordBox.Text);

            if (err != AuthController.Error.OK)
            {
                if (ErrorMessages.ContainsKey(err))
                {
                    MessageBox.Show(ErrorMessages[err], "Intento de inicio de sesión");
                    AceptBtn.Enabled = true;
                    return;
                }
                else
                {
                    MessageBox.Show($"El sistema ha devuelto un valor inesperado:\n'{err}'", "Intento de inicio de sesión");
                    AceptBtn.Enabled = true;
                    return;
                }
            }

            Hide();
            Clear();
            new MainMenu(this).Show();
        }

        /// <summary>
        /// Es llamado al momento de hacer click en el botón <see cref="CancelBtn"/>
        /// </summary>
        private void CancelBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Es llamado al momento de cerrar el formulario
        /// </summary>
        private void AuthMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AuthController.IsUserLoged)
            {
                AuthController.Logout();
            }
        }

        /// <summary>
        /// Es llamado al momento de modificar el texto de <see cref="PasswordBox"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordBox_TextChanged(object sender, System.EventArgs e)
        {
            if (!TextFilter.IsValidPasswordText(PasswordBox.Text))
            {
                AceptBtn.Enabled = false;
                PasswordWarningIcon.Visible = true;
            }
            else
            {
                AceptBtn.Enabled = true;
                PasswordWarningIcon.Visible = false;
            }
        }

        /// <summary>
        /// Limpia los datos ingresados
        /// </summary>
        private void Clear()
        {
            UsernameBox.Text = string.Empty;
            PasswordBox.Text = string.Empty;
        }
    }
}
