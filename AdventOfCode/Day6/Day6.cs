namespace AdventOfCode
{
    public class Day6
    {

        public static int FindMarker(string path)
        {
            var data = File.ReadAllText(path);

            return FindMarker(data, 4);
        }

        public static int FindMarkerString(string data)
        {
            return FindMarker(data, 4);
        }

        public static int FindMessage(string path)
        {
            var data = File.ReadAllText(path);

            return FindMarker(data, 14);
        }

        public static int FindMessageString(string data)
        {
            return FindMarker(data, 14);
        }

        private static int FindMarker(string data, int len)
        {
            for (var i = 0; i < data.Length - len; i++)
            {
                if (data.Substring(i, len).Distinct().Count() == len)
                {
                    return i + len;
                }
            }

            return -1;
        }
    }
}
