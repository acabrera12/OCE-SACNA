using OCESACNA.Engine.Collections;
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

            ConnectManager.GetAllStudents(GetStudents);
        }

        public void GetStudents(object sender, RequestEventArgs eventArgs)
        {
            var count = eventArgs.Response.Count;
            if (InvokeRequired)
            {
                Invoke(new Action(() => StudentsLabel.Text = $"{count} estudiante(s) registrado(s)"));
            }
        }
    }
}
