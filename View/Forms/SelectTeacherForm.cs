using OCESACNA.Controller;
using OCESACNA.View.Collections;
using System;
using System.Windows.Forms;

namespace OCESACNA.View.Forms
{
    /// <summary>
    /// Representa el formulario de selección de docentes
    /// </summary>
    public partial class SelectTeacherForm : Form, ISelectionForm<Teacher>
    { 
        /// <summary>
        /// Inicializa una instancia del formulario
        /// </summary>
        public SelectTeacherForm()
        {
            InitializeComponent();
            LoadData();
        }

        public Teacher SelectedItem { get; set; }

        public event SelectionFormEventHanlder<Teacher> Acepted;

        public event EventHandler Aborted;

        protected void OnAcept(Teacher selectedTeacher)
        {
            if (SelectedItem == null)
            {
                MessageBox.Show(
                    "Seleccione un elemento primero."
                );
                return;
            }
            Acepted?.Invoke(selectedTeacher);
        }

        protected void OnAbort()
        {
            Aborted?.Invoke(this, EventArgs.Empty);
        }

        public void Clear()
        {
            SelectedItem = null;
            SelectBox.Text = "Seleccionar";
        }

        public void LoadData()
        {
            if (DataGrid.Rows.Count != 0)
                DataGrid.Rows.Clear();

            foreach (Teacher teacher in DataController.GetAllTeachers())
                DataGrid.Rows.Add(
                    "",
                    teacher,
                    teacher.FullName
                );
        }

        private void AceptButton_Click(object sender, EventArgs e)
        {
            OnAcept(SelectedItem);
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            OnAbort();
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid.Columns[e.ColumnIndex].Name != "Selection")
                return;

            int index = e.RowIndex;
            SelectedItem = (Teacher)DataGrid.Rows[index].Cells["TeacherValue"].Value;
            SelectBox.Text = SelectedItem.FullName;
        }

        private void SelectTeacherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnAbort();
        }
    }
}
