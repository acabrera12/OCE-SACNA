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
        }
    }
}
