using NUnit.Framework;

namespace AdventOfCode.Test
{
    internal class Day2Test : ITest
    {
        public string TestPath { get; set; } = "../../../Day2/input.test";
        public string ProdPath { get; set; } = "../../../Day2/input.prod";

        [Test]
        public void Test()
        {
            Assert.AreEqual(15, Day2.ReadFile(TestPath).Select(f => f.Score).Sum());
        }

        [Test]
        public void Prod()
        {
            Assert.AreEqual(13052, Day2.ReadFile(ProdPath).Select(f => f.Score).Sum());
            Assert.AreEqual(13693, Day2.ReadFileCorrectly(ProdPath).Select(f => f.Score).Sum());
        }
    }
}
