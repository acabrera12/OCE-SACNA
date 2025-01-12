using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OCESACNA.Engine.Core;
using OCESACNA.Engine.Collections;
using OCESACNA.View.Collections;

namespace OCESACNA.View.Module
{
    public partial class ManageSbjetModulesModule : Form
    {
        bool isEditing = false;
        int selectedID = -1;

        public ManageSbjetModulesModule()
        {
            InitializeComponent();
        }

        private void ManageSbjetModulesModule_Load(object sender, System.EventArgs e)
        {
            ConnectManager.GetAllSbjetModules(ReciveModulesData);
            ConnectManager.DataModified.Connect(UpdateModulesData);

            foreach (DataGridViewColumn column in DataGrid.Columns)
            {
                if (column.Visible && column.Name != "Selection")
                {
                    SearchByBox.Items.Add(new ComboBoxElement() { Value = column.Name, Text = column.HeaderText });
                }
            }
            SearchByBox.DisplayMember = "Text";
            SearchByBox.ValueMember = "Value";
            SearchByBox.SelectedIndex = 0;
        }

        private void UpdateModulesData(object sender, EventArgs e)
        {
            ConnectManager.GetAllSbjetModules(ReciveModulesData);
        }

        private void ReciveModulesData(object sender, RequestEventArgs e)
        {
            if (InvokeRequired)
            {
                SubjectModule[] list = new SubjectModule[e.Response.Count];
                int index = 0;

                foreach (Dictionary<string, dynamic> dic in e.Response)
                {
                    SubjectModule sbjm = ConversionManager.DictionaryToSbjetModule(dic);

                    list.SetValue(sbjm, index);
                    index++;
                }

                Invoke(new Action(() => GetModules(list)));
            }
        }

        private void GetModules(SubjectModule[] list)
        {
            if (DataGrid.Rows.Count != 0)
            {
                DataGrid.Rows.Clear();
            }
            foreach (SubjectModule sbjm in list)
            {
                DataGrid.Rows.Add(new object[] { "", sbjm.SbjetModuleID, sbjm.Name});
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (NameBox.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }

            if (NameBox.Text == "")
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }

            SubjectModule module = new SubjectModule(-1, NameBox.Text);

            ConnectManager.AddSbjetModule(ConversionManager.SubjectModuleToDBSubjectModule(module));
            Clear();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Seleccione un elemento");
                return;
            }

            if (NameBox.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }

            SubjectModule module = new SubjectModule(selectedID, NameBox.Text);

            ConnectManager.UpdateSbjetModule(ConversionManager.SubjectModuleToDBSubjectModule(module));
            Clear();
        }

        private void EraseBtn_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Seleccione un elemento");
                return;
            }
            if (MessageBox.Show($"¿Quieres eliminar el área de formación con el ID {selectedID}?\nEsta acción no se puede revertir.", "Confirar acción", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ConnectManager.DeleteSbjetModule(selectedID);
                selectedID = -1;
                Clear();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (isEditing)
            {
                CreateBtn.Enabled = false;

                if (NameBox.Text == "")
                {
                    isEditing = false;
                    CreateBtn.Enabled = true;
                }
                return;
            }

            if (NameBox.Text != "")
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

            int index = e.RowIndex;

            if (index >= 0)
            {
                isEditing = true;
                selectedID = int.Parse(DataGrid.Rows[index].Cells["ID"].Value.ToString());

                NameBox.Text = DataGrid.Rows[index].Cells["ModuleName"].Value.ToString();
            }
        }

        private void Clear()
        {
            NameBox.Text = string.Empty;
        }
    }
}
