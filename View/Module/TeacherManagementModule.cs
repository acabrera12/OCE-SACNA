using System;
using System.Windows.Forms;
using OCESACNA.Controller;
using OCESACNA.View.Collections;

namespace OCESACNA.View.Module
{
    /// <summary>
    /// Módulo de gestión de docentes
    /// </summary>
    public partial class TeacherManagementModule : Form, IColoreable, IModule
    {
        public bool IsEditing { get; set; } = false;

        public int SelectedIndex { get; set; } = -1;

        /// <summary>
        /// Obtiene o establece el docente seleccionado
        /// </summary>
        private Teacher SelectedTeacher { get; set; }

        /// <summary>
        /// Inicializa una instancia del formulario
        /// </summary>
        public TeacherManagementModule()
        {
            InitializeComponent();
            ApplyTheme(Program.CurrentTheme);
            LoadData();

            ColorTheme.ThemeChanged += ColorTheme_ThemeChanged;
            Program.CurrentTheme.DarkModeChanged += ColorTheme_DarkModeChanged;
            DataController.TeacherDataModified += () => {
                if (InvokeRequired)
                    Invoke(new Action(() => LoadData()));
            };
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

        public void ColorTheme_ThemeChanged(ColorTheme theme)
        {
            ApplyTheme(theme);
        }

        public void ColorTheme_DarkModeChanged(bool value)
        {
            ApplyTheme(Program.CurrentTheme);
        }

        public void LoadData()
        {
            if (DataGrid.Rows.Count != 0)
            {
                DataGrid.Rows.Clear();
            }

            foreach (Teacher teacher in DataController.GetAllTeachers())
            {
                DataGrid.Rows.Add(new object[]
                {
                    "", teacher,
                    teacher.FullName
                });
            }
        }

        public void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                CreateButton.Enabled = false;

                if (FullNameBox.Text.Length == 0)
                {
                    IsEditing = false;
                    CreateButton.Enabled = true;
                }
                return;
            }

            bool textBoxContainsText = FullNameBox.Text.Length != 0;

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
            SelectedTeacher = (Teacher)DataGrid.Rows[index].Cells["TeacherValue"].Value;
            SelectedIndex = index;
            FullNameBox.Text = SelectedTeacher.FullName;
        }

        public void CreateButton_Click(object sender, EventArgs e)
        {
            if (FullNameBox.Text.Replace(" ", "") == string.Empty)
            {
                MessageBox.Show("Rellene todos los campos primero");
                return;
            }

            string fullName = FullNameBox.Text;
            DataController.AddTeacher(new Teacher(-1, fullName));
            Clear();
        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            if (SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento primero.");
                return;
            }

            if (FullNameBox.Text.Replace(" ", "") == string.Empty)
            {
                MessageBox.Show("Rellene todos los campos primero");
                return;
            }

            string fullName = FullNameBox.Text;
            DataController.UpdateTeacher(new Teacher(SelectedTeacher.TeachID, fullName));
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
                "¿Está seguro de eliminar este docente?" +
                "\nEsta acción no se puede revertir.",
                "Confirmar acción",
                MessageBoxButtons.YesNo
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            DataController.DeleteTeacher(SelectedTeacher.TeachID);
            Clear();
        }

        public void Clear()
        {
            SelectedTeacher = null;
            SelectedIndex = -1;
            FullNameBox.Text = string.Empty;
        }
    }
}
