namespace OCESACNA.View.Module
{
    partial class SubjectManagementModule
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
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SelectModuleLabel = new System.Windows.Forms.Label();
            this.SelectModuleBox = new System.Windows.Forms.TextBox();
            this.SelectModuleButton = new FontAwesome.Sharp.IconButton();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SelectTeacherLabel = new System.Windows.Forms.Label();
            this.SelectTeacherBox = new System.Windows.Forms.TextBox();
            this.SelectTeacherButton = new FontAwesome.Sharp.IconButton();
            this.SelectCourseLabel = new System.Windows.Forms.Label();
            this.SelectCourseBox = new System.Windows.Forms.TextBox();
            this.SelectCourseButton = new FontAwesome.Sharp.IconButton();
            this.EraseButton = new FontAwesome.Sharp.IconButton();
            this.EditButton = new FontAwesome.Sharp.IconButton();
            this.CreateButton = new FontAwesome.Sharp.IconButton();
            this.Title = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Selection = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SubjectValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectModuleValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.FlowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LeftPanel.Controls.Add(this.FlowPanel);
            this.LeftPanel.Controls.Add(this.EraseButton);
            this.LeftPanel.Controls.Add(this.EditButton);
            this.LeftPanel.Controls.Add(this.CreateButton);
            this.LeftPanel.Controls.Add(this.Title);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(192, 450);
            this.LeftPanel.TabIndex = 3;
            // 
            // FlowPanel
            // 
            this.FlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FlowPanel.Controls.Add(this.SelectModuleLabel);
            this.FlowPanel.Controls.Add(this.SelectModuleBox);
            this.FlowPanel.Controls.Add(this.SelectModuleButton);
            this.FlowPanel.Controls.Add(this.NameLabel);
            this.FlowPanel.Controls.Add(this.NameBox);
            this.FlowPanel.Controls.Add(this.SelectTeacherLabel);
            this.FlowPanel.Controls.Add(this.SelectTeacherBox);
            this.FlowPanel.Controls.Add(this.SelectTeacherButton);
            this.FlowPanel.Controls.Add(this.SelectCourseLabel);
            this.FlowPanel.Controls.Add(this.SelectCourseBox);
            this.FlowPanel.Controls.Add(this.SelectCourseButton);
            this.FlowPanel.Location = new System.Drawing.Point(9, 36);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(177, 309);
            this.FlowPanel.TabIndex = 14;
            // 
            // SelectModuleLabel
            // 
            this.SelectModuleLabel.AutoSize = true;
            this.SelectModuleLabel.Location = new System.Drawing.Point(3, 0);
            this.SelectModuleLabel.Name = "SelectModuleLabel";
            this.SelectModuleLabel.Size = new System.Drawing.Size(93, 13);
            this.SelectModuleLabel.TabIndex = 2;
            this.SelectModuleLabel.Text = "Área de formación";
            // 
            // SelectModuleBox
            // 
            this.SelectModuleBox.Enabled = false;
            this.SelectModuleBox.Location = new System.Drawing.Point(3, 16);
            this.SelectModuleBox.Name = "SelectModuleBox";
            this.SelectModuleBox.Size = new System.Drawing.Size(168, 20);
            this.SelectModuleBox.TabIndex = 15;
            this.SelectModuleBox.Text = "(Seleccionar)";
            // 
            // SelectModuleButton
            // 
            this.SelectModuleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectModuleButton.IconChar = FontAwesome.Sharp.IconChar.Share;
            this.SelectModuleButton.IconColor = System.Drawing.Color.Black;
            this.SelectModuleButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SelectModuleButton.IconSize = 18;
            this.SelectModuleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SelectModuleButton.Location = new System.Drawing.Point(3, 42);
            this.SelectModuleButton.Name = "SelectModuleButton";
            this.SelectModuleButton.Size = new System.Drawing.Size(168, 25);
            this.SelectModuleButton.TabIndex = 18;
            this.SelectModuleButton.Text = "Seleccionar";
            this.SelectModuleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectModuleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SelectModuleButton.UseVisualStyleBackColor = true;
            this.SelectModuleButton.Click += new System.EventHandler(this.SelectModuleButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 70);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Nombre";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(3, 86);
            this.NameBox.MaxLength = 100;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(168, 20);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // SelectTeacherLabel
            // 
            this.SelectTeacherLabel.AutoSize = true;
            this.SelectTeacherLabel.Location = new System.Drawing.Point(3, 109);
            this.SelectTeacherLabel.Name = "SelectTeacherLabel";
            this.SelectTeacherLabel.Size = new System.Drawing.Size(48, 13);
            this.SelectTeacherLabel.TabIndex = 16;
            this.SelectTeacherLabel.Text = "Docente";
            // 
            // SelectTeacherBox
            // 
            this.SelectTeacherBox.Enabled = false;
            this.SelectTeacherBox.Location = new System.Drawing.Point(3, 125);
            this.SelectTeacherBox.Name = "SelectTeacherBox";
            this.SelectTeacherBox.Size = new System.Drawing.Size(168, 20);
            this.SelectTeacherBox.TabIndex = 17;
            this.SelectTeacherBox.Text = "(Seleccionar)";
            // 
            // SelectTeacherButton
            // 
            this.SelectTeacherButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectTeacherButton.IconChar = FontAwesome.Sharp.IconChar.Share;
            this.SelectTeacherButton.IconColor = System.Drawing.Color.Black;
            this.SelectTeacherButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SelectTeacherButton.IconSize = 18;
            this.SelectTeacherButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SelectTeacherButton.Location = new System.Drawing.Point(3, 151);
            this.SelectTeacherButton.Name = "SelectTeacherButton";
            this.SelectTeacherButton.Size = new System.Drawing.Size(168, 25);
            this.SelectTeacherButton.TabIndex = 19;
            this.SelectTeacherButton.Text = "Seleccionar";
            this.SelectTeacherButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectTeacherButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SelectTeacherButton.UseVisualStyleBackColor = true;
            this.SelectTeacherButton.Click += new System.EventHandler(this.SelectTeacherButton_Click);
            // 
            // SelectCourseLabel
            // 
            this.SelectCourseLabel.AutoSize = true;
            this.SelectCourseLabel.Location = new System.Drawing.Point(3, 179);
            this.SelectCourseLabel.Name = "SelectCourseLabel";
            this.SelectCourseLabel.Size = new System.Drawing.Size(34, 13);
            this.SelectCourseLabel.TabIndex = 20;
            this.SelectCourseLabel.Text = "Curso";
            // 
            // SelectCourseBox
            // 
            this.SelectCourseBox.Enabled = false;
            this.SelectCourseBox.Location = new System.Drawing.Point(3, 195);
            this.SelectCourseBox.Name = "SelectCourseBox";
            this.SelectCourseBox.Size = new System.Drawing.Size(168, 20);
            this.SelectCourseBox.TabIndex = 21;
            this.SelectCourseBox.Text = "(Seleccionar)";
            // 
            // SelectCourseButton
            // 
            this.SelectCourseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectCourseButton.IconChar = FontAwesome.Sharp.IconChar.Share;
            this.SelectCourseButton.IconColor = System.Drawing.Color.Black;
            this.SelectCourseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SelectCourseButton.IconSize = 18;
            this.SelectCourseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SelectCourseButton.Location = new System.Drawing.Point(3, 221);
            this.SelectCourseButton.Name = "SelectCourseButton";
            this.SelectCourseButton.Size = new System.Drawing.Size(168, 25);
            this.SelectCourseButton.TabIndex = 22;
            this.SelectCourseButton.Text = "Seleccionar";
            this.SelectCourseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectCourseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SelectCourseButton.UseVisualStyleBackColor = true;
            this.SelectCourseButton.Click += new System.EventHandler(this.SelectCourseButton_Click);
            // 
            // EraseButton
            // 
            this.EraseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EraseButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.EraseButton.IconColor = System.Drawing.Color.Black;
            this.EraseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EraseButton.IconSize = 18;
            this.EraseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EraseButton.Location = new System.Drawing.Point(12, 413);
            this.EraseButton.Name = "EraseButton";
            this.EraseButton.Size = new System.Drawing.Size(168, 25);
            this.EraseButton.TabIndex = 13;
            this.EraseButton.Text = "Eliminar";
            this.EraseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EraseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.EraseButton.UseVisualStyleBackColor = true;
            this.EraseButton.Click += new System.EventHandler(this.EraseButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.EditButton.IconColor = System.Drawing.Color.Black;
            this.EditButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditButton.IconSize = 18;
            this.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditButton.Location = new System.Drawing.Point(12, 382);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(168, 25);
            this.EditButton.TabIndex = 12;
            this.EditButton.Text = "Editar";
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateButton.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.CreateButton.IconColor = System.Drawing.Color.Black;
            this.CreateButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CreateButton.IconSize = 18;
            this.CreateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateButton.Location = new System.Drawing.Point(12, 351);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(168, 25);
            this.CreateButton.TabIndex = 11;
            this.CreateButton.Text = "Crear nuevo";
            this.CreateButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(8, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(96, 20);
            this.Title.TabIndex = 10;
            this.Title.Text = "Asignatura";
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TopPanel.Location = new System.Drawing.Point(192, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(608, 64);
            this.TopPanel.TabIndex = 4;
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
            this.SubjectValue,
            this.SubjectModuleValue,
            this.SubjectModuleName,
            this.SubjectName,
            this.TeacherValue,
            this.TeacherName,
            this.CourseValue,
            this.CourseName});
            this.DataGrid.Location = new System.Drawing.Point(198, 70);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(590, 368);
            this.DataGrid.TabIndex = 5;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            // 
            // Selection
            // 
            this.Selection.HeaderText = "";
            this.Selection.Name = "Selection";
            this.Selection.ReadOnly = true;
            this.Selection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Selection.Width = 25;
            // 
            // SubjectValue
            // 
            this.SubjectValue.HeaderText = "SubjectValue";
            this.SubjectValue.Name = "SubjectValue";
            this.SubjectValue.ReadOnly = true;
            this.SubjectValue.Visible = false;
            // 
            // SubjectModuleValue
            // 
            this.SubjectModuleValue.HeaderText = "SubjectModuleValue";
            this.SubjectModuleValue.Name = "SubjectModuleValue";
            this.SubjectModuleValue.ReadOnly = true;
            this.SubjectModuleValue.Visible = false;
            // 
            // SubjectModuleName
            // 
            this.SubjectModuleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SubjectModuleName.HeaderText = "Área de formación";
            this.SubjectModuleName.Name = "SubjectModuleName";
            this.SubjectModuleName.ReadOnly = true;
            this.SubjectModuleName.Width = 108;
            // 
            // SubjectName
            // 
            this.SubjectName.HeaderText = "Nombre";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            this.SubjectName.Width = 200;
            // 
            // TeacherValue
            // 
            this.TeacherValue.HeaderText = "TeacherValue";
            this.TeacherValue.Name = "TeacherValue";
            this.TeacherValue.ReadOnly = true;
            this.TeacherValue.Visible = false;
            // 
            // TeacherName
            // 
            this.TeacherName.HeaderText = "Docente";
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            // 
            // CourseValue
            // 
            this.CourseValue.HeaderText = "CourseValue";
            this.CourseValue.Name = "CourseValue";
            this.CourseValue.ReadOnly = true;
            this.CourseValue.Visible = false;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Curso";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // SubjectManagementModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "SubjectManagementModule";
            this.Text = "Asignaturas";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.FlowPanel.ResumeLayout(false);
            this.FlowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private FontAwesome.Sharp.IconButton EraseButton;
        private FontAwesome.Sharp.IconButton EditButton;
        private FontAwesome.Sharp.IconButton CreateButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectModuleValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.Label SelectModuleLabel;
        private System.Windows.Forms.TextBox SelectModuleBox;
        private System.Windows.Forms.Label SelectTeacherLabel;
        private System.Windows.Forms.TextBox SelectTeacherBox;
        private FontAwesome.Sharp.IconButton SelectModuleButton;
        private FontAwesome.Sharp.IconButton SelectTeacherButton;
        private System.Windows.Forms.Label SelectCourseLabel;
        private System.Windows.Forms.TextBox SelectCourseBox;
        private FontAwesome.Sharp.IconButton SelectCourseButton;
    }
}