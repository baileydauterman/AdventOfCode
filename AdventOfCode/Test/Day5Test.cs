using NUnit.Framework;

namespace AdventOfCode.Test
{
    internal class Day5Test : ITest
    {
        [Test]
        public void Prod()
        {
            Assert.AreEqual(new Day5().CrateMover9000("../../../Day5/input.prod", new Day5().prod), "FWNSHLDNZ");
            Assert.AreEqual(new Day5().CrateMover9001("../../../Day5/input.prod", new Day5().prod), "RNRGDNFQG");
        }

        [Test]
        public void Test()
        {
            Assert.AreEqual(new Day5().CrateMover9000("../../../Day5/input.test", new Day5().test), "CMZ");
            Assert.AreEqual(new Day5().CrateMover9001("../../../Day5/input.test", new Day5().test), "MCD");
        }
    }
}
