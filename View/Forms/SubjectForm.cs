using OCESACNA.Engine.Collections;
using System;
using System.Windows.Forms;

namespace OCESACNA.View.Forms
{
    public partial class SubjectForm : Form
    {
        public Signal Acepted = new Signal();
        public Signal Canceled = new Signal();

        readonly string[] YearsNames = Engine.Engine.YearsNames;
        public DataFormType FormType { get; set; }

        private int SubjectID { get; set; }
        private SubjectModule SubjectModule { get; set; }
        private Teacher Teacher { get; set; }
        private Course Course { get; set; }

        public enum DataFormType
        {
            None = 0,
            Create = 1,
            Update = 2
        }

        public SubjectForm()
        {
            InitializeComponent();
        }

        public void SetData(Subject data)
        {
            SubjectID = data.SubjectID;
            SubjectModule = data.SbjetModule;
            Course = data.Course;
            Teacher = data.Teach;

            SbjetModuleBox.Text = data.SbjetModule.Name;
            TeacherBox.Text = data.Teach.FullName;
            CourseBox.Text = Course.MakeFormat(Course);
            NameBox.Text = data.Name;
        }

        public Subject GetDataAndHide()
        {
            if (!VerifyData())
            {
                throw new Exception("Alguno de los campos es inválido");
            }

            Hide();
            return new Subject()
            {
                SubjectID = SubjectID,
                SbjetModule = SubjectModule,
                Course = Course,
                Teach = Teacher,
                Name = NameBox.Text
            };
        }

        public void ClearData()
        {
            SubjectID = -1;
            SubjectModule = null;
            Teacher = null;
            SbjetModuleBox.Text = string.Empty;
            TeacherBox.Text = string.Empty;
            CourseBox.Text = string.Empty;
            NameBox.Text = string.Empty;
        }

        private void AceptBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Acepted.Emit(e);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Canceled.Emit(e);
        }

        ChoiceSbjetModuleForm ChoiceSbjetModule;
        private void ChoiceSbjetModuleBtn_Click(object sender, EventArgs e)
        {
            ChoiceSbjetModule = new ChoiceSbjetModuleForm();
            ChoiceSbjetModule.DataElementChoiced.Connect(ChoiceSbjetModule_DataElementChoiced);
            ChoiceSbjetModule.ShowDialog();
        }

        private void ChoiceSbjetModule_DataElementChoiced(object sender, EventArgs e)
        {
            SubjectModule = ChoiceSbjetModule.Choiced;
            SbjetModuleBox.Text = SubjectModule.Name;
            ChoiceSbjetModule.Close();
        }

        ChoiceTeacherForm ChoiceTeacher;
        private void ChoiceTeacherBtn_Click(object sender, EventArgs e)
        {
            ChoiceTeacher = new ChoiceTeacherForm();
            ChoiceTeacher.DataElementChoiced.Connect(ChoiceTeacher_DataElementChoiced);
            ChoiceTeacher.ShowDialog();
        }

        private void ChoiceTeacher_DataElementChoiced(object sender, EventArgs e)
        {
            Teacher = ChoiceTeacher.Choiced;
            TeacherBox.Text = Teacher.FullName;
            ChoiceTeacher.Close();
        }

        ChoiceCourseForm ChoiceCourse;
        private void ChoiceCourseBtn_Click(object sender, EventArgs e)
        {
            ChoiceCourse = new ChoiceCourseForm();
            ChoiceCourse.DataElementChoiced.Connect(ChoiceCourse_DataElementChoiced);
            ChoiceCourse.ShowDialog();
        }

        private void ChoiceCourse_DataElementChoiced(object sender, EventArgs e)
        {
            Course = ChoiceCourse.Choiced;
            CourseBox.Text = $"{YearsNames[Course.Year]} de {Course.Mention} '{Course.Section}'";
            ChoiceCourse.Close();
        }

        private bool VerifyData()
        {
            if (NameBox.Text.Replace(" ", "") == string.Empty)
            {
                return false;
            }
            if (Teacher == null || Course == null || SubjectModule == null)
            {
                return false;
            }
            return true;
        }
    }
}
