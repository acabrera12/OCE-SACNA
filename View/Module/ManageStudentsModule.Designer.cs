
namespace OCESACNA.View.Module
{
    partial class ManageStudentsModule
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
            this.MainContainer = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchByBox = new System.Windows.Forms.ComboBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateBtn = new FontAwesome.Sharp.IconButton();
            this.EditBtn = new FontAwesome.Sharp.IconButton();
            this.EraseBtn = new FontAwesome.Sharp.IconButton();
            this.Selection = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FederalEntty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RprsentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Representative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mention = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainContainer.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.Cedula,
            this.LastNames,
            this.FirstNames,
            this.Age,
            this.Sex,
            this.Birthdate,
            this.BirthPlace,
            this.FederalEntty,
            this.Address,
            this.PhoneNumber,
            this.Email,
            this.RprsentID,
            this.Representative,
            this.CourseID,
            this.Year,
            this.Mention,
            this.Section});
            this.DataGrid.Location = new System.Drawing.Point(3, 41);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(576, 382);
            this.DataGrid.TabIndex = 1;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
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
            this.LeftPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Estudiante";
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
            this.ID.Width = 57;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cédula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // LastNames
            // 
            this.LastNames.HeaderText = "Apellidos";
            this.LastNames.Name = "LastNames";
            this.LastNames.ReadOnly = true;
            this.LastNames.Width = 150;
            // 
            // FirstNames
            // 
            this.FirstNames.HeaderText = "Nombres";
            this.FirstNames.Name = "FirstNames";
            this.FirstNames.ReadOnly = true;
            this.FirstNames.Width = 150;
            // 
            // Age
            // 
            this.Age.HeaderText = "Edad";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 50;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Sexo";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Width = 50;
            // 
            // Birthdate
            // 
            this.Birthdate.HeaderText = "Fecha de Nacimiento";
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.ReadOnly = true;
            // 
            // BirthPlace
            // 
            this.BirthPlace.HeaderText = "Lugar de Nacimiento";
            this.BirthPlace.Name = "BirthPlace";
            this.BirthPlace.ReadOnly = true;
            // 
            // FederalEntty
            // 
            this.FederalEntty.HeaderText = "Entidad Federal";
            this.FederalEntty.Name = "FederalEntty";
            this.FederalEntty.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Dirección";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 125;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Número Telefónico";
            this.PhoneNumber.MaxInputLength = 20;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "E-Mail";
            this.Email.MaxInputLength = 100;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // RprsentID
            // 
            this.RprsentID.HeaderText = "RprsentID";
            this.RprsentID.Name = "RprsentID";
            this.RprsentID.ReadOnly = true;
            this.RprsentID.Visible = false;
            // 
            // Representative
            // 
            this.Representative.HeaderText = "Representante";
            this.Representative.Name = "Representative";
            this.Representative.ReadOnly = true;
            // 
            // CourseID
            // 
            this.CourseID.HeaderText = "CourseID";
            this.CourseID.Name = "CourseID";
            this.CourseID.ReadOnly = true;
            this.CourseID.Visible = false;
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
            // 
            // Section
            // 
            this.Section.HeaderText = "Sección";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            // 
            // ManageStudentsModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.MainContainer);
            this.Name = "ManageStudentsModule";
            this.Text = "ManageStudentsModule";
            this.Load += new System.EventHandler(this.ManageStudentsModule_Load);
            this.MainContainer.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainContainer;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.ComboBox SearchByBox;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton CreateBtn;
        private FontAwesome.Sharp.IconButton EditBtn;
        private FontAwesome.Sharp.IconButton EraseBtn;
        private System.Windows.Forms.DataGridViewButtonColumn Selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn FederalEntty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn RprsentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Representative;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mention;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
    }
}