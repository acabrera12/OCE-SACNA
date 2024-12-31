using OCESACNA.Engine.Collections;
using OCESACNA.Engine.Core;
using OCESACNA.View.Collections;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OCESACNA.View.Module
{
    public partial class ManageUsersModule : Form
    {
        int selectedID;
        public ManageUsersModule()
        {
            InitializeComponent();
        }

        private void ManageUsersModule_Load(object sender, EventArgs e)
        {
            ConnectManager.GetAllUsers(ReciveUsersData);
            ConnectManager.DataModified.Connect(UpdateUsersData);
            RankBox.Items.Add(new RankComboBoxElement("Usuario", User.RANKING.USER));
            RankBox.Items.Add(new RankComboBoxElement("Administrador", User.RANKING.ADMIN));

            RankBox.DisplayMember = "Text";
            RankBox.ValueMember = "Value";
            RankBox.SelectedIndex = 0;

            StateBox.Items.Add(new StateComboBoxElement("Activo", User.STATES.ACTIVE));
            StateBox.Items.Add(new StateComboBoxElement("No Activo", User.STATES.INACTIVE));

            StateBox.DisplayMember = "Text";
            StateBox.ValueMember = "Value";
            StateBox.SelectedIndex = 0;

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

        private void UpdateUsersData(object sender, EventArgs e)
        {
            ConnectManager.GetAllUsers(ReciveUsersData);
        }

        private void ReciveUsersData(object sender, RequestEventArgs eventArgs)
        {
            if (InvokeRequired)
            {
                User[] list = new User[eventArgs.Response.Count];
                int index = 0;

                foreach (Dictionary<string, dynamic> dic in eventArgs.Response)
                {
                    User user = ConversionManager.DictionaryToUser(dic);

                    list.SetValue(user, index);
                    index++;
                }

                Invoke(new Action(() => GetUsers(list)));
            }
        }

        private void GetUsers(User[] list)
        {
            if (DataGrid.Rows.Count != 0)
            {
                DataGrid.Rows.Clear();
            }
            foreach (User user in list)
            {
                DataGrid.Rows.Add(new object[] { "", user.UserID, user.UserName, user.Password, user.Rank, User.GetRankingText(user.Rank), user.State, User.GetStateText(user.State) });
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            UserNameBox.Text = UserNameBox.Text.Replace(" ", "");
            PasswordBox.Text = PasswordBox.Text.Replace(" ", "");
            ConfirnPasswordBox.Text = ConfirnPasswordBox.Text.Replace(" ", "");

            if (UserNameBox.Text == "" || PasswordBox.Text == "" || ConfirnPasswordBox.Text == "")
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }

            string username = UserNameBox.Text;
            string password = PasswordBox.Text;

            if (password != ConfirnPasswordBox.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            User.RANKING rank = ((RankComboBoxElement)RankBox.Items[RankBox.SelectedIndex]).Value;
            User.STATES state = ((StateComboBoxElement)StateBox.Items[StateBox.SelectedIndex]).Value;

            User user = new User(-1, username, password, rank, state);

            ConnectManager.AddUser(ConversionManager.UserToDBUser(user));
            Clear();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Seleccione un elemento");
                return;
            }

            UserNameBox.Text = UserNameBox.Text.Replace(" ", "");
            PasswordBox.Text = PasswordBox.Text.Replace(" ", "");
            ConfirnPasswordBox.Text = ConfirnPasswordBox.Text.Replace(" ", "");

            if (UserNameBox.Text == "" || PasswordBox.Text == "" || ConfirnPasswordBox.Text == "")
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }

            string username = UserNameBox.Text;
            string password = PasswordBox.Text;

            if (password != ConfirnPasswordBox.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            User.RANKING rank = ((RankComboBoxElement)RankBox.Items[RankBox.SelectedIndex]).Value;
            User.STATES state = ((StateComboBoxElement)StateBox.Items[StateBox.SelectedIndex]).Value;

            User user = new User(selectedID, username, password, rank, state);

            ConnectManager.UpdateUser(ConversionManager.UserToDBUser(user));
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
            if (MessageBox.Show($"¿Quieres eliminar el Usuario con el ID {selectedID}? Esta acción no se puede revertir.", "Confirar acción", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ConnectManager.DeleteUser(selectedID);
                selectedID = -1;
                Clear();
            }
        }

        bool isEditing = false;

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (isEditing)
            {
                CreateBtn.Enabled = false;

                if (UserNameBox.Text == "" && PasswordBox.Text == "" && ConfirnPasswordBox.Text == "")
                {
                    isEditing = false;
                    CreateBtn.Enabled = true;
                }
                return;
            }

            if (UserNameBox.Text != "" || PasswordBox.Text != "" || ConfirnPasswordBox.Text != "")
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

            if (index >= 1)
            {
                isEditing = true;
                selectedID = int.Parse(DataGrid.Rows[index].Cells["ID"].Value.ToString());
                UserNameBox.Text = DataGrid.Rows[index].Cells["UserName"].Value.ToString();
                PasswordBox.Text = DataGrid.Rows[index].Cells["Password"].Value.ToString();
                ConfirnPasswordBox.Text = DataGrid.Rows[index].Cells["Password"].Value.ToString();

                foreach (RankComboBoxElement cbe in RankBox.Items)
                {
                    if (cbe.Value.ToString() == DataGrid.Rows[index].Cells["RankValue"].Value.ToString())
                    {
                        int cbeindex = RankBox.Items.IndexOf(cbe);
                        RankBox.SelectedIndex = cbeindex;
                        break;
                    }
                }

                foreach (StateComboBoxElement cbe in StateBox.Items)
                {
                    if (cbe.Value.ToString() == DataGrid.Rows[index].Cells["StateValue"].Value.ToString())
                    {
                        int cbeindex = StateBox.Items.IndexOf(cbe);
                        StateBox.SelectedIndex = cbeindex;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No es aplicable a este elemento");
            }
        }

        private void Clear()
        {
            UserNameBox.Text = string.Empty;
            PasswordBox.Text = string.Empty;
            ConfirnPasswordBox.Text = string.Empty;
            RankBox.SelectedIndex = 0;
            StateBox.SelectedIndex = 0;
        }
    }
}
