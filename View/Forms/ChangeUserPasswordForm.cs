using OCESACNA.Controller;
using OCESACNA.View.Collections;
using System;
using System.Windows.Forms;

namespace OCESACNA.View.Forms
{
    /// <summary>
    /// Representa el formulario de cambio de contraseña de usuario
    /// </summary>
    public partial class ChangeUserPasswordForm : Form, IColoreable
    {
        /// <summary>
        /// Caracter que se usará para ocultar la contraseña
        /// </summary>
        private const char PasswordChar = '•';

        /// <summary>
        /// Caracter que se usará para mostrar la contraseña
        /// </summary>
        private const char EmptyPasswordChar = '\0';

        /// <summary>
        /// Obtiene o establece el usuario seleccionado
        /// </summary>
        private User SelectedUser { get; set; }

        /// <summary>
        /// Delegado encargado de soportar el evento <see cref="Acepted"/>
        /// </summary>
        public delegate void AceptedEventHandler(object sender);

        /// <summary>
        /// Evento llamado cuando se presiona el botón <see cref="AceptButton"/> en un formulario <see cref="ChangeUserPasswordForm"/>
        /// </summary>
        public event AceptedEventHandler Acepted;

        /// <summary>
        /// Es llamado al momento de aceptar el formulario
        /// </summary>
        protected void OnAcept()
        {
            Acepted(this);
        }

        /// <summary>
        /// Inicializa una instancia del formulario de cambio de contraseña
        /// </summary>
        public ChangeUserPasswordForm()
        {
            InitializeComponent();
            ApplyTheme(Program.CurrentTheme);
            Program.CurrentTheme.DarkModeChanged += ColorTheme_DarkModeChanged;
            ColorTheme.ThemeChanged += ColorTheme_ThemeChanged;
        }

        public void ApplyTheme(ColorTheme theme)
        {
            // this
            theme.ApplyBackgroundStyle(this);

            // AceptButton / AbortButton
            theme.ApplyButtonStyle(AceptButton, AbortButton);

            // UserNameLabel, OldPasswordLabel, NewPassworLabel, ConfirmPasswordLabel
            theme.ApplyFontStyle(ColorTheme.BackgroundType.Background,
                UserNameLabel, OldPasswordLabel, NewPassworLabel, ConfirmPasswordLabel);
        }

        public void ColorTheme_ThemeChanged(ColorTheme theme)
        {
            ApplyTheme(theme);
        }

        public void ColorTheme_DarkModeChanged(bool value)
        {
            ApplyTheme(Program.CurrentTheme);
        }

        /// <summary>
        /// Establece los datos del fomulario
        /// </summary>
        /// <param name="user"></param>
        public void SetData(User user)
        {
            SelectedUser = user;
            UserNameBox.Text = user.UserName;
        }

        /// <summary>
        /// Obtiene los datos del formulario
        /// </summary>
        /// <returns>Un usuario <see cref="User"/></returns>
        public User GetData()
        {
            return SelectedUser;
        }

        /// <summary>
        /// Es llamado cunado se presiona el botón <see cref="AceptButton"/>
        /// </summary>
        private void AceptButton_Click(object sender, EventArgs e)
        {
            TextFilter.ReplaceSpacesInTextBox(OldPasswordBox);
            TextFilter.ReplaceSpacesInTextBox(NewPasswordBox);
            TextFilter.ReplaceSpacesInTextBox(ConfirmPasswordBox);

            if (TextFilter.IsOneTextBoxTextEmpty(new TextBox[] { OldPasswordBox, NewPasswordBox, ConfirmPasswordBox }))
            {
                MessageBox.Show("Rellene todos los campos primero");
                return;
            }

            string
                oldPassword = OldPasswordBox.Text,
                newPassword = NewPasswordBox.Text,
                newPassword2 = ConfirmPasswordBox.Text;

            if (!TextFilter.IsValidPasswordText(oldPassword) || !TextFilter.IsValidPasswordText(newPassword) || !TextFilter.IsValidPasswordText(newPassword2))
            {
                MessageBox.Show("Uno o más campos de contraseña\nposeen caracteres inválidos");
                return;
            }

            if (!SelectedUser.IsValidPassword(oldPassword))
            {
                MessageBox.Show("Contreseña inválida");
                return;
            }

            if (newPassword != newPassword2)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            SelectedUser.GenerateSafePassword(newPassword);

            // Comprueba que las contraseñas se hayan encriptado correctamente
            // Este caso no debería pasar
            if (!SelectedUser.IsValidPassword(newPassword))
            {
                MessageBox.Show("Ha habido un error inesperado al\nmomento de encriptar los datos. No\nse han almacenado los datos");
                return;
            }

            OnAcept();
            Clear();
            Hide();
        }

        /// <summary>
        /// Es llamado cunado se presiona el botón <see cref="AbortButton"/>
        /// </summary>
        private void AbortButton_Click(object sender, EventArgs e)
        {
            Clear();
            Hide();
        }

        /// <summary>
        /// Es llamado cunado se presiona el botón <see cref="ShowPasswordBox"/>
        /// </summary>
        private void ShowPasswordBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!ShowPasswordBox.Checked)
            {
                OldPasswordBox.PasswordChar = PasswordChar;
                NewPasswordBox.PasswordChar = PasswordChar;
                ConfirmPasswordBox.PasswordChar = PasswordChar;
            }
            else
            {
                OldPasswordBox.PasswordChar = EmptyPasswordChar;
                NewPasswordBox.PasswordChar = EmptyPasswordChar;
                ConfirmPasswordBox.PasswordChar = EmptyPasswordChar;
            }
        }

        /// <summary>
        /// Es llamado cuando se ha cerrado el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeUserPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clear();
        }

        /// <summary>
        /// Limpia los datos del formulario
        /// </summary>
        private void Clear()
        {
            SelectedUser = null;
            OldPasswordBox.Text = string.Empty;
            NewPasswordBox.Text = string.Empty;
            ConfirmPasswordBox.Text = string.Empty;
        }
    }
}
