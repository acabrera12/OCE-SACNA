using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OCESACNA.Engine.Collections;
using OCESACNA.Engine.DBCollections;
using OCESACNA.View.Collections;

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
            if (DataGrid.Columns[e.ColumnIndex].Name != "Selection")
            {
                return;
            }

            int index = e.RowIndex;

            if (index >= 0)
            {
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
}
