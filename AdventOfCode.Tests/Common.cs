namespace AdventOfCode.Tests
{
    internal class Common
    {

        public static string BuildPath(string day, DataType type)
        {
            switch (type)
            {
                case DataType.Prod:
                    return Path.Combine(".", "data", $"{day}.prod");
                case DataType.Test:
                    return Path.Combine(".", "data", $"{day}.test");
            }

            return string.Empty;
        }

        public enum DataType
        {
            Prod, Test
        }
    }
}
