using OCESACNA.Engine.Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OCESACNA.View.Module;

namespace OCESACNA.View.Menu
{
    public partial class MainMenu : Form
    {
        private readonly List<Form> ActiveModulesList = new List<Form>();
        private Form ActiveModule = null;

        public AuthMenu authMenu;
        public MainMenu(AuthMenu authMenu)
        {
            this.authMenu = authMenu;
            InitializeComponent();
        }

        private void ShowModule(Type type)
        {
            if (ActiveModule != null)
            {
                if (ActiveModule.GetType() == type)
                {
                    Console.WriteLine($"{this.GetType()}: Allready in Module({type})");
                    return;
                }
            }

            Form toActivate = null;

            foreach (Form md in ActiveModulesList)
            {
                if (md.GetType() == type)
                {
                    toActivate = md;
                    break;
                }
            }

            if (toActivate != null)
            {
                ActiveModule.Hide();
                ActiveModule = toActivate;
                toActivate.Show();
                Console.WriteLine($"{this.GetType()}: Showing Module({type})");
                return;
            }

            var instance = (Form)Activator.CreateInstance(type);

            ActiveModulesList.Add(instance);

            if (ActiveModule != null)
            {
                ActiveModule.Hide();
            }

            instance.TopLevel = false;
            instance.FormBorderStyle = FormBorderStyle.None;
            instance.Dock = DockStyle.Fill;

            MainContainer.Controls.Add(instance);

            instance.Show();

            ActiveModule = instance;
            Console.WriteLine($"{this.GetType()}: Created a New Module({type})");
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            AuthManager.Logout();
            authMenu.Show();
        }

        private void MainMenu_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha iniciado sesión correctamente");
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            ShowModule(typeof(StartModule));
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(StartModule));
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(SettingsModule));
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            InfoMenu infoMenu = new InfoMenu();
            infoMenu.ShowDialog();
        }

        private void ManageStudentBtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(ManageStudentsModule));
        }

        private void ManageRpresentBtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(ManageRepresentativesModule));
        }

        private void ManageSubjectsBtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(ManageSubjectsModule));
        }

        private void ManageTeachersBtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(ManageTeachersModule));
        }

        private void ManageScoresBtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(ManageScoresModule));
        }

        private void ManageUsersBtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(ManageUsersModule));
        }

        private void ManageCoursesBtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(ManageCoursesModule));
        }

        private void ManageSbjectModulesBtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(ManageSbjetModulesModule));
        }
    }
}
