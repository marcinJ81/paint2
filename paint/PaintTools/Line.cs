using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint.PaintTools
{
    public class Line : AMainTools
    {
        public Line(int size, int xEnd, int yEnd, int xStart, int yStart, ICoordinates icoordintes)
            : base(size, xEnd, yEnd, xStart, yStart, icoordintes)
        {
            throw new NotImplementedException();
        }

        public override void getMainTool(IPenTool ipen, IToolBrush ibrush, Color color, string name)
        {
            throw new NotImplementedException();
        }
    }
}
