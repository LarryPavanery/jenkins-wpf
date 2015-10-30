using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace IntroTest
{
    [TestFixture]
    class SecondTests
    {
        [Test]
        public void PositiveTest()
        {
            Assert.AreEqual(2, 2);
        }

        [Test]
        public void NegativeTest()
        {
            Assert.Fail("This is a failure in SecondTests");
        }
    }
}
