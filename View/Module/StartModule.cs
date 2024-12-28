using OCESACNA.Engine.Core;
using OCESACNA.Engine.Collections;
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

        private void GetStudents(object sende, RequestEventArgs eventArgs)
        {
            var count = eventArgs.response.Count;
            StudentsLabel.Text = $"{count} estudiante(s) registrado(s)";
        }
    }
}
