using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint.PaintTools
{
    public class EllipseTool : AMainTools
    {
        public EllipseTool(int size, int xEnd, int yEnd, int xStart, int yStart, ICoordinates icoordintes)
            : base(size, xEnd, yEnd, xStart, yStart, icoordintes)
        {
        }

        public override void getMainTool(IPenTool ipen, IToolBrush ibrush, Color color, string name)
        {
            throw new NotImplementedException();
        }
    }
}
