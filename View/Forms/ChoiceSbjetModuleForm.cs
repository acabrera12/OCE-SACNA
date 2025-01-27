using OCESACNA.Engine.Collections;
using System;
using System.Windows.Forms;

namespace OCESACNA.View.Forms
{
    public partial class ChoiceSbjetModuleForm : Form
    {
        public Signal DataElementChoiced = new Signal();

        public SubjectModule Choiced { get; set; }

        public ChoiceSbjetModuleForm()
        {
            InitializeComponent();
        }

        private void ChoiceSbjetModuleForm_Load(object sender, EventArgs e)
        {
            foreach (SubjectModule module in Engine.Engine.SubjectModules)
            {
                DataGrid.Rows.Add(new object[] {
                    "", module.SbjetModuleID, module.Name
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

            Choiced = new SubjectModule()
            {
                SbjetModuleID = int.Parse(DataGrid.Rows[index].Cells["ID"].Value.ToString()),
                Name = DataGrid.Rows[index].Cells["CourseName"].Value.ToString()
            };

            DataElementChoiced.Emit(EventArgs.Empty);
        }
    }
}
