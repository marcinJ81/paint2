using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint
{
    public interface IToolManagment
    {
        List<PenTool> FillListOfTool();
    }
    public class ToolManagment : IToolManagment
    {

        public List<PenTool> FillListOfTool()
        {
            List<PenTool> result = new List<PenTool> {
                new PenTool
                {
                    name = "Pen",
                    active = false
                },
                new PenTool
                {
                    name = "Brush",
                    active = false
                },
                new PenTool
                {
                    name = "Line",
                    active = false
                },
                new PenTool
                {
                    name = "Rectangle",
                    active = false
                },
                new PenTool
                {
                    name = "Ellipse",
                    active = false
                },
                 new PenTool
                {
                    name = "Ellipse",
                    active = false
                },
                new PenTool
                {
                    name = "FillEllipse",
                    active = false
                },
                new PenTool
                {
                    name = "FillRectangle",
                    active = false
                },
                 new PenTool
                {
                    name = "Eraser",
                    active = false
                }
            };

            return result;
        }
    }
}
