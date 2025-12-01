namespace AdventOfCode.Tests
{
    internal class Day6
    {
        [Test]
        public void Test()
        {
            Assert.That(AdventOfCode.Day6.FindMarkerString("bvwbjplbgvbhsrlpgdmjqwftvncz"), Is.EqualTo(5));
            Assert.That(AdventOfCode.Day6.FindMarkerString("nppdvjthqldpwncqszvftbrmjlhg"), Is.EqualTo(6));
            Assert.That(AdventOfCode.Day6.FindMarkerString("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg"), Is.EqualTo(10));
            Assert.That(AdventOfCode.Day6.FindMarkerString("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw"), Is.EqualTo(11));

            Assert.That(AdventOfCode.Day6.FindMessageString("mjqjpqmgbljsphdztnvjfqwrcgsmlb"), Is.EqualTo(19));
            Assert.That(AdventOfCode.Day6.FindMessageString("bvwbjplbgvbhsrlpgdmjqwftvncz"), Is.EqualTo(23));
            Assert.That(AdventOfCode.Day6.FindMessageString("nppdvjthqldpwncqszvftbrmjlhg"), Is.EqualTo(23));
            Assert.That(AdventOfCode.Day6.FindMessageString("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg"), Is.EqualTo(29));
            Assert.That(AdventOfCode.Day6.FindMessageString("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw"), Is.EqualTo(26));
        }

        [Test]
        public void Prod()
        {
            var path = Common.BuildPath("6", Common.DataType.Prod);

            Assert.That(AdventOfCode.Day6.FindMarker(path), Is.EqualTo(1658));
            Assert.That(AdventOfCode.Day6.FindMessage(path), Is.EqualTo(2260));
        }
    }
}
