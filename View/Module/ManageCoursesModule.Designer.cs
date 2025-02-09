
namespace OCESACNA.View.Module
{
    partial class ManageCoursesModule
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("1° Año");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("2° Año");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("3° Año");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("4° Año");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("5° Año");
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.SectionGroup = new System.Windows.Forms.GroupBox();
            this.SectionBox = new System.Windows.Forms.ComboBox();
            this.SectionNameLabel = new System.Windows.Forms.Label();
            this.CreateSBtn = new FontAwesome.Sharp.IconButton();
            this.EraseSBtn = new FontAwesome.Sharp.IconButton();
            this.MentionGroup = new System.Windows.Forms.GroupBox();
            this.YearBox = new System.Windows.Forms.ComboBox();
            this.YearLabel = new System.Windows.Forms.Label();
            this.MentionNameLabel = new System.Windows.Forms.Label();
            this.MentionNameBox = new System.Windows.Forms.TextBox();
            this.CreateMBtn = new FontAwesome.Sharp.IconButton();
            this.EditMBtn = new FontAwesome.Sharp.IconButton();
            this.EraseMBtn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Tree = new System.Windows.Forms.TreeView();
            this.MainContainer = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchByBox = new System.Windows.Forms.ComboBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Selection = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mention = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.SectionGroup.SuspendLayout();
            this.MentionGroup.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.White;
            this.LeftPanel.Controls.Add(this.SectionGroup);
            this.LeftPanel.Controls.Add(this.MentionGroup);
            this.LeftPanel.Controls.Add(this.label1);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(200, 450);
            this.LeftPanel.TabIndex = 2;
            // 
            // SectionGroup
            // 
            this.SectionGroup.Controls.Add(this.SectionBox);
            this.SectionGroup.Controls.Add(this.SectionNameLabel);
            this.SectionGroup.Controls.Add(this.CreateSBtn);
            this.SectionGroup.Controls.Add(this.EraseSBtn);
            this.SectionGroup.Location = new System.Drawing.Point(12, 229);
            this.SectionGroup.Name = "SectionGroup";
            this.SectionGroup.Size = new System.Drawing.Size(177, 118);
            this.SectionGroup.TabIndex = 13;
            this.SectionGroup.TabStop = false;
            this.SectionGroup.Text = "Sección";
            // 
            // SectionBox
            // 
            this.SectionBox.FormattingEnabled = true;
            this.SectionBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J"});
            this.SectionBox.Location = new System.Drawing.Point(6, 32);
            this.SectionBox.Name = "SectionBox";
            this.SectionBox.Size = new System.Drawing.Size(165, 21);
            this.SectionBox.TabIndex = 11;
            // 
            // SectionNameLabel
            // 
            this.SectionNameLabel.AutoSize = true;
            this.SectionNameLabel.Location = new System.Drawing.Point(6, 16);
            this.SectionNameLabel.Name = "SectionNameLabel";
            this.SectionNameLabel.Size = new System.Drawing.Size(31, 13);
            this.SectionNameLabel.TabIndex = 4;
            this.SectionNameLabel.Text = "Letra";
            // 
            // CreateSBtn
            // 
            this.CreateSBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateSBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.CreateSBtn.IconColor = System.Drawing.Color.Black;
            this.CreateSBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CreateSBtn.IconSize = 16;
            this.CreateSBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateSBtn.Location = new System.Drawing.Point(6, 59);
            this.CreateSBtn.Name = "CreateSBtn";
            this.CreateSBtn.Size = new System.Drawing.Size(165, 23);
            this.CreateSBtn.TabIndex = 10;
            this.CreateSBtn.Text = "Crear";
            this.CreateSBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateSBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateSBtn.UseVisualStyleBackColor = true;
            this.CreateSBtn.Click += new System.EventHandler(this.CreateSBtn_Click);
            // 
            // EraseSBtn
            // 
            this.EraseSBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EraseSBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.EraseSBtn.IconColor = System.Drawing.Color.Black;
            this.EraseSBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EraseSBtn.IconSize = 16;
            this.EraseSBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EraseSBtn.Location = new System.Drawing.Point(6, 88);
            this.EraseSBtn.Name = "EraseSBtn";
            this.EraseSBtn.Size = new System.Drawing.Size(165, 23);
            this.EraseSBtn.TabIndex = 8;
            this.EraseSBtn.Text = "Eliminar";
            this.EraseSBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EraseSBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EraseSBtn.UseVisualStyleBackColor = true;
            this.EraseSBtn.Click += new System.EventHandler(this.EraseSBtn_Click);
            // 
            // MentionGroup
            // 
            this.MentionGroup.Controls.Add(this.YearBox);
            this.MentionGroup.Controls.Add(this.YearLabel);
            this.MentionGroup.Controls.Add(this.MentionNameLabel);
            this.MentionGroup.Controls.Add(this.MentionNameBox);
            this.MentionGroup.Controls.Add(this.CreateMBtn);
            this.MentionGroup.Controls.Add(this.EditMBtn);
            this.MentionGroup.Controls.Add(this.EraseMBtn);
            this.MentionGroup.Location = new System.Drawing.Point(12, 36);
            this.MentionGroup.Name = "MentionGroup";
            this.MentionGroup.Size = new System.Drawing.Size(177, 187);
            this.MentionGroup.TabIndex = 12;
            this.MentionGroup.TabStop = false;
            this.MentionGroup.Text = "Mención";
            // 
            // YearBox
            // 
            this.YearBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.YearBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.YearBox.FormattingEnabled = true;
            this.YearBox.Items.AddRange(new object[] {
            "Todos",
            "1° Año",
            "2° Año",
            "3° Año",
            "4° Año",
            "5° Año"});
            this.YearBox.Location = new System.Drawing.Point(6, 71);
            this.YearBox.MaxLength = 100;
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(165, 21);
            this.YearBox.TabIndex = 12;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(6, 55);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(26, 13);
            this.YearLabel.TabIndex = 11;
            this.YearLabel.Text = "Año";
            // 
            // MentionNameLabel
            // 
            this.MentionNameLabel.AutoSize = true;
            this.MentionNameLabel.Location = new System.Drawing.Point(6, 16);
            this.MentionNameLabel.Name = "MentionNameLabel";
            this.MentionNameLabel.Size = new System.Drawing.Size(44, 13);
            this.MentionNameLabel.TabIndex = 4;
            this.MentionNameLabel.Text = "Nombre";
            // 
            // MentionNameBox
            // 
            this.MentionNameBox.Location = new System.Drawing.Point(6, 32);
            this.MentionNameBox.MaxLength = 100;
            this.MentionNameBox.Name = "MentionNameBox";
            this.MentionNameBox.Size = new System.Drawing.Size(165, 20);
            this.MentionNameBox.TabIndex = 0;
            this.MentionNameBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // CreateMBtn
            // 
            this.CreateMBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateMBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.CreateMBtn.IconColor = System.Drawing.Color.Black;
            this.CreateMBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CreateMBtn.IconSize = 16;
            this.CreateMBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateMBtn.Location = new System.Drawing.Point(6, 97);
            this.CreateMBtn.Name = "CreateMBtn";
            this.CreateMBtn.Size = new System.Drawing.Size(165, 23);
            this.CreateMBtn.TabIndex = 10;
            this.CreateMBtn.Text = "Crear";
            this.CreateMBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateMBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateMBtn.UseVisualStyleBackColor = true;
            this.CreateMBtn.Click += new System.EventHandler(this.CreateMBtn_Click);
            // 
            // EditMBtn
            // 
            this.EditMBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditMBtn.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.EditMBtn.IconColor = System.Drawing.Color.Black;
            this.EditMBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditMBtn.IconSize = 16;
            this.EditMBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditMBtn.Location = new System.Drawing.Point(6, 126);
            this.EditMBtn.Name = "EditMBtn";
            this.EditMBtn.Size = new System.Drawing.Size(165, 23);
            this.EditMBtn.TabIndex = 9;
            this.EditMBtn.Text = "Editar";
            this.EditMBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditMBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditMBtn.UseVisualStyleBackColor = true;
            this.EditMBtn.Click += new System.EventHandler(this.EditMBtn_Click);
            // 
            // EraseMBtn
            // 
            this.EraseMBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EraseMBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.EraseMBtn.IconColor = System.Drawing.Color.Black;
            this.EraseMBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EraseMBtn.IconSize = 16;
            this.EraseMBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EraseMBtn.Location = new System.Drawing.Point(6, 155);
            this.EraseMBtn.Name = "EraseMBtn";
            this.EraseMBtn.Size = new System.Drawing.Size(165, 23);
            this.EraseMBtn.TabIndex = 8;
            this.EraseMBtn.Text = "Eliminar";
            this.EraseMBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EraseMBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EraseMBtn.UseVisualStyleBackColor = true;
            this.EraseMBtn.Click += new System.EventHandler(this.EraseMBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Curso";
            // 
            // Tree
            // 
            this.Tree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Tree.Location = new System.Drawing.Point(206, 12);
            this.Tree.Name = "Tree";
            treeNode1.Name = "1thYear";
            treeNode1.Text = "1° Año";
            treeNode2.Name = "2thYear";
            treeNode2.Text = "2° Año";
            treeNode3.Name = "3thYear";
            treeNode3.Text = "3° Año";
            treeNode4.Name = "4thYear";
            treeNode4.Text = "4° Año";
            treeNode5.Name = "5thYear";
            treeNode5.Text = "5° Año";
            this.Tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.Tree.Size = new System.Drawing.Size(164, 426);
            this.Tree.TabIndex = 3;
            this.Tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Tree_NodeMouseClick);
            // 
            // MainContainer
            // 
            this.MainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainContainer.Controls.Add(this.TopPanel);
            this.MainContainer.Controls.Add(this.DataGrid);
            this.MainContainer.Location = new System.Drawing.Point(376, 12);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(412, 426);
            this.MainContainer.TabIndex = 5;
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
            this.TopPanel.Size = new System.Drawing.Size(406, 32);
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
            this.SearchBox.Size = new System.Drawing.Size(192, 20);
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
            this.Year,
            this.Mention,
            this.Section});
            this.DataGrid.Location = new System.Drawing.Point(3, 41);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(406, 382);
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
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 50;
            // 
            // Year
            // 
            this.Year.HeaderText = "Año";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // Mention
            // 
            this.Mention.HeaderText = "Mención";
            this.Mention.Name = "Mention";
            this.Mention.ReadOnly = true;
            this.Mention.Width = 150;
            // 
            // Section
            // 
            this.Section.HeaderText = "Sección";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            this.Section.Width = 50;
            // 
            // ManageCoursesModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.LeftPanel);
            this.Name = "ManageCoursesModule";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.ManageCoursesModule_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.SectionGroup.ResumeLayout(false);
            this.SectionGroup.PerformLayout();
            this.MentionGroup.ResumeLayout(false);
            this.MentionGroup.PerformLayout();
            this.MainContainer.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton CreateMBtn;
        private FontAwesome.Sharp.IconButton EditMBtn;
        private FontAwesome.Sharp.IconButton EraseMBtn;
        private System.Windows.Forms.Label MentionNameLabel;
        private System.Windows.Forms.TextBox MentionNameBox;
        private System.Windows.Forms.GroupBox MentionGroup;
        private System.Windows.Forms.GroupBox SectionGroup;
        private System.Windows.Forms.Label SectionNameLabel;
        private FontAwesome.Sharp.IconButton CreateSBtn;
        private FontAwesome.Sharp.IconButton EraseSBtn;
        private System.Windows.Forms.ComboBox SectionBox;
        private System.Windows.Forms.ComboBox YearBox;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.TreeView Tree;
        private System.Windows.Forms.Panel MainContainer;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.ComboBox SearchByBox;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mention;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
    }
}