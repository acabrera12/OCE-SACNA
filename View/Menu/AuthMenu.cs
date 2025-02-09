using OCESACNA.Engine.Collections;
using OCESACNA.Engine.Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OCESACNA.View.Collections;

namespace OCESACNA.View.Menu
{
    public partial class AuthMenu : Form, IColoreable
    {
        public AuthMenu()
        {
            InitializeComponent();
            ApplyTheme(Program.CurrentTheme);
        }

        public void ApplyTheme(Theme theme)
        {
            BackColor = theme.BackgroundColor;

            panel1.BackColor = theme.MainColor;

            label1.ForeColor = theme.FontColor;
            label1.BackColor = theme.BackgroundColor;

            label2.ForeColor = theme.FontColor;
            label2.BackColor = theme.BackgroundColor;

            label3.ForeColor = theme.FontColor;
            label3.BackColor = theme.BackgroundColor;

            UsernameBox.ForeColor = theme.FontColorContrast;
            UsernameBox.BackColor = theme.SecondaryColor;

            PasswordBox.ForeColor = theme.FontColorContrast;
            PasswordBox.BackColor = theme.SecondaryColor;

            LogginBtn.ForeColor = theme.FontColorContrast;
            LogginBtn.IconColor = theme.FontColorContrast;
            LogginBtn.BackColor = theme.BackgroundColor;
        }

        private static readonly Dictionary<AuthManager.ResultCode, string> Messages
            = new Dictionary<AuthManager.ResultCode, string>()
            {
                {AuthManager.ResultCode.USER_NAME_EMPTY, "Rellene todos los campos" },
                {AuthManager.ResultCode.USER_PASSWORD_EMPTY, "Rellene todos los campos" },
                {AuthManager.ResultCode.INCORRECT_PASSWORD, "Contraseña inválida"},
                {AuthManager.ResultCode.UNREGISTERED_USER, "Usuario inválido"},
                {AuthManager.ResultCode.DISABLED_USER, "Usuario suspendido" }
            };

        private void LogginBtn_Click(object sender, EventArgs e)
        {
            LogginBtn.Enabled = false;

            UsernameBox.Text = EraseIvalid(UsernameBox.Text);
            PasswordBox.Text = EraseIvalid(PasswordBox.Text);

            string username = UsernameBox.Text;
            string password = PasswordBox.Text;

            User user = new User(0, username, password, User.RANKING.USER, User.STATES.ACTIVE);

            AuthManager.ResultCode resultCode = AuthManager.TryLogginAs(user);

            if (resultCode != AuthManager.ResultCode.SUCCESS)
            {
                if (!Messages.ContainsKey(resultCode))
                {
                    MessageBox.Show($"El sistema ha devuelto un error\nno planificado ({resultCode})");
                    LogginBtn.Enabled = true;
                    return;
                }

                MessageBox.Show(Messages[resultCode]);
                LogginBtn.Enabled = true;
                return;
            }

            MainMenu MainMenu = new MainMenu(this);

            Hide();

            UsernameBox.Text = string.Empty;
            PasswordBox.Text = string.Empty;
            LogginBtn.Enabled = true;

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
