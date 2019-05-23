using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint
{
    public interface IToolBrush
    {
        SolidBrush setSolidBrush(Color color);
        
    }
    public class ToolBrush : IToolBrush
    {
        public SolidBrush setSolidBrush(Color color)
        {
            SolidBrush brush = new SolidBrush(color);
            return brush;
        }
    }
}
