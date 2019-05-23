using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint
{
    public interface IToolManagment
    {
        Dictionary<string,bool> FillListOfTool();
    }
    public class ToolManagment : IToolManagment
    {

        public Dictionary<string, bool> FillListOfTool()
        {
            Dictionary<string, bool> result = new Dictionary<string, bool>()
            {  
                {
                    "Pen",
                    false
                },
               
                {
                    "Brush",
                    false
                },
               
                {
                   "Line",
                    false
                },
                
                {
                    "Rectangle",
                    false
                },
                
                {
                    "Ellipse",
                    false
                },
                 
                {
                    "FillEllipse",
                    false
                },
                
                {
                    "FillRectangle",
                    false
                },
                 
                {
                    "Eraser",
                    false
                }
            };

            return result;
        }
    }
}
