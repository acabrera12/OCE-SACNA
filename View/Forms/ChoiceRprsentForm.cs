using OCESACNA.Engine.Collections;
using System;
using System.Windows.Forms;

namespace OCESACNA.View.Forms
{
    public partial class ChoiceRprsentForm : Form
    {
        public ChoiceRprsentForm()
        {
            InitializeComponent();
        }

        public Signal DataElementChoiced = new Signal();
        public Representative Choiced;

        private void ChoiceRprsentForm_Load(object sender, EventArgs e)
        {
            foreach (Representative representative in Engine.Engine.Representatives)
            {
                DataGrid.Rows.Add(new object[] {
                    "", representative.RprsentID, representative.FullName, representative.PhoneNumber, representative.Email
                });
            }
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (DataGrid.Columns[e.ColumnIndex].Name != "Selection" || index < 0)
            {
                return;
            }

            Choiced = new Representative(
                int.Parse(DataGrid.Rows[index].Cells["ID"].Value.ToString()),
                DataGrid.Rows[index].Cells["FullName"].Value.ToString(),
                DataGrid.Rows[index].Cells["PhoneNumber"].Value.ToString(),
                DataGrid.Rows[index].Cells["Email"].Value.ToString()
            );

            DataElementChoiced.Emit(EventArgs.Empty);
        }
    }
}
