
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
            this.TopMenu = new System.Windows.Forms.MenuStrip();
            this.HomeBtn = new FontAwesome.Sharp.IconMenuItem();
            this.SettingsBtn = new FontAwesome.Sharp.IconMenuItem();
            this.ManageMenuBtn = new FontAwesome.Sharp.IconMenuItem();
            this.SubjectManagementBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.TeacherManagementBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentManagementBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.RepresentativeManagementBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ScoreManagementBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminMenuBtn = new FontAwesome.Sharp.IconMenuItem();
            this.SACNABtn = new FontAwesome.Sharp.IconMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SubjectModuleManagementBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.CourseManagementBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.UserManagementBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PendingSubjectManagementBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.TopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TopMenu.GripMargin = new System.Windows.Forms.Padding(2);
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeBtn,
            this.SettingsBtn,
            this.ManageMenuBtn,
            this.AdminMenuBtn,
            this.SACNABtn});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Padding = new System.Windows.Forms.Padding(0);
            this.TopMenu.Size = new System.Drawing.Size(800, 63);
            this.TopMenu.TabIndex = 0;
            this.TopMenu.Text = "TopMenu";
            // 
            // HomeBtn
            // 
            this.HomeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HomeBtn.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.HomeBtn.IconColor = System.Drawing.SystemColors.ControlText;
            this.HomeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeBtn.IconSize = 38;
            this.HomeBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.HomeBtn.Size = new System.Drawing.Size(67, 63);
            this.HomeBtn.Text = "Principal";
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SettingsBtn.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.SettingsBtn.IconColor = System.Drawing.SystemColors.ControlText;
            this.SettingsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingsBtn.IconSize = 38;
            this.SettingsBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.SettingsBtn.Size = new System.Drawing.Size(97, 63);
            this.SettingsBtn.Text = "Configuración";
            this.SettingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // ManageMenuBtn
            // 
            this.ManageMenuBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubjectManagementBtn,
            this.TeacherManagementBtn,
            this.StudentManagementBtn,
            this.RepresentativeManagementBtn,
            this.ScoreManagementBtn});
            this.ManageMenuBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ManageMenuBtn.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.ManageMenuBtn.IconColor = System.Drawing.SystemColors.ControlText;
            this.ManageMenuBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ManageMenuBtn.IconSize = 38;
            this.ManageMenuBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManageMenuBtn.Name = "ManageMenuBtn";
            this.ManageMenuBtn.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ManageMenuBtn.Size = new System.Drawing.Size(64, 63);
            this.ManageMenuBtn.Text = "Nómina";
            this.ManageMenuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubjectManagementBtn
            // 
            this.SubjectManagementBtn.Name = "SubjectManagementBtn";
            this.SubjectManagementBtn.Size = new System.Drawing.Size(180, 22);
            this.SubjectManagementBtn.Text = "Asignaturas";
            this.SubjectManagementBtn.Click += new System.EventHandler(this.SubjectManagementBtn_Click);
            // 
            // TeacherManagementBtn
            // 
            this.TeacherManagementBtn.Name = "TeacherManagementBtn";
            this.TeacherManagementBtn.Size = new System.Drawing.Size(180, 22);
            this.TeacherManagementBtn.Text = "Docentes";
            this.TeacherManagementBtn.Click += new System.EventHandler(this.TeacherManagementBtn_Click);
            // 
            // StudentManagementBtn
            // 
            this.StudentManagementBtn.Name = "StudentManagementBtn";
            this.StudentManagementBtn.Size = new System.Drawing.Size(180, 22);
            this.StudentManagementBtn.Text = "Estudiantes";
            this.StudentManagementBtn.Click += new System.EventHandler(this.StudentManagementBtn_Click);
            // 
            // RepresentativeManagementBtn
            // 
            this.RepresentativeManagementBtn.Name = "RepresentativeManagementBtn";
            this.RepresentativeManagementBtn.Size = new System.Drawing.Size(180, 22);
            this.RepresentativeManagementBtn.Text = "Representantes";
            this.RepresentativeManagementBtn.Click += new System.EventHandler(this.RepresentativeManagementBtn_Click);
            // 
            // ScoreManagementBtn
            // 
            this.ScoreManagementBtn.Name = "ScoreManagementBtn";
            this.ScoreManagementBtn.Size = new System.Drawing.Size(180, 22);
            this.ScoreManagementBtn.Text = "Sábana de Notas";
            this.ScoreManagementBtn.Click += new System.EventHandler(this.ScoreManagementBtn_Click);
            // 
            // AdminMenuBtn
            // 
            this.AdminMenuBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubjectModuleManagementBtn,
            this.PendingSubjectManagementBtn,
            this.CourseManagementBtn,
            this.UserManagementBtn});
            this.AdminMenuBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AdminMenuBtn.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.AdminMenuBtn.IconColor = System.Drawing.SystemColors.ControlText;
            this.AdminMenuBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AdminMenuBtn.IconSize = 38;
            this.AdminMenuBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AdminMenuBtn.Name = "AdminMenuBtn";
            this.AdminMenuBtn.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.AdminMenuBtn.Size = new System.Drawing.Size(61, 63);
            this.AdminMenuBtn.Text = "Gestión";
            this.AdminMenuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SACNABtn
            // 
            this.SACNABtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SACNABtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SACNABtn.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.SACNABtn.IconColor = System.Drawing.SystemColors.ControlText;
            this.SACNABtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SACNABtn.IconSize = 38;
            this.SACNABtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SACNABtn.Name = "SACNABtn";
            this.SACNABtn.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.SACNABtn.Size = new System.Drawing.Size(60, 63);
            this.SACNABtn.Text = "SACNA";
            this.SACNABtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SACNABtn.Click += new System.EventHandler(this.SACNABtn_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 63);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 410);
            this.MainPanel.TabIndex = 1;
            // 
            // SubjectModuleManagementBtn
            // 
            this.SubjectModuleManagementBtn.Name = "SubjectModuleManagementBtn";
            this.SubjectModuleManagementBtn.Size = new System.Drawing.Size(197, 22);
            this.SubjectModuleManagementBtn.Text = "Áreas de Formación";
            this.SubjectModuleManagementBtn.Click += new System.EventHandler(this.SubjectModuleManagementBtn_Click);
            // 
            // CourseManagementBtn
            // 
            this.CourseManagementBtn.Name = "CourseManagementBtn";
            this.CourseManagementBtn.Size = new System.Drawing.Size(197, 22);
            this.CourseManagementBtn.Text = "Cursos";
            this.CourseManagementBtn.Click += new System.EventHandler(this.CourseManagementBtn_Click);
            // 
            // UserManagementBtn
            // 
            this.UserManagementBtn.Name = "UserManagementBtn";
            this.UserManagementBtn.Size = new System.Drawing.Size(197, 22);
            this.UserManagementBtn.Text = "Usuarios";
            this.UserManagementBtn.Click += new System.EventHandler(this.UserManagementBtn_Click);
            // 
            // PendingSubjectManagementBtn
            // 
            this.PendingSubjectManagementBtn.Name = "PendingSubjectManagementBtn";
            this.PendingSubjectManagementBtn.Size = new System.Drawing.Size(197, 22);
            this.PendingSubjectManagementBtn.Text = "Asignaturas Pendientes";
            this.PendingSubjectManagementBtn.Click += new System.EventHandler(this.PendingSubjectManagementBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopMenu);
            this.MainMenuStrip = this.TopMenu;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TopMenu;
        private FontAwesome.Sharp.IconMenuItem HomeBtn;
        private FontAwesome.Sharp.IconMenuItem SettingsBtn;
        private FontAwesome.Sharp.IconMenuItem ManageMenuBtn;
        private FontAwesome.Sharp.IconMenuItem AdminMenuBtn;
        private System.Windows.Forms.Panel MainPanel;
        private FontAwesome.Sharp.IconMenuItem SACNABtn;
        private System.Windows.Forms.ToolStripMenuItem SubjectManagementBtn;
        private System.Windows.Forms.ToolStripMenuItem TeacherManagementBtn;
        private System.Windows.Forms.ToolStripMenuItem StudentManagementBtn;
        private System.Windows.Forms.ToolStripMenuItem RepresentativeManagementBtn;
        private System.Windows.Forms.ToolStripMenuItem ScoreManagementBtn;
        private System.Windows.Forms.ToolStripMenuItem SubjectModuleManagementBtn;
        private System.Windows.Forms.ToolStripMenuItem PendingSubjectManagementBtn;
        private System.Windows.Forms.ToolStripMenuItem CourseManagementBtn;
        private System.Windows.Forms.ToolStripMenuItem UserManagementBtn;
    }
}