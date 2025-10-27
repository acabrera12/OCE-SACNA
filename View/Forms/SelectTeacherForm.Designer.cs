
namespace OCESACNA.View.Forms
{
    partial class SelectTeacherForm
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
            this.AceptButton = new System.Windows.Forms.Button();
            this.AbortButton = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Selection = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TeacherValue = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AceptButton
            // 
            this.AceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AceptButton.Location = new System.Drawing.Point(12, 196);
            this.AceptButton.Name = "AceptButton";
            this.AceptButton.Size = new System.Drawing.Size(143, 23);
            this.AceptButton.TabIndex = 0;
            this.AceptButton.Text = "Aceptar";
            this.AceptButton.UseVisualStyleBackColor = true;
            this.AceptButton.Click += new System.EventHandler(this.AceptButton_Click);
            // 
            // AbortButton
            // 
            this.AbortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AbortButton.Location = new System.Drawing.Point(161, 196);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(143, 23);
            this.AbortButton.TabIndex = 1;
            this.AbortButton.Text = "Cancelar";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selection,
            this.TeacherValue,
            this.TeacherName});
            this.DataGrid.Location = new System.Drawing.Point(12, 38);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(292, 152);
            this.DataGrid.TabIndex = 2;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            // 
            // Selection
            // 
            this.Selection.HeaderText = "";
            this.Selection.Name = "Selection";
            this.Selection.ReadOnly = true;
            this.Selection.Width = 30;
            // 
            // TeacherValue
            // 
            this.TeacherValue.HeaderText = "TeacherValue";
            this.TeacherValue.Name = "TeacherValue";
            this.TeacherValue.ReadOnly = true;
            this.TeacherValue.Visible = false;
            this.TeacherValue.Width = 50;
            // 
            // TeacherName
            // 
            this.TeacherName.HeaderText = "Nombre";
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            this.TeacherName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TeacherName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TeacherName.Width = 219;
            // 
            // SelectBox
            // 
            this.SelectBox.Enabled = false;
            this.SelectBox.Location = new System.Drawing.Point(12, 12);
            this.SelectBox.Name = "SelectBox";
            this.SelectBox.Size = new System.Drawing.Size(292, 20);
            this.SelectBox.TabIndex = 3;
            this.SelectBox.Text = "Selecionar";
            // 
            // SelectTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 231);
            this.Controls.Add(this.SelectBox);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.AceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectTeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleccionar Docente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectTeacherForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AceptButton;
        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Selection;
        private System.Windows.Forms.DataGridViewButtonColumn TeacherValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.TextBox SelectBox;
    }
}