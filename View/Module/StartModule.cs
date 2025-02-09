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
            if (AuthManager.IsAdminUser())
            {
                UserTitle.Text = "Administrador";
            }

            UserLabel.Text = AuthManager.GetLogedUserName();
            StudentsLabel.Text = $"{Engine.Engine.Students.Count} estudiante(s) registrado(s)";
        }
    }
}
