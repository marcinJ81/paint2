using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint
{
    public abstract class AMainTools
    {
        public Point point { get; private set; }
        public int size { get; set; }

        public AMainTools(int size, int x,int y)
        {
            point = new Point(x, y);
            this.size = size;
        }
        public abstract void getMainTool(IPenTool ipen, IToolBrush ibrush, Color color, string name);
    }
    public interface IMainTools
    {
        void getMainTool(IPenTool ipen, IToolBrush ibrush, int size, Color color, int x, int y,string name);
       
    }

    public class EllipseTool : IMainTools
    {
        public void getMainTool(IPenTool ipen, IToolBrush ibrush, int size, Color color, int x, int y, string name)
        {
            throw new NotImplementedException();
        }
    }

    public class RectangleTool : IMainTools
    {
        public void getMainTool(IPenTool ipen, IToolBrush ibrush, int size, Color color, int x, int y, string name)
        {
            throw new NotImplementedException();
        }
    }

    public class Line : IMainTools
    {
        public void getMainTool(IPenTool ipen, IToolBrush ibrush, int size, Color color, int x, int y, string name)
        {
            throw new NotImplementedException();
        }
    }
    //public class MainTools
    // {
    //     private Graphics myGraphics;
    //     DrawLine(pen, pStart, pEnd);
    //     DrawRectangle(pen, pStart.X, pStart.Y, (pEnd.X - pStart.X), (pEnd.Y - pStart.Y));
    //     DrawEllipse(pen, pStart.X, pStart.Y, (pEnd.X - pStart.X), (pEnd.Y - pStart.Y));
    //     FillEllipse(brush, pStart.X, pStart.Y, (pEnd.X - pStart.X), (pEnd.Y - pStart.Y));
    //     FillRectangle(brush, pStart.X, pStart.Y, (pEnd.X - pStart.X), (pEnd.Y - pStart.Y));
    //     FillEllipse(brush, e.X, e.Y, (int)nudTRackBar.Value, (int)nudTRackBar.Value); //brush
    //     FillEllipse(ibrush.setSolidBrush(Color.White), e.X, e.Y, (int)nudTRackBar.Value, (int)nudTRackBar.Value);//eraser
    // }
}
