namespace OCESACNA.View.Module
{
    partial class RepresentativeManagementModule
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.FullNameBox = new System.Windows.Forms.TextBox();
            this.EraseButton = new FontAwesome.Sharp.IconButton();
            this.EditButton = new FontAwesome.Sharp.IconButton();
            this.CreateButton = new FontAwesome.Sharp.IconButton();
            this.Title = new System.Windows.Forms.Label();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Selection = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RepresentativeValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.LeftPanel.SuspendLayout();
            this.FlowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
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
            this.FlowPanel.Controls.Add(this.FullNameLabel);
            this.FlowPanel.Controls.Add(this.FullNameBox);
            this.FlowPanel.Controls.Add(this.PhoneNumberLabel);
            this.FlowPanel.Controls.Add(this.PhoneNumberBox);
            this.FlowPanel.Controls.Add(this.EmailLabel);
            this.FlowPanel.Controls.Add(this.EmailBox);
            this.FlowPanel.Location = new System.Drawing.Point(9, 36);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(177, 309);
            this.FlowPanel.TabIndex = 14;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(3, 0);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(90, 13);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "Nombre completo";
            // 
            // FullNameBox
            // 
            this.FullNameBox.Location = new System.Drawing.Point(3, 16);
            this.FullNameBox.MaxLength = 100;
            this.FullNameBox.Name = "FullNameBox";
            this.FullNameBox.Size = new System.Drawing.Size(168, 20);
            this.FullNameBox.TabIndex = 1;
            this.FullNameBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
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
            this.Title.Size = new System.Drawing.Size(146, 24);
            this.Title.TabIndex = 10;
            this.Title.Text = "Representante";
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
            this.RepresentativeValue,
            this.FullName,
            this.PhoneNumber,
            this.Email});
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
            // RepresentativeValue
            // 
            this.RepresentativeValue.HeaderText = "RepresentativeValue";
            this.RepresentativeValue.Name = "RepresentativeValue";
            this.RepresentativeValue.ReadOnly = true;
            this.RepresentativeValue.Visible = false;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Nombre Completo";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 200;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Número Telefónico";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Correo Electronico";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(3, 39);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(93, 13);
            this.PhoneNumberLabel.TabIndex = 2;
            this.PhoneNumberLabel.Text = "Número telefónico";
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Location = new System.Drawing.Point(3, 55);
            this.PhoneNumberBox.MaxLength = 25;
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(168, 20);
            this.PhoneNumberBox.TabIndex = 3;
            this.PhoneNumberBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(3, 78);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(36, 13);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "E-Mail";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(3, 94);
            this.EmailBox.MaxLength = 100;
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(168, 20);
            this.EmailBox.TabIndex = 5;
            this.EmailBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // RepresentativeManagementModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "RepresentativeManagementModule";
            this.Text = "RepresentativeManagementModule";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.FlowPanel.ResumeLayout(false);
            this.FlowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox FullNameBox;
        private FontAwesome.Sharp.IconButton EraseButton;
        private FontAwesome.Sharp.IconButton EditButton;
        private FontAwesome.Sharp.IconButton CreateButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepresentativeValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailBox;
    }
}