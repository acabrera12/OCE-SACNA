using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OCESACNA.Engine.Collections;
using OCESACNA.View.Collections;

namespace OCESACNA.View.Forms
{
    public partial class StudentForm : Form, IDataForm
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

            SexBox.Items.Add(new BoolComboBoxElement("M", true));
            SexBox.Items.Add(new BoolComboBoxElement("F", false));
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

        public void SetData(Dictionary<string, dynamic> data)
        {

        }

        public object[] GetData()
        {
            bool sex = false;
            string mention = "";
            string section = "";

            int index = SexBox.SelectedIndex;
            foreach (BoolComboBoxElement boolComboBox in SexBox.Items)
            {
                if (index == SexBox.Items.IndexOf(boolComboBox))
                {
                    sex = boolComboBox.Value;
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

            object[] values = new object[]
            {
                StudentID, CedulaBox.Text, LastNamesBox.Text, FirstNameLabel.Text, AgeBox.Value,
                sex, BirthdateBox.Value, BirthPlaceBox.Text, FederalEnttyBox.Text, AddressBox.Text,
                PhoneNumberBox.Text, EmailBox.Text, Rprsent, new Course(-1, YearBox.SelectedIndex, mention, section)
            };

            return values;
        }

        public void ClearData()
        {

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
            StringComboBoxElement stringCombo = new StringComboBoxElement("None", "");

            foreach (StringComboBoxElement scbe in YearBox.Items)
            {
                if (index == YearBox.Items.IndexOf(scbe))
                {
                    stringCombo = scbe;
                    break;
                }
            }

            foreach (Course c in Engine.Engine.Courses.Where(t => stringCombo.Text == YearsNames[t.Year]))
            {
                MentionBox.Items.Add(new StringComboBoxElement(c.Mention, string.Empty));
            }
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

            foreach (Course c in Engine.Engine.Courses.Where(t => stringCombo.Text == YearsNames[t.Year] && t.Mention == stringCombo.Text))
            {
                SectionBox.Items.Add(c.Section);
            }
        }

        ChoiceRprsentForm Cr;

        private void SelectRprsentBtn_Click(object sender, EventArgs e)
        {
            Cr = new ChoiceRprsentForm();
            Cr.ShowDialog();
            Cr.DataElementChoiced.Connect(OnChoiceRprsentDataChoiced);
        }

        private void OnChoiceRprsentDataChoiced(object sender, EventArgs e)
        {
            Rprsent = Cr.Choiced;

            RprsentBox.Text = Rprsent.FullName;

            Cr.Close();
        }
    }
}
