namespace OCE_SACNA
{
    partial class AuthMenu
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
            components = new System.ComponentModel.Container();
            titleLabel = new Label();
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            LoginButton = new FontAwesome.Sharp.IconButton();
            toolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI", 12F);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(512, 64);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Menú de Autenticación";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(156, 190);
            UsernameBox.MaxLength = 16;
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(200, 23);
            UsernameBox.TabIndex = 1;
            toolTip.SetToolTip(UsernameBox, "Compo \"Usuario\"");
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(156, 212);
            PasswordBox.MaxLength = 16;
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(200, 23);
            PasswordBox.TabIndex = 2;
            toolTip.SetToolTip(PasswordBox, "Campo \"Contraseña\"");
            // 
            // LoginButton
            // 
            LoginButton.IconChar = FontAwesome.Sharp.IconChar.Key;
            LoginButton.IconColor = Color.Black;
            LoginButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LoginButton.IconSize = 16;
            LoginButton.ImageAlign = ContentAlignment.MiddleRight;
            LoginButton.Location = new Point(156, 241);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(200, 23);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Iniciar Sesión";
            LoginButton.TextAlign = ContentAlignment.MiddleLeft;
            LoginButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            toolTip.SetToolTip(LoginButton, "Botón para Iniciar Sesión");
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // AuthMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 380);
            ControlBox = false;
            Controls.Add(LoginButton);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AuthMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú de Autenticación";
            Load += AuthMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private FontAwesome.Sharp.IconButton LoginButton;
        private ToolTip toolTip;
    }
}