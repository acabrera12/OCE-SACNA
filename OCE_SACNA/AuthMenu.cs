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
using OfficeLayer;

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

            User user = new User(username, password, AuthManager.RANKING.USER, AuthManager.USER_STATE.ACTIVE);

            AuthManager.ERR_CODES response = AuthManager.Login(user);

            if (response != AuthManager.ERR_CODES.SUSSCES)
            {
                MessageBox.Show($"En sistema ha regresado un error {response}");
            }
        }
    }
}
