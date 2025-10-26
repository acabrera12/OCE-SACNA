
namespace OCESACNA.View.Forms
{
    partial class SelectCourseForm
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
            this.AbortButton = new System.Windows.Forms.Button();
            this.AceptButton = new System.Windows.Forms.Button();
            this.SelectBox = new System.Windows.Forms.TextBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Selection = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CourseValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseGuideName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AbortButton
            // 
            this.AbortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AbortButton.Location = new System.Drawing.Point(161, 196);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(143, 23);
            this.AbortButton.TabIndex = 9;
            this.AbortButton.Text = "Cancelar";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // AceptButton
            // 
            this.AceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AceptButton.Location = new System.Drawing.Point(12, 196);
            this.AceptButton.Name = "AceptButton";
            this.AceptButton.Size = new System.Drawing.Size(143, 23);
            this.AceptButton.TabIndex = 8;
            this.AceptButton.Text = "Aceptar";
            this.AceptButton.UseVisualStyleBackColor = true;
            this.AceptButton.Click += new System.EventHandler(this.AceptButton_Click);
            // 
            // SelectBox
            // 
            this.SelectBox.Enabled = false;
            this.SelectBox.Location = new System.Drawing.Point(12, 12);
            this.SelectBox.Name = "SelectBox";
            this.SelectBox.Size = new System.Drawing.Size(292, 20);
            this.SelectBox.TabIndex = 10;
            this.SelectBox.Text = "Selecionar";
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selection,
            this.CourseValue,
            this.CourseName,
            this.CourseGuideName});
            this.DataGrid.Location = new System.Drawing.Point(12, 39);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(292, 152);
            this.DataGrid.TabIndex = 11;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            // 
            // Selection
            // 
            this.Selection.HeaderText = "";
            this.Selection.Name = "Selection";
            this.Selection.ReadOnly = true;
            this.Selection.Width = 30;
            // 
            // CourseValue
            // 
            this.CourseValue.HeaderText = "CourseValue";
            this.CourseValue.Name = "CourseValue";
            this.CourseValue.ReadOnly = true;
            this.CourseValue.Visible = false;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Curso";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // CourseGuideName
            // 
            this.CourseGuideName.HeaderText = "Docente guía";
            this.CourseGuideName.Name = "CourseGuideName";
            this.CourseGuideName.ReadOnly = true;
            // 
            // SelectCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 231);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.SelectBox);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.AceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SelectCourseForm";
            this.Text = "Seleccionar curso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectCourseForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.Button AceptButton;
        private System.Windows.Forms.TextBox SelectBox;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseGuideName;
    }
}