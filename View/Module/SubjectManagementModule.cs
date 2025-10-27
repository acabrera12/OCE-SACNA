using OCESACNA.Controller;
using OCESACNA.View.Collections;
using OCESACNA.View.Forms;
using System;
using System.Windows.Forms;

namespace OCESACNA.View.Module
{
    public partial class SubjectManagementModule : Form, IModule
    {
        public bool IsEditing { get; set; }

        public int SelectedIndex { get; set; }

        private Subject SelectedSubject { get; set; }

        private Teacher SelectedTeacher { get; set; }

        private SubjectModule SelectedSubjectModule { get; set; }

        private Course SelectedCourse { get; set; }

        /// <summary>
        /// Obtiene o establece el formulario de selección de datos
        /// </summary>
        private SelectTeacherForm SelectTeacherForm { get; set; }

        /// <summary>
        /// Obtiene o establece el formulario de selección de datos
        /// </summary>
        private SelectSubjectModuleForm SelectSubjectModuleForm { get; set; }

        /// <summary>
        /// Obtiene o establece el formulario de selección de datos
        /// </summary>
        private SelectCourseForm SelectCourseForm { get; set; }

        public SubjectManagementModule()
        {
            InitializeComponent();

            SelectTeacherForm = new SelectTeacherForm();
            SelectTeacherForm.Aborted += SelectTeacherForm_Aborted;
            SelectTeacherForm.Acepted += SelectTeacherForm_Acepted;

            SelectSubjectModuleForm = new SelectSubjectModuleForm();
            SelectSubjectModuleForm.Aborted += SelectSubjectModuleForm_Aborted;
            SelectSubjectModuleForm.Acepted += SelectSubjectModuleForm_Acepted;

            SelectCourseForm = new SelectCourseForm();
            SelectCourseForm.Aborted += SelectCourseForm_Aborted;
            SelectCourseForm.Acepted += SelectCourseForm_Acepted;

            DataController.SubjectDataModified += () =>
             {
                 if (InvokeRequired)
                     Invoke(new Action(LoadData));
             };
            LoadData();
        }

        private void SelectCourseForm_Acepted(Course course)
        {
            SelectedCourse = course;
            SelectCourseBox.Text = SelectedCourse.FullName;
            SelectCourseForm.Hide();
        }

        private void SelectCourseForm_Aborted(object sender, EventArgs e)
        {
            if (!IsEditing)
            {
                SelectedCourse = null;
                SelectTeacherBox.Text = "(Seleccionar)";
            }

            SelectCourseForm.Hide();
        }

        private void SelectSubjectModuleForm_Acepted(SubjectModule subjectModule)
        {
            SelectedSubjectModule = subjectModule;
            SelectModuleBox.Text = SelectedSubjectModule.Name;
            SelectSubjectModuleForm.Hide();
        }

        private void SelectSubjectModuleForm_Aborted(object sender, EventArgs e)
        {
            if (!IsEditing)
            {
                SelectTeacherBox.Text = "(Seleccionar)";
                SelectedSubjectModule = null;
            }

            SelectSubjectModuleForm.Hide();
        }

        private void SelectTeacherForm_Acepted(Teacher teacher)
        {
            SelectedTeacher = teacher;
            SelectTeacherBox.Text = SelectedTeacher.FullName;
            SelectTeacherForm.Hide();
        }

        /// <summary>
        /// Es llamado cuando se presiona el botón <see cref="SelectTeacherButton"/>
        /// </summary>
        private void SelectTeacherButton_Click(object sender, EventArgs e)
        {
            SelectTeacherForm.Clear();
            SelectTeacherForm.LoadData();
            SelectTeacherForm.ShowDialog();
        }

        private void SelectTeacherForm_Aborted(object sender, EventArgs e)
        {
            if (!IsEditing)
            {
                SelectTeacherBox.Text = "(Seleccionar)";
                SelectedTeacher = null;
            }

            SelectTeacherForm.Hide();
        }

        public void Clear()
        {
            SelectedSubject = null;
            SelectedTeacher = null;
            SelectedSubjectModule = null;
            SelectedCourse = null;
            SelectedIndex = -1;
            NameBox.Text = string.Empty;
            SelectCourseBox.Text = "(Seleccionar)";
            SelectTeacherBox.Text = "(Seleccionar)";
            SelectModuleBox.Text = "(Seleccionar)";
            SelectCourseForm.Clear();
            SelectTeacherForm.Clear();
            SelectSubjectModuleForm.Clear();
        }

        public void CreateButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text.Replace(" ", "") == string.Empty)
            {
                MessageBox.Show("Rellene todos los campos primero");
                return;
            }

            if (SelectedSubjectModule == null)
            {
                MessageBox.Show("Seleccione un área de formación primero.");
                return;
            }

            if (SelectedTeacher == null)
            {
                MessageBox.Show("Seleccione un docente primero.");
                return;
            }

            if (SelectedCourse == null)
            {
                MessageBox.Show("Seleccione un curso primero.");
                return;
            }

            string name = NameBox.Text;
            Teacher teacher = SelectedTeacher;
            Course course = SelectedCourse;
            SubjectModule module = SelectedSubjectModule;

            Subject subject = new Subject(-1, module, name, teacher, course);

            DataController.AddSubject(subject);
            Clear();
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
            SelectedSubject = (Subject)DataGrid.Rows[index].Cells["SubjectValue"].Value;

            SelectCourseForm.SelectedItem = SelectedSubject.Course;
            SelectTeacherForm.SelectedItem = SelectedSubject.Teacher;
            SelectSubjectModuleForm.SelectedItem = SelectedSubject.SubjectModule;

            SelectedCourse = SelectedSubject.Course;
            SelectedTeacher = SelectedSubject.Teacher;
            SelectedSubjectModule = SelectedSubject.SubjectModule;

            SelectCourseBox.Text = SelectedCourse.FullName;
            SelectTeacherBox.Text = SelectedTeacher.FullName;
            SelectModuleBox.Text = SelectedSubjectModule.Name;
            NameBox.Text = SelectedSubject.Name;
        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text.Replace(" ", "") == string.Empty)
            {
                MessageBox.Show("Rellene todos los campos primero");
                return;
            }

            if (SelectedSubjectModule == null)
            {
                MessageBox.Show("Seleccione un área de formación primero.");
                return;
            }

            if (SelectedTeacher == null)
            {
                MessageBox.Show("Seleccione un docente primero.");
                return;
            }

            if (SelectedCourse == null)
            {
                MessageBox.Show("Seleccione un curso primero.");
                return;
            }

            string name = NameBox.Text;
            Teacher teacher = SelectedTeacher;
            Course course = SelectedCourse;
            SubjectModule module = SelectedSubjectModule;

            Subject subject = new Subject(SelectedSubject.SubjetID, module, name, teacher, course);

            DataController.UpdateSubject(subject);
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
                "¿Está seguro de eliminar esta asignatura?" +
                "\nEsta acción no se puede revertir.",
                "Confirmar acción",
                MessageBoxButtons.YesNo
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            DataController.DeleteSubject(SelectedSubject.SubjetID);
            Clear();
        }

        public void LoadData()
        {
            if (DataGrid.Rows.Count != 0)
                DataGrid.Rows.Clear();

            foreach (Subject subject in DataController.GetAllSubjects())
                DataGrid.Rows.Add(new object[]
                {
                    "",
                    subject,
                    subject.SubjectModule,
                    subject.SubjectModule.Name,
                    subject.Name,
                    subject.Teacher,
                    subject.Teacher.FullName,
                    subject.Course,
                    subject.Course.FullName
                });
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

        private void SelectModuleButton_Click(object sender, EventArgs e)
        {
            SelectSubjectModuleForm.Clear();
            SelectSubjectModuleForm.LoadData();
            SelectSubjectModuleForm.ShowDialog();
        }

        private void SelectCourseButton_Click(object sender, EventArgs e)
        {
            SelectCourseForm.Clear();
            SelectCourseForm.LoadData();
            SelectCourseForm.ShowDialog();
        }
    }
}
