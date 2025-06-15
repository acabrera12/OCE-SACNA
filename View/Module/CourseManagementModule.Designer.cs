namespace OCESACNA.View.Module
{
    partial class CourseManagementModule
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
            this.YearLabel = new System.Windows.Forms.Label();
            this.YearBox = new System.Windows.Forms.ComboBox();
            this.MentionLabel = new System.Windows.Forms.Label();
            this.MentionBox = new System.Windows.Forms.TextBox();
            this.SectionLabel = new System.Windows.Forms.Label();
            this.SectionBox = new System.Windows.Forms.ComboBox();
            this.SelectGuideLabel = new System.Windows.Forms.Label();
            this.SelectGuideBox = new System.Windows.Forms.TextBox();
            this.SelectGuideButton = new FontAwesome.Sharp.IconButton();
            this.EraseButton = new FontAwesome.Sharp.IconButton();
            this.EditButton = new FontAwesome.Sharp.IconButton();
            this.CreateButton = new FontAwesome.Sharp.IconButton();
            this.Title = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.SearchPerYearLabel = new System.Windows.Forms.Label();
            this.SearchPerYearBox = new System.Windows.Forms.ComboBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Selection = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CourseValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseMention = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseGuide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.FlowPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
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
            this.LeftPanel.TabIndex = 1;
            // 
            // FlowPanel
            // 
            this.FlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FlowPanel.Controls.Add(this.YearLabel);
            this.FlowPanel.Controls.Add(this.YearBox);
            this.FlowPanel.Controls.Add(this.MentionLabel);
            this.FlowPanel.Controls.Add(this.MentionBox);
            this.FlowPanel.Controls.Add(this.SectionLabel);
            this.FlowPanel.Controls.Add(this.SectionBox);
            this.FlowPanel.Controls.Add(this.SelectGuideLabel);
            this.FlowPanel.Controls.Add(this.SelectGuideBox);
            this.FlowPanel.Controls.Add(this.SelectGuideButton);
            this.FlowPanel.Location = new System.Drawing.Point(9, 36);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(177, 309);
            this.FlowPanel.TabIndex = 14;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(3, 0);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(26, 13);
            this.YearLabel.TabIndex = 6;
            this.YearLabel.Text = "Año";
            // 
            // YearBox
            // 
            this.YearBox.FormattingEnabled = true;
            this.YearBox.Location = new System.Drawing.Point(3, 16);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(168, 21);
            this.YearBox.TabIndex = 7;
            // 
            // MentionLabel
            // 
            this.MentionLabel.AutoSize = true;
            this.MentionLabel.Location = new System.Drawing.Point(3, 40);
            this.MentionLabel.Name = "MentionLabel";
            this.MentionLabel.Size = new System.Drawing.Size(48, 13);
            this.MentionLabel.TabIndex = 8;
            this.MentionLabel.Text = "Mención";
            // 
            // MentionBox
            // 
            this.MentionBox.Location = new System.Drawing.Point(3, 56);
            this.MentionBox.MaxLength = 100;
            this.MentionBox.Name = "MentionBox";
            this.MentionBox.Size = new System.Drawing.Size(168, 20);
            this.MentionBox.TabIndex = 10;
            this.MentionBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // SectionLabel
            // 
            this.SectionLabel.AutoSize = true;
            this.SectionLabel.Location = new System.Drawing.Point(3, 79);
            this.SectionLabel.Name = "SectionLabel";
            this.SectionLabel.Size = new System.Drawing.Size(26, 13);
            this.SectionLabel.TabIndex = 11;
            this.SectionLabel.Text = "Año";
            // 
            // SectionBox
            // 
            this.SectionBox.FormattingEnabled = true;
            this.SectionBox.Location = new System.Drawing.Point(3, 95);
            this.SectionBox.Name = "SectionBox";
            this.SectionBox.Size = new System.Drawing.Size(168, 21);
            this.SectionBox.TabIndex = 12;
            // 
            // SelectGuideLabel
            // 
            this.SelectGuideLabel.AutoSize = true;
            this.SelectGuideLabel.Location = new System.Drawing.Point(3, 119);
            this.SelectGuideLabel.Name = "SelectGuideLabel";
            this.SelectGuideLabel.Size = new System.Drawing.Size(75, 13);
            this.SelectGuideLabel.TabIndex = 13;
            this.SelectGuideLabel.Text = "Docente Guía";
            // 
            // SelectGuideBox
            // 
            this.SelectGuideBox.Enabled = false;
            this.SelectGuideBox.Location = new System.Drawing.Point(3, 135);
            this.SelectGuideBox.Name = "SelectGuideBox";
            this.SelectGuideBox.Size = new System.Drawing.Size(168, 20);
            this.SelectGuideBox.TabIndex = 14;
            this.SelectGuideBox.Text = "(Seleccionar)";
            // 
            // SelectGuideButton
            // 
            this.SelectGuideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectGuideButton.IconChar = FontAwesome.Sharp.IconChar.Share;
            this.SelectGuideButton.IconColor = System.Drawing.Color.Black;
            this.SelectGuideButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SelectGuideButton.IconSize = 18;
            this.SelectGuideButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SelectGuideButton.Location = new System.Drawing.Point(3, 161);
            this.SelectGuideButton.Name = "SelectGuideButton";
            this.SelectGuideButton.Size = new System.Drawing.Size(168, 25);
            this.SelectGuideButton.TabIndex = 15;
            this.SelectGuideButton.Text = "Seleccionar";
            this.SelectGuideButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectGuideButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SelectGuideButton.UseVisualStyleBackColor = true;
            this.SelectGuideButton.Click += new System.EventHandler(this.SelectGuideButton_Click);
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
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(8, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(65, 24);
            this.Title.TabIndex = 10;
            this.Title.Text = "Curso";
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TopPanel.Controls.Add(this.SearchPerYearLabel);
            this.TopPanel.Controls.Add(this.SearchPerYearBox);
            this.TopPanel.Location = new System.Drawing.Point(192, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(608, 64);
            this.TopPanel.TabIndex = 3;
            // 
            // SearchPerYearLabel
            // 
            this.SearchPerYearLabel.AutoSize = true;
            this.SearchPerYearLabel.Location = new System.Drawing.Point(6, 20);
            this.SearchPerYearLabel.Name = "SearchPerYearLabel";
            this.SearchPerYearLabel.Size = new System.Drawing.Size(26, 13);
            this.SearchPerYearLabel.TabIndex = 14;
            this.SearchPerYearLabel.Text = "Año";
            // 
            // SearchPerYearBox
            // 
            this.SearchPerYearBox.FormattingEnabled = true;
            this.SearchPerYearBox.Location = new System.Drawing.Point(6, 36);
            this.SearchPerYearBox.Name = "SearchPerYearBox";
            this.SearchPerYearBox.Size = new System.Drawing.Size(168, 21);
            this.SearchPerYearBox.TabIndex = 13;
            this.SearchPerYearBox.SelectedIndexChanged += new System.EventHandler(this.SearchPerYearBox_SelectedIndexChanged);
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
            this.CourseValue,
            this.CourseYear,
            this.CourseMention,
            this.CourseSection,
            this.CourseGuide});
            this.DataGrid.Location = new System.Drawing.Point(198, 70);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(590, 368);
            this.DataGrid.TabIndex = 4;
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
            // CourseValue
            // 
            this.CourseValue.HeaderText = "CourseValue";
            this.CourseValue.Name = "CourseValue";
            this.CourseValue.ReadOnly = true;
            this.CourseValue.Visible = false;
            // 
            // CourseYear
            // 
            this.CourseYear.HeaderText = "Año";
            this.CourseYear.Name = "CourseYear";
            this.CourseYear.ReadOnly = true;
            this.CourseYear.Width = 150;
            // 
            // CourseMention
            // 
            this.CourseMention.HeaderText = "Mección";
            this.CourseMention.Name = "CourseMention";
            this.CourseMention.ReadOnly = true;
            this.CourseMention.Width = 200;
            // 
            // CourseSection
            // 
            this.CourseSection.HeaderText = "Sección";
            this.CourseSection.Name = "CourseSection";
            this.CourseSection.ReadOnly = true;
            this.CourseSection.Width = 50;
            // 
            // CourseGuide
            // 
            this.CourseGuide.HeaderText = "Docente Guía";
            this.CourseGuide.Name = "CourseGuide";
            this.CourseGuide.ReadOnly = true;
            this.CourseGuide.Width = 150;
            // 
            // CourseManagementModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "CourseManagementModule";
            this.Text = "Gestión de Cursos";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.FlowPanel.ResumeLayout(false);
            this.FlowPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.ComboBox YearBox;
        private System.Windows.Forms.Label MentionLabel;
        private FontAwesome.Sharp.IconButton EraseButton;
        private FontAwesome.Sharp.IconButton EditButton;
        private FontAwesome.Sharp.IconButton CreateButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox MentionBox;
        private System.Windows.Forms.Label SectionLabel;
        private System.Windows.Forms.ComboBox SectionBox;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseMention;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseGuide;
        private System.Windows.Forms.Label SearchPerYearLabel;
        private System.Windows.Forms.ComboBox SearchPerYearBox;
        private System.Windows.Forms.Label SelectGuideLabel;
        private System.Windows.Forms.TextBox SelectGuideBox;
        private FontAwesome.Sharp.IconButton SelectGuideButton;
    }
}