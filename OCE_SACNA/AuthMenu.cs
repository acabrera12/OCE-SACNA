using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace OCE_SACNA
{
    public partial class AuthMenu : Form
    {
        public AuthMenu()
        {
            InitializeComponent();
        }

        private void AuthMenu_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;

            User user = new User(username, password);

            AuthMgr.ResultCode response = AuthManager.Login(user);

            if (response != AuthMgr.ResultCode.SUSSCES)
            {
                if (response == AuthMgr.ResultCode.USER_NAME_EMPTY)
                {
                    MessageBox.Show("Por favor, ingrese un usuario");
                }
                else if (response == AuthMgr.ResultCode.USER_PASSWORD_EMPTY)
                {
                    MessageBox.Show("Por favor, ingrese una contraseña");
                }
                else if (response == AuthMgr.ResultCode.INCORRECT_PASSWORD)
                {
                    MessageBox.Show("La contraseña es incorrecta");
                }
                else if (response == AuthMgr.ResultCode.DISABLED_USER)
                {
                    MessageBox.Show("Usuario desactivado, póngase en contacto con su administrador");
                }
                else
                {
                    MessageBox.Show($"El sistema ha devuelto un error imprevisto: '{result}'");
                }
            }

            // MenuInicio MenuInicio = new MenuInicio();

            this.Hide();

            // MenuInico.Show();
        }
    }
}