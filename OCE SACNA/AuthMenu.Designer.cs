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
            panel1 = new Panel();
            label1 = new Label();
            LogginBtn = new FontAwesome.Sharp.IconButton();
            UsernameBox = new TextBox();
            label2 = new Label();
            PasswordBox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 247);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(147, 9);
            label1.Name = "label1";
            label1.Size = new Size(281, 37);
            label1.TabIndex = 2;
            label1.Text = "Menú de Autenticación";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LogginBtn
            // 
            LogginBtn.IconChar = FontAwesome.Sharp.IconChar.Key;
            LogginBtn.IconColor = Color.Black;
            LogginBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LogginBtn.IconSize = 16;
            LogginBtn.ImageAlign = ContentAlignment.MiddleRight;
            LogginBtn.Location = new Point(147, 212);
            LogginBtn.Name = "LogginBtn";
            LogginBtn.Size = new Size(281, 23);
            LogginBtn.TabIndex = 3;
            LogginBtn.Text = "Iniciar Sesión";
            LogginBtn.UseVisualStyleBackColor = true;
            LogginBtn.Click += LogginBtn_Click;
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(147, 115);
            UsernameBox.MaxLength = 16;
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(281, 23);
            UsernameBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 97);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 5;
            label2.Text = "Usuario";
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(147, 159);
            PasswordBox.MaxLength = 16;
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '·';
            PasswordBox.Size = new Size(281, 23);
            PasswordBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 141);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // AuthMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 247);
            Controls.Add(label3);
            Controls.Add(PasswordBox);
            Controls.Add(label2);
            Controls.Add(UsernameBox);
            Controls.Add(LogginBtn);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AuthMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AuthMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconButton LogginBtn;
        private TextBox UsernameBox;
        private Label label2;
        private TextBox PasswordBox;
        private Label label3;
    }
}