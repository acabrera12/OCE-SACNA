namespace OCESACNA.View.Module
{
    partial class SettingsModule
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
            this.SideMenu = new System.Windows.Forms.MenuStrip();
            this.MainSettingsButton = new FontAwesome.Sharp.IconMenuItem();
            this.CustomButton = new FontAwesome.Sharp.IconMenuItem();
            this.ServerSettingsButton = new FontAwesome.Sharp.IconMenuItem();
            this.SideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.GripMargin = new System.Windows.Forms.Padding(2);
            this.SideMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainSettingsButton,
            this.CustomButton,
            this.ServerSettingsButton});
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Padding = new System.Windows.Forms.Padding(0);
            this.SideMenu.Size = new System.Drawing.Size(133, 450);
            this.SideMenu.TabIndex = 2;
            this.SideMenu.Text = "SideMenu";
            // 
            // MainSettingsButton
            // 
            this.MainSettingsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainSettingsButton.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.MainSettingsButton.IconColor = System.Drawing.SystemColors.ControlText;
            this.MainSettingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MainSettingsButton.IconSize = 30;
            this.MainSettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainSettingsButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MainSettingsButton.Name = "MainSettingsButton";
            this.MainSettingsButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.MainSettingsButton.Size = new System.Drawing.Size(132, 44);
            this.MainSettingsButton.Text = "General";
            // 
            // CustomButton
            // 
            this.CustomButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CustomButton.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            this.CustomButton.IconColor = System.Drawing.SystemColors.ControlText;
            this.CustomButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CustomButton.IconSize = 30;
            this.CustomButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CustomButton.Name = "CustomButton";
            this.CustomButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.CustomButton.Size = new System.Drawing.Size(132, 44);
            this.CustomButton.Text = "Personalizar";
            // 
            // ServerSettingsButton
            // 
            this.ServerSettingsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ServerSettingsButton.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.ServerSettingsButton.IconColor = System.Drawing.SystemColors.ControlText;
            this.ServerSettingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ServerSettingsButton.IconSize = 30;
            this.ServerSettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ServerSettingsButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ServerSettingsButton.Name = "ServerSettingsButton";
            this.ServerSettingsButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.ServerSettingsButton.Size = new System.Drawing.Size(132, 44);
            this.ServerSettingsButton.Text = "Base de datos";
            // 
            // SettingsModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SideMenu);
            this.Name = "SettingsModule";
            this.Text = "Configuración";
            this.SideMenu.ResumeLayout(false);
            this.SideMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip SideMenu;
        private FontAwesome.Sharp.IconMenuItem MainSettingsButton;
        private FontAwesome.Sharp.IconMenuItem CustomButton;
        private FontAwesome.Sharp.IconMenuItem ServerSettingsButton;
    }
}