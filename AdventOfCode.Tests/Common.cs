namespace AdventOfCode.Tests
{
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
}
