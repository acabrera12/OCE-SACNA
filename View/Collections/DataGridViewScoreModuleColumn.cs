using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCESACNA.View.Collections
{
    class DataGridViewScoreModuleColumn : DataGridViewColumn
    {
        public DataGridViewScoreModuleColumn()
        {
            this.CellTemplate = new DataGridViewScoreModuleCell();
        }

        public override object Clone()
        {
            return (DataGridViewScoreModuleColumn)base.Clone();
        }
    }
}
