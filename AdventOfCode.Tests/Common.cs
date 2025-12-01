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

        public static string BuildPath(string year, string day, DataType type)
        {
            switch (type)
            {
                case DataType.Prod:
                    return Path.Combine(".", "data", year, day, "prod");
                case DataType.Test:
                    return Path.Combine(".", "data", year, day, "test");
            }

            return string.Empty;
        }

        public enum DataType
        {
            Prod, Test
        }
    }
}
