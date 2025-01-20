using OCESACNA.Engine.Collections;
using OCESACNA.View.Collections;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OCESACNA.View.Forms
{
    public partial class StudentForm : Form
    {
        public Signal Acepted = new Signal();
        public Signal Canceled = new Signal();
        public DataFormType FormType { get; set; }

        readonly string[] YearsNames = Engine.Engine.YearsNames;
        readonly string[] YearsKeys = Engine.Engine.YearsKeys;
        private int StudentID { get; set; }
        private Representative Rprsent { get; set; }

        public enum DataFormType
        {
            None = 0,
            Create = 1,
            Update = 2
        }

        public StudentForm()
        {
            InitializeComponent();

            SexBox.Items.Add(new SexComboBoxElement("M", Student.SEXS.M));
            SexBox.Items.Add(new SexComboBoxElement("F", Student.SEXS.F));
            ComboBoxElement.AjustComboBox(SexBox);

            int index = 0;
            foreach (string item in YearsKeys)
            {
                StringComboBoxElement stringCombo = new StringComboBoxElement(YearsNames[index], item);
                YearBox.Items.Add(stringCombo);
                index++;
            }
            ComboBoxElement.AjustComboBox(YearBox);
        }

        public void SetData(Student data)
        {
            StudentID = data.StudentID;
            Rprsent = data.Rprsent;
            RprsentBox.Text = Rprsent.FullName;
            YearBox.SelectedIndex = data.Course.Year;

            foreach (StringComboBoxElement scbe in MentionBox.Items)
            {
                if (scbe.Text == data.Course.Mention)
                {
                    MentionBox.SelectedIndex = MentionBox.Items.IndexOf(scbe);
                    break;
                }
            }

            foreach (StringComboBoxElement scbe in SectionBox.Items)
            {
                if (scbe.Text == data.Course.Section)
                {
                    SectionBox.SelectedIndex = SectionBox.Items.IndexOf(scbe);
                    break;
                }
            }

            foreach (SexComboBoxElement scbe in SexBox.Items)
            {
                if (scbe.Value == data.Sex)
                {
                    SexBox.SelectedIndex = SexBox.Items.IndexOf(scbe);
                    break;
                }
            }

            CedulaBox.Text = data.Cedula.ToString();
            LastNamesBox.Text = data.LastNames;
            FirstNamesBox.Text = data.FirstNames;
            AgeBox.Value = data.Age;
            BirthdateBox.Value = data.Birthdate;
            BirthPlaceBox.Text = data.BirthPlace;
            FederalEnttyBox.Text = data.FederalEntty;
            AddressBox.Text = data.Address;
            PhoneNumberBox.Text = data.PhoneNumber;
            EmailBox.Text = data.Email;
        }

        public Student GetDataAndHide()
        {
            Student.SEXS sex = 0;
            string mention = "";
            string section = "";

            int index = SexBox.SelectedIndex;
            foreach (SexComboBoxElement intComboBox in SexBox.Items)
            {
                if (index == SexBox.Items.IndexOf(intComboBox))
                {
                    sex = intComboBox.Value;
                    break;
                }
            }

            index = MentionBox.SelectedIndex;
            foreach (StringComboBoxElement stringComboBox in MentionBox.Items)
            {
                if (index == MentionBox.Items.IndexOf(stringComboBox))
                {
                    mention = stringComboBox.Text;
                    break;
                }
            }

            index = SectionBox.SelectedIndex;
            foreach (StringComboBoxElement stringComboBox in SectionBox.Items)
            {
                if (index == SectionBox.Items.IndexOf(stringComboBox))
                {
                    section = stringComboBox.Text;
                    break;
                }
            }

            if (!VerifyData())
            {
                throw new Exception("Alguno de los campos es inválido");
            }

            Student student = new Student()
            {
                StudentID = StudentID,
                Address = AddressBox.Text,
                Age = int.Parse(AgeBox.Value.ToString()),
                Birthdate = BirthdateBox.Value,
                BirthPlace = BirthPlaceBox.Text,
                Cedula = int.Parse(CedulaBox.Text),
                Course = Engine.Engine.Courses.Where(
                    t => t.Year == YearBox.SelectedIndex
                    && t.Mention == mention
                    && t.Section == section
                ).First(),
                Email = EmailBox.Text,
                FederalEntty = FederalEnttyBox.Text,
                FirstNames = FirstNamesBox.Text,
                LastNames = LastNamesBox.Text,
                PhoneNumber = PhoneNumberBox.Text,
                Rprsent = Rprsent,
                Sex = sex
            };

            Hide();
            return student;
        }

        public void ClearData()
        {
            StudentID = -1;
            AddressBox.Text = string.Empty;
            BirthdateBox.Value = DateTime.Today;
            BirthPlaceBox.Text = string.Empty;
            CedulaBox.Text = string.Empty;
            YearBox.SelectedIndex = 0;
            EmailBox.Text = string.Empty;
            FederalEnttyBox.Text = string.Empty;
            FirstNamesBox.Text = string.Empty;
            LastNamesBox.Text = string.Empty;
            PhoneNumberBox.Text = string.Empty;
            Rprsent = null;
            RprsentBox.Text = string.Empty;
            SexBox.SelectedIndex = 0;
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

        private void YearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MentionBox.Items.Count != 0)
            {
                MentionBox.Items.Clear();
                SectionBox.Items.Clear();
            }

            int index = YearBox.SelectedIndex;

            foreach (Course c in Engine.Engine.Courses.Where(t => t.Year == index))
            {
                MentionBox.Items.Add(new StringComboBoxElement(c.Mention, string.Empty));
            }

            ComboBoxElement.AjustComboBox(MentionBox);
            MentionBox.SelectedIndex = 0;
        }

        private void MentionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SectionBox.Items.Count != 0)
            {
                SectionBox.Items.Clear();
            }

            int index = MentionBox.SelectedIndex;
            StringComboBoxElement stringCombo = new StringComboBoxElement("None", "");

            foreach (StringComboBoxElement scbe in MentionBox.Items)
            {
                if (index == MentionBox.Items.IndexOf(scbe))
                {
                    stringCombo = scbe;
                    break;
                }
            }

            foreach (Course c in Engine.Engine.Courses.Where(t => t.Year == YearBox.SelectedIndex && t.Mention == stringCombo.Text))
            {
                SectionBox.Items.Add(new StringComboBoxElement(c.Section, string.Empty));
            }

            ComboBoxElement.AjustComboBox(SectionBox);
            SectionBox.SelectedIndex = 0;
        }

        ChoiceRprsentForm Cr;

        private void SelectRprsentBtn_Click(object sender, EventArgs e)
        {
            Cr = new ChoiceRprsentForm();
            Cr.DataElementChoiced.Connect(OnChoiceRprsentDataChoiced);
            Cr.ShowDialog();
        }

        private void OnChoiceRprsentDataChoiced(object sender, EventArgs e)
        {
            Rprsent = Cr.Choiced;
            RprsentBox.Text = Rprsent.FullName;
            Cr.Close();
        }

        private bool VerifyData()
        {
            if (CedulaBox.Text.Replace(" ", "") == string.Empty || !int.TryParse(CedulaBox.Text, result: out _))
            {
                return false;
            }
            if (LastNamesBox.Text.Replace(" ", "") == string.Empty || FirstNamesBox.Text.Replace(" ", "") == string.Empty)
            {
                return false;
            }
            if (BirthPlaceBox.Text.Replace(" ", "") == string.Empty || FederalEnttyBox.Text.Replace(" ", "") == string.Empty)
            {
                return false;
            }
            if (AddressBox.Text.Replace(" ", "") == string.Empty || PhoneNumberBox.Text.Replace(" ", "") == string.Empty)
            {
                return false;
            }
            if (EmailBox.Text.Replace(" ", "") == string.Empty || YearBox.SelectedIndex == -1)
            {
                return false;
            }
            if (MentionBox.SelectedIndex == -1 || SectionBox.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }
    }
}
