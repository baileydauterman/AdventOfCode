using NUnit.Framework;

namespace AdventOfCode.Test
{
    internal class Day5Test : ITest
    {
        public string TestPath { get; set; } = "../../../Day5/input.test";
        public string ProdPath { get; set; } = "../../../Day5/input.prod";

        [Test]
        public void Prod()
        {
            Assert.AreEqual("FWNSHLDNZ", new Day5().CrateMover9000(ProdPath, new Day5().prod));
            Assert.AreEqual("RNRGDNFQG", new Day5().CrateMover9001(ProdPath, new Day5().prod));
        }

        [Test]
        public void Test()
        {
            Assert.AreEqual("CMZ", new Day5().CrateMover9000(TestPath, new Day5().test));
            Assert.AreEqual("MCD", new Day5().CrateMover9001(TestPath, new Day5().test));
        }
    }
}
