using NUnit.Framework;

namespace AdventOfCode.Test
{
    internal class Day3Test : ITest
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(Day3.GetPriority("../../../Day3/input.test"), 157);
            Assert.AreEqual(Day3.GetBadgeNum("../../../Day3/input.test2"), 70);
        }

        [Test]
        public void Prod()
        {
            Assert.AreEqual(Day3.GetPriority("../../../Day3/input.prod"), 7817);
            Assert.AreEqual(Day3.GetBadgeNum("../../../Day3/input.prod"), 2444);
        }
    }
}
