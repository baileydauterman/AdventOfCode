namespace AdventOfCode.Tests
{
	public class Day7
    {
        [Test]
        public void Test()
        {
            var path = Path.Combine(".", "Day7", "i.test");

            Assert.That(new AdventOfCode.Day7().FindUnder(path), Is.EqualTo(95437));
            Assert.That(new AdventOfCode.Day7().FindDelete(path), Is.EqualTo(24933642));
        }

        [Test]
        public void Prod()
        {
            var path = Path.Combine(".", "Day7", "i.prod");

            Assert.That(new AdventOfCode.Day7().FindUnder(path), Is.EqualTo(1297159));
            Assert.That(new AdventOfCode.Day7().FindDelete(path), Is.EqualTo(3866390));
        }
    }
}

