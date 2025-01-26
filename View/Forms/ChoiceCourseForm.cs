using OCESACNA.Engine.Collections;
using System;
using System.Windows.Forms;

namespace OCESACNA.View.Forms
{
    public partial class ChoiceCourseForm : Form
    {
        readonly string[] YearNames = Engine.Engine.YearsNames;
        public Signal DataElementChoiced = new Signal();

        public Course Choiced { get; set; }

        public ChoiceCourseForm()
        {
            InitializeComponent();
        }

        private void ChoiceCourseForm_Load(object sender, EventArgs e)
        {
            foreach (Course c in Engine.Engine.Courses)
            {
                DataGrid.Rows.Add(new object[] {
                    "", c.CourseID, c,
                    $"{YearNames[c.Year]} de {c.Mention} '{c.Section}'"
                });
            }
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid.Columns[e.ColumnIndex].Name != "Selection")
            {
                return;
            }

            int index = e.RowIndex;

            if (index < 0)
            {
                MessageBox.Show("No aplicable a este elemento");
                return;
            }

            Choiced = Engine.Engine.Courses.Find(t => t.CourseID == (int)DataGrid.Rows[index].Cells["ID"].Value);
            DataElementChoiced.Emit(EventArgs.Empty);
        }
    }
}
