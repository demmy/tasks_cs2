using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication;

namespace UnitTest
{
    [TestFixture]
    class UnitTestSum
    {
        [Test]
        public void TestSum()
        {
            Assert.AreEqual(5, Program.Sum(2, 3), "Middle values sa wrong");
            Assert.AreEqual(0, Program.Sum(0,0), "Middle values sa wrong");   
            Assert.AreEqual(0, Program.Sum(-1, 1), "Middle values sa wrong");
            Assert.AreEqual(-7, Program.Sum(-10, 3), "Middle values sa wrong");
            Assert.AreEqual(2147483646, Program.Sum(-1, int.MaxValue), "limiting values is wrong");
            Assert.AreEqual(-2147483648, Program.Sum(1, int.MaxValue), "limiting values is wrong");
            Assert.AreEqual(2147483647, Program.Sum(2147483644, 3), "limiting values is wrong");
            Assert.AreEqual(2147483647, Program.Sum(-1, int.MinValue), "limiting values is wrong");
            Assert.AreEqual(-2147483647, Program.Sum(1, int.MinValue), "limiting values is wrong");
            Assert.AreEqual(-2147483648, Program.Sum(-2147483647, -1), "limiting values is wrong");
            Assert.AreEqual(2147483647, Program.Sum(int.MaxValue, 0), "limiting values is wrong");
            //Assert.Throws(typeof(OverflowException), () => { Program.Sum(2, 3); }, "Error!");
        }
    }
}
