
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
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.SearchByBox = new System.Windows.Forms.ComboBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.ScoreValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstLapse = new OCESACNA.View.Collections.DataGridViewScoreModuleColumn();
            this.SecondLapse = new OCESACNA.View.Collections.DataGridViewScoreModuleColumn();
            this.ThirdLapse = new OCESACNA.View.Collections.DataGridViewScoreModuleColumn();
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
            this.MainContainer.TabIndex = 5;
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.Color.White;
            this.TopPanel.Controls.Add(this.SearchLabel);
            this.TopPanel.Controls.Add(this.SearchByLabel);
            this.TopPanel.Controls.Add(this.SearchByBox);
            this.TopPanel.Controls.Add(this.SearchBox);
            this.TopPanel.Location = new System.Drawing.Point(3, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(770, 48);
            this.TopPanel.TabIndex = 2;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(595, 9);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(40, 13);
            this.SearchLabel.TabIndex = 14;
            this.SearchLabel.Text = "Buscar";
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.AutoSize = true;
            this.SearchByLabel.Location = new System.Drawing.Point(451, 9);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(58, 13);
            this.SearchByLabel.TabIndex = 14;
            this.SearchByLabel.Text = "Buscar por";
            // 
            // SearchByBox
            // 
            this.SearchByBox.FormattingEnabled = true;
            this.SearchByBox.Location = new System.Drawing.Point(454, 24);
            this.SearchByBox.Name = "SearchByBox";
            this.SearchByBox.Size = new System.Drawing.Size(138, 21);
            this.SearchByBox.TabIndex = 14;
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Location = new System.Drawing.Point(598, 25);
            this.SearchBox.MaxLength = 255;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(169, 20);
            this.SearchBox.TabIndex = 14;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AllowUserToOrderColumns = true;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScoreValue,
            this.StudentName,
            this.FirstLapse,
            this.SecondLapse,
            this.ThirdLapse});
            this.DataGrid.Location = new System.Drawing.Point(3, 57);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(770, 366);
            this.DataGrid.TabIndex = 1;
            // 
            // ScoreValue
            // 
            this.ScoreValue.Frozen = true;
            this.ScoreValue.HeaderText = "ScoreValue";
            this.ScoreValue.Name = "ScoreValue";
            this.ScoreValue.Visible = false;
            // 
            // StudentName
            // 
            this.StudentName.Frozen = true;
            this.StudentName.HeaderText = "Estudiante";
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 200;
            // 
            // FirstLapse
            // 
            this.FirstLapse.HeaderText = "Primer Lapso";
            this.FirstLapse.Name = "FirstLapse";
            this.FirstLapse.Width = 150;
            // 
            // SecondLapse
            // 
            this.SecondLapse.HeaderText = "Segundo Lapso";
            this.SecondLapse.Name = "SecondLapse";
            this.SecondLapse.Width = 150;
            // 
            // ThirdLapse
            // 
            this.ThirdLapse.HeaderText = "Tercer Lapso";
            this.ThirdLapse.Name = "ThirdLapse";
            this.ThirdLapse.Width = 150;
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
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.ComboBox SearchByBox;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private Collections.DataGridViewScoreModuleColumn FirstLapse;
        private Collections.DataGridViewScoreModuleColumn SecondLapse;
        private Collections.DataGridViewScoreModuleColumn ThirdLapse;
        private System.Windows.Forms.Label SearchLabel;
    }
}