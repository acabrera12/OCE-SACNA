using OCESACNA.Controller;
using OCESACNA.View.Collections;
using System;
using System.Windows.Forms;

namespace OCESACNA.View.Module
{
    public partial class SubjectModuleManagementModule : Form, IModule
    {
        public bool IsEditing { get; set; } = false;

        public int SelectedIndex { get; set; } = -1;

        /// <summary>
        /// Obtiene o establece el docente seleccionado
        /// </summary>
        private SubjectModule SelectedSubjectMdl { get; set; }

        public SubjectModuleManagementModule()
        {
            InitializeComponent();
            LoadData();

            DataController.SubjectModuleDataModified += () => {
                if (InvokeRequired)
                    Invoke(new Action(() => LoadData()));
            };
        }

        public void LoadData()
        {
            if (DataGrid.Rows.Count != 0)
            {
                DataGrid.Rows.Clear();
            }

            foreach (SubjectModule subjectModule in DataController.GetAllSubjectModules())
            {
                DataGrid.Rows.Add(new object[] { "", subjectModule, subjectModule.Name });
            }
        }

        public void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                CreateButton.Enabled = false;

                if (NameBox.Text.Length == 0)
                {
                    IsEditing = false;
                    CreateButton.Enabled = true;
                }
                return;
            }

            bool textBoxContainsText = NameBox.Text.Length != 0;

            EraseButton.Enabled = !textBoxContainsText;
            EditButton.Enabled = !textBoxContainsText;
        }

        public void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid.Columns[e.ColumnIndex].Name != "Selection")
            {
                return;
            }

            int index = e.RowIndex;

            IsEditing = true;
            SelectedSubjectMdl = (SubjectModule)DataGrid.Rows[index].Cells["SubjectGroupValue"].Value;
            SelectedIndex = index;
            NameBox.Text = SelectedSubjectMdl.Name;
        }

        public void CreateButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text.Replace(" ", "") == string.Empty)
            {
                MessageBox.Show("Rellene todos los campos primero");
                return;
            }

            string name = NameBox.Text;
            DataController.AddSubjectModule(new SubjectModule(-1, name));
            Clear();
        }
    

        public void EditButton_Click(object sender, EventArgs e)
        {
            if (SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento primero.");
                return;
            }

            if (NameBox.Text.Replace(" ", "") == string.Empty)
            {
                MessageBox.Show("Rellene todos los campos primero");
                return;
            }

            string name = NameBox.Text;
            DataController.UpdateSubjectModule(new SubjectModule(SelectedSubjectMdl.SbjetModuleID, name));
            Clear();
        }

        public void EraseButton_Click(object sender, EventArgs e)
        {
            if (SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento primero.");
                return;
            }

            var result = MessageBox.Show(
                "¿Está seguro de eliminar este área de formación?" +
                "\nEsta acción no se puede revertir.",
                "Confirmar acción",
                MessageBoxButtons.YesNo
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            DataController.DeleteSubjectModule(SelectedSubjectMdl.SbjetModuleID);
            Clear();
        }

        public void Clear()
        {
            SelectedSubjectMdl = null;
            SelectedIndex = -1;
            NameBox.Text = string.Empty;
        }
    }
}
