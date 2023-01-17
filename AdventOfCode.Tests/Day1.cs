namespace AdventOfCode.Tests
{
    internal class Day1
    {
        [Test]
        public void Test()
        {
            var path = Path.Combine(".", "data", "Day1.test");

            Assert.That(AdventOfCode.Day1.Max(path), Is.EqualTo(24000));
            Assert.That(AdventOfCode.Day1.Top3(path), Is.EqualTo(45000));
        }

        [Test]
        public void Prod()
        {
            var path = Path.Combine(".", "data", "Day1.prod");

            Assert.That(AdventOfCode.Day1.Max(path), Is.EqualTo(69177));
            Assert.That(AdventOfCode.Day1.Top3(path), Is.EqualTo(207456));
        }
    }
}
