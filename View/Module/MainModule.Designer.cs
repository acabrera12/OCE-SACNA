namespace OCESACNA.View.Module
{
    partial class MainModule
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
            this.UserIcon = new FontAwesome.Sharp.IconPictureBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UserRankLabel = new System.Windows.Forms.Label();
            this.UserInfoPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            this.UserInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Controls.Add(this.UserInfoPanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 64);
            this.TopPanel.TabIndex = 0;
            // 
            // UserIcon
            // 
            this.UserIcon.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserIcon.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.UserIcon.IconColor = System.Drawing.SystemColors.ControlText;
            this.UserIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UserIcon.IconSize = 48;
            this.UserIcon.Location = new System.Drawing.Point(3, 3);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(52, 52);
            this.UserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.UserIcon.TabIndex = 0;
            this.UserIcon.TabStop = false;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(61, 3);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(90, 20);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "{username}";
            // 
            // UserRankLabel
            // 
            this.UserRankLabel.AutoSize = true;
            this.UserRankLabel.Location = new System.Drawing.Point(61, 23);
            this.UserRankLabel.Name = "UserRankLabel";
            this.UserRankLabel.Size = new System.Drawing.Size(36, 13);
            this.UserRankLabel.TabIndex = 2;
            this.UserRankLabel.Text = "{rank}";
            // 
            // UserInfoPanel
            // 
            this.UserInfoPanel.Controls.Add(this.UserIcon);
            this.UserInfoPanel.Controls.Add(this.UserRankLabel);
            this.UserInfoPanel.Controls.Add(this.UsernameLabel);
            this.UserInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.UserInfoPanel.Name = "UserInfoPanel";
            this.UserInfoPanel.Size = new System.Drawing.Size(200, 58);
            this.UserInfoPanel.TabIndex = 3;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.ExitButton.IconColor = System.Drawing.Color.Black;
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitButton.Location = new System.Drawing.Point(739, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(58, 58);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TopPanel);
            this.Name = "MainModule";
            this.Text = "Inicio";
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
            this.UserInfoPanel.ResumeLayout(false);
            this.UserInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private FontAwesome.Sharp.IconPictureBox UserIcon;
        private System.Windows.Forms.Label UserRankLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Panel UserInfoPanel;
        private FontAwesome.Sharp.IconButton ExitButton;
    }
}