using NUnit.Framework;

namespace AdventOfCode.Test
{
    [TestFixture]
    internal class Day1Test : ITest
    {
        private const string testPath = "../../../Day1/input.test";
        private const string prodPath = "../../../Day1/input.prod";

        [Test]
        public void Test()
        {
            Assert.AreEqual(AdventOfCode.Day1.Max(testPath), 24000);
            Assert.AreEqual(AdventOfCode.Day1.Top3(testPath), 45000);
        }

        [Test]
        public void Prod()
        {
            Assert.AreEqual(AdventOfCode.Day1.Max(prodPath), 69177);
            Assert.AreEqual(AdventOfCode.Day1.Top3(prodPath), 207456);
        }
    }
}
