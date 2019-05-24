using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint.PaintTools
{
    public class EmptyEllipse : APenToolType
    {
        public EmptyEllipse(PictureBox canvasControl, int size, int xEnd, int yEnd, int xStart, int yStart, ICoordinates icoordintes)
            : base(canvasControl, size, xEnd, yEnd, xStart, yStart, icoordintes)
        {
            this.specificNameTool = "Empty Ellipse";
        }

        public override string specificNameTool { get; set; }

        public override bool getMainToolTypePen(IPenTool ipen, Color color)
        {
            base.graphic.DrawEllipse(ipen.getPenTool(base.size, color), base.pointStart.X, base.pointStart.Y,
                (base.pointEnd.X - base.pointStart.X), (base.pointEnd.Y - base.pointStart.Y));
            return true;
        }


    }

    public class LineWithPen : APenToolType
    {
        public LineWithPen(PictureBox canvasControl, int size, int xEnd, int yEnd, int xStart, int yStart, ICoordinates icoordintes)
            : base(canvasControl, size, xEnd, yEnd, xStart, yStart, icoordintes)
        {
            this.specificNameTool = "Line";
        }

        public override string specificNameTool { get; set; }

        public override bool getMainToolTypePen(IPenTool ipen, Color color)
        {
            base.graphic.DrawLine(ipen.getPenTool(base.size, color), base.pointStart, base.pointEnd);
            return true;
        }


    }

    public class EmptyRectangle : APenToolType
    {
        public EmptyRectangle(PictureBox canvasControl, int size, int xEnd, int yEnd, int xStart, int yStart, ICoordinates icoordintes) 
            : base(canvasControl, size, xEnd, yEnd, xStart, yStart, icoordintes)
        {
            this.specificNameTool = "Empty Rectangle";
        }

        public override string specificNameTool { get; set; }

        public override bool getMainToolTypePen(IPenTool ipen, Color color)
        {
            base.graphic.DrawRectangle(ipen.getPenTool(base.size, color), base.pointStart.X, base.pointStart.Y, 
                (base.pointEnd.X - base.pointStart.X), (base.pointEnd.Y - base.pointStart.Y));
            return true;
        }


    }


}
