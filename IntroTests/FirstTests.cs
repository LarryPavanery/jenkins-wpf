using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace IntroTest
{
    [TestFixture]
    class FirstTests
    {
        [Test]
        public void PositiveTest()
        {
            int x = 2;
            int y = 2;

            Assert.AreEqual(x, y);
        }

        [Test, ExpectedException(typeof(NotSupportedException))]
        public void ExceptedExceptionTest()
        {
            throw new NotSupportedException();
        }

        [Test, Ignore]
        public void NotImplementedException()
        {
            throw new NotImplementedException();
        }
    }
}
