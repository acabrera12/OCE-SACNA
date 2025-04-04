using ScoreModule = OCESACNA.Controller.ScoreModule;
using System.Windows.Forms;

namespace OCESACNA.View.Collections
{
    /// <summary>
    /// Representa una columna de <see cref="DataGridView"/> que almacena valores de <see cref="ScoreModule"/>
    /// </summary>
    public class DataGridViewScoreModuleColumn : DataGridViewColumn
    {
        /// <summary>
        /// Inicializa una instancia de la clase <see cref="DataGridViewScoreModuleColumn"/>
        /// </summary>
        public DataGridViewScoreModuleColumn()
        {
            CellTemplate = new DataGridViewScoreModuleCell();
        }

        public override object Clone()
        {
            return (DataGridViewScoreModuleColumn)base.Clone();
        }
    }
}
