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
            if (AuthManager.GetAdministratorAuthorization())
            {
                UserTitle.Text = "Administrador";
            }

            UserLabel.Text = AuthManager.GetLoggedUsername();
            StudentsLabel.Text = $"{Engine.Engine.Students.Count} estudiante(s) registrado(s)";
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
