namespace AdventOfCode.Tests
{
    internal class Day4
    {
        [Test]
        public void Test()
        {
            var path = Common.BuildPath("4", Common.DataType.Test);

            Assert.That(AdventOfCode.Day4.CheckSections(path), Is.EqualTo(2));
        }

        [Test]
        public void Prod()
        {
            var path = Common.BuildPath("4", Common.DataType.Prod);

            Assert.That(AdventOfCode.Day4.CheckSections(path), Is.EqualTo(431));
            Assert.That(AdventOfCode.Day4.CheckSectionsAny(path), Is.EqualTo(823));
        }
    }
}
