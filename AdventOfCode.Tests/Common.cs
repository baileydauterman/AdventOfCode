using NuGet.Frameworks;

namespace AdventOfCode.Tests
{
    public enum DataType
    {
        Prod, Test
    }
    internal static class Common
    {

        public static string BuildPath(string day, DataType type)
        {
            switch (type)
            {
                case DataType.Prod:
                    return Path.Combine(".", "data", "day", day, "prod");
                case DataType.Test:
                    return Path.Combine(".", "data", "day", day, "test");
            }

            return string.Empty;
        }

        public static string BuildPath(int year, int day, DataType type)
        {
            switch (type)
            {
                case DataType.Prod:
                    return Path.Combine(".", "data", year.ToString(), day.ToString(), "prod");
                case DataType.Test:
                    return Path.Combine(".", "data", year.ToString(), day.ToString(), "test");
                default:
                    return string.Empty;
            }
        }

        public enum DataType
        {
            Prod, Test
        }
    }

    public class BaseDayTest
    {
        public int Year { get; }

        public int Day { get; }

        public int Part1ExpectedTestResult { get; set; }

        public int Part1ExpectedPuzzleResult { get; set; }

        public int Part2ExpectedTestResult { get; set; }

        public int Part2ExpectedPuzzleResult { get; set; }

        public BaseDayTest(int year, int day)
        {
            Year = year;
            Day = day;
        }

        [Test]
        public void Part1()
        {
            using (var stream = File.OpenRead(BuildPath(DataType.Test)))
            {
                Assert.That(Part1Solver(stream), Is.EqualTo(Part1ExpectedTestResult));
            }

            using (var stream = File.OpenRead(BuildPath(DataType.Prod)))
            {
                Assert.That(Part1Solver(stream), Is.EqualTo(Part1ExpectedPuzzleResult));
            }
        }

        public virtual int Part1Solver(Stream stream)
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Part2()
        {
            using (var stream = File.OpenRead(BuildPath(DataType.Test)))
            {
                Assert.That(Part2Solver(stream), Is.EqualTo(Part2ExpectedTestResult));
            }

            using (var stream = File.OpenRead(BuildPath(DataType.Prod)))
            {
                Assert.That(Part2Solver(stream), Is.EqualTo(Part2ExpectedPuzzleResult));
            }
        }

        public virtual int Part2Solver(Stream stream)
        {
            throw new NotImplementedException();
        }

        private string BuildPath(DataType type)
        {
            switch (type)
            {
                case DataType.Prod:
                    return Path.Combine(".", "data", Year.ToString(), Day.ToString(), "prod");
                case DataType.Test:
                    return Path.Combine(".", "data", Year.ToString(), Day.ToString(), "test");
                default:
                    return string.Empty;
            }
        }
    }
}
