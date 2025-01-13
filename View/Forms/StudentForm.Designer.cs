
namespace OCESACNA.View.Forms
{
    partial class StudentForm
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
            this.AceptBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CedulaBox = new System.Windows.Forms.TextBox();
            this.CedulaLabel = new System.Windows.Forms.Label();
            this.LastNamesLabel = new System.Windows.Forms.Label();
            this.LastNamesBox = new System.Windows.Forms.TextBox();
            this.FirstNamesBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.AgeBox = new System.Windows.Forms.NumericUpDown();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.SexBox = new System.Windows.Forms.ComboBox();
            this.SexLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AgeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AceptBtn
            // 
            this.AceptBtn.Location = new System.Drawing.Point(386, 424);
            this.AceptBtn.Name = "AceptBtn";
            this.AceptBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptBtn.TabIndex = 0;
            this.AceptBtn.Text = "Aceptar";
            this.AceptBtn.UseVisualStyleBackColor = true;
            this.AceptBtn.Click += new System.EventHandler(this.AceptBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(305, 424);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancelar";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CedulaBox
            // 
            this.CedulaBox.Location = new System.Drawing.Point(12, 25);
            this.CedulaBox.MaxLength = 16;
            this.CedulaBox.Name = "CedulaBox";
            this.CedulaBox.Size = new System.Drawing.Size(100, 20);
            this.CedulaBox.TabIndex = 2;
            // 
            // CedulaLabel
            // 
            this.CedulaLabel.AutoSize = true;
            this.CedulaLabel.Location = new System.Drawing.Point(12, 9);
            this.CedulaLabel.Name = "CedulaLabel";
            this.CedulaLabel.Size = new System.Drawing.Size(40, 13);
            this.CedulaLabel.TabIndex = 3;
            this.CedulaLabel.Text = "Cédula";
            // 
            // LastNamesLabel
            // 
            this.LastNamesLabel.AutoSize = true;
            this.LastNamesLabel.Location = new System.Drawing.Point(115, 9);
            this.LastNamesLabel.Name = "LastNamesLabel";
            this.LastNamesLabel.Size = new System.Drawing.Size(49, 13);
            this.LastNamesLabel.TabIndex = 5;
            this.LastNamesLabel.Text = "Apellidos";
            // 
            // LastNamesBox
            // 
            this.LastNamesBox.Location = new System.Drawing.Point(118, 25);
            this.LastNamesBox.MaxLength = 100;
            this.LastNamesBox.Name = "LastNamesBox";
            this.LastNamesBox.Size = new System.Drawing.Size(168, 20);
            this.LastNamesBox.TabIndex = 4;
            // 
            // FirstNamesBox
            // 
            this.FirstNamesBox.Location = new System.Drawing.Point(292, 25);
            this.FirstNamesBox.MaxLength = 100;
            this.FirstNamesBox.Name = "FirstNamesBox";
            this.FirstNamesBox.Size = new System.Drawing.Size(169, 20);
            this.FirstNamesBox.TabIndex = 4;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(289, 9);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(49, 13);
            this.FirstNameLabel.TabIndex = 5;
            this.FirstNameLabel.Text = "Nombres";
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(12, 64);
            this.AgeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(100, 20);
            this.AgeBox.TabIndex = 6;
            this.AgeBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(12, 48);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(32, 13);
            this.AgeLabel.TabIndex = 7;
            this.AgeLabel.Text = "Edad";
            // 
            // SexBox
            // 
            this.SexBox.FormattingEnabled = true;
            this.SexBox.Location = new System.Drawing.Point(118, 64);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(46, 21);
            this.SexBox.TabIndex = 8;
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Location = new System.Drawing.Point(115, 48);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(31, 13);
            this.SexLabel.TabIndex = 9;
            this.SexLabel.Text = "Sexo";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.SexBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.LastNamesLabel);
            this.Controls.Add(this.FirstNamesBox);
            this.Controls.Add(this.LastNamesBox);
            this.Controls.Add(this.CedulaLabel);
            this.Controls.Add(this.CedulaBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AceptBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.AgeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AceptBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox CedulaBox;
        private System.Windows.Forms.Label CedulaLabel;
        private System.Windows.Forms.Label LastNamesLabel;
        private System.Windows.Forms.TextBox LastNamesBox;
        private System.Windows.Forms.TextBox FirstNamesBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.NumericUpDown AgeBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.ComboBox SexBox;
        private System.Windows.Forms.Label SexLabel;
    }
}