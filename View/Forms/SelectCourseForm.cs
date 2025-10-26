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
            DataController.CourseDataModified += () =>
            {
                if (InvokeRequired)
                    Invoke(new Action(LoadData));
            };
            LoadData();
        }

        public Course SelectedItem { get; set; }

        public event EventHandler Acepted;
        public event EventHandler Aborted;

        public void AbortButton_Click(object sender, EventArgs e)
        {
            OnAbort();
        }

        public void AceptButton_Click(object sender, EventArgs e)
        {
            if (SelectedItem == null)
            {
                MessageBox.Show("Seleccione un elemento primero.");
                return;
            }

            OnAcept();
        }

        public void Clear()
        {
            SelectedItem = null;
            SelectBox.Text = "Seleccionar";
        }

        public void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid.Columns[e.ColumnIndex].Name != "Selection")
            {
                return;
            }

            int index = e.RowIndex;
            SelectedItem = (Course)DataGrid.Rows[index].Cells["CourseValue"].Value;
            SelectBox.Text = SelectedItem.FullName;
        }

        public void LoadData()
        {
            if (DataGrid.Rows.Count != 0)
            {
                DataGrid.Rows.Clear();
            }

            foreach (Course course in DataController.GetAllCourses())
            {
                DataGrid.Rows.Add(new object[]
                {
                    "",
                    course,
                    course.FullName,
                    course.Guide.FullName
                });
            }
        }

        public void OnAbort()
        {
            Clear();
            Aborted?.Invoke(this, EventArgs.Empty);
        }

        public void OnAcept()
        {
            Acepted?.Invoke(this, EventArgs.Empty);
        }

        private void SelectCourseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnAbort();
        }
    }
}
