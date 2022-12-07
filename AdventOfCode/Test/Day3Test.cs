using NUnit.Framework;

namespace AdventOfCode.Test
{
    internal class Day3Test : ITest
    {
        public string TestPath { get; set; } = "../../../Day3/input.test";
        public string ProdPath { get; set; } = "../../../Day3/input.prod";

        [Test]
        public void Test()
        {
            Assert.AreEqual(157, Day3.GetPriority(TestPath));
            Assert.AreEqual(70, Day3.GetBadgeNum("../../../Day3/input.test2"));
        }

        [Test]
        public void Prod()
        {
            Assert.AreEqual(7817, Day3.GetPriority(ProdPath));
            Assert.AreEqual(2444, Day3.GetBadgeNum(ProdPath));
        }
    }
}
