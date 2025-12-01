namespace AdventOfCode.Tests
{
	public class Day7
    {
        [Test]
        public void Test()
        {
            var path = Common.BuildPath("7", Common.DataType.Test);

            Assert.That(new AdventOfCode.Day7().FindUnder(path), Is.EqualTo(95437));
            Assert.That(new AdventOfCode.Day7().FindDelete(path), Is.EqualTo(24933642));
        }

        [Test]
        public void Prod()
        {
            var path = Common.BuildPath("7", Common.DataType.Prod);

            Assert.That(new AdventOfCode.Day7().FindUnder(path), Is.EqualTo(1297159));
            Assert.That(new AdventOfCode.Day7().FindDelete(path), Is.EqualTo(3866390));
        }
    }
}

