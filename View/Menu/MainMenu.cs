using OCESACNA.Controller;
using OCESACNA.View.Collections;
using OCESACNA.View.Module;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IconMenuItem = FontAwesome.Sharp.IconMenuItem;

namespace OCESACNA.View.Menu
{
    /// <summary>
    /// Formulario principal
    /// </summary>
    public partial class MainMenu : Form, IColoreable
    {
        /// <summary>
        /// Obtiene o establece el módulo actual
        /// </summary>
        private Form CurrentModule { get; set; }

        /// <summary>
        /// Lista de módulos activos
        /// </summary>
        private readonly List<Form> ActiveModules = new List<Form>();

        /// <summary>
        /// Nombre original del formulario
        /// </summary>
        private readonly string OriginalName;

        /// <summary>
        /// Obtiene o establece la referencia al menú de autenticación
        /// </summary>
        AuthMenu AuthMenu { get; set; }

        /// <summary>
        /// Inicializa una instancia del formulario <see cref="MainMenu"/>
        /// </summary>
        public MainMenu(AuthMenu authMenu)
        {
            AuthMenu = authMenu;

            InitializeComponent();

            OriginalName = Text;

            ApplyTheme(Program.CurrentTheme);

            Theme.ThemeChanged += Theme_ThemeChanged;

            BtnList = new IconMenuItem[] { HomeBtn, SettingsBtn, ManageMenuBtn, AdminMenuBtn, SACNABtn };
        }

        /// <summary>
        /// Es llamado cuando se cambia el tema del programa
        /// </summary>
        /// <param name="newTheme"></param>
        private void Theme_ThemeChanged(Theme newTheme)
        {
            ApplyTheme(newTheme);
        }

        public void ApplyTheme(Theme theme)
        {
            // this
            BackColor = theme.BackColor;
            ForeColor = theme.ForeColor;

            // topMenu
            TopMenu.BackColor = theme.Color;
            TopMenu.ForeColor = theme.ForeColor;

            // homeBtn
            HomeBtn.BackColor = theme.Color;
            HomeBtn.ForeColor = theme.ForeColor;
            HomeBtn.IconColor = theme.ForeColor;

            // settingsBtn
            SettingsBtn.BackColor = theme.Color;
            SettingsBtn.ForeColor = theme.ForeColor;
            SettingsBtn.IconColor = theme.ForeColor;

            // manageMenuBtn
            ManageMenuBtn.BackColor = theme.Color;
            ManageMenuBtn.ForeColor = theme.ForeColor;
            ManageMenuBtn.IconColor = theme.ForeColor;

            // adminMenuBtn
            AdminMenuBtn.BackColor = theme.Color;
            AdminMenuBtn.ForeColor = theme.ForeColor;
            AdminMenuBtn.IconColor = theme.ForeColor;

            // mainPanel
            MainPanel.BackColor = theme.BackColor;
            MainPanel.ForeColor = theme.ForeColor;

            // SACNABtn
            SACNABtn.BackColor = theme.Color;
            SACNABtn.ForeColor = theme.ForeColor;
            SACNABtn.IconColor = theme.ForeColor;
        }

        /// <summary>
        /// Es llamado al momento de cerrar el formulario
        /// </summary>
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            AuthMenu?.Show();
        }

        /// <summary>
        /// Es llamado al momento de cargar el fomulario
        /// </summary>
        private void MainMenu_Load(object sender, System.EventArgs e)
        {
            if (!AuthController.LogedUserIsAdmin)
            {
                AdminMenuBtn.Visible = false;
            }

            ShowModule(typeof(MainModule));
            HighlightBtn(HomeBtn);
        }

        /// <summary>
        /// Muestra el módulo proporcionado
        /// </summary>
        /// <param name="module"></param>
        private void ShowModule(Type moduleType)
        {
            if (CurrentModule != null && CurrentModule.GetType() == moduleType)
            {
                Console.WriteLine($"{typeof(MainMenu)}: Allready in Module({moduleType})");
                return;
            }

            Form newModule = ActiveModules.Find(md => md.GetType() == moduleType);

            if (newModule != null)
            {
                CurrentModule.Hide();
                CurrentModule = newModule;
                CurrentModule.Show();

                Console.WriteLine($"{typeof(MainMenu)}: Showing module; {moduleType}");

                Text = $"{OriginalName} - {CurrentModule.Text}";

                return;
            }

            Form instance = (Form)Activator.CreateInstance(moduleType);
            instance.TopLevel = false;
            instance.FormBorderStyle = FormBorderStyle.None;
            instance.Dock = DockStyle.Fill;

            ActiveModules.Add(instance);
            CurrentModule?.Hide();
            MainPanel.Controls.Add(instance);
            CurrentModule = instance;
            CurrentModule.Show();
            Text = $"{OriginalName} - {CurrentModule.Text}";

            Console.WriteLine($"{typeof(MainMenu)}: Created a New Module({moduleType})");
        }

        /// <summary>
        /// Obtiene o establece la lista de botones
        /// </summary>
        private IconMenuItem[] BtnList { get; set; }

        /// <summary>
        /// Resalta el botón proporcionado
        /// </summary>
        /// <param name="iconMenuItem">Botón</param>
        private void HighlightBtn(IconMenuItem iconMenuItem)
        {
            Theme theme = Program.CurrentTheme;

            foreach (IconMenuItem btn in BtnList)
            {
                btn.BackColor = theme.Color;
                btn.ForeColor = theme.ForeColor;
                btn.IconColor = theme.ForeColor;
            }

            iconMenuItem.BackColor = theme.HighlightColor;
            iconMenuItem.ForeColor = theme.ContrastForeColor;
            iconMenuItem.IconColor = theme.ContrastForeColor;
        }

        /// <summary>
        /// Es llamado al momeno de hacer click en <see cref="HomeBtn"/>
        /// </summary>
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(MainModule));
            HighlightBtn(HomeBtn);
        }

        /// <summary>
        /// Es llamado al momento de hacer click en <see cref="SettingsBtn"/>
        /// </summary>
        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(SettingsModule));
            HighlightBtn(SettingsBtn);
        }

        /// <summary>
        ///  Es llamado al momento de hacer click en <see cref="SubjectManagementBtn"/>
        /// </summary>
        private void SubjectManagementBtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(SubjectManagementModule));
            HighlightBtn(ManageMenuBtn);
        }

        /// <summary>
        ///  Es llamado al momento de hacer click en <see cref="TeacherManagementBtn"/>
        /// </summary>
        private void TeacherManagementBtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(TeacherManagementModule));
            HighlightBtn(ManageMenuBtn);
        }

        /// <summary>
        ///  Es llamado al momento de hacer click en <see cref="StudentManagementBtn"/>
        /// </summary>
        private void StudentManagementBtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(StudentManagementModule));
            HighlightBtn(ManageMenuBtn);
        }

        /// <summary>
        ///  Es llamado al momento de hacer click en <see cref="RepresentativeManagementBtn"/>
        /// </summary>
        private void RepresentativeManagementBtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(RepresentativeManagementModule));
            HighlightBtn(ManageMenuBtn);
        }

        /// <summary>
        ///  Es llamado al momento de hacer click en <see cref="ScoreManagementBtn"/>
        /// </summary>
        private void ScoreManagementBtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(ScoreManagementModule));
            HighlightBtn(ManageMenuBtn);
        }

        /// <summary>
        ///  Es llamado al momento de hacer click en <see cref="SubjectModuleManagementBtn"/>
        /// </summary>
        private void SubjectModuleManagementBtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(SubjectModuleManagementModule));
            HighlightBtn(AdminMenuBtn);
        }

        /// <summary>
        ///  Es llamado al momento de hacer click en <see cref="CourseManagementBtn"/>
        /// </summary>
        private void CourseManagementBtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(CourseManagementModule));
            HighlightBtn(AdminMenuBtn);
        }

        /// <summary>
        ///  Es llamado al momento de hacer click en <see cref="UserManagementBtn"/>
        /// </summary>
        private void UserManagementBtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(UserManagementModule));
            HighlightBtn(AdminMenuBtn);
        }

        /// <summary>
        ///  Es llamado al momento de hacer click en <see cref="SACNABtn"/>
        /// </summary>
        private void SACNABtn_Click(object sender, EventArgs e)
        {
            ShowModule(typeof(SACNAModule));
            HighlightBtn(SACNABtn);
        }
    }
}
