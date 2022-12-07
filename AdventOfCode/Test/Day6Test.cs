using NUnit.Framework;

namespace AdventOfCode.Test
{
    internal class Day6Test : ITest
    {
        public string TestPath { get; set; } = "../../../Day6/input.test";
        public string ProdPath { get; set; } = "../../../Day6/input.prod";

        [Test]
        public void Prod()
        {
            Assert.AreEqual(Day6.FindMarker(ProdPath), 1658);
            Assert.AreEqual(Day6.FindMessage(ProdPath), 2260);
        }

        [Test]
        public void Test()
        {
            Assert.AreEqual(Day6.FindMarkerString("bvwbjplbgvbhsrlpgdmjqwftvncz"), 5);
            Assert.AreEqual(Day6.FindMarkerString("nppdvjthqldpwncqszvftbrmjlhg"), 6);
            Assert.AreEqual(Day6.FindMarkerString("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg"), 10);
            Assert.AreEqual(Day6.FindMarkerString("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw"), 11);

            Assert.AreEqual(Day6.FindMessageString("mjqjpqmgbljsphdztnvjfqwrcgsmlb"), 19);
            Assert.AreEqual(Day6.FindMessageString("bvwbjplbgvbhsrlpgdmjqwftvncz"), 23);
            Assert.AreEqual(Day6.FindMessageString("nppdvjthqldpwncqszvftbrmjlhg"), 23);
            Assert.AreEqual(Day6.FindMessageString("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg"), 29);
            Assert.AreEqual(Day6.FindMessageString("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw"), 26);
        }
    }
}
