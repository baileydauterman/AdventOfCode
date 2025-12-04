namespace AdventOfCode.Tests._2025;

public class Day1 : BaseDayTest
{
    public Day1() : base(2025, 1)
    {
        Part1ExpectedTestResult = 3;
        Part1ExpectedPuzzleResult = 1180;
        Part2ExpectedTestResult = 6;
        Part2ExpectedPuzzleResult = 6892;
    }

    public override int Part1Solver(Stream stream)
    {
        var dial = AdventOfCode._2025.Day1.Part1(stream);
        return dial.Password1;
    }

    public override int Part2Solver(Stream stream)
    {
        var dial = AdventOfCode._2025.Day1.Part1(stream);
        return dial.Password2;
    }
}
