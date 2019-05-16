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
        private List<PenTool> listoftools { get; set; }
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
                if (!listoftools.Where(x => x.name == name).Any())
                    return false;
                var result = listoftools.Where(x => x.name == name).FirstOrDefault().active;
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
                setDeactiveTools();
               if(listoftools.Where(x => x.name == name).Any())
                    listoftools.Where(x => x.name == name).First().active = true;
            }
        }

        public void setDeactiveTools()
        {
            if (listoftools.Any())
            {
                foreach (var i in listoftools)
                {
                    listoftools.Where(x => x.name == i.name).First().active = false;
                }
                
            }
        }
    }
}
