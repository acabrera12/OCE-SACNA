namespace OCESACNA.View.Menu
{
    partial class HandlerMenu
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
            this.infoPanel = new System.Windows.Forms.Panel();
            this.errLabel = new System.Windows.Forms.Label();
            this.exceptionLabel = new System.Windows.Forms.Label();
            this.exceptionDetails = new System.Windows.Forms.RichTextBox();
            this.settingsGroup = new System.Windows.Forms.GroupBox();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.exitOnCloseBtton = new System.Windows.Forms.CheckBox();
            this.infoPanel.SuspendLayout();
            this.actionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.exceptionDetails);
            this.infoPanel.Controls.Add(this.exceptionLabel);
            this.infoPanel.Controls.Add(this.errLabel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(231, 377);
            this.infoPanel.TabIndex = 0;
            // 
            // errLabel
            // 
            this.errLabel.AutoSize = true;
            this.errLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLabel.Location = new System.Drawing.Point(12, 9);
            this.errLabel.Name = "errLabel";
            this.errLabel.Size = new System.Drawing.Size(49, 20);
            this.errLabel.TabIndex = 0;
            this.errLabel.Text = "Error";
            // 
            // exceptionLabel
            // 
            this.exceptionLabel.AutoSize = true;
            this.exceptionLabel.Location = new System.Drawing.Point(13, 29);
            this.exceptionLabel.Name = "exceptionLabel";
            this.exceptionLabel.Size = new System.Drawing.Size(53, 13);
            this.exceptionLabel.TabIndex = 1;
            this.exceptionLabel.Text = "exception";
            // 
            // exceptionDetails
            // 
            this.exceptionDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.exceptionDetails.Location = new System.Drawing.Point(12, 45);
            this.exceptionDetails.Name = "exceptionDetails";
            this.exceptionDetails.ReadOnly = true;
            this.exceptionDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.exceptionDetails.Size = new System.Drawing.Size(213, 320);
            this.exceptionDetails.TabIndex = 2;
            this.exceptionDetails.Text = "";
            // 
            // settingsGroup
            // 
            this.settingsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsGroup.Location = new System.Drawing.Point(6, 32);
            this.settingsGroup.Name = "settingsGroup";
            this.settingsGroup.Size = new System.Drawing.Size(291, 100);
            this.settingsGroup.TabIndex = 0;
            this.settingsGroup.TabStop = false;
            this.settingsGroup.Text = "Configuración";
            // 
            // actionsPanel
            // 
            this.actionsPanel.Controls.Add(this.exitOnCloseBtton);
            this.actionsPanel.Controls.Add(this.settingsGroup);
            this.actionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionsPanel.Location = new System.Drawing.Point(231, 0);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(309, 377);
            this.actionsPanel.TabIndex = 2;
            // 
            // exitOnCloseBtton
            // 
            this.exitOnCloseBtton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitOnCloseBtton.AutoSize = true;
            this.exitOnCloseBtton.Location = new System.Drawing.Point(210, 9);
            this.exitOnCloseBtton.Name = "exitOnCloseBtton";
            this.exitOnCloseBtton.Size = new System.Drawing.Size(87, 17);
            this.exitOnCloseBtton.TabIndex = 1;
            this.exitOnCloseBtton.Text = "Salir al cerrar";
            this.exitOnCloseBtton.UseVisualStyleBackColor = true;
            // 
            // HandlerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 377);
            this.Controls.Add(this.actionsPanel);
            this.Controls.Add(this.infoPanel);
            this.Name = "HandlerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soporte de SACNA";
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.actionsPanel.ResumeLayout(false);
            this.actionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label errLabel;
        private System.Windows.Forms.Label exceptionLabel;
        private System.Windows.Forms.RichTextBox exceptionDetails;
        private System.Windows.Forms.GroupBox settingsGroup;
        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.CheckBox exitOnCloseBtton;
    }
}