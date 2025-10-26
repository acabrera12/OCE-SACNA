using System;
using System.Windows.Forms;
using OCESACNA.Controller;
using OCESACNA.View.Collections;

namespace OCESACNA.View.Module
{
    /// <summary>
    /// Representa el formulario de gestión de representantes
    /// </summary>
    public partial class RepresentativeManagementModule : Form, IColoreable, IModule
    {
        public bool IsEditing { get; set; } = false;

        public int SelectedIndex { get; set; } = -1;

        /// <summary>
        /// Obtiene o establece el representante seleccionado
        /// </summary>
        private Representative SelectedRepresentative { get; set; }

        /// <summary>
        /// Inicializa una instancia del formulario
        /// </summary>
        public RepresentativeManagementModule()
        {
            InitializeComponent();
            ApplyTheme(Program.CurrentTheme);
            LoadData();

            ColorTheme.ThemeChanged += ColorTheme_ThemeChanged;
            Program.CurrentTheme.DarkModeChanged += ColorTheme_DarkModeChanged;
            DataController.RepresentativeDataModified += () =>
            {
                if (InvokeRequired)
                    Invoke(new Action(LoadData));
            };
        }

        public void ApplyTheme(ColorTheme theme)
        {
            // this
            theme.ApplyBackgroundStyle(this);

            // fore elements
            theme.ApplyForeStyle(LeftPanel, TopPanel);

            // buttons
            theme.ApplyButtonStyle(CreateButton, EditButton, EraseButton);
        }

        public void Clear()
        {
            SelectedRepresentative = null;
            SelectedIndex = -1;
            FullNameBox.Text = string.Empty;
            PhoneNumberBox.Text = string.Empty;
            EmailBox.Text = string.Empty;
        }

        public void ColorTheme_DarkModeChanged(bool value)
        {
            ApplyTheme(Program.CurrentTheme);
        }

        public void ColorTheme_ThemeChanged(ColorTheme theme)
        {
            ApplyTheme(theme);
        }

        public void CreateButton_Click(object sender, EventArgs e)
        {
            if (FullNameBox.Text.Replace(" ", "") == "" || PhoneNumberBox.Text.Replace(" ", "") == "" || EmailBox.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Rellene todos los campos primero");
                return;
            }

            Representative representative = new Representative()
            {
                RprsentID = -1,
                FullName = FullNameBox.Text,
                PhoneNumber = PhoneNumberBox.Text,
                Email = EmailBox.Text
            };

            DataController.AddRepresentative(representative);
            Clear();
        }

        public void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid.Columns[e.ColumnIndex].Name != "Selection")
            {
                return;
            }

            int index = e.RowIndex;

            IsEditing = true;
            SelectedIndex = index;
            SelectedRepresentative = (Representative)DataGrid.Rows[index].Cells["RepresentativeValue"].Value;

            FullNameBox.Text = SelectedRepresentative.FullName;
            PhoneNumberBox.Text = SelectedRepresentative.PhoneNumber;
            EmailBox.Text = SelectedRepresentative.Email;
        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            if (SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento primero");
                return;
            }

            if (FullNameBox.Text.Replace(" ","") == "" || PhoneNumberBox.Text.Replace(" ", "") == "" || EmailBox.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Rellene todos los campos primero");
                return;
            }

            Representative representative = new Representative()
            {
                RprsentID = SelectedRepresentative.RprsentID,
                FullName = FullNameBox.Text,
                PhoneNumber = PhoneNumberBox.Text,
                Email = EmailBox.Text
            };

            DataController.UpdateRepresentative(representative);
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
                $"¿Desea eliminar al representante?" +
                $"\nEsta acción es inrreversible.",
                "Confirmar acción",
                MessageBoxButtons.YesNo
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            DataController.DeleteRepresenative(SelectedRepresentative.RprsentID);
            Clear();
        }

        public void LoadData()
        {
            if (DataGrid.Rows.Count != 0)
            {
                DataGrid.Rows.Clear();
            }

            foreach (Representative representative in DataController.GetAllRepresentatives())
            {
                DataGrid.Rows.Add(new object[]
                {
                    "", representative,
                    representative.FullName,
                    representative.PhoneNumber,
                    representative.Email
                });
            }
        }

        public void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                CreateButton.Enabled = false;

                if (TextFilter.IsAllTextBoxesTextEmpty(new TextBox[] { FullNameBox, PhoneNumberBox, EmailBox }))
                {
                    IsEditing = false;
                    CreateButton.Enabled = true;
                }
                return;
            }

            bool textBoxContainsText = TextFilter.IsAllTextBoxesTextEmpty(new TextBox[] { FullNameBox, PhoneNumberBox, EmailBox });

            EraseButton.Enabled = textBoxContainsText;
            EditButton.Enabled = textBoxContainsText;
        }
    }
}
