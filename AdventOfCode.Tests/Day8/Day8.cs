namespace AdventOfCode.Tests
{
	public class Day8
    {
        [Test]
        public void Test()
        {
            var path = Path.Combine(".", "Day8", "i.test");

            Assert.That(AdventOfCode.Day8.FindVisibleTrees(path), Is.EqualTo(21));
            Assert.That(AdventOfCode.Day8.FindScenicSpot(path), Is.EqualTo(8));
        }

        [Test]
        public void Prod()
        {
            var path = Path.Combine(".", "Day8", "i.prod");

            Assert.That(AdventOfCode.Day8.FindVisibleTrees(path), Is.EqualTo(1690));
        }
    }
}

