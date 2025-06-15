namespace OCESACNA.View.Module
{
    partial class UserManagementModule
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
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.ConfirmPassworLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordBox = new System.Windows.Forms.TextBox();
            this.RankLabel = new System.Windows.Forms.Label();
            this.RankBox = new System.Windows.Forms.ComboBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.StateBox = new System.Windows.Forms.ComboBox();
            this.ChangePasswordButton = new FontAwesome.Sharp.IconButton();
            this.EraseButton = new FontAwesome.Sharp.IconButton();
            this.EditButton = new FontAwesome.Sharp.IconButton();
            this.CreateButton = new FontAwesome.Sharp.IconButton();
            this.Title = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Content = new System.Windows.Forms.Panel();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Selection = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UserValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.FlowPanel.SuspendLayout();
            this.Content.SuspendLayout();
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
            this.LeftPanel.TabIndex = 0;
            // 
            // FlowPanel
            // 
            this.FlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FlowPanel.Controls.Add(this.UserNameLabel);
            this.FlowPanel.Controls.Add(this.UserNameBox);
            this.FlowPanel.Controls.Add(this.PasswordLabel);
            this.FlowPanel.Controls.Add(this.PasswordBox);
            this.FlowPanel.Controls.Add(this.ConfirmPassworLabel);
            this.FlowPanel.Controls.Add(this.ConfirmPasswordBox);
            this.FlowPanel.Controls.Add(this.RankLabel);
            this.FlowPanel.Controls.Add(this.RankBox);
            this.FlowPanel.Controls.Add(this.StateLabel);
            this.FlowPanel.Controls.Add(this.StateBox);
            this.FlowPanel.Controls.Add(this.ChangePasswordButton);
            this.FlowPanel.Location = new System.Drawing.Point(9, 36);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(177, 309);
            this.FlowPanel.TabIndex = 14;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(3, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(96, 13);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "Nombre de usuario";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(3, 16);
            this.UserNameBox.MaxLength = 16;
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(168, 20);
            this.UserNameBox.TabIndex = 1;
            this.UserNameBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(3, 39);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(61, 13);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Contraseña";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(3, 55);
            this.PasswordBox.MaxLength = 16;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(168, 20);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // ConfirmPassworLabel
            // 
            this.ConfirmPassworLabel.AutoSize = true;
            this.ConfirmPassworLabel.Location = new System.Drawing.Point(3, 78);
            this.ConfirmPassworLabel.Name = "ConfirmPassworLabel";
            this.ConfirmPassworLabel.Size = new System.Drawing.Size(107, 13);
            this.ConfirmPassworLabel.TabIndex = 4;
            this.ConfirmPassworLabel.Text = "Confirmar contraseña";
            // 
            // ConfirmPasswordBox
            // 
            this.ConfirmPasswordBox.Location = new System.Drawing.Point(3, 94);
            this.ConfirmPasswordBox.MaxLength = 16;
            this.ConfirmPasswordBox.Name = "ConfirmPasswordBox";
            this.ConfirmPasswordBox.PasswordChar = '•';
            this.ConfirmPasswordBox.Size = new System.Drawing.Size(168, 20);
            this.ConfirmPasswordBox.TabIndex = 5;
            this.ConfirmPasswordBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // RankLabel
            // 
            this.RankLabel.AutoSize = true;
            this.RankLabel.Location = new System.Drawing.Point(3, 117);
            this.RankLabel.Name = "RankLabel";
            this.RankLabel.Size = new System.Drawing.Size(52, 13);
            this.RankLabel.TabIndex = 6;
            this.RankLabel.Text = "Autoridad";
            // 
            // RankBox
            // 
            this.RankBox.FormattingEnabled = true;
            this.RankBox.Location = new System.Drawing.Point(3, 133);
            this.RankBox.Name = "RankBox";
            this.RankBox.Size = new System.Drawing.Size(168, 21);
            this.RankBox.TabIndex = 7;
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(3, 157);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(40, 13);
            this.StateLabel.TabIndex = 8;
            this.StateLabel.Text = "Estado";
            // 
            // StateBox
            // 
            this.StateBox.FormattingEnabled = true;
            this.StateBox.Location = new System.Drawing.Point(3, 173);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(168, 21);
            this.StateBox.TabIndex = 9;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ChangePasswordButton.IconColor = System.Drawing.Color.Black;
            this.ChangePasswordButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ChangePasswordButton.Location = new System.Drawing.Point(3, 200);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(168, 25);
            this.ChangePasswordButton.TabIndex = 10;
            this.ChangePasswordButton.Text = "Cambiar contraseña";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Visible = false;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
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
            this.Title.Size = new System.Drawing.Size(81, 24);
            this.Title.TabIndex = 10;
            this.Title.Text = "Usuario";
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TopPanel.Location = new System.Drawing.Point(192, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(608, 64);
            this.TopPanel.TabIndex = 0;
            // 
            // Content
            // 
            this.Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Content.BackColor = System.Drawing.SystemColors.Control;
            this.Content.Controls.Add(this.DataGrid);
            this.Content.Location = new System.Drawing.Point(198, 70);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(590, 368);
            this.Content.TabIndex = 1;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AllowUserToOrderColumns = true;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selection,
            this.UserValue,
            this.UserName,
            this.Rank,
            this.State});
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(590, 368);
            this.DataGrid.TabIndex = 0;
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
            // UserValue
            // 
            this.UserValue.HeaderText = "UserValue";
            this.UserValue.Name = "UserValue";
            this.UserValue.ReadOnly = true;
            this.UserValue.Visible = false;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Usuario";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Rank
            // 
            this.Rank.HeaderText = "Autoridad";
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            this.Rank.Width = 116;
            // 
            // State
            // 
            this.State.HeaderText = "Estado de activación";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 150;
            // 
            // UserManagementModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "UserManagementModule";
            this.Text = "Gestión de Usuarios";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.FlowPanel.ResumeLayout(false);
            this.FlowPanel.PerformLayout();
            this.Content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox ConfirmPasswordBox;
        private System.Windows.Forms.Label ConfirmPassworLabel;
        private System.Windows.Forms.Label RankLabel;
        private System.Windows.Forms.ComboBox RankBox;
        private System.Windows.Forms.ComboBox StateBox;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label Title;
        private FontAwesome.Sharp.IconButton CreateButton;
        private FontAwesome.Sharp.IconButton EditButton;
        private FontAwesome.Sharp.IconButton EraseButton;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
        private FontAwesome.Sharp.IconButton ChangePasswordButton;
    }
}