using NUnit.Framework;

namespace AdventOfCode.Test
{
    internal class Day2Test : ITest
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(Day2.ReadFile("../../../Day2/input.test").Select(f => f.Score).Sum(), 15);
        }

        [Test]
        public void Prod()
        {
            Assert.AreEqual(Day2.ReadFile("../../../Day2/input.prod").Select(f => f.Score).Sum(), 13052);
            Assert.AreEqual(Day2.ReadFileCorrectly("../../../Day2/input.prod").Select(f => f.Score).Sum(), 13693);
        }
    }
}
