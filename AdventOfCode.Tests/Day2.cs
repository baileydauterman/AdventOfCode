namespace AdventOfCode.Tests
{
    internal class Day2
    {
        [Test]
        public void Test()
        {
            var path = Common.BuildPath("Day2", Common.DataType.Test);

            Assert.That(AdventOfCode.Day2.ReadFile(path).Select(f => f.Score).Sum(), Is.EqualTo(15));
        }

        [Test]
        public void Prod()
        {
            var path = Common.BuildPath("Day2", Common.DataType.Prod);

            Assert.That(AdventOfCode.Day2.ReadFile(path).Select(f => f.Score).Sum(), Is.EqualTo(13052));
            Assert.That(AdventOfCode.Day2.ReadFileCorrectly(path).Select(f => f.Score).Sum(), Is.EqualTo(13693));
        }
    }
}
