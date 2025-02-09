
namespace OCESACNA.View.Module
{
    partial class ManageSubjectsModule
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateBtn = new FontAwesome.Sharp.IconButton();
            this.EditBtn = new FontAwesome.Sharp.IconButton();
            this.EraseBtn = new FontAwesome.Sharp.IconButton();
            this.MainContainer = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchByBox = new System.Windows.Forms.ComboBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Selection = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectModuleValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectModule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeachValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.White;
            this.LeftPanel.Controls.Add(this.label1);
            this.LeftPanel.Controls.Add(this.CreateBtn);
            this.LeftPanel.Controls.Add(this.EditBtn);
            this.LeftPanel.Controls.Add(this.EraseBtn);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(200, 450);
            this.LeftPanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Asignatura";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.CreateBtn.IconColor = System.Drawing.Color.Black;
            this.CreateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CreateBtn.IconSize = 16;
            this.CreateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateBtn.Location = new System.Drawing.Point(12, 357);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(176, 23);
            this.CreateBtn.TabIndex = 10;
            this.CreateBtn.Text = "Crear";
            this.CreateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditBtn.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.EditBtn.IconColor = System.Drawing.Color.Black;
            this.EditBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditBtn.IconSize = 16;
            this.EditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditBtn.Location = new System.Drawing.Point(12, 386);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(176, 23);
            this.EditBtn.TabIndex = 9;
            this.EditBtn.Text = "Editar";
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // EraseBtn
            // 
            this.EraseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EraseBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.EraseBtn.IconColor = System.Drawing.Color.Black;
            this.EraseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EraseBtn.IconSize = 16;
            this.EraseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EraseBtn.Location = new System.Drawing.Point(12, 415);
            this.EraseBtn.Name = "EraseBtn";
            this.EraseBtn.Size = new System.Drawing.Size(176, 23);
            this.EraseBtn.TabIndex = 8;
            this.EraseBtn.Text = "Eliminar";
            this.EraseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EraseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EraseBtn.UseVisualStyleBackColor = true;
            this.EraseBtn.Click += new System.EventHandler(this.EraseBtn_Click);
            // 
            // MainContainer
            // 
            this.MainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainContainer.Controls.Add(this.TopPanel);
            this.MainContainer.Controls.Add(this.DataGrid);
            this.MainContainer.Location = new System.Drawing.Point(206, 12);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(582, 426);
            this.MainContainer.TabIndex = 8;
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.Color.White;
            this.TopPanel.Controls.Add(this.SearchLabel);
            this.TopPanel.Controls.Add(this.SearchByBox);
            this.TopPanel.Controls.Add(this.SearchBox);
            this.TopPanel.Location = new System.Drawing.Point(3, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(576, 32);
            this.TopPanel.TabIndex = 2;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(3, 10);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(58, 13);
            this.SearchLabel.TabIndex = 14;
            this.SearchLabel.Text = "Buscar por";
            // 
            // SearchByBox
            // 
            this.SearchByBox.FormattingEnabled = true;
            this.SearchByBox.Location = new System.Drawing.Point(67, 6);
            this.SearchByBox.Name = "SearchByBox";
            this.SearchByBox.Size = new System.Drawing.Size(138, 21);
            this.SearchByBox.TabIndex = 14;
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Location = new System.Drawing.Point(211, 6);
            this.SearchBox.MaxLength = 255;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(362, 20);
            this.SearchBox.TabIndex = 14;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AllowUserToOrderColumns = true;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selection,
            this.ID,
            this.SubjectModuleValue,
            this.SubjectModule,
            this.SubjectName,
            this.TeachValue,
            this.Teach,
            this.CourseValue,
            this.Course});
            this.DataGrid.Location = new System.Drawing.Point(3, 41);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(576, 382);
            this.DataGrid.TabIndex = 1;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            // 
            // Selection
            // 
            this.Selection.HeaderText = "•••";
            this.Selection.Name = "Selection";
            this.Selection.ReadOnly = true;
            this.Selection.Width = 32;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 16;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 57;
            // 
            // SubjectModuleValue
            // 
            this.SubjectModuleValue.HeaderText = "SubjectModuleValue";
            this.SubjectModuleValue.Name = "SubjectModuleValue";
            this.SubjectModuleValue.ReadOnly = true;
            this.SubjectModuleValue.Visible = false;
            // 
            // SubjectModule
            // 
            this.SubjectModule.HeaderText = "Área de Formación";
            this.SubjectModule.Name = "SubjectModule";
            this.SubjectModule.ReadOnly = true;
            this.SubjectModule.Width = 200;
            // 
            // SubjectName
            // 
            this.SubjectName.HeaderText = "Nombre";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            this.SubjectName.Width = 150;
            // 
            // TeachValue
            // 
            this.TeachValue.HeaderText = "TeachValue";
            this.TeachValue.Name = "TeachValue";
            this.TeachValue.ReadOnly = true;
            this.TeachValue.Visible = false;
            // 
            // Teach
            // 
            this.Teach.HeaderText = "Docente";
            this.Teach.Name = "Teach";
            this.Teach.ReadOnly = true;
            // 
            // CourseValue
            // 
            this.CourseValue.HeaderText = "CourseValue";
            this.CourseValue.Name = "CourseValue";
            this.CourseValue.ReadOnly = true;
            this.CourseValue.Visible = false;
            // 
            // Course
            // 
            this.Course.HeaderText = "Curso";
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            this.Course.Width = 200;
            // 
            // ManageSubjectsModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.LeftPanel);
            this.Name = "ManageSubjectsModule";
            this.Text = "Asignaturas";
            this.Load += new System.EventHandler(this.ManageSubjectsModule_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.MainContainer.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton CreateBtn;
        private FontAwesome.Sharp.IconButton EditBtn;
        private FontAwesome.Sharp.IconButton EraseBtn;
        private System.Windows.Forms.Panel MainContainer;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.ComboBox SearchByBox;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectModuleValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectModule;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeachValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teach;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
    }
}