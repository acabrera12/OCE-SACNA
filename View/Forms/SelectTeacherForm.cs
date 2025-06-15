using OCESACNA.Controller;
using OCESACNA.View.Collections;
using System;
using System.Windows.Forms;

namespace OCESACNA.View.Forms
{
    /// <summary>
    /// Representa el formulario de selección de docentes
    /// </summary>
    public partial class SelectTeacherForm : Form, IColoreable, ISelectionForm<Teacher>
    {
        public Teacher SelectedItem { get; set; }

        /// <summary>
        /// Inicializa una instancia del formulario
        /// </summary>
        public SelectTeacherForm()
        {
            InitializeComponent();
            ApplyTheme(Program.CurrentTheme);
            LoadData();
        }

        public event EventHandler Acepted;

        public event EventHandler Aborted;

        public void AbortButton_Click(object sender, EventArgs e)
        {
            OnAbort();
        }

        public void AceptButton_Click(object sender, EventArgs e)
        {
            if (SelectedItem == null)
            {
                MessageBox.Show("Seleccione un elemento primero.");
                return;
            }

            OnAcept();
        }

        public void ApplyTheme(ColorTheme theme)
        {
            // this
            theme.ApplyBackgroundStyle(this);
        }

        public void ColorTheme_DarkModeChanged(bool value)
        {
            ApplyTheme(Program.CurrentTheme);
        }

        public void ColorTheme_ThemeChanged(ColorTheme theme)
        {
            ApplyTheme(theme);
        }

        public void LoadData()
        {
            if (DataGrid.Rows.Count != 0)
            {
                DataGrid.Rows.Clear();
            }

            foreach (Teacher teacher in DataController.GetAllTeachers())
            {
                DataGrid.Rows.Add(new object[]
                {
                    "", teacher,
                    teacher.FullName
                });
            }
        }

        public void OnAbort()
        {
            Clear();
            Aborted?.Invoke(this, EventArgs.Empty);
        }

        public void OnAcept()
        {
            Acepted?.Invoke(this, EventArgs.Empty);
        }

        public void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid.Columns[e.ColumnIndex].Name != "Selection")
            {
                return;
            }

            int index = e.RowIndex;
            SelectedItem = (Teacher)DataGrid.Rows[index].Cells["TeacherValue"].Value;
            SelectBox.Text = SelectedItem.FullName;
        }

        /// <summary>
        /// Es llamado cuando se va a cerrar el formulario
        /// </summary>
        private void SelectTeacherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnAbort();
        }

        public void Clear()
        {
            SelectedItem = null;
            SelectBox.Text = "Seleccionar";
        }
    }
}
