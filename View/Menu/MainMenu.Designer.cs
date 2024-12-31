
namespace OCESACNA.View.Menu
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.MainMenuBtn = new FontAwesome.Sharp.IconMenuItem();
            this.SettingBtn = new FontAwesome.Sharp.IconMenuItem();
            this.ManagementBtn = new FontAwesome.Sharp.IconMenuItem();
            this.ManageStudentBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageRpresentBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageSubjectsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageTeachersBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageScoresBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminBtn = new FontAwesome.Sharp.IconMenuItem();
            this.ManageUsersBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageCoursesBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageSbjectModulesBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLabels = new System.Windows.Forms.MenuStrip();
            this.infoBtn = new FontAwesome.Sharp.IconMenuItem();
            this.ExitBtn = new FontAwesome.Sharp.IconMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.MainContainer = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.menuLabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuBtn,
            this.SettingBtn,
            this.ManagementBtn,
            this.AdminBtn});
            this.menu.Location = new System.Drawing.Point(0, 24);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(808, 55);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.BackColor = System.Drawing.Color.White;
            this.MainMenuBtn.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.MainMenuBtn.IconColor = System.Drawing.Color.Black;
            this.MainMenuBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MainMenuBtn.IconSize = 32;
            this.MainMenuBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(65, 51);
            this.MainMenuBtn.Text = "Principal";
            this.MainMenuBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MainMenuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.Color.White;
            this.SettingBtn.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.SettingBtn.IconColor = System.Drawing.Color.Black;
            this.SettingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingBtn.IconSize = 32;
            this.SettingBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(95, 51);
            this.SettingBtn.Text = "Configuración";
            this.SettingBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // ManagementBtn
            // 
            this.ManagementBtn.BackColor = System.Drawing.Color.White;
            this.ManagementBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageStudentBtn,
            this.ManageRpresentBtn,
            this.ManageSubjectsBtn,
            this.ManageTeachersBtn,
            this.ManageScoresBtn});
            this.ManagementBtn.IconChar = FontAwesome.Sharp.IconChar.School;
            this.ManagementBtn.IconColor = System.Drawing.Color.Black;
            this.ManagementBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ManagementBtn.IconSize = 32;
            this.ManagementBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManagementBtn.Name = "ManagementBtn";
            this.ManagementBtn.Size = new System.Drawing.Size(62, 51);
            this.ManagementBtn.Text = "Nómina";
            this.ManagementBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ManagementBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ManageStudentBtn
            // 
            this.ManageStudentBtn.Name = "ManageStudentBtn";
            this.ManageStudentBtn.Size = new System.Drawing.Size(162, 22);
            this.ManageStudentBtn.Text = "Estudiantes";
            this.ManageStudentBtn.Click += new System.EventHandler(this.ManageStudentBtn_Click);
            // 
            // ManageRpresentBtn
            // 
            this.ManageRpresentBtn.Name = "ManageRpresentBtn";
            this.ManageRpresentBtn.Size = new System.Drawing.Size(162, 22);
            this.ManageRpresentBtn.Text = "Representantes";
            this.ManageRpresentBtn.Click += new System.EventHandler(this.ManageRpresentBtn_Click);
            // 
            // ManageSubjectsBtn
            // 
            this.ManageSubjectsBtn.Name = "ManageSubjectsBtn";
            this.ManageSubjectsBtn.Size = new System.Drawing.Size(162, 22);
            this.ManageSubjectsBtn.Text = "Asignaturas";
            this.ManageSubjectsBtn.Click += new System.EventHandler(this.ManageSubjectsBtn_Click);
            // 
            // ManageTeachersBtn
            // 
            this.ManageTeachersBtn.Name = "ManageTeachersBtn";
            this.ManageTeachersBtn.Size = new System.Drawing.Size(162, 22);
            this.ManageTeachersBtn.Text = "Docentes";
            this.ManageTeachersBtn.Click += new System.EventHandler(this.ManageTeachersBtn_Click);
            // 
            // ManageScoresBtn
            // 
            this.ManageScoresBtn.Name = "ManageScoresBtn";
            this.ManageScoresBtn.Size = new System.Drawing.Size(162, 22);
            this.ManageScoresBtn.Text = "Sábana de Notas";
            this.ManageScoresBtn.Click += new System.EventHandler(this.ManageScoresBtn_Click);
            // 
            // AdminBtn
            // 
            this.AdminBtn.BackColor = System.Drawing.Color.White;
            this.AdminBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageUsersBtn,
            this.ManageCoursesBtn,
            this.ManageSbjectModulesBtn});
            this.AdminBtn.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.AdminBtn.IconColor = System.Drawing.Color.Black;
            this.AdminBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AdminBtn.IconSize = 32;
            this.AdminBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(59, 51);
            this.AdminBtn.Text = "Gestión";
            this.AdminBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AdminBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ManageUsersBtn
            // 
            this.ManageUsersBtn.Name = "ManageUsersBtn";
            this.ManageUsersBtn.Size = new System.Drawing.Size(180, 22);
            this.ManageUsersBtn.Text = "Usuarios";
            this.ManageUsersBtn.Click += new System.EventHandler(this.ManageUsersBtn_Click);
            // 
            // ManageCoursesBtn
            // 
            this.ManageCoursesBtn.Name = "ManageCoursesBtn";
            this.ManageCoursesBtn.Size = new System.Drawing.Size(180, 22);
            this.ManageCoursesBtn.Text = "Cursos";
            this.ManageCoursesBtn.Click += new System.EventHandler(this.ManageCoursesBtn_Click);
            // 
            // ManageSbjectModulesBtn
            // 
            this.ManageSbjectModulesBtn.Name = "ManageSbjectModulesBtn";
            this.ManageSbjectModulesBtn.Size = new System.Drawing.Size(180, 22);
            this.ManageSbjectModulesBtn.Text = "Áreas de Formación";
            this.ManageSbjectModulesBtn.Click += new System.EventHandler(this.ManageSbjectModulesBtn_Click);
            // 
            // menuLabels
            // 
            this.menuLabels.BackColor = System.Drawing.Color.SteelBlue;
            this.menuLabels.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoBtn,
            this.ExitBtn});
            this.menuLabels.Location = new System.Drawing.Point(0, 0);
            this.menuLabels.Name = "menuLabels";
            this.menuLabels.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuLabels.Size = new System.Drawing.Size(808, 24);
            this.menuLabels.TabIndex = 1;
            this.menuLabels.Text = "menuStrip2";
            // 
            // infoBtn
            // 
            this.infoBtn.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.infoBtn.IconColor = System.Drawing.Color.White;
            this.infoBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(28, 20);
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.ExitBtn.IconColor = System.Drawing.Color.White;
            this.ExitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(104, 20);
            this.ExitBtn.Text = "Cerrar Sesión";
            this.ExitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "OCE SACNA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(0, 79);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(808, 371);
            this.MainContainer.TabIndex = 3;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuLabels);
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(489, 489);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Shown += new System.EventHandler(this.MainMenu_Shown);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.menuLabels.ResumeLayout(false);
            this.menuLabels.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuLabels;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem MainMenuBtn;
        private FontAwesome.Sharp.IconMenuItem SettingBtn;
        private FontAwesome.Sharp.IconMenuItem infoBtn;
        private FontAwesome.Sharp.IconMenuItem ManagementBtn;
        private System.Windows.Forms.ToolStripMenuItem ManageStudentBtn;
        private System.Windows.Forms.ToolStripMenuItem ManageRpresentBtn;
        private System.Windows.Forms.ToolStripMenuItem ManageSubjectsBtn;
        private System.Windows.Forms.ToolStripMenuItem ManageTeachersBtn;
        private System.Windows.Forms.ToolStripMenuItem ManageScoresBtn;
        private FontAwesome.Sharp.IconMenuItem ExitBtn;
        private FontAwesome.Sharp.IconMenuItem AdminBtn;
        private System.Windows.Forms.Panel MainContainer;
        private System.Windows.Forms.ToolStripMenuItem ManageUsersBtn;
        private System.Windows.Forms.ToolStripMenuItem ManageCoursesBtn;
        private System.Windows.Forms.ToolStripMenuItem ManageSbjectModulesBtn;
    }
}