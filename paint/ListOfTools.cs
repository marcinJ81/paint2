using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace paint
{
    public interface IListOfTools
    {
        PenTool chooseOneactiveTool(string name);
        bool chooseActiveTool(string name);
        void setActiveTool(string name);
        void setDeactiveTools();
    }
    public class ListOfTools : IListOfTools
    {
        private Dictionary<string,bool> listoftools { get; set; }
        private readonly IPenTool ipentool;
        private readonly IToolManagment imanagment;

        public ListOfTools()
        {
            this.ipentool = new PenTool();
            this.imanagment = new ToolManagment();
            listoftools = imanagment.FillListOfTool();
        }
        public bool chooseActiveTool(string name)
        {
            if (listoftools.Any())
            {
                if (!listoftools.Where(x => x.Key == name).Any())
                    return false;
                var result = listoftools.Where(x => x.Key == name).FirstOrDefault().Value;
                return result;
            }
            return false;
        }

        public PenTool chooseOneactiveTool(string name)
        {
            throw new NotImplementedException();
        }

        public void setActiveTool(string name)
        {
            if (listoftools.Any())
            {
                listoftools = imanagment.FillListOfTool();
                if (listoftools.Where(x => x.Key == name).Any())
                {
                    listoftools[name] = true;
                }
            }
        }

        public void setDeactiveTools()
        {
           
            
        }
    }
}
