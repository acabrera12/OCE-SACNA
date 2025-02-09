
namespace OCESACNA.View.Module
{
    partial class ManageScoresModule
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
            this.MainContainer = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchByBox = new System.Windows.Forms.ComboBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.CourseBox = new System.Windows.Forms.ComboBox();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.LapseBox = new System.Windows.Forms.ComboBox();
            this.LapseLabel = new System.Windows.Forms.Label();
            this.ScoreValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainContainer.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainContainer
            // 
            this.MainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainContainer.Controls.Add(this.TopPanel);
            this.MainContainer.Controls.Add(this.DataGrid);
            this.MainContainer.Location = new System.Drawing.Point(12, 12);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(776, 426);
            this.MainContainer.TabIndex = 6;
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.Color.White;
            this.TopPanel.Controls.Add(this.SearchLabel);
            this.TopPanel.Controls.Add(this.LapseLabel);
            this.TopPanel.Controls.Add(this.CourseLabel);
            this.TopPanel.Controls.Add(this.SearchByBox);
            this.TopPanel.Controls.Add(this.LapseBox);
            this.TopPanel.Controls.Add(this.SearchBox);
            this.TopPanel.Controls.Add(this.CourseBox);
            this.TopPanel.Location = new System.Drawing.Point(3, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(770, 48);
            this.TopPanel.TabIndex = 2;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(276, 8);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(58, 13);
            this.SearchLabel.TabIndex = 14;
            this.SearchLabel.Text = "Buscar por";
            // 
            // SearchByBox
            // 
            this.SearchByBox.FormattingEnabled = true;
            this.SearchByBox.Location = new System.Drawing.Point(279, 23);
            this.SearchByBox.Name = "SearchByBox";
            this.SearchByBox.Size = new System.Drawing.Size(138, 21);
            this.SearchByBox.TabIndex = 14;
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Location = new System.Drawing.Point(423, 23);
            this.SearchBox.MaxLength = 255;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(344, 20);
            this.SearchBox.TabIndex = 14;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScoreValue,
            this.StudentName});
            this.DataGrid.Location = new System.Drawing.Point(3, 57);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(770, 366);
            this.DataGrid.TabIndex = 1;
            // 
            // CourseBox
            // 
            this.CourseBox.FormattingEnabled = true;
            this.CourseBox.Location = new System.Drawing.Point(3, 23);
            this.CourseBox.Name = "CourseBox";
            this.CourseBox.Size = new System.Drawing.Size(148, 21);
            this.CourseBox.TabIndex = 15;
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(3, 8);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(34, 13);
            this.CourseLabel.TabIndex = 16;
            this.CourseLabel.Text = "Curso";
            // 
            // LapseBox
            // 
            this.LapseBox.FormattingEnabled = true;
            this.LapseBox.Location = new System.Drawing.Point(157, 23);
            this.LapseBox.Name = "LapseBox";
            this.LapseBox.Size = new System.Drawing.Size(116, 21);
            this.LapseBox.TabIndex = 15;
            // 
            // LapseLabel
            // 
            this.LapseLabel.AutoSize = true;
            this.LapseLabel.Location = new System.Drawing.Point(154, 8);
            this.LapseLabel.Name = "LapseLabel";
            this.LapseLabel.Size = new System.Drawing.Size(36, 13);
            this.LapseLabel.TabIndex = 16;
            this.LapseLabel.Text = "Lapso";
            // 
            // ScoreValue
            // 
            this.ScoreValue.HeaderText = "ScoreValue";
            this.ScoreValue.Name = "ScoreValue";
            this.ScoreValue.Visible = false;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Estudiante";
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 150;
            // 
            // ManageScoresModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainContainer);
            this.Name = "ManageScoresModule";
            this.Text = "Sábana de Notas";
            this.Load += new System.EventHandler(this.ManageScoresModule_Load);
            this.MainContainer.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainContainer;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.ComboBox SearchByBox;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.ComboBox CourseBox;
        private System.Windows.Forms.Label LapseLabel;
        private System.Windows.Forms.ComboBox LapseBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
    }
}