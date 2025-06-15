using OCESACNA.Controller;
using OCESACNA.View.Collections;
using OCESACNA.View.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OCESACNA.View.Module
{
    /// <summary>
    /// Módulo de gestión de usuarios
    /// </summary>
    public partial class UserManagementModule : Form, IColoreable, IModule
    {
        public bool IsEditing { get; set; } = false;

        public int SelectedIndex { get; set; } = -1;

        /// <summary>
        /// Obtiene o establece el usuario seleccionado
        /// </summary>
        private User SelectedUser { get; set; }

        /// <summary>
        /// Obtiene o establece el formulario de cambio de contraseña de usuario
        /// </summary>
        private ChangeUserPasswordForm ChangeUserPasswordForm { get; set; }

        /// <summary>
        /// Inicializa una instancia del formulario
        /// </summary>
        public UserManagementModule()
        {
            InitializeComponent();
            ApplyTheme(Program.CurrentTheme);
            LoadData();

            ChangeUserPasswordForm = new ChangeUserPasswordForm();
            ChangeUserPasswordForm.Acepted += ChangeUserPasswordForm_Acepted;
            Program.CurrentTheme.DarkModeChanged += ColorTheme_DarkModeChanged;
            ColorTheme.ThemeChanged += ColorTheme_ThemeChanged;
            DataController.UserDataModified += LoadData;

            for (int rank = 2; rank <= (int)User.Ranking.ADMIN; rank++)
            {
                RankBox.Items.Add(new ComboBoxElement<User.Ranking>(User.GetRankingText((User.Ranking)rank), (User.Ranking)rank));
            }

            for (int state = 1; state <= (int)User.States.DISABLED; state++)
            {
                StateBox.Items.Add(new ComboBoxElement<User.States>(User.GetStatesText((User.States)state), (User.States)state));
            }

            ComboBoxElement.SetupComboBox(RankBox, true);
            ComboBoxElement.SetupComboBox(StateBox, true);
        }

        public void ApplyTheme(ColorTheme theme)
        {
            // this
            theme.ApplyBackgroundStyle(this);

            // LeftPanel 
            theme.ApplyForeStyle(LeftPanel);

            // CreateButton, EditButton, EraseButton, ChangePasswordButton
            theme.ApplyButtonStyle(CreateButton, EditButton, EraseButton, ChangePasswordButton);

            // UserNameLabel, PasswordLabel, ConfirmPassworLabel, RankLabel, StateLabel
            theme.ApplyFontStyle(ColorTheme.BackgroundType.ForeBackground,
                UserNameLabel, PasswordLabel, ConfirmPassworLabel, RankLabel,
                StateLabel);
        }

        public void ColorTheme_ThemeChanged(ColorTheme theme)
        {
            ApplyTheme(theme);
        }

        public void ColorTheme_DarkModeChanged(bool value)
        {
            ApplyTheme(Program.CurrentTheme);
        }

        public void LoadData()
        {
            if (DataGrid.Rows.Count != 0)
            {
                DataGrid.Rows.Clear();
            }

            foreach (User user in DataController.GetAllUsers())
            {
                DataGrid.Rows.Add(new object[]
                { "", user, user.UserName,
                    User.GetRankingText(user.Rank),
                    User.GetStatesText(user.State)
                });
            }
        }

        public void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                CreateButton.Enabled = false;

                if (TextFilter.IsAllTextBoxesTextEmpty(new TextBox[] { UserNameBox, PasswordBox, ConfirmPasswordBox }))
                {
                    IsEditing = false;
                    CreateButton.Enabled = true;

                    PasswordBox.Visible = true;
                    PasswordLabel.Visible = true;

                    ConfirmPasswordBox.Visible = true;
                    ConfirmPassworLabel.Visible = true;

                    ChangePasswordButton.Visible = false;
                }
                return;
            }

            bool textBoxContainsText = TextFilter.IsAllTextBoxesTextEmpty(new TextBox[] { UserNameBox, PasswordBox, ConfirmPasswordBox });

            EraseButton.Enabled = textBoxContainsText;
            EditButton.Enabled = textBoxContainsText;
        }

        public void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid.Columns[e.ColumnIndex].Name != "Selection")
            {
                return;
            }

            int index = e.RowIndex;

            if (!TextFilter.IsAllTextBoxesTextEmpty(new TextBox[] { PasswordBox, ConfirmPasswordBox }))
            {
                PasswordBox.Text = string.Empty;
                ConfirmPasswordBox.Text = string.Empty;
            }

            IsEditing = true;
            User user = (User)DataGrid.Rows[index].Cells["UserValue"].Value;
            SelectedIndex = user.UserID;
            UserNameBox.Text = user.UserName;

            SelectedUser = user;
            PasswordBox.Visible = false;
            PasswordLabel.Visible = false;
            ConfirmPasswordBox.Visible = false;
            ConfirmPassworLabel.Visible = false;
            ChangePasswordButton.Visible = true;

            foreach (ComboBoxElement<User.Ranking> boxElement in RankBox.Items)
            {
                if (boxElement.Value == user.Rank)
                {
                    RankBox.SelectedItem = boxElement;
                    break;
                }
            }

            foreach (ComboBoxElement<User.States> boxElement in StateBox.Items)
            {
                if (boxElement.Value == user.State)
                {
                    StateBox.SelectedItem = boxElement;
                    break;
                }
            }
        }

        public void CreateButton_Click(object sender, EventArgs e)
        {
            TextFilter.ReplaceSpacesInTextBox(UserNameBox);
            TextFilter.ReplaceSpacesInTextBox(PasswordBox);
            TextFilter.ReplaceSpacesInTextBox(ConfirmPasswordBox);

            if (TextFilter.IsOneTextBoxTextEmpty(new TextBox[] { UserNameBox, PasswordBox, ConfirmPasswordBox }))
            {
                MessageBox.Show("Rellene todos los campos primero");
                return;
            }

            string username = UserNameBox.Text;

            if (DataController.GetAllUsers().Where(item => item.UserName == username).Count() != 0)
            {
                MessageBox.Show($"Ya existe un usuario con el nombre\n\"{username}\", elija otro");
                return;
            }

            string password = PasswordBox.Text;
            string password2 = ConfirmPasswordBox.Text;

            if (!TextFilter.IsValidPasswordText(password) || !TextFilter.IsValidPasswordText(password2))
            {
                MessageBox.Show("Uno o ambos campos de contraseña\nposeen caracteres inválidos");
                return;
            }

            if (password != password2)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            User.Ranking rank = ((ComboBoxElement<User.Ranking>)RankBox.Items[RankBox.SelectedIndex]).Value;
            User.States state = ((ComboBoxElement<User.States>)StateBox.Items[StateBox.SelectedIndex]).Value;

            User user = new User(-1, username, password, "", rank, state);
            user.GenerateSafePassword(user.Password);

            // Comprueba que las contraseñas se hayan encriptado correctamente
            // Este caso no debería pasar
            if (!user.IsValidPassword(password))
            {
                MessageBox.Show("Ha habido un error inesperado al\nmomento de encriptar los datos. No\nse han almacenado los datos");
                return;
            }

            DataController.AddUser(user);
            Clear();
        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            TextFilter.ReplaceSpacesInTextBox(UserNameBox);
            TextFilter.ReplaceSpacesInTextBox(PasswordBox);
            TextFilter.ReplaceSpacesInTextBox(ConfirmPasswordBox);

            if (TextFilter.IsOneTextBoxTextEmpty(new TextBox[] { UserNameBox, PasswordBox, ConfirmPasswordBox }))
            {
                MessageBox.Show("Rellene todos los campos primero");
                return;
            }

            if (SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento primero");
                return;
            }

            string username = UserNameBox.Text;

            if (username != SelectedUser.UserName && DataController.GetAllUsers().Where(item => item.UserName == username).Count() != 0)
            {
                MessageBox.Show($"Ya existe un usuario con el nombre\n\"{username}\", elija otro");
                return;
            }

            User.Ranking rank = ((ComboBoxElement<User.Ranking>)RankBox.Items[RankBox.SelectedIndex]).Value;
            User.States state = ((ComboBoxElement<User.States>)StateBox.Items[StateBox.SelectedIndex]).Value;

            if (DataController.GetAllUsers().Count() == 1 && state == User.States.DISABLED)
            {
                MessageBox.Show("No se puede desactivar, considere agregar\notro usuario antes.");
                return;
            }

            User user = new User()
            {
                UserID = SelectedUser.UserID,
                Password = SelectedUser.Password,
                PasswordHash = SelectedUser.PasswordHash,
                UserName = username,
                Rank = rank,
                State = state
            };

            DataController.UpdateUser(user);
            Clear();
        }

        public void EraseButton_Click(object sender, EventArgs e)
        {
            if (SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento primero");
                return;
            }

            var result = MessageBox.Show(
                $"¿Desea eliminar al usuario \"{SelectedUser.UserName}\"?" +
                $"\nEsta acción es inrreversible.",
                "Confirmar acción",
                MessageBoxButtons.YesNo
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            if (SelectedUser.Rank == User.Ranking.ADMIN && SelectedUser.State == User.States.ENABLED)
            {
                MessageBox.Show(
                    "No se puede eliminar, los usuarios administradores\n" +
                    "son indispensables para el sistema. Si desea eliminarlo\n" +
                    "considere cambiar su estado a desactivado primero y\n" +
                    "luego eliminelo."
                );
                return;
            }

            if (DataController.GetAllUsers().Count() == 1)
            {
                MessageBox.Show("No se puede eliminar, considere agregar\notro usuario antes.");
                return;
            }

            DataController.DeleteUser(SelectedUser.UserID);
            Clear();
        }

        /// <summary>
        /// Es llamado cuando se presiona el botón para cambiar la contraseña
        /// </summary>
        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            if (SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento primero");
                return;
            }

            ChangeUserPasswordForm.SetData(SelectedUser);
            ChangeUserPasswordForm.ShowDialog();
        }

        /// <summary>
        /// Es llamado cuando el formulario <see cref="ChangeUserPasswordForm"/> indica que fué aceptado
        /// </summary>
        private void ChangeUserPasswordForm_Acepted(object sender)
        {
            User user = ChangeUserPasswordForm.GetData();
            SelectedUser = user;
        }

        public void Clear()
        {
            SelectedIndex = -1;
            UserNameBox.Text = string.Empty;
            PasswordBox.Text = string.Empty;
            ConfirmPasswordBox.Text = string.Empty;
            RankBox.SelectedIndex = 0;
            StateBox.SelectedIndex = 0;
        }
    }
}
