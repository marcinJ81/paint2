using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint.PaintTools
{
    public class FullEllipse : ABrushToolType
    {
        public FullEllipse(PictureBox canvasControl, int size, int xEnd, int yEnd, int xStart, int yStart, ICoordinates icoordintes)
            : base(canvasControl, size, xEnd, yEnd, xStart, yStart, icoordintes)
        {
            specificNameTool = "Full Ellipse";
        }
        public override string specificNameTool { get; set; }

        public override bool getMainToolTypeBrush(IToolBrush ibrush, Color color)
        {
            base.graphic.FillEllipse(ibrush.setSolidBrush(color), base.pointStart.X, base.pointStart.Y,
                (base.pointEnd.X - base.pointStart.X), (base.pointEnd.Y - base.pointStart.Y));
            return true;
        }
    }

    public class FullRectangle : ABrushToolType
    {
        public FullRectangle(PictureBox canvasControl, int size, int xEnd, int yEnd, int xStart, int yStart, ICoordinates icoordintes)
            : base(canvasControl, size, xEnd, yEnd, xStart, yStart, icoordintes)
        {
            specificNameTool = "Full Rectangle";
        }

        public override string specificNameTool { get; set; }

        public override bool getMainToolTypeBrush(IToolBrush ibrush, Color color)
        {
            base.graphic.FillRectangle(ibrush.setSolidBrush(color), base.pointStart.X, base.pointStart.Y, 
                (base.pointEnd.X - base.pointStart.X), (base.pointEnd.Y - base.pointStart.Y));
            return true;
        }
    }
    public class Eraser : ABrushToolType
    {
        public Eraser(PictureBox canvasControl, int size, int xEnd, int yEnd, int xStart, int yStart, ICoordinates icoordintes) 
            : base(canvasControl, size, xEnd, yEnd, xStart, yStart, icoordintes)
        {
            this.specificNameTool = "Eraser";
        }

        public override string specificNameTool { get; set; }

        public override bool getMainToolTypeBrush(IToolBrush ibrush, Color color)
        {
            base.graphic.FillEllipse(ibrush.setSolidBrush(Color.White), base.pointStart.X, base.pointStart.Y, base.size, base.size);
            return true;
        }
    }
    public class SimpleBrush : ABrushToolType
    {
        public SimpleBrush(PictureBox canvasControl, int size, int xEnd, int yEnd, int xStart, int yStart, ICoordinates icoordintes)
            : base(canvasControl, size, xEnd, yEnd, xStart, yStart, icoordintes)
        {
            this.specificNameTool = "Simple Brush";
        }

        public override string specificNameTool { get; set; }

        public override bool getMainToolTypeBrush(IToolBrush ibrush, Color color)
        {
            base.graphic.FillEllipse(ibrush.setSolidBrush(color), base.pointStart.X, base.pointStart.Y, base.size, base.size);
            return true;
        }
    }

}
