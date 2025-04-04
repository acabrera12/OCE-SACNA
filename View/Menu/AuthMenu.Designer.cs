
namespace OCESACNA.View.Menu
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
            this.components = new System.ComponentModel.Container();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.KeyIcon = new FontAwesome.Sharp.IconPictureBox();
            this.TopTitleLabel = new System.Windows.Forms.Label();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.AceptBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordWarningIcon = new FontAwesome.Sharp.IconPictureBox();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordWarningIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.LeftPanel.Controls.Add(this.KeyIcon);
            this.LeftPanel.Controls.Add(this.TopTitleLabel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(148, 248);
            this.LeftPanel.TabIndex = 0;
            // 
            // KeyIcon
            // 
            this.KeyIcon.BackColor = System.Drawing.Color.MediumPurple;
            this.KeyIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyIcon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.KeyIcon.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.KeyIcon.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.KeyIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.KeyIcon.IconSize = 148;
            this.KeyIcon.Location = new System.Drawing.Point(0, 32);
            this.KeyIcon.Name = "KeyIcon";
            this.KeyIcon.Size = new System.Drawing.Size(148, 216);
            this.KeyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.KeyIcon.TabIndex = 1;
            this.KeyIcon.TabStop = false;
            // 
            // TopTitleLabel
            // 
            this.TopTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopTitleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TopTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TopTitleLabel.Name = "TopTitleLabel";
            this.TopTitleLabel.Size = new System.Drawing.Size(148, 32);
            this.TopTitleLabel.TabIndex = 0;
            this.TopTitleLabel.Text = "Menú de Autenticación";
            this.TopTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(154, 101);
            this.UsernameBox.MaxLength = 16;
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(223, 20);
            this.UsernameBox.TabIndex = 2;
            this.MainToolTip.SetToolTip(this.UsernameBox, "Nombre de usuario(Campo)");
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(154, 140);
            this.PasswordBox.MaxLength = 16;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '•';
            this.PasswordBox.Size = new System.Drawing.Size(223, 20);
            this.PasswordBox.TabIndex = 4;
            this.MainToolTip.SetToolTip(this.PasswordBox, "Contraseña(Campo)");
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // AceptBtn
            // 
            this.AceptBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.AceptBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.AceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AceptBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AceptBtn.Location = new System.Drawing.Point(154, 194);
            this.AceptBtn.Name = "AceptBtn";
            this.AceptBtn.Size = new System.Drawing.Size(114, 42);
            this.AceptBtn.TabIndex = 5;
            this.AceptBtn.Text = "Aceptar";
            this.MainToolTip.SetToolTip(this.AceptBtn, "Botón de aceptar");
            this.AceptBtn.UseVisualStyleBackColor = false;
            this.AceptBtn.Click += new System.EventHandler(this.AceptBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.SystemColors.Control;
            this.CancelBtn.Location = new System.Drawing.Point(275, 194);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(102, 42);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancelar";
            this.MainToolTip.SetToolTip(this.CancelBtn, "Botón de cancelar");
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(151, 85);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(43, 13);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Usuario";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(151, 124);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(61, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Contraseña";
            // 
            // PasswordWarningIcon
            // 
            this.PasswordWarningIcon.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordWarningIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordWarningIcon.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.PasswordWarningIcon.IconColor = System.Drawing.SystemColors.ControlText;
            this.PasswordWarningIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PasswordWarningIcon.IconSize = 19;
            this.PasswordWarningIcon.Location = new System.Drawing.Point(358, 121);
            this.PasswordWarningIcon.Name = "PasswordWarningIcon";
            this.PasswordWarningIcon.Size = new System.Drawing.Size(19, 19);
            this.PasswordWarningIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PasswordWarningIcon.TabIndex = 7;
            this.PasswordWarningIcon.TabStop = false;
            this.MainToolTip.SetToolTip(this.PasswordWarningIcon, "La contraseña proporcionada no está en el formato admitido");
            this.PasswordWarningIcon.Visible = false;
            // 
            // AuthMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(389, 248);
            this.Controls.Add(this.PasswordWarningIcon);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AceptBtn);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú de Autenticación";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthMenu_FormClosing);
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeyIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordWarningIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label TopTitleLabel;
        private FontAwesome.Sharp.IconPictureBox KeyIcon;
        private System.Windows.Forms.ToolTip MainToolTip;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button AceptBtn;
        private System.Windows.Forms.Button CancelBtn;
        private FontAwesome.Sharp.IconPictureBox PasswordWarningIcon;
    }
}