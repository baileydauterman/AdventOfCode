namespace AdventOfCode.Tests
{
    internal class Day1
    {
        [Test]
        public void Test()
        {
            var path = Common.BuildPath("1", Common.DataType.Test);

            Assert.That(AdventOfCode.Day1.Max(path), Is.EqualTo(24000));
            Assert.That(AdventOfCode.Day1.Top3(path), Is.EqualTo(45000));
        }

        [Test]
        public void Prod()
        {
            var path = Common.BuildPath("1", Common.DataType.Prod);

            Assert.That(AdventOfCode.Day1.Max(path), Is.EqualTo(69177));
            Assert.That(AdventOfCode.Day1.Top3(path), Is.EqualTo(207456));
        }
    }
}
