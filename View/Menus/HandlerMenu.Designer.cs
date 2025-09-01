
namespace OCESACNA.View.Menus
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
            this.switchButton2 = new OCESACNA.Model.Components.SwitchButton();
            this.SuspendLayout();
            // 
            // switchButton2
            // 
            this.switchButton2.AutoSize = true;
            this.switchButton2.Location = new System.Drawing.Point(52, 56);
            this.switchButton2.Name = "switchButton2";
            this.switchButton2.Size = new System.Drawing.Size(93, 17);
            this.switchButton2.TabIndex = 1;
            this.switchButton2.Text = "switchButton2";
            this.switchButton2.UseVisualStyleBackColor = true;
            // 
            // HandlerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.switchButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HandlerMenu";
            this.Text = "HandlerMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Model.Components.SwitchButton switchButton2;
    }
}