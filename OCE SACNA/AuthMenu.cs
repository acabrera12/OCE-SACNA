using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine.Core;
using Engine.ClassDB;

namespace OCE_SACNA
{
    public partial class AuthMenu : Form
    {
        public AuthMenu()
        {
            InitializeComponent();
        }

        private void LogginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;

            User user = new User(username, password);

            AuthMgr.ResultCode resultCode =  AuthMgr.TryLogginAs(user);

            if (resultCode != AuthMgr.ResultCode.SUSSCES)
            {
                switch (resultCode)
                {
                    case AuthMgr.ResultCode.USER_NAME_EMPTY:
                        MessageBox.Show("For favor, ingrese un Usuario");
                        break;
                    case AuthMgr.ResultCode.USER_PASSWORD_EMPTY:
                        MessageBox.Show("For favor, ingrese una Contraseña");
                        break;
                    case AuthMgr.ResultCode.UNREGISTERED_USER:
                        MessageBox.Show("Su usuario no se encuentra registrado en la base de datos");
                        break;
                    case AuthMgr.ResultCode.INCORRECT_PASSWORD:
                        MessageBox.Show("La contraseña proporcionada es incorrecta");
                        break;
                    case AuthMgr.ResultCode.DISABLED_USER:
                        MessageBox.Show("Este usuario se encuentra desactivado, pógace en contanto con su administrador");
                        break;
                    default:
                        MessageBox.Show($"El sistema ha devuelto un valor no esperado: {resultCode}");
                        break;
                }
                return;
            }

            MainMenu MainMenu = new MainMenu();

            this.Hide();

            MainMenu.Show();
        }
    }
}
