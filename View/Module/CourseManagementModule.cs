using System;
using System.Windows.Forms;
using OCESACNA.View.Collections;
using OCESACNA.Controller;
using System.Linq;
using OCESACNA.View.Forms;

namespace OCESACNA.View.Module
{
    /// <summary>
    /// Módulo de gestión de Cursos
    /// </summary>
    public partial class CourseManagementModule : Form, IColoreable, IModule
    {
        public bool IsEditing { get; set; } = false;

        public int SelectedIndex { get; set; } = -1;

        /// <summary>
        /// Obtiene o establece el formulario de selección de datos
        /// </summary>
        private SelectTeacherForm SelectTeacherForm { get; set; }

        /// <summary>
        /// Obtiene o establece el curso seleccionado
        /// </summary>
        private Course SelectedCourse { get; set; }

        /// <summary>
        /// Inicializa una instancia del formulario
        /// </summary>
        public CourseManagementModule()
        {
            InitializeComponent();
            ApplyTheme(Program.CurrentTheme);
            LoadData();

            SelectTeacherForm = new SelectTeacherForm();
            SelectTeacherForm.Aborted += SelectTeacherForm_Aborted;
            SelectTeacherForm.Acepted += SelectTeacherForm_Acepted;

            Program.CurrentTheme.DarkModeChanged += ColorTheme_DarkModeChanged;
            ColorTheme.ThemeChanged += ColorTheme_ThemeChanged;
            DataController.CourseDataModified += () => {
                if (InvokeRequired)
                    Invoke(new Action(()=> LoadData()));
            };

            for (int year = 0; year <= (int)Course.Years.Year5th; year++)
            {
                YearBox.Items.Add(new ComboBoxElement<Course.Years>(Course.GetYearsText((Course.Years)year), (Course.Years)year));
            }

            foreach (char section in Course.Sections)
            {
                SectionBox.Items.Add(new ComboBoxElement<char>($"\"{section}\"", section));
            }

            foreach (ComboBoxElement<Course.Years> comboBox in YearBox.Items)
            {
                SearchPerYearBox.Items.Add(comboBox);
            }

            ComboBoxElement.SetupComboBox(YearBox, true);
            ComboBoxElement.SetupComboBox(SectionBox, true);
            ComboBoxElement.SetupComboBox(SearchPerYearBox, true);
        }

        /// <summary>
        /// Es llamado cuando se acepta el formulario <see cref="SelectTeacherForm"/>
        /// </summary>
        private void SelectTeacherForm_Acepted(object sender, EventArgs e)
        {
            SelectGuideBox.Text = SelectTeacherForm.SelectedItem.FullName;
            SelectTeacherForm.Hide();
        }

        /// <summary>
        /// Es llamado cuando se cancela el formulario <see cref="SelectTeacherForm"/>
        /// </summary>
        private void SelectTeacherForm_Aborted(object sender, EventArgs e)
        {
            if (!IsEditing)
            {
                SelectGuideBox.Text = "(Seleccionar)";
            }
            
            SelectTeacherForm.Hide();
        }

        public void ApplyTheme(ColorTheme theme)
        {
            // this
            theme.ApplyBackgroundStyle(this);

            // LeftPanel
            theme.ApplyForeStyle(LeftPanel);

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
            
            int selectedYear =
                SearchPerYearBox.Items.Count != 0 ?
                (int)((ComboBoxElement<Course.Years>)SearchPerYearBox.SelectedItem).Value :
                (int)Course.Years.Year1th;

            foreach (Course course in DataController.GetAllCourses().Where(t => t.Year == selectedYear))
            {
                DataGrid.Rows.Add(new object[]
                {
                    "", course,
                    Course.GetYearsText(course.Year),
                    course.Mention,
                    course.Section,
                    course.Guide.FullName
                }) ;
            }
        }

        public void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                CreateButton.Enabled = false;

                if (MentionBox.Text.Length == 0)
                {
                    IsEditing = false;
                    CreateButton.Enabled = true;
                }
                return;
            }

            bool textBoxContainsText = MentionBox.Text.Length != 0;

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
            SelectedCourse = (Course)DataGrid.Rows[index].Cells["CourseValue"].Value;
            SelectedIndex = index;

            foreach (ComboBoxElement<Course.Years> boxElement in YearBox.Items)
            {
                if (boxElement.Value == SelectedCourse.Year)
                {
                    YearBox.SelectedItem = boxElement;
                    break;
                }
            }

            foreach (ComboBoxElement<char> boxElement in SectionBox.Items)
            {
                if (boxElement.Value == SelectedCourse.Section)
                {
                    SectionBox.SelectedItem = boxElement;
                    break;
                }
            }

            MentionBox.Text = SelectedCourse.Mention;
            SelectTeacherForm.SelectedItem = SelectedCourse.Guide;
            SelectGuideBox.Text = SelectedCourse.Guide.FullName;
        }

        public void CreateButton_Click(object sender, EventArgs e)
        {
            if (MentionBox.Text.Replace(" ", "") == string.Empty)
            {
                MessageBox.Show("Rellene todos los campos primero");
                return;
            }

            if (SelectTeacherForm.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un guía primero.");
                return;
            }

            Course.Years year = ((ComboBoxElement<Course.Years>)YearBox.SelectedItem).Value;
            string mention = MentionBox.Text;
            char section = ((ComboBoxElement<char>)SectionBox.SelectedItem).Value;
            Teacher teacher = SelectTeacherForm.SelectedItem;

            Course course = new Course(-1, teacher, year, mention, section);

            if (DataController.GetAllCourses().Where(t => t.Year == (int)year && t.Mention == mention && t.Section == section).Count() != 0)
            {
                MessageBox.Show($"Ya existe {course.FullName}.");
                return;
            }

            DataController.AddCourse(course);
            Clear();
        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            if (SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento primero.");
                return;
            }

            if (MentionBox.Text.Replace(" ", "") == string.Empty)
            {
                MessageBox.Show("Rellene todos los campos primero");
                return;
            }

            if (SelectTeacherForm.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un guía primero.");
                return;
            }

            Course.Years year = ((ComboBoxElement<Course.Years>)YearBox.SelectedItem).Value;
            string mention = MentionBox.Text;
            char section = ((ComboBoxElement<char>)SectionBox.SelectedItem).Value;
            Teacher teacher = SelectTeacherForm.SelectedItem;

            Course course = new Course(SelectedCourse.CourseID, teacher, year, mention, section);

            if (DataController.GetAllCourses().Where(t => t.Year == (int)year && t.Mention == mention && t.Section == section && t.CourseID != course.CourseID).Count() != 0)
            {
                MessageBox.Show($"Ya existe {course.FullName}.");
                return;
            }

            DataController.UpdateCourse(course);
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
                "¿Está seguro de eliminar este curso?" +
                "\nEsta acción no se puede revertir.",
                "Confirmar acción",
                MessageBoxButtons.YesNo
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            DataController.DeleteCourse(SelectedCourse.CourseID);
            Clear();
        }

        public void Clear()
        {
            SelectedCourse = null;
            SelectedIndex = -1;
            MentionBox.Text = string.Empty;
            SelectGuideBox.Text = "(Seleccionar)";
            SelectTeacherForm.Clear();
        }

        /// <summary>
        /// Es llamado cuando se presiona el botón <see cref="SelectGuideButton"/>
        /// </summary>
        private void SelectGuideButton_Click(object sender, EventArgs e)
        {
            SelectTeacherForm.Clear();
            SelectTeacherForm.LoadData();
            SelectTeacherForm.ShowDialog();
        }

        private void SearchPerYearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
