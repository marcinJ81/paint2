using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint.PaintTools
{
    public interface ICoordinates
    {
        Point setStartCoordinates(int x, int y);
        Point setEndCoordinates(int x, int y);
    }

    public class Cooordinates : ICoordinates
    {
        public Point setEndCoordinates(int x, int y)
        {
            Point pointEnd;
            pointEnd = new Point(x, y);
            return pointEnd;
        }

        public Point setStartCoordinates(int x, int y)
        {
            Point pointStart;
            pointStart = new Point(x, y);
            return pointStart;
        }
    }
}
