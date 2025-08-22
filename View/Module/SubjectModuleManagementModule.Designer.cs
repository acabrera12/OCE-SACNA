namespace OCESACNA.View.Module
{
    partial class SubjectModuleManagementModule
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
            this.SubjectModuleNameLabel = new System.Windows.Forms.Label();
            this.SubjectModuleNameBox = new System.Windows.Forms.TextBox();
            this.EraseButton = new FontAwesome.Sharp.IconButton();
            this.EditButton = new FontAwesome.Sharp.IconButton();
            this.CreateButton = new FontAwesome.Sharp.IconButton();
            this.Title = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Selection = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SubjectModuleValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.LeftPanel.TabIndex = 4;
            // 
            // FlowPanel
            // 
            this.FlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FlowPanel.Controls.Add(this.SubjectModuleNameLabel);
            this.FlowPanel.Controls.Add(this.SubjectModuleNameBox);
            this.FlowPanel.Location = new System.Drawing.Point(9, 36);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(177, 309);
            this.FlowPanel.TabIndex = 14;
            // 
            // SubjectModuleNameLabel
            // 
            this.SubjectModuleNameLabel.AutoSize = true;
            this.SubjectModuleNameLabel.Location = new System.Drawing.Point(3, 0);
            this.SubjectModuleNameLabel.Name = "SubjectModuleNameLabel";
            this.SubjectModuleNameLabel.Size = new System.Drawing.Size(44, 13);
            this.SubjectModuleNameLabel.TabIndex = 0;
            this.SubjectModuleNameLabel.Text = "Nombre";
            // 
            // SubjectModuleNameBox
            // 
            this.SubjectModuleNameBox.Location = new System.Drawing.Point(3, 16);
            this.SubjectModuleNameBox.MaxLength = 100;
            this.SubjectModuleNameBox.Name = "SubjectModuleNameBox";
            this.SubjectModuleNameBox.Size = new System.Drawing.Size(168, 20);
            this.SubjectModuleNameBox.TabIndex = 1;
            this.SubjectModuleNameBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
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
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(8, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(179, 22);
            this.Title.TabIndex = 10;
            this.Title.Text = "Área de Formación";
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TopPanel.Location = new System.Drawing.Point(192, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(608, 64);
            this.TopPanel.TabIndex = 5;
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
            this.SubjectModuleValue,
            this.SubjectModuleName});
            this.DataGrid.Location = new System.Drawing.Point(198, 70);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(590, 368);
            this.DataGrid.TabIndex = 6;
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
            // SubjectModuleValue
            // 
            this.SubjectModuleValue.HeaderText = "SubjectModuleValue";
            this.SubjectModuleValue.Name = "SubjectModuleValue";
            this.SubjectModuleValue.ReadOnly = true;
            this.SubjectModuleValue.Visible = false;
            // 
            // SubjectModuleName
            // 
            this.SubjectModuleName.HeaderText = "Área de Formación";
            this.SubjectModuleName.Name = "SubjectModuleName";
            this.SubjectModuleName.ReadOnly = true;
            this.SubjectModuleName.Width = 250;
            // 
            // SubjectModuleManagementModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "SubjectModuleManagementModule";
            this.Text = "Gestión de Áreas de Formación";
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
        private System.Windows.Forms.Label SubjectModuleNameLabel;
        private System.Windows.Forms.TextBox SubjectModuleNameBox;
        private FontAwesome.Sharp.IconButton EraseButton;
        private FontAwesome.Sharp.IconButton EditButton;
        private FontAwesome.Sharp.IconButton CreateButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectModuleValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectModuleName;
    }
}