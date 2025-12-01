namespace AdventOfCode.Tests
{
	public class Day8
    {
        [Test]
        public void Test()
        {
            var path = Common.BuildPath("8", Common.DataType.Test);

            Assert.That(AdventOfCode.Day8.FindVisibleTrees(path), Is.EqualTo(21));
            Assert.That(AdventOfCode.Day8.FindScenicSpot(path), Is.EqualTo(8));
        }

        [Test]
        public void Prod()
        {
            var path = Common.BuildPath("8", Common.DataType.Prod);

            Assert.That(AdventOfCode.Day8.FindVisibleTrees(path), Is.EqualTo(1690));
        }
    }
}

