
namespace OCESACNA.View.Forms
{
    partial class ChangeUserPasswordForm
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
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordBox = new System.Windows.Forms.TextBox();
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.OldPasswordBox = new System.Windows.Forms.TextBox();
            this.NewPassworLabel = new System.Windows.Forms.Label();
            this.NewPasswordBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ShowPasswordBox = new System.Windows.Forms.CheckBox();
            this.AceptButton = new FontAwesome.Sharp.IconButton();
            this.AbortButton = new FontAwesome.Sharp.IconButton();
            this.FlowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(3, 16);
            this.UserNameBox.MaxLength = 16;
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.ReadOnly = true;
            this.UserNameBox.Size = new System.Drawing.Size(200, 20);
            this.UserNameBox.TabIndex = 2;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(3, 117);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(107, 13);
            this.ConfirmPasswordLabel.TabIndex = 7;
            this.ConfirmPasswordLabel.Text = "Confirmar contraseña";
            // 
            // ConfirmPasswordBox
            // 
            this.ConfirmPasswordBox.Location = new System.Drawing.Point(3, 133);
            this.ConfirmPasswordBox.MaxLength = 16;
            this.ConfirmPasswordBox.Name = "ConfirmPasswordBox";
            this.ConfirmPasswordBox.PasswordChar = '•';
            this.ConfirmPasswordBox.Size = new System.Drawing.Size(200, 20);
            this.ConfirmPasswordBox.TabIndex = 8;
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.Location = new System.Drawing.Point(3, 39);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(94, 13);
            this.OldPasswordLabel.TabIndex = 3;
            this.OldPasswordLabel.Text = "Contraseña Actual";
            // 
            // OldPasswordBox
            // 
            this.OldPasswordBox.Location = new System.Drawing.Point(3, 55);
            this.OldPasswordBox.MaxLength = 16;
            this.OldPasswordBox.Name = "OldPasswordBox";
            this.OldPasswordBox.PasswordChar = '•';
            this.OldPasswordBox.Size = new System.Drawing.Size(200, 20);
            this.OldPasswordBox.TabIndex = 4;
            // 
            // NewPassworLabel
            // 
            this.NewPassworLabel.AutoSize = true;
            this.NewPassworLabel.Location = new System.Drawing.Point(3, 78);
            this.NewPassworLabel.Name = "NewPassworLabel";
            this.NewPassworLabel.Size = new System.Drawing.Size(95, 13);
            this.NewPassworLabel.TabIndex = 5;
            this.NewPassworLabel.Text = "Nueva contraseña";
            // 
            // NewPasswordBox
            // 
            this.NewPasswordBox.Location = new System.Drawing.Point(3, 94);
            this.NewPasswordBox.MaxLength = 16;
            this.NewPasswordBox.Name = "NewPasswordBox";
            this.NewPasswordBox.PasswordChar = '•';
            this.NewPasswordBox.Size = new System.Drawing.Size(200, 20);
            this.NewPasswordBox.TabIndex = 6;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(3, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(140, 13);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "Cambio de contraseña para:";
            // 
            // FlowPanel
            // 
            this.FlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowPanel.Controls.Add(this.UserNameLabel);
            this.FlowPanel.Controls.Add(this.UserNameBox);
            this.FlowPanel.Controls.Add(this.OldPasswordLabel);
            this.FlowPanel.Controls.Add(this.OldPasswordBox);
            this.FlowPanel.Controls.Add(this.NewPassworLabel);
            this.FlowPanel.Controls.Add(this.NewPasswordBox);
            this.FlowPanel.Controls.Add(this.ConfirmPasswordLabel);
            this.FlowPanel.Controls.Add(this.ConfirmPasswordBox);
            this.FlowPanel.Controls.Add(this.ShowPasswordBox);
            this.FlowPanel.Location = new System.Drawing.Point(12, 12);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(292, 178);
            this.FlowPanel.TabIndex = 10;
            // 
            // ShowPasswordBox
            // 
            this.ShowPasswordBox.AutoSize = true;
            this.ShowPasswordBox.Location = new System.Drawing.Point(3, 159);
            this.ShowPasswordBox.Name = "ShowPasswordBox";
            this.ShowPasswordBox.Size = new System.Drawing.Size(123, 17);
            this.ShowPasswordBox.TabIndex = 9;
            this.ShowPasswordBox.Text = "Mostrar Contraseñas";
            this.ShowPasswordBox.UseVisualStyleBackColor = true;
            this.ShowPasswordBox.CheckedChanged += new System.EventHandler(this.ShowPasswordBox_CheckedChanged);
            // 
            // AceptButton
            // 
            this.AceptButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AceptButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AceptButton.IconColor = System.Drawing.Color.Black;
            this.AceptButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AceptButton.Location = new System.Drawing.Point(12, 196);
            this.AceptButton.Name = "AceptButton";
            this.AceptButton.Size = new System.Drawing.Size(143, 23);
            this.AceptButton.TabIndex = 1;
            this.AceptButton.Text = "Aceptar";
            this.AceptButton.UseVisualStyleBackColor = true;
            this.AceptButton.Click += new System.EventHandler(this.AceptButton_Click);
            // 
            // AbortButton
            // 
            this.AbortButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AbortButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AbortButton.IconColor = System.Drawing.Color.Black;
            this.AbortButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AbortButton.Location = new System.Drawing.Point(161, 196);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(143, 23);
            this.AbortButton.TabIndex = 12;
            this.AbortButton.Text = "Cancelar";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // ChangeUserPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 231);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.AceptButton);
            this.Controls.Add(this.FlowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeUserPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cambiar contraseña";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangeUserPasswordForm_FormClosed);
            this.FlowPanel.ResumeLayout(false);
            this.FlowPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.TextBox ConfirmPasswordBox;
        private System.Windows.Forms.Label OldPasswordLabel;
        private System.Windows.Forms.TextBox OldPasswordBox;
        private System.Windows.Forms.Label NewPassworLabel;
        private System.Windows.Forms.TextBox NewPasswordBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
        private FontAwesome.Sharp.IconButton AceptButton;
        private FontAwesome.Sharp.IconButton AbortButton;
        private System.Windows.Forms.CheckBox ShowPasswordBox;
    }
}