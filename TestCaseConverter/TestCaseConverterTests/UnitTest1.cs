using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestCaseConverterTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ParseFromPosrobotFile()
        {
            System.IO.FileStream str = new System.IO.FileStream("C:\\Users\\Francisco Troncoso\\Desktop\\Conversion\\Origen\\AvanceEfectivo.script", System.IO.FileMode.Open);
            IEnumerable<TestCaseConverter.PosRobotTestCase> asd = TestCaseConverter.PosRobotTestCase.fromPosRobotFile(str);

        }

        [TestMethod]
        public void CreateIntellibotFunctions()
        {
            System.IO.FileStream str = new System.IO.FileStream("C:\\Users\\Francisco Troncoso\\Downloads\\ScriptCompleto.txt", System.IO.FileMode.Open);
            IEnumerable<TestCaseConverter.PosRobotTestCase> asd = TestCaseConverter.PosRobotTestCase.fromPosRobotFile(str);

            System.IO.FileStream fout = new System.IO.FileStream("C:\\Users\\Francisco Troncoso\\Documents\\Test.iscript", System.IO.FileMode.Create);
            TestCaseConverter.Functions.WriteAsIntellibot(fout, asd, TestCaseConverter.Functions.WriteEncoding.ASCII);

        }
    }
}
