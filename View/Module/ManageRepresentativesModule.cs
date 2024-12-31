using OCESACNA.Engine.Collections;
using OCESACNA.Engine.Core;
using OCESACNA.View.Collections;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OCESACNA.View.Module
{
    public partial class ManageRepresentativesModule : Form
    {
        int selectedID = -1;
        bool isEditing = false;

        public ManageRepresentativesModule()
        {
            InitializeComponent();
        }

        private void ManageRepresentativesModule_Load(object sender, EventArgs e)
        {
            ConnectManager.GetAllRepresentatives(ReciveRprsentativesData);
            ConnectManager.DataModified.Connect(UpdateRprsentativesData);

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

        private void UpdateRprsentativesData(object sender, EventArgs e)
        {
            ConnectManager.GetAllRepresentatives(ReciveRprsentativesData);
        }

        private void ReciveRprsentativesData(object sender, RequestEventArgs eventArgs)
        {
            if (InvokeRequired)
            {
                Representative[] list = new Representative[eventArgs.Response.Count];
                int index = 0;

                foreach (Dictionary<string, dynamic> dic in eventArgs.Response)
                {
                    Representative representative = ConversionManager.DictionaryToRprsentative(dic);

                    list.SetValue(representative, index);
                    index++;
                }

                Invoke(new Action(() => GetRprsentatives(list)));
            }
        }

        private void GetRprsentatives(Representative[] list)
        {
            if (DataGrid.Rows.Count != 0)
            {
                DataGrid.Rows.Clear();
            }
            foreach (Representative representative in list)
            {
                DataGrid.Rows.Add(new object[] { "", representative.RprsentID, representative.FullName, representative.PhoneNumber, representative.Email });
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (FullNameBox.Text.Replace(" ", "") == "" || PhoneNumberBox.Text.Replace(" ", "") == "" || EmailBox.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }

            if (FullNameBox.Text == "" || PhoneNumberBox.Text == "" || EmailBox.Text == "")
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }

            string fullname = FullNameBox.Text;
            string phone = PhoneNumberBox.Text;
            string email = EmailBox.Text;

            Representative rprsent = new Representative(-1, fullname, phone, email);

            ConnectManager.AddRepresentative(ConversionManager.RprsentativeToDBRprsentative(rprsent));
            Clear();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Seleccione un elemento");
                return;
            }

            if (FullNameBox.Text == "" || PhoneNumberBox.Text == "" || EmailBox.Text == "")
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }

            string fullname = FullNameBox.Text;
            string phone = PhoneNumberBox.Text;
            string email = EmailBox.Text;

            Representative rprsent = new Representative(selectedID, fullname, phone, email);

            ConnectManager.UpdateRepresentative(ConversionManager.RprsentativeToDBRprsentative(rprsent));
            selectedID = -1;
            Clear();
        }

        private void EraseBtn_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Seleccione un elemento");
                return;
            }
            if (MessageBox.Show($"¿Quieres eliminar al Representante con el ID {selectedID}? Esta acción no se puede revertir.", "Confirar acción", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ConnectManager.DeleteRepresentative(selectedID);
                selectedID = -1;
                Clear();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (isEditing)
            {
                CreateBtn.Enabled = false;

                if (FullNameBox.Text == "" && PhoneNumberBox.Text == "" && EmailBox.Text == "")
                {
                    isEditing = false;
                    CreateBtn.Enabled = true;
                }
                return;
            }

            if (FullNameBox.Text != "" || PhoneNumberBox.Text != "" || EmailBox.Text != "")
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

                FullNameBox.Text = DataGrid.Rows[index].Cells["FullName"].Value.ToString();
                PhoneNumberBox.Text = DataGrid.Rows[index].Cells["PhoneNumber"].Value.ToString();
                EmailBox.Text = DataGrid.Rows[index].Cells["Email"].Value.ToString();
            }
        }

        private void Clear()
        {
            FullNameBox.Text = string.Empty;
            PhoneNumberBox.Text = string.Empty;
            EmailBox.Text = string.Empty;
        }
    }
}
