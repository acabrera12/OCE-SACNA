using OCESACNA.Engine.Collections;
using OCESACNA.View.Collections;
using System.Windows.Forms;
using System.Linq;
using System;

namespace OCESACNA.View.Module
{
    public partial class ManageScoresModule : Form, IColoreable
    {
        public ManageScoresModule()
        {
            InitializeComponent();
            ApplyTheme(Program.CurrentTheme);
        }

        public void ApplyTheme(Theme theme)
        {
            BackColor = theme.BackgroundColor;
            TopPanel.BackColor = theme.SecondaryColor;
        }

        private void ManageScoresModule_Load(object sender, System.EventArgs e)
        {

        }
    }
}
