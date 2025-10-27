using OCESACNA.Controller;
using OCESACNA.View.Collections;
using System;
using System.Windows.Forms;

namespace OCESACNA.View.Forms
{
    public partial class SelectCourseForm : Form, ISelectionForm<Course>
    {
        public SelectCourseForm()
        {
            InitializeComponent();
            LoadData();
        }

        public Course SelectedItem { get; set; }

        public event SelectionFormEventHanlder<Course> Acepted;
        public event EventHandler Aborted;

        public void AbortButton_Click(object sender, EventArgs e)
        {
            OnAbort();
        }

        private void AceptButton_Click(object sender, EventArgs e)
        {
            if (SelectedItem == null)
            {
                MessageBox.Show("Seleccione un elemento primero.");
                return;
            }

            OnAcept(SelectedItem);
        }

        public void Clear()
        {
            SelectedItem = null;
            SelectBox.Text = "Seleccionar";
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid.Columns[e.ColumnIndex].Name != "Selection")
                return;

            int index = e.RowIndex;
            SelectedItem = (Course)DataGrid.Rows[index].Cells["CourseValue"].Value;
            SelectBox.Text = SelectedItem.FullName;
        }

        public void LoadData()
        {
            if (DataGrid.Rows.Count != 0)
                DataGrid.Rows.Clear();

            foreach (Course course in DataController.GetAllCourses())
                DataGrid.Rows.Add(new object[]
                {
                    "",
                    course,
                    course.FullName,
                    course.Guide.FullName
                });
        }

        protected void OnAbort()
        {
            Clear();
            Aborted?.Invoke(this, EventArgs.Empty);
        }

        protected void OnAcept(Course selectedCourse)
        {
            Acepted?.Invoke(selectedCourse);
        }

        private void SelectCourseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnAbort();
        }
    }
}
