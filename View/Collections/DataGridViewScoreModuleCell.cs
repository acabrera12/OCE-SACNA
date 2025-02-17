using System;
using System.Drawing;
using System.Windows.Forms;

namespace OCESACNA.View.Collections
{
    class DataGridViewScoreModuleCell : DataGridViewTextBoxCell
    {
        public new Engine.Collections.ScoreModule Value { get; set; }

        public DataGridViewScoreModuleCell()
        {
            this.Value = new Engine.Collections.ScoreModule();
        }

        public override object Clone()
        {
            DataGridViewScoreModuleCell cell = (DataGridViewScoreModuleCell)base.Clone();
            cell.Value = this.Value;

            return cell;
        }

        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {

        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            int widthPerValue = cellBounds.Width / 3;

            Rectangle react1 = new Rectangle(cellBounds.Left, cellBounds.Top, widthPerValue, cellBounds.Height);
            Rectangle react2 = new Rectangle(cellBounds.Left + widthPerValue, cellBounds.Top, widthPerValue, cellBounds.Height);
            Rectangle react3 = new Rectangle(cellBounds.Left + 2 * widthPerValue, cellBounds.Top, widthPerValue, cellBounds.Height);

            TextRenderer.DrawText(graphics, Value.Score.ToString(), cellStyle.Font, react1, cellStyle.ForeColor);
            TextRenderer.DrawText(graphics, Value.DefScore.ToString(), cellStyle.Font, react2, cellStyle.ForeColor);
            TextRenderer.DrawText(graphics, Value.Inas.ToString(), cellStyle.Font, react3, cellStyle.ForeColor);

            Pen pen = new Pen(SystemColors.ControlDark);

            graphics.DrawRectangle(pen, react1.Left, react1.Top - 1, react1.Width, react1.Height);
            graphics.DrawRectangle(pen, react2.Left, react2.Top - 1, react2.Width, react2.Height);
            graphics.DrawRectangle(pen, react3.Left, react3.Top - 1, react3.Width, react3.Height);
        }

        public override Type EditType
        {
            get { return null; }
        }

        public override Type FormattedValueType => base.FormattedValueType;

        public override Type ValueType => base.ValueType;

        public override object DefaultNewRowValue => base.DefaultNewRowValue;
    }
}
