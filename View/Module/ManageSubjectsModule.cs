using System.Windows.Forms;
using OCESACNA.Engine.Collections;
using OCESACNA.Engine.Core;
using OCESACNA.View.Forms;
using System;
using System.Collections.Generic;

namespace OCESACNA.View.Module
{
    public partial class ManageSubjectsModule : Form
    {
        readonly SubjectForm SubjectDataForm;
        int selectedID = -1;

        public ManageSubjectsModule()
        {
            InitializeComponent();
            SubjectDataForm = new SubjectForm();
            SubjectDataForm.Acepted.Connect(SubjectDataForm_Acepted);
            SubjectDataForm.Canceled.Connect(SubjectDataForm_Canceled);
        }

        private void ManageSubjectsModule_Load(object sender, EventArgs e)
        {
            ConnectManager.GetAllSubjects(ReciveSubjectsData);
            ConnectManager.DataModified.Connect(UpdateSubjectsData);
        }

        private void UpdateSubjectsData(object sender, EventArgs e)
        {
            ConnectManager.GetAllSubjects(ReciveSubjectsData);
        }

        private void ReciveSubjectsData(object sender, RequestEventArgs e)
        {
            if (InvokeRequired)
            {
                Subject[] list = new Subject[e.Response.Count];

                int index = 0;
                foreach (Dictionary<string, dynamic> dic in e.Response)
                {
                    Subject subject = ConversionManager.DictionaryToSubject(dic);

                    list.SetValue(subject, index);
                    index++;
                }

                Invoke(new Action(() => GetSubjectsData(list)));
            }
        }

        private void GetSubjectsData(Subject[] list)
        {
            if (DataGrid.Rows.Count != 0)
            {
                DataGrid.Rows.Clear();
            }
            foreach(Subject s in list)
            {
                DataGrid.Rows.Add(new object[] {
                    "", s.SubjectID, s.SbjetModule, s.SbjetModule.Name, s.Name, s.Teach, s.Teach.FullName, s.Course, 
                    $"{Engine.Engine.YearsNames[s.Course.Year]} de {s.Course.Mention} '{s.Course.Section}'"
                });
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            SubjectDataForm.ClearData();
            SubjectDataForm.FormType = SubjectForm.DataFormType.Create;
            SubjectDataForm.ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Seleccione un elemento");
                return;
            }

            SubjectDataForm.SetData(Engine.Engine.Subjects.Find(t => t.SubjectID == selectedID));
            SubjectDataForm.FormType = SubjectForm.DataFormType.Update;
            SubjectDataForm.ShowDialog();
        }

        private void EraseBtn_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Seleccione un elemento");
                return;
            }

            string name = Engine.Engine.Subjects.Find(t => t.SubjectID == selectedID).Name;

            if (MessageBox.Show($"¿Quieres eliminar la asignatura '{name}' (ID:{selectedID})?\nEsta acción no se puede revertir", "Confirmar Acción", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            ConnectManager.DeleteSubject(selectedID);

            selectedID = -1;
            Clear();
        }

        private void SubjectDataForm_Acepted(object sender, EventArgs e)
        {
            switch (SubjectDataForm.FormType)
            {
                case SubjectForm.DataFormType.None:
                    return;
                case SubjectForm.DataFormType.Create:
                    CreatedConfirmed();
                    break;
                case SubjectForm.DataFormType.Update:
                    UpdateConfirmed();
                    break;
            }
        }

        private void SubjectDataForm_Canceled(object sender, EventArgs e)
        {
            SubjectForm.DataFormType s = SubjectDataForm.FormType;
            Console.WriteLine($"{GetType()}: action {s} canceled");

            SubjectDataForm.FormType = SubjectForm.DataFormType.None;
        }

        private void CreatedConfirmed()
        {
            Subject subject;
            try
            {
                subject = SubjectDataForm.GetDataAndHide();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{GetType()}: {e}");
                MessageBox.Show("Alguno de los campos es inválido");
                return;
            }

            ConnectManager.AddSubject(ConversionManager.SubjectToDBSubject(subject));
            Clear();
        }

        private void UpdateConfirmed()
        {
            Subject subject;
            try
            {
                subject = SubjectDataForm.GetDataAndHide();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{GetType()}: {e}");
                MessageBox.Show("Alguno de los campos es inválido");
                return;
            }

            ConnectManager.UpdateSubject(ConversionManager.SubjectToDBSubject(subject));
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
            SubjectDataForm.ClearData();
        }
    }
}
