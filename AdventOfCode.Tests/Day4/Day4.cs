namespace AdventOfCode.Tests
{
    internal class Day4
    {
        [Test]
        public void Test()
        {
            var path = Path.Combine(".", "Day4", "i.test");

            Assert.That(AdventOfCode.Day4.CheckSections(path), Is.EqualTo(2));
        }

        [Test]
        public void Prod()
        {
            var path = Path.Combine(".", "Day4", "i.prod");

            Assert.That(AdventOfCode.Day4.CheckSections(path), Is.EqualTo(431));
            Assert.That(AdventOfCode.Day4.CheckSectionsAny(path), Is.EqualTo(823));
        }
    }
}
