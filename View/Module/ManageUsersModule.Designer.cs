
namespace OCESACNA.View.Module
{
    partial class ManageUsersModule
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
            this.ConfirnPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirnPasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateBtn = new FontAwesome.Sharp.IconButton();
            this.EditBtn = new FontAwesome.Sharp.IconButton();
            this.EraseBtn = new FontAwesome.Sharp.IconButton();
            this.StateLabel = new System.Windows.Forms.Label();
            this.RankLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.StateBox = new System.Windows.Forms.ComboBox();
            this.RankBox = new System.Windows.Forms.ComboBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchByBox = new System.Windows.Forms.ComboBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.MainContainer = new System.Windows.Forms.Panel();
            this.Selection = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.White;
            this.LeftPanel.Controls.Add(this.ConfirnPasswordLabel);
            this.LeftPanel.Controls.Add(this.ConfirnPasswordBox);
            this.LeftPanel.Controls.Add(this.label1);
            this.LeftPanel.Controls.Add(this.CreateBtn);
            this.LeftPanel.Controls.Add(this.EditBtn);
            this.LeftPanel.Controls.Add(this.EraseBtn);
            this.LeftPanel.Controls.Add(this.StateLabel);
            this.LeftPanel.Controls.Add(this.RankLabel);
            this.LeftPanel.Controls.Add(this.PasswordLabel);
            this.LeftPanel.Controls.Add(this.UserNameLabel);
            this.LeftPanel.Controls.Add(this.StateBox);
            this.LeftPanel.Controls.Add(this.RankBox);
            this.LeftPanel.Controls.Add(this.PasswordBox);
            this.LeftPanel.Controls.Add(this.UserNameBox);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(200, 450);
            this.LeftPanel.TabIndex = 0;
            // 
            // ConfirnPasswordLabel
            // 
            this.ConfirnPasswordLabel.AutoSize = true;
            this.ConfirnPasswordLabel.Location = new System.Drawing.Point(12, 112);
            this.ConfirnPasswordLabel.Name = "ConfirnPasswordLabel";
            this.ConfirnPasswordLabel.Size = new System.Drawing.Size(108, 13);
            this.ConfirnPasswordLabel.TabIndex = 13;
            this.ConfirnPasswordLabel.Text = "Confirmar Contraseña";
            // 
            // ConfirnPasswordBox
            // 
            this.ConfirnPasswordBox.Location = new System.Drawing.Point(12, 128);
            this.ConfirnPasswordBox.MaxLength = 16;
            this.ConfirnPasswordBox.Name = "ConfirnPasswordBox";
            this.ConfirnPasswordBox.PasswordChar = '•';
            this.ConfirnPasswordBox.Size = new System.Drawing.Size(176, 20);
            this.ConfirnPasswordBox.TabIndex = 12;
            this.ConfirnPasswordBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usuario";
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
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(12, 191);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(40, 13);
            this.StateLabel.TabIndex = 7;
            this.StateLabel.Text = "Estado";
            // 
            // RankLabel
            // 
            this.RankLabel.AutoSize = true;
            this.RankLabel.Location = new System.Drawing.Point(12, 151);
            this.RankLabel.Name = "RankLabel";
            this.RankLabel.Size = new System.Drawing.Size(52, 13);
            this.RankLabel.TabIndex = 6;
            this.RankLabel.Text = "Autoridad";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 73);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(61, 13);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Contraseña";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(12, 34);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(98, 13);
            this.UserNameLabel.TabIndex = 4;
            this.UserNameLabel.Text = "Nombre de Usuario";
            // 
            // StateBox
            // 
            this.StateBox.FormattingEnabled = true;
            this.StateBox.Location = new System.Drawing.Point(12, 207);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(176, 21);
            this.StateBox.TabIndex = 3;
            // 
            // RankBox
            // 
            this.RankBox.FormattingEnabled = true;
            this.RankBox.Location = new System.Drawing.Point(12, 167);
            this.RankBox.Name = "RankBox";
            this.RankBox.Size = new System.Drawing.Size(176, 21);
            this.RankBox.TabIndex = 2;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(12, 89);
            this.PasswordBox.MaxLength = 16;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(176, 20);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(12, 50);
            this.UserNameBox.MaxLength = 16;
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(176, 20);
            this.UserNameBox.TabIndex = 0;
            this.UserNameBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
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
            this.UserName,
            this.Password,
            this.RankValue,
            this.Rank,
            this.StateValue,
            this.State});
            this.DataGrid.Location = new System.Drawing.Point(3, 41);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(576, 382);
            this.DataGrid.TabIndex = 1;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
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
            this.MainContainer.TabIndex = 3;
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
            // UserName
            // 
            this.UserName.HeaderText = "Nombre de Usuario";
            this.UserName.MaxInputLength = 16;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 150;
            // 
            // Password
            // 
            this.Password.HeaderText = "Contraseña";
            this.Password.MaxInputLength = 16;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // RankValue
            // 
            this.RankValue.HeaderText = "RankValue";
            this.RankValue.Name = "RankValue";
            this.RankValue.ReadOnly = true;
            this.RankValue.Visible = false;
            // 
            // Rank
            // 
            this.Rank.HeaderText = "Autoridad";
            this.Rank.MaxInputLength = 32;
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            // 
            // StateValue
            // 
            this.StateValue.HeaderText = "StateValue";
            this.StateValue.Name = "StateValue";
            this.StateValue.ReadOnly = true;
            this.StateValue.Visible = false;
            // 
            // State
            // 
            this.State.HeaderText = "Estado";
            this.State.MaxInputLength = 32;
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // ManageUsersModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.LeftPanel);
            this.Name = "ManageUsersModule";
            this.Text = "ManageUsersModule";
            this.Load += new System.EventHandler(this.ManageUsersModule_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel MainContainer;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.ComboBox RankBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.ComboBox StateBox;
        private System.Windows.Forms.Label RankLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label StateLabel;
        private FontAwesome.Sharp.IconButton EraseBtn;
        private FontAwesome.Sharp.IconButton EditBtn;
        private FontAwesome.Sharp.IconButton CreateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ConfirnPasswordLabel;
        private System.Windows.Forms.TextBox ConfirnPasswordBox;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.ComboBox SearchByBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.DataGridViewButtonColumn Selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
    }
}