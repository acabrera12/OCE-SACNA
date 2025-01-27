using OCESACNA.Engine.Collections;
using OCESACNA.Engine.Core;
using OCESACNA.View.Collections;
using OCESACNA.View.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OCESACNA.View.Module
{
    public partial class ManageStudentsModule : Form
    {
        int selectedID = -1;

        Course[] coursesList;
        Representative[] representativesList;

        readonly StudentForm StudentDataForm;

        public ManageStudentsModule()
        {
            InitializeComponent();
            StudentDataForm = new StudentForm();
            StudentDataForm.Acepted.Connect(StudentDataForm_Acepted);
            StudentDataForm.Canceled.Connect(StudentDataForm_Canceled);
        }

        private void ManageStudentsModule_Load(object sender, System.EventArgs e)
        {
            ConnectManager.GetAllCourses(ReciveCoursesData);
            ConnectManager.GetAllRepresentatives(ReciveRepresentativesData);
            ConnectManager.GetAllStudents(ReciveStudentsData);

            ConnectManager.DataModified.Connect(UpdateData);

            foreach (DataGridViewColumn column in DataGrid.Columns)
            {
                if (column.Visible && column.Name != "Selection")
                {
                    SearchByBox.Items.Add(new ComboBoxElement() { Value = column.Name, Text = column.HeaderText });
                }
            }
            ComboBoxElement.AjustComboBox(SearchByBox);
        }

        private void UpdateData(object sender, EventArgs e)
        {
            ConnectManager.GetAllCourses(ReciveCoursesData);
            ConnectManager.GetAllRepresentatives(ReciveRepresentativesData);
            ConnectManager.GetAllStudents(ReciveStudentsData);
        }

        private void ReciveStudentsData(object sender, RequestEventArgs e)
        {
            if (InvokeRequired)
            {
                Student[] list = new Student[e.Response.Count];
                int index = 0;

                foreach (Dictionary<string, dynamic> dic in e.Response)
                {
                    Course c = coursesList.Where(i => i.CourseID == dic["CourseID"]).First();
                    Representative r = representativesList.Where(i => i.RprsentID == dic["RprsentID"]).First();

                    if (c == null || r == null)
                    {
                        MessageBox.Show($"No se pudo cargar un valor dependencia de\n'{dic["FirstNames"]}' (ID:{dic["StudentID"]})", "Error al cargar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    dic["Course"] = c;
                    dic["Rprsent"] = r;

                    Student student = ConversionManager.DictonaryToStudent(dic);

                    list.SetValue(student, index);
                    index++;
                }

                Invoke(new Action(() => GetStudents(list)));
            }
        }

        private void ReciveCoursesData(object sender, RequestEventArgs e)
        {
            if (InvokeRequired)
            {
                Course[] list = new Course[e.Response.Count];
                int index = 0;

                foreach (Dictionary<string, dynamic> dic in e.Response)
                {
                    Course course = ConversionManager.DictionaryToCourse(dic);

                    list.SetValue(course, index);
                    index++;
                }

                Invoke(new Action(() => coursesList = list));
            }
        }

        private void ReciveRepresentativesData(object sender, RequestEventArgs e)
        {
            if (InvokeRequired)
            {
                Representative[] list = new Representative[e.Response.Count];
                int index = 0;

                foreach (Dictionary<string, dynamic> dic in e.Response)
                {
                    Representative rprsent = ConversionManager.DictionaryToRprsentative(dic);

                    list.SetValue(rprsent, index);
                    index++;
                }

                Invoke(new Action(() => representativesList = list));
            }
        }

        private void GetStudents(Student[] list)
        {
            if (DataGrid.Rows.Count != 0)
            {
                DataGrid.Rows.Clear();
            }

            string[] names = Engine.Engine.YearsNames;

            foreach (Student s in list)
            {
                DataGrid.Rows.Add(new object[] {
                    "", s.StudentID, s.Cedula, s.LastNames, s.FirstNames, s.Sex, s.Sex.ToString(),
                    s.Age, s.Birthdate, s.BirthPlace, s.FederalEntty, s.Address, s.PhoneNumber,
                    s.Email, s.Rprsent.RprsentID, s.Rprsent.FullName, s.Course.CourseID,
                    names[s.Course.Year], s.Course.Mention, s.Course.Section
                });
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            StudentDataForm.ClearData();
            StudentDataForm.FormType = StudentForm.DataFormType.Create;
            StudentDataForm.ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Seleccione un elemento");
                return;
            }

            StudentDataForm.FormType = StudentForm.DataFormType.Update;
            StudentDataForm.SetData(Engine.Engine.Students.Find(t => t.StudentID == selectedID));
            StudentDataForm.ShowDialog();
        }

        private void EraseBtn_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Seleccione un elemento");
                return;
            }

            string name = Engine.Engine.Students.Find(t => t.StudentID == selectedID).FirstNames;

            if (MessageBox.Show($"¿Quieres eliminar el estudiante {name} (ID:{selectedID})?\nEsta acción no se puede revertir", "Confirmar Acción", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            ConnectManager.DeleteStudent(selectedID);

            selectedID = -1;
            Clear();
        }

        private void StudentDataForm_Acepted(object sender, EventArgs e)
        {
            switch (StudentDataForm.FormType)
            {
                case StudentForm.DataFormType.None:
                    return;
                case StudentForm.DataFormType.Create:
                    CreateConfirmed();
                    break;
                case StudentForm.DataFormType.Update:
                    UpdateConfirmed();
                    break;
            }
        }

        private void StudentDataForm_Canceled(object sender, EventArgs e)
        {
            StudentForm.DataFormType s = StudentDataForm.FormType;
            Console.WriteLine($"{GetType()}: action {s} canceled");

            StudentDataForm.FormType = StudentForm.DataFormType.None;
        }

        private void CreateConfirmed()
        {
            Student student;
            try
            {
                student = StudentDataForm.GetDataAndHide();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{GetType()}: {e}");
                MessageBox.Show("Alguno de los campos es inválido");
                return;
            }

            ConnectManager.AddStudent(ConversionManager.StudentToDBStudent(student));
            Clear();
        }

        private void UpdateConfirmed()
        {
            Student student;
            try
            {
                student = StudentDataForm.GetDataAndHide();
                student.StudentID = selectedID;
            }
            catch (Exception e)
            {
                Console.WriteLine($"{GetType()}: {e}");
                MessageBox.Show("Alguno de los campos es inválido");
                return;
            }

            ConnectManager.UpdateStudent(ConversionManager.StudentToDBStudent(student));
            Clear();
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid.Columns[e.ColumnIndex].Name != "Selection")
            {
                return;
            }

            int index = e.RowIndex;

            if (index >= 0)
            {
                selectedID = int.Parse(DataGrid.Rows[index].Cells["ID"].Value.ToString());
            }
        }

        private void Clear()
        {
            StudentDataForm.ClearData();
        }
    }
}
