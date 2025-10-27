using OCESACNA.Controller;
using OCESACNA.View.Collections;
using System;
using System.Windows.Forms;

namespace OCESACNA.View.Forms
{
    public partial class SelectSubjectModuleForm : Form, ISelectionForm<SubjectModule>
    {
        public SelectSubjectModuleForm()
        {
            InitializeComponent();
            LoadData();
        }

        public SubjectModule SelectedItem { get; set; }

        public event SelectionFormEventHanlder<SubjectModule> Acepted;
        public event EventHandler Aborted;

        private void AbortButton_Click(object sender, EventArgs e)
        {
            OnAbort();
        }

        private void AceptButton_Click(object sender, EventArgs e)
        {
            if (SelectedItem == null)
            {
                MessageBox.Show("Seleccione un elemento primero.");
                return;
            }

            OnAcept(SelectedItem);
        }

        public void Clear()
        {
            SelectedItem = null;
            SelectBox.Text = "Seleccionar";
        }

        public void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid.Columns[e.ColumnIndex].Name != "Selection")
                return;

            int index = e.RowIndex;
            SelectedItem = (SubjectModule)DataGrid.Rows[index].Cells["SubjectModuleValue"].Value;
            SelectBox.Text = SelectedItem.Name;
        }

        public void LoadData()
        {
            if (DataGrid.Rows.Count != 0)
                DataGrid.Rows.Clear();

            foreach (SubjectModule subjectModule in DataController.GetAllSubjectModules())
                DataGrid.Rows.Add(new object[]
                {
                    "",
                    subjectModule,
                    subjectModule.Name
                });
        }

        protected void OnAbort()
        {
            Clear();
            Aborted?.Invoke(this, EventArgs.Empty);
        }

        protected void OnAcept(SubjectModule selectedSubjectModule)
        {
            Acepted?.Invoke(selectedSubjectModule);
        }

        private void SelectSubjectModuleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnAbort();
        }
    }
}
