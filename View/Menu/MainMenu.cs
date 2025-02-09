using OCESACNA.Engine.Core;
using OCESACNA.View.Module;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OCESACNA.View.Menu
{
    public partial class MainMenu : Form
    {
        private readonly List<Form> ActiveModulesList = new List<Form>();
        private Form ActiveModule = null;

        private string originalName;

        public AuthMenu authMenu;
        public MainMenu(AuthMenu authMenu)
        {
            this.authMenu = authMenu;
            InitializeComponent();
            originalName = Text;
        }

        private void ShowModule(Type type)
        {
            if (ActiveModule != null)
            {
                if (ActiveModule.GetType() == type)
                {
                    Console.WriteLine($"{GetType()}: Allready in Module({type})");
                    return;
                }
            }

            Form toActivate = ActiveModulesList.Find(md => md.GetType() == type);

            if (toActivate != null)
            {
                ActiveModule.Hide();
                ActiveModule = toActivate;
                toActivate.Show();
                Console.WriteLine($"{GetType()}: Showing Module({type})");
                Text = $"{originalName} - {toActivate.Text}";
                return;
            }

            var instance = (Form)Activator.CreateInstance(type);

            ActiveModulesList.Add(instance);

            ActiveModule?.Hide();

            instance.TopLevel = false;
            instance.FormBorderStyle = FormBorderStyle.None;
            instance.Dock = DockStyle.Fill;

            MainContainer.Controls.Add(instance);

            instance.Show();

            ActiveModule = instance;
            Console.WriteLine($"{this.GetType()}: Created a New Module({type})");
            Text = $"{originalName} - {instance.Text}";
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
            Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            ShowModule(typeof(StartModule));

            if (!AuthManager.IsAdminUser())
            {
                AdminBtn.Visible = false;
            }
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
