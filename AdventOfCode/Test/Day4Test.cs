using NUnit.Framework;

namespace AdventOfCode.Test
{
    internal class Day4Test : ITest
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(Day4.CheckSections("../../../Day4/input.test"), 2);
        }

        [Test]
        public void Prod()
        {
            Assert.AreEqual(Day4.CheckSections("../../../Day4/input.prod"), 431);
            Assert.AreEqual(Day4.CheckSectionsAny("../../../Day4/input.prod"), 823);
        }
    }
}
