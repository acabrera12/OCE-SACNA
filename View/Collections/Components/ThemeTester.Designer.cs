
namespace OCESACNA.View.Collections.Components
{
    partial class ThemeTester
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
            this.LightMode = new System.Windows.Forms.Panel();
            this.DarkMode = new System.Windows.Forms.Panel();
            this.FontColor = new System.Windows.Forms.Label();
            this.DarkFontColor = new System.Windows.Forms.Label();
            this.ForeElement = new System.Windows.Forms.Panel();
            this.DarkForeElement = new System.Windows.Forms.Panel();
            this.HightlineElement = new System.Windows.Forms.Panel();
            this.DarkHightlineElement = new System.Windows.Forms.Panel();
            this.ContrastedFontColor = new System.Windows.Forms.Label();
            this.DarkContrastedFontColor = new System.Windows.Forms.Label();
            this.LightButton = new FontAwesome.Sharp.IconButton();
            this.DarkButton = new FontAwesome.Sharp.IconButton();
            this.FlatButtonLight = new FontAwesome.Sharp.IconButton();
            this.DarkFlatButton = new FontAwesome.Sharp.IconButton();
            this.LightMode.SuspendLayout();
            this.DarkMode.SuspendLayout();
            this.HightlineElement.SuspendLayout();
            this.DarkHightlineElement.SuspendLayout();
            this.SuspendLayout();
            // 
            // LightMode
            // 
            this.LightMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LightMode.Controls.Add(this.FlatButtonLight);
            this.LightMode.Controls.Add(this.LightButton);
            this.LightMode.Controls.Add(this.HightlineElement);
            this.LightMode.Controls.Add(this.ForeElement);
            this.LightMode.Controls.Add(this.FontColor);
            this.LightMode.Location = new System.Drawing.Point(0, 0);
            this.LightMode.Name = "LightMode";
            this.LightMode.Size = new System.Drawing.Size(372, 454);
            this.LightMode.TabIndex = 0;
            // 
            // DarkMode
            // 
            this.DarkMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DarkMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.DarkMode.Controls.Add(this.DarkFlatButton);
            this.DarkMode.Controls.Add(this.DarkButton);
            this.DarkMode.Controls.Add(this.DarkHightlineElement);
            this.DarkMode.Controls.Add(this.DarkForeElement);
            this.DarkMode.Controls.Add(this.DarkFontColor);
            this.DarkMode.Location = new System.Drawing.Point(372, 0);
            this.DarkMode.Name = "DarkMode";
            this.DarkMode.Size = new System.Drawing.Size(372, 454);
            this.DarkMode.TabIndex = 1;
            // 
            // FontColor
            // 
            this.FontColor.AutoSize = true;
            this.FontColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontColor.Location = new System.Drawing.Point(300, 410);
            this.FontColor.Name = "FontColor";
            this.FontColor.Size = new System.Drawing.Size(66, 44);
            this.FontColor.TabIndex = 0;
            this.FontColor.Text = "Aa";
            // 
            // DarkFontColor
            // 
            this.DarkFontColor.AutoSize = true;
            this.DarkFontColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DarkFontColor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DarkFontColor.Location = new System.Drawing.Point(303, 410);
            this.DarkFontColor.Name = "DarkFontColor";
            this.DarkFontColor.Size = new System.Drawing.Size(66, 44);
            this.DarkFontColor.TabIndex = 1;
            this.DarkFontColor.Text = "Aa";
            // 
            // ForeElement
            // 
            this.ForeElement.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ForeElement.Location = new System.Drawing.Point(3, 3);
            this.ForeElement.Name = "ForeElement";
            this.ForeElement.Size = new System.Drawing.Size(200, 200);
            this.ForeElement.TabIndex = 1;
            // 
            // DarkForeElement
            // 
            this.DarkForeElement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DarkForeElement.Location = new System.Drawing.Point(3, 3);
            this.DarkForeElement.Name = "DarkForeElement";
            this.DarkForeElement.Size = new System.Drawing.Size(200, 200);
            this.DarkForeElement.TabIndex = 2;
            // 
            // HightlineElement
            // 
            this.HightlineElement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.HightlineElement.Controls.Add(this.ContrastedFontColor);
            this.HightlineElement.Location = new System.Drawing.Point(209, 103);
            this.HightlineElement.Name = "HightlineElement";
            this.HightlineElement.Size = new System.Drawing.Size(100, 100);
            this.HightlineElement.TabIndex = 2;
            // 
            // DarkHightlineElement
            // 
            this.DarkHightlineElement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.DarkHightlineElement.Controls.Add(this.DarkContrastedFontColor);
            this.DarkHightlineElement.Location = new System.Drawing.Point(209, 103);
            this.DarkHightlineElement.Name = "DarkHightlineElement";
            this.DarkHightlineElement.Size = new System.Drawing.Size(100, 100);
            this.DarkHightlineElement.TabIndex = 3;
            // 
            // ContrastedFontColor
            // 
            this.ContrastedFontColor.AutoSize = true;
            this.ContrastedFontColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrastedFontColor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ContrastedFontColor.Location = new System.Drawing.Point(17, 28);
            this.ContrastedFontColor.Name = "ContrastedFontColor";
            this.ContrastedFontColor.Size = new System.Drawing.Size(66, 44);
            this.ContrastedFontColor.TabIndex = 1;
            this.ContrastedFontColor.Text = "Aa";
            // 
            // DarkContrastedFontColor
            // 
            this.DarkContrastedFontColor.AutoSize = true;
            this.DarkContrastedFontColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DarkContrastedFontColor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DarkContrastedFontColor.Location = new System.Drawing.Point(17, 28);
            this.DarkContrastedFontColor.Name = "DarkContrastedFontColor";
            this.DarkContrastedFontColor.Size = new System.Drawing.Size(66, 44);
            this.DarkContrastedFontColor.TabIndex = 2;
            this.DarkContrastedFontColor.Text = "Aa";
            // 
            // LightButton
            // 
            this.LightButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.LightButton.IconColor = System.Drawing.Color.Black;
            this.LightButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LightButton.Location = new System.Drawing.Point(3, 209);
            this.LightButton.Name = "LightButton";
            this.LightButton.Size = new System.Drawing.Size(200, 23);
            this.LightButton.TabIndex = 3;
            this.LightButton.Text = "LightButton";
            this.LightButton.UseVisualStyleBackColor = true;
            // 
            // DarkButton
            // 
            this.DarkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DarkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DarkButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DarkButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DarkButton.IconColor = System.Drawing.Color.Black;
            this.DarkButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DarkButton.Location = new System.Drawing.Point(3, 209);
            this.DarkButton.Name = "DarkButton";
            this.DarkButton.Size = new System.Drawing.Size(200, 23);
            this.DarkButton.TabIndex = 4;
            this.DarkButton.Text = "DarkButton";
            this.DarkButton.UseVisualStyleBackColor = false;
            // 
            // FlatButtonLight
            // 
            this.FlatButtonLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.FlatButtonLight.FlatAppearance.BorderSize = 0;
            this.FlatButtonLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatButtonLight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FlatButtonLight.IconChar = FontAwesome.Sharp.IconChar.None;
            this.FlatButtonLight.IconColor = System.Drawing.Color.Black;
            this.FlatButtonLight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FlatButtonLight.Location = new System.Drawing.Point(209, 74);
            this.FlatButtonLight.Name = "FlatButtonLight";
            this.FlatButtonLight.Size = new System.Drawing.Size(100, 23);
            this.FlatButtonLight.TabIndex = 4;
            this.FlatButtonLight.Text = "HightlineButton";
            this.FlatButtonLight.UseVisualStyleBackColor = false;
            // 
            // DarkFlatButton
            // 
            this.DarkFlatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.DarkFlatButton.FlatAppearance.BorderSize = 0;
            this.DarkFlatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DarkFlatButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DarkFlatButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DarkFlatButton.IconColor = System.Drawing.Color.Black;
            this.DarkFlatButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DarkFlatButton.Location = new System.Drawing.Point(209, 74);
            this.DarkFlatButton.Name = "DarkFlatButton";
            this.DarkFlatButton.Size = new System.Drawing.Size(100, 23);
            this.DarkFlatButton.TabIndex = 5;
            this.DarkFlatButton.Text = "DarkHightlineButton";
            this.DarkFlatButton.UseVisualStyleBackColor = false;
            // 
            // ThemeTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DarkMode);
            this.Controls.Add(this.LightMode);
            this.Name = "ThemeTester";
            this.Size = new System.Drawing.Size(744, 454);
            this.LightMode.ResumeLayout(false);
            this.LightMode.PerformLayout();
            this.DarkMode.ResumeLayout(false);
            this.DarkMode.PerformLayout();
            this.HightlineElement.ResumeLayout(false);
            this.HightlineElement.PerformLayout();
            this.DarkHightlineElement.ResumeLayout(false);
            this.DarkHightlineElement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LightMode;
        private System.Windows.Forms.Panel DarkMode;
        private System.Windows.Forms.Label FontColor;
        private System.Windows.Forms.Label DarkFontColor;
        private System.Windows.Forms.Panel ForeElement;
        private System.Windows.Forms.Panel DarkForeElement;
        private System.Windows.Forms.Panel HightlineElement;
        private System.Windows.Forms.Panel DarkHightlineElement;
        private System.Windows.Forms.Label ContrastedFontColor;
        private System.Windows.Forms.Label DarkContrastedFontColor;
        private FontAwesome.Sharp.IconButton LightButton;
        private FontAwesome.Sharp.IconButton DarkButton;
        private FontAwesome.Sharp.IconButton FlatButtonLight;
        private FontAwesome.Sharp.IconButton DarkFlatButton;
    }
}
