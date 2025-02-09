using System.Windows.Forms;
using OCESACNA.Engine.Core;
using OCESACNA.Engine.Collections;
using OCESACNA.View.Collections;

namespace OCESACNA.View.Module
{
    public partial class ManageScoresModule : Form
    {
        public ManageScoresModule()
        {
            InitializeComponent();

            foreach (Course c in Engine.Engine.Courses)
            {
                CourseBox.Items.Add(new CourseComboBoxElement(Course.MakeFormat(c), c));
            }

            int index = 0;
            foreach (string lapse in Engine.Engine.Lapses)
            {
                LapseBox.Items.Add(new IntComboBoxElement(lapse, index));
                index++;
            }

            foreach (DataGridViewColumn column in DataGrid.Columns)
            {
                if (column.Visible)
                {
                    SearchByBox.Items.Add(new ComboBoxElement() { Value = column.Name, Text = column.HeaderText });
                }
            }

            ComboBoxElement.AjustComboBox(CourseBox);
            ComboBoxElement.AjustComboBox(LapseBox);
            ComboBoxElement.AjustComboBox(SearchByBox);
        }

        private void ManageScoresModule_Load(object sender, System.EventArgs e)
        {

        }
    }
}
