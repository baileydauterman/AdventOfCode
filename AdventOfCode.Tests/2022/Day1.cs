namespace AdventOfCode.Tests
{
    internal class Day1 : BaseDayTest
    {
        public Day1() : base(2022, 1)
        {
            Part1ExpectedTestResult = 24000;
            Part1ExpectedPuzzleResult = 69177;
            Part2ExpectedTestResult = 45000;
            Part2ExpectedPuzzleResult = 207456;
        }

        public override int Part1Solver(Stream stream)
        {
            return AdventOfCode.Day1.Max(stream);
        }

        public override int Part2Solver(Stream stream)
        {
            return AdventOfCode.Day1.Top3(stream);
        }
    }
}
