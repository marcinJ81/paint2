using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint.PaintTools
{
    public abstract class APenToolType : ACoordinates
    {
        public abstract string specificNameTool { get; set; }
        public APenToolType(PictureBox canvasControl, int size, int xEnd, int yEnd, int xStart, int yStart, ICoordinates icoordintes)
            : base(canvasControl, size, xEnd, yEnd, xStart, yStart, icoordintes)
        {
        }
        public abstract bool getMainToolTypePen(IPenTool ipen, Color color);
    }
}
