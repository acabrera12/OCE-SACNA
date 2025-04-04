using System;
using System.Drawing;
using System.Windows.Forms;
using ScoreModule = OCESACNA.Controller.ScoreModule;

namespace OCESACNA.View.Collections
{
    /// <summary>
    /// Representa una celda individual del control <see cref="DataGridView"/> con valores <see cref="ScoreModule"/>
    /// </summary>
    public class DataGridViewScoreModuleCell : DataGridViewCell
    {
        /// <summary>
        /// Obtiene o establece el valor de la celda
        /// </summary>
        public new ScoreModule Value { get; set; }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="DataGridViewScoreModuleCell"/> vacía
        /// </summary>
        public DataGridViewScoreModuleCell()
        {
            Value = new ScoreModule();
        }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="DataGridViewScoreModuleCell"/>
        /// </summary>
        /// <param name="scoreModule">Conjunto de valores de una calificación</param>
        public DataGridViewScoreModuleCell(ScoreModule scoreModule)
        {
            Value = scoreModule;
        }

        public override object Clone()
        {
            using (DataGridViewScoreModuleCell cell = (DataGridViewScoreModuleCell)base.Clone())
            {
                cell.Value = Value;

                return cell;
            }
        }

        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            base.OnMouseClick(e);
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            int widthPerValue = cellBounds.Width / 3;

            Rectangle
                react1 = new Rectangle(cellBounds.Left, cellBounds.Top, widthPerValue, cellBounds.Height),
                react2 = new Rectangle(cellBounds.Left + widthPerValue, cellBounds.Top, widthPerValue, cellBounds.Height),
                react3 = new Rectangle(cellBounds.Left + 2 * widthPerValue, cellBounds.Top, widthPerValue, cellBounds.Height);

            TextRenderer.DrawText(graphics, Value.Score.ToString(), cellStyle.Font, react1, cellStyle.ForeColor);
            TextRenderer.DrawText(graphics, Value.ScoreDef.ToString(), cellStyle.Font, react2, cellStyle.ForeColor);
            TextRenderer.DrawText(graphics, Value.Inas.ToString(), cellStyle.Font, react3, cellStyle.ForeColor);

            Pen pen = new Pen(SystemColors.ControlDark);

            graphics.DrawRectangle(pen, react1.Left, react1.Top - 1, react1.Width, react1.Height);
            graphics.DrawRectangle(pen, react2.Left, react2.Top - 1, react2.Width, react2.Height);
            graphics.DrawRectangle(pen, react3.Left, react3.Top - 1, react3.Width, react3.Height);
        }

        public override Type EditType => null;

        public override Type FormattedValueType => base.FormattedValueType;

        public override Type ValueType => base.ValueType;

        public override object DefaultNewRowValue => base.DefaultNewRowValue;
    }
}