namespace AdventOfCode.Tests
{
    internal class Day5
    {
        [Test]
        public void Test()
        {
            var path = Path.Combine(".", "Day5", "i.test");

            var runner = new AdventOfCode.Day5();

            Assert.That(runner.CrateMover9000(path, runner.testChars), Is.EqualTo("CMZ"));

            runner = new AdventOfCode.Day5();
            Assert.That(runner.CrateMover9001(path, runner.testChars), Is.EqualTo("MCD"));
        }

        [Test]
        public void Prod()
        {
            var path = Path.Combine(".", "Day5", "i.prod");

            var runner = new AdventOfCode.Day5();

            Assert.That(runner.CrateMover9000(path, runner.prodChars), Is.EqualTo("FWNSHLDNZ"));

            runner= new AdventOfCode.Day5();
            Assert.That(runner.CrateMover9001(path, runner.prodChars), Is.EqualTo("RNRGDNFQG"));
        }
    }
}
