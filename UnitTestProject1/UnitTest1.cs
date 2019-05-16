using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using paint;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestForListOfTools
    {
        private readonly IListOfTools itools;
        private readonly IToolManagment imanagment;
        public UnitTestForListOfTools()
        {
            this.itools = new ListOfTools();
            this.imanagment = new ToolManagment();
        }

        [Test]
        [TestCase("Line",true)]
        [TestCase("Rectangle", true)]
        [TestCase("Test", false)]
        public void Test_check_setActiveTool_result_in_param(string name, bool result)
        {
            itools.setActiveTool(name);
            var resultFromMethod = itools.chooseActiveTool(name);
            NUnit.Framework.Assert.AreEqual(result, resultFromMethod);

        }
    }

}
