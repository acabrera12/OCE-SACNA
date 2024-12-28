using OCESACNA.Engine.Collections;
using OCESACNA.Engine.Core;
using System;
using System.Windows.Forms;

namespace OCESACNA.View.Menu
{
    public partial class AuthMenu : Form
    {
        public AuthMenu()
        {
            InitializeComponent();
        }

        private void LogginBtn_Click(object sender, EventArgs e)
        {
            UsernameBox.Text = EraseIvalid(UsernameBox.Text);
            PasswordBox.Text = EraseIvalid(PasswordBox.Text);

            string username = UsernameBox.Text;
            string password = PasswordBox.Text;

            User user = new User(0, username, password, User.RANKING.USER, User.STATES.ACTIVE);

            AuthManager.ResultCode resultCode = AuthManager.TryLogginAs(user);

            if (resultCode != AuthManager.ResultCode.SUSSCES)
            {
                switch (resultCode)
                {
                    case AuthManager.ResultCode.USER_NAME_EMPTY:
                        MessageBox.Show("Rellene todos los campos");
                        break;
                    case AuthManager.ResultCode.USER_PASSWORD_EMPTY:
                        MessageBox.Show("Rellene todos los campos");
                        break;
                    case AuthManager.ResultCode.INCORRECT_PASSWORD:
                        MessageBox.Show("Contraseña incorrecta");
                        break;
                    case AuthManager.ResultCode.UNREGISTERED_USER:
                        MessageBox.Show("Usuario no Registrado");
                        break;
                    case AuthManager.ResultCode.DISABLED_USER:
                        MessageBox.Show("Usuario desactivado por un administrador");
                        break;
                    default:
                        MessageBox.Show($"En sistema ha regresado un valor inprevisto '{resultCode}'");
                        break;
                }
                return;
            }

            MainMenu MainMenu = new MainMenu(this);

            Hide();

            UsernameBox.Text = string.Empty;
            PasswordBox.Text = string.Empty;

            MainMenu.Show();
        }

        private string EraseIvalid(string input)
        {
            string[] toErase = { " ", "'", "/", @"\", "~" };

            string output = input;
            
            for (int i = 0; i < toErase.Length; i++)
            {
                output = output.Replace(toErase[i], "");
            }

             return output;
        }
    }
}
