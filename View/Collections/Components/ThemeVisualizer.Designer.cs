
namespace OCESACNA.View.Collections.Components
{
    partial class ThemeVisualizer
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.FontColor = new System.Windows.Forms.Label();
            this.ForePanel = new System.Windows.Forms.Panel();
            this.ForeFontColor = new System.Windows.Forms.Label();
            this.HightlinePanel = new System.Windows.Forms.Panel();
            this.ContrastedFontColor = new System.Windows.Forms.Label();
            this.ForePanel.SuspendLayout();
            this.HightlinePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FontColor
            // 
            this.FontColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FontColor.AutoSize = true;
            this.FontColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontColor.Location = new System.Drawing.Point(172, 121);
            this.FontColor.Name = "FontColor";
            this.FontColor.Size = new System.Drawing.Size(41, 29);
            this.FontColor.TabIndex = 0;
            this.FontColor.Text = "Aa";
            // 
            // ForePanel
            // 
            this.ForePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ForePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ForePanel.Controls.Add(this.ForeFontColor);
            this.ForePanel.Location = new System.Drawing.Point(0, 52);
            this.ForePanel.Name = "ForePanel";
            this.ForePanel.Size = new System.Drawing.Size(98, 98);
            this.ForePanel.TabIndex = 1;
            // 
            // ForeFontColor
            // 
            this.ForeFontColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ForeFontColor.AutoSize = true;
            this.ForeFontColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeFontColor.Location = new System.Drawing.Point(21, 31);
            this.ForeFontColor.Name = "ForeFontColor";
            this.ForeFontColor.Size = new System.Drawing.Size(57, 37);
            this.ForeFontColor.TabIndex = 2;
            this.ForeFontColor.Text = "Aa";
            // 
            // HightlinePanel
            // 
            this.HightlinePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HightlinePanel.BackColor = System.Drawing.Color.MediumPurple;
            this.HightlinePanel.Controls.Add(this.ContrastedFontColor);
            this.HightlinePanel.Location = new System.Drawing.Point(115, 3);
            this.HightlinePanel.Name = "HightlinePanel";
            this.HightlinePanel.Size = new System.Drawing.Size(98, 98);
            this.HightlinePanel.TabIndex = 2;
            // 
            // ContrastedFontColor
            // 
            this.ContrastedFontColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContrastedFontColor.AutoSize = true;
            this.ContrastedFontColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrastedFontColor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ContrastedFontColor.Location = new System.Drawing.Point(21, 31);
            this.ContrastedFontColor.Name = "ContrastedFontColor";
            this.ContrastedFontColor.Size = new System.Drawing.Size(57, 37);
            this.ContrastedFontColor.TabIndex = 2;
            this.ContrastedFontColor.Text = "Aa";
            // 
            // ThemeVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HightlinePanel);
            this.Controls.Add(this.ForePanel);
            this.Controls.Add(this.FontColor);
            this.Name = "ThemeVisualizer";
            this.Size = new System.Drawing.Size(216, 150);
            this.ForePanel.ResumeLayout(false);
            this.ForePanel.PerformLayout();
            this.HightlinePanel.ResumeLayout(false);
            this.HightlinePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FontColor;
        private System.Windows.Forms.Panel ForePanel;
        private System.Windows.Forms.Label ForeFontColor;
        private System.Windows.Forms.Panel HightlinePanel;
        private System.Windows.Forms.Label ContrastedFontColor;
    }
}
