using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint
{  
    public interface IPenTool
    {
        Pen ChangeSize(IPenTool ipenTool, int size, Color color);
        Color ChangeColor(Color color);
        Point ChangePointXY(Point pstartX);
       
    }
    public class PenTool : IPenTool
    {
        private Color color { get; set; }
        private Point point { get; set; }
        public int pointX { get; set;}
        public int pointY { get; set; }
        public string name { get; set; }
        public bool active { get; set; }

        public PenTool(){ }
        public PenTool(int x, int y,Color color)
            :this()
        {
            this.color = color;
            this.point = new Point(x,y);
            this.pointX = point.X;
            this.pointY = point.Y;
        }
        public Color ChangeColor(Color color)
        {
            this.color = color;
            return color;
        }

        public Point ChangePointXY(Point pstartXY)
        {
            this.point = pstartXY;
            this.pointX = point.X;
            this.pointY = point.Y;

            return this.point;
        }

        public Pen ChangeSize(IPenTool ipenTool, int size,Color color )
        {
            Pen myPen = new Pen(ipenTool.ChangeColor(color), (float)size);
            return myPen;
        }

    }
}
