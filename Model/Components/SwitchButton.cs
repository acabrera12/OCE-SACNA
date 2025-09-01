using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace OCESACNA.Model.Components
{
    public class SwitchButton : CheckBox
    {
        private Color fillColor = Color.AliceBlue;

        public SwitchButton()
        {

        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            var graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            
        }
    }
}
