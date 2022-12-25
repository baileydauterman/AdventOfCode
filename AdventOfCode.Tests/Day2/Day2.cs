namespace AdventOfCode.Tests
{
    internal class Day2
    {
        [Test]
        public void Day2_Test()
        {
            var path = Path.Combine(".", "Day2", "i.test");

            Assert.That(AdventOfCode.Day2.ReadFile(path).Select(f => f.Score).Sum(), Is.EqualTo(15));
        }

        [Test]
        public void Day2_Prod()
        {
            var path = Path.Combine(".", "Day2", "i.prod");

            Assert.That(AdventOfCode.Day2.ReadFile(path).Select(f => f.Score).Sum(), Is.EqualTo(13052));
            Assert.That(AdventOfCode.Day2.ReadFileCorrectly(path).Select(f => f.Score).Sum(), Is.EqualTo(13693));
        }
    }
}
