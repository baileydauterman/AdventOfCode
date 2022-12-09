using NUnit.Framework;

namespace AdventOfCode.Test
{
	public class Day7Test : ITest
	{
		public Day7Test()
		{
		}

        public string TestPath { get; set; } = "../../../Day7/input.test";
        public string ProdPath { get; set; } = "../../../Day7/input.prod";

        [Test]
        public void Prod()
        {
            Assert.AreEqual(1297159, new Day7().FindUnder(ProdPath));
            Assert.AreEqual(3866390, new Day7().FindDelete(ProdPath));
        }

        [Test]
        public void Test()
        {
            Assert.AreEqual(95437, new Day7().FindUnder(TestPath));
            Assert.AreEqual(24933642, new Day7().FindDelete(TestPath));
        }
    }
}

