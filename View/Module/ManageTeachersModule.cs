using System.Windows.Forms;
using System;
using OCESACNA.View.Forms;
using OCESACNA.Engine.Collections;
using OCESACNA.Engine.Core;
using System.Collections.Generic;

namespace OCESACNA.View.Module
{
    public partial class ManageTeachersModule : Form
    {
        ChoiceCourseForm ChoiceCourseForm { get; set; }
        Course SelectedCourse { get; set; }

        bool isEditing = false;
        int SelectedID = -1;

        public ManageTeachersModule()
        {
            InitializeComponent();
            ChoiceCourseForm = new ChoiceCourseForm();
            ChoiceCourseForm.DataElementChoiced.Connect(ChoiceCourseForm_DataElementChoiced);
        }

        private void ManageTeachersModule_Load(object sender, EventArgs e)
        {
            ConnectManager.GetAllTeachers(ReciveTeachersData);
            ConnectManager.DataModified.Connect(UpdateTeachersData);
        }

        private void UpdateTeachersData(object sender, EventArgs e)
        {
            ConnectManager.GetAllTeachers(ReciveTeachersData);
        }

        private void ReciveTeachersData(object sender, RequestEventArgs e)
        {
            if (InvokeRequired)
            {
                Teacher[] list = new Teacher[e.Response.Count];

                int index = 0;
                foreach(Dictionary<string, dynamic> dic in e.Response)
                {
                    dic["Course"] = Engine.Engine.Courses.Find(t => t.CourseID == dic["CourseID"]);
                    Teacher teacher = ConversionManager.DictionaryToTeacher(dic);

                    list.SetValue(teacher, index);
                    index++;
                }

                Invoke(new Action(() => GetTeachers(list)));
            }
        }

        private void GetTeachers(Teacher[] list)
        {
            if (DataGrid.Rows.Count != 0)
            {
                DataGrid.Rows.Clear();
            }
            foreach(Teacher teacher in list)
            {
                DataGrid.Rows.Add(new object[] {
                    "", teacher.TeachID, teacher.FullName, teacher.Course,
                    $"{Engine.Engine.YearsNames[teacher.Course.Year]} de {teacher.Course.Mention} '{teacher.Course.Section}'"
                });
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (FullNameBox.Text.Replace(" ", "") == string.Empty)
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }

            if (SelectedCourse == null)
            {
                MessageBox.Show("Seleccione un curso");
                return;
            }

            Teacher teacher = new Teacher(-1, SelectedCourse, FullNameBox.Text);

            ConnectManager.AddTeacher(ConversionManager.TeacherToDBTeacher(teacher));
            Clear();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (SelectedID == -1)
            {
                MessageBox.Show("Seleccione un elemento");
                return;
            }

            if (FullNameBox.Text.Replace(" ","") == string.Empty)
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }

            Teacher teacher = new Teacher(SelectedID, SelectedCourse, FullNameBox.Text);

            ConnectManager.UpdateTeacher(ConversionManager.TeacherToDBTeacher(teacher));
            Clear();
        }

        private void EraseBtn_Click(object sender, EventArgs e)
        {
            if (SelectedID == -1)
            {
                MessageBox.Show("Seleccione un elemento");
                return;
            }
            if (MessageBox.Show($"¿Quieres elimina al docente con el ID {SelectedID}?\nEsta Acción no se puede revertir", "Confirmar Acción", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ConnectManager.DeleteTeacher(SelectedID);
                Clear();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (isEditing)
            {
                CreateBtn.Enabled = false;

                if (FullNameBox.Text == "")
                {
                    isEditing = false;
                    CreateBtn.Enabled = true;
                }
                return;
            }

            if (FullNameBox.Text != "")
            {
                EraseBtn.Enabled = false;
                EditBtn.Enabled = false;
            }
            else
            {
                EraseBtn.Enabled = true;
                EditBtn.Enabled = true;
            }
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid.Columns[e.ColumnIndex].Name != "Selection")
            {
                return;
            }

            int index = e.RowIndex;;

            isEditing = true;
            SelectedID = int.Parse(DataGrid.Rows[index].Cells["ID"].Value.ToString());
            SelectedCourse = (Course)DataGrid.Rows[index].Cells["CourseValue"].Value;

            FullNameBox.Text = DataGrid.Rows[index].Cells["FullName"].Value.ToString();
            CourseBox.Text = $"{Engine.Engine.YearsNames[SelectedCourse.Year]} de {SelectedCourse.Mention} '{SelectedCourse.Section}'";
        }

        private void ChoiceCourseBtn_Click(object sender, EventArgs e)
        {
            ChoiceCourseForm.ShowDialog();
        }

        private void ChoiceCourseForm_DataElementChoiced(object sender, EventArgs e)
        {
            SelectedCourse = ChoiceCourseForm.Choiced;

            ChoiceCourseForm.Hide();
            var c = SelectedCourse;
            CourseBox.Text = $"{Engine.Engine.YearsNames[c.Year]} de {c.Mention} '{c.Section}'";
        }

        private void Clear()
        {
            SelectedID = -1;
            SelectedCourse = null;
            CourseBox.Text = string.Empty;
            FullNameBox.Text = string.Empty;
        }
    }
}
