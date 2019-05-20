using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint.PaintTools
{
    public interface IGraphicsCanvas
    {
        Graphics getSetTolsForCanvas(PictureBox canvasControl);
    }
    public class GraphicsCanvas : IGraphicsCanvas
    {
        public Graphics getSetTolsForCanvas(PictureBox canvasControl)
        {
            Graphics result = canvasControl.CreateGraphics();
            return result;
        }
    }
}
