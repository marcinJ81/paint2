using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint.PaintTools
{
    public abstract class AMainTools
    {
        public Point pointStart { get; private set; }
        public Point pointEnd { get; private set; }
        public int size { get; set; }

        public AMainTools(int size, int xEnd, int yEnd, int xStart, int yStart, ICoordinates icoordintes)
        {
            this.pointEnd = icoordintes.setEndCoordinates(xEnd, yEnd);
            //defalut values for start coodinates are 0 (usually)
            this.pointStart = icoordintes.setStartCoordinates(xStart, yStart);
            this.size = size;
        }
    }

    public abstract class AGraphicCanvas : AMainTools
    {
        public Graphics graphic { get; private set; }

        public AGraphicCanvas(PictureBox canvasControl, int size, int xEnd, int yEnd, int xStart, int yStart, ICoordinates icoordintes)
            : base(size, xEnd, yEnd, xStart, yStart, icoordintes)
        {
            this.graphic = canvasControl.CreateGraphics();
        }
    }

    public abstract class APenToolType : AGraphicCanvas
    {
        public APenToolType(PictureBox canvasControl,int size, int xEnd, int yEnd, int xStart, int yStart, ICoordinates icoordintes) 
            : base(canvasControl,size, xEnd, yEnd, xStart, yStart, icoordintes)
        {
        }

        public abstract bool getMainToolTypePen(IPenTool ipen, Color color, string name);
    }

    public abstract class ABrushToolType : AGraphicCanvas
    {
        public ABrushToolType(PictureBox canvasControl,int size, int xEnd, int yEnd, int xStart, int yStart, ICoordinates icoordintes)
            : base(canvasControl, size, xEnd, yEnd, xStart, yStart, icoordintes)
        {
        }

        public abstract bool getMainToolTypeBrush(IToolBrush ibrush, Color color, string name);
    }





}
