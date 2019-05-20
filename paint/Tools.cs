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
        Pen getPenTool(int size, Color color);
    }
    public class PenTool : IPenTool
    {
        public string name { get; set; }
        public bool active { get; set; }

        public Pen getPenTool(int size, Color color)
        {
            Pen myPen = new Pen(color, (float)size);
            return myPen;
        }

    }
}
