using OCESACNA.Engine.Core;
using System;
using System.Windows.Forms;

namespace OCESACNA.View.Module
{
    public partial class StartModule : Form
    {
        public StartModule()
        {
            InitializeComponent();
        }

        private void StartModule_Load(object sender, EventArgs e)
        {
            string username = AuthManager.GetLoggedUsername();
            bool isAdmin = AuthManager.GetAdministratorAuthorization();

            if (isAdmin)
            {
                UserTitle.Text = "Administrador";
            }

            UserLabel.Text = username;
        }
    }
}
