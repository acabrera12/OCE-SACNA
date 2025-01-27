using OCESACNA.Engine.Collections;
using System;
using System.Windows.Forms;

namespace OCESACNA.View.Forms
{
    public partial class ChoiceTeacherForm : Form
    {
        public Signal DataElementChoiced = new Signal();

        public Teacher Choiced { get; set; }

        private Course Course { get; set; }

        public ChoiceTeacherForm()
        {
            InitializeComponent();
        }

        private void ChoiceTeacherForm_Load(object sender, EventArgs e)
        {
            foreach (Teacher teacher in Engine.Engine.Teachers)
            {
                DataGrid.Rows.Add(new object[]
                {
                    "", teacher.TeachID, teacher.FullName, teacher.Course,
                    Course.MakeFormat(teacher.Course)
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

            Choiced = new Teacher()
            {
                TeachID = int.Parse(DataGrid.Rows[index].Cells["ID"].Value.ToString()),
                Course = Course,
                FullName = DataGrid.Rows[index].Cells["FullName"].Value.ToString()
            };

            DataElementChoiced.Emit(EventArgs.Empty);
        }
    }
}
