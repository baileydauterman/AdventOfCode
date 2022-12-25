namespace AdventOfCode.Tests
{
	public class Day8
    {
        [Test]
        public void Test()
        {
            var path = Path.Combine(".", "Day8", "i.test");

            Assert.That(AdventOfCode.Day8.FindVisibleTrees(path), Is.EqualTo(95437));
            Assert.That(new AdventOfCode.Day7().FindDelete(path), Is.EqualTo(24933642));
        }

        [Test]
        public void Prod()
        {
            var path = Path.Combine(".", "Day8", "i.prod");

            Assert.That(new AdventOfCode.Day7().FindUnder(path), Is.EqualTo(1297159));
            Assert.That(new AdventOfCode.Day7().FindDelete(path), Is.EqualTo(3866390));
        }
    }
}

