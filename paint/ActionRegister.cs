using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint
{
    public interface IActionRegister
    {
        void SetElementToListOfActions(Action<Graphics> action);
        List<Action<Graphics>> getAllElementsFromList();
    }


    public class ActionRegister : IActionRegister
    {
        private List<Action<Graphics>> ListAction;

        public ActionRegister()
        {
            List<Action<Graphics>> ListAction = new List<Action<Graphics>>();
        }

        public List<Action<Graphics>> getAllElementsFromList()
        {
            return ListAction;
        }

        void IActionRegister.SetElementToListOfActions(Action<Graphics> action)
        {
            List<Action<Graphics>> result = new List<Action<Graphics>>();
            result.Add(action);
            ListAction = result;
        }
    }
}
