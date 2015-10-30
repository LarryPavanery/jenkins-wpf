using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void somaTest()
        {
            Calc cl = new Calc();
            Assert.AreEqual(4, cl.soma(2, 2), "x:<{0}> * y:<{1}> = 4", new object[] { 2, 2 });
        }
    }
}