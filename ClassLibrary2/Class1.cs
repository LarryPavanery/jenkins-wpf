using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {
        [Test]
        public void PassingTest()
        {
            Assert.AreEqual(2, 2);
        }

        [Test]
        public void FailingTest()
        {
            Assert.AreNotEqual(2, 3);
        }

    }
}
