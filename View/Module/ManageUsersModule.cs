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
        public ManageUsersModule()
        {
            InitializeComponent();
        }

        private void ManageUsersModule_Load(object sender, EventArgs e)
        {
            ConnectManager.GetAllUsers(ReciveUsersData);
            RankBox.Items.Add(new ComboBoxElement() { Value = User.RANKING.USER, Text = "Usuario" });
            RankBox.Items.Add(new ComboBoxElement() { Value = User.RANKING.ADMIN, Text = "Administrador" });

            RankBox.DisplayMember = "Text";
            RankBox.ValueMember = "Value";
            RankBox.SelectedIndex = 0;

            StateBox.Items.Add(new ComboBoxElement() { Value = User.STATES.ACTIVE, Text = "Activo" });
            StateBox.Items.Add(new ComboBoxElement() { Value = User.STATES.INACTIVE, Text = "Inactivo" });

            StateBox.DisplayMember = "Text";
            StateBox.ValueMember = "Value";
            StateBox.SelectedIndex = 0;
        }

        private void ReciveUsersData(object sender, RequestEventArgs eventArgs)
        {
            if (InvokeRequired)
            {
                User[] list = new User[eventArgs.response.Count];
                int index = 0;

                foreach (Dictionary<string, dynamic> dic in eventArgs.response)
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
            foreach (User user in list)
            {
                DataGrid.Rows.Add(new object[] { "", user.UserID, user.UserName, user.Password, User.GetRankingText(user.Rank), User.GetStateText(user.State) });
            }
        }
    }
}
