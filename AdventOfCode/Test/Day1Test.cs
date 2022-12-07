using NUnit.Framework;

namespace AdventOfCode.Test
{
    [TestFixture]
    internal class Day1Test : ITest
    {
        public string TestPath { get; set; } = "../../../Day1/input.test";
        public string ProdPath { get; set; } = "../../../Day1/input.prod";

        [Test]
        public void Test()
        {
            Assert.AreEqual(24000, Day1.Max(TestPath));
            Assert.AreEqual(45000, Day1.Top3(TestPath));
        }

        [Test]
        public void Prod()
        {
            Assert.AreEqual(69177, Day1.Max(ProdPath));
            Assert.AreEqual(207456, Day1.Top3(ProdPath));
        }
    }
}
