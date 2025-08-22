using System.Windows.Forms;
using OCESACNA.View.Collections;
using OCESACNA.Controller;
using System;

namespace OCESACNA.View.Module
{
    public partial class SubjectModuleManagementModule : Form, IColoreable, IModule
    {
        public bool IsEditing { get; set; } = false;

        public int SelectedIndex { get; set; } = -1;

        /// <summary>
        /// Obtiene o establece el área de formación seleccionado
        /// </summary>
        private SubjectModule SelectedSubjectModule { get; set; }

        public SubjectModuleManagementModule()
        {
            InitializeComponent();
            ApplyTheme(Program.CurrentTheme);
            LoadData();

            ColorTheme.ThemeChanged += ColorTheme_ThemeChanged;
            Program.CurrentTheme.DarkModeChanged += ColorTheme_DarkModeChanged;
            DataController.SubjectModuleDataModified += LoadData;
        }

        public void ApplyTheme(ColorTheme theme)
        {
            // this
            theme.ApplyBackgroundStyle(this);

            // fore panels
            theme.ApplyForeStyle(LeftPanel, TopPanel);

            // buttons
            theme.ApplyButtonStyle(CreateButton, EditButton, EraseButton);
        }

        public void ColorTheme_DarkModeChanged(bool value)
        {
            ApplyTheme(Program.CurrentTheme);
        }

        public void ColorTheme_ThemeChanged(ColorTheme theme)
        {
            ApplyTheme(theme);
        }

        public void LoadData()
        {
            if (DataGrid.Rows.Count != 0)
            {
                DataGrid.Rows.Clear();
            }

            foreach (SubjectModule subjectModule in DataController.GetAllSubjectModules())
            {
                DataGrid.Rows.Add(new object[]
                {
                    "", subjectModule,
                    subjectModule.Name
                });
            }
        }

        public void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                CreateButton.Enabled = false;

                if (SubjectModuleNameBox.Text == string.Empty)
                {
                    IsEditing = false;
                    CreateButton.Enabled = true;
                }
                return;
            }

            bool textBoxContainsText = SubjectModuleNameBox.Text == string.Empty;

            EraseButton.Enabled = textBoxContainsText;
            EditButton.Enabled = textBoxContainsText;
        }

        public void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid.Columns[e.ColumnIndex].Name != "Selection")
            {
                return;
            }

            int index = e.RowIndex;

            IsEditing = true;
            SelectedIndex = index;
            SelectedSubjectModule = (SubjectModule)DataGrid.Rows[index].Cells["SubjectModuleValue"].Value;

            SubjectModuleNameBox.Text = SelectedSubjectModule.Name;
        }

        public void CreateButton_Click(object sender, EventArgs e)
        {
            if (SubjectModuleNameBox.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Rellene todos los campos primero");
                return;
            }

            SubjectModule subjectModule = new SubjectModule()
            {
                SbjetModuleID = -1,
                Name = SubjectModuleNameBox.Text
            };

            DataController.AddSubjectModule(subjectModule);
            Clear();
        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            if (SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento primero");
                return;
            }

            if (SubjectModuleNameBox.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Rellene todos los campos primero");
                return;
            }

            SubjectModule subjectModule = new SubjectModule()
            {
                SbjetModuleID = SelectedSubjectModule.SbjetModuleID,
                Name = SubjectModuleNameBox.Text
            };

            DataController.UpdateSubjectModule(subjectModule);
            Clear();
        }

        public void EraseButton_Click(object sender, EventArgs e)
        {
            if (SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento primero");
                return;
            }

            var result = MessageBox.Show(
                $"¿Desea eliminar el área de formación?" +
                $"\nEsta acción es inrreversible.",
                "Confirmar acción",
                MessageBoxButtons.YesNo
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            DataController.DeleteSubjectModule(SelectedSubjectModule.SbjetModuleID);
            Clear();
        }

        public void Clear()
        {
            IsEditing = false;
            SelectedIndex = -1;
            SelectedSubjectModule = null;
            SubjectModuleNameBox.Text = string.Empty;
        }
    }
}
