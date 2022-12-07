using NUnit.Framework;

namespace AdventOfCode.Test
{
    internal class Day4Test : ITest
    {
        public string TestPath { get; set; } = "../../../Day4/input.test";

        public string ProdPath { get; set; } = "../../../Day4/input.prod";

        [Test]
        public void Test()
        {
            Assert.AreEqual(2, Day4.CheckSections(TestPath));
        }

        [Test]
        public void Prod()
        {
            Assert.AreEqual(431, Day4.CheckSections(ProdPath));
            Assert.AreEqual(823, Day4.CheckSectionsAny(ProdPath));
        }
    }
}
