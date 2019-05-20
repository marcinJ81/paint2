using paint.PaintTools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint.PaintTools
{
    public class RectangleTool : APenToolType
    {
        public string toolName { get; private set; }
        public RectangleTool(string name,PictureBox canvasControl,int size, int xEnd, int yEnd, int xStart, int yStart, ICoordinates icoordintes) 
            : base(canvasControl,size, xEnd, yEnd, xStart, yStart, icoordintes)
        {
            this.toolName = name;
        }

        public override bool getMainToolTypePen(IPenTool ipen, Color color, string name)
        {
            if (this.toolName == name)
            {
                base.graphic.DrawRectangle(ipen.getPenTool(base.size, color), base.pointStart.X, base.pointStart.Y,
               (base.pointEnd.X - base.pointStart.X), (base.pointEnd.Y - base.pointStart.Y));
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
