using static AdventOfCode.Day2;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace AdventOfCode
{
    public class Day3
    {
        public static Dictionary<char, int> priorityDict = new Dictionary<char, int>
    {
        { 'a', 1},
        { 'b', 2},
        { 'c', 3},
        { 'd', 4},
        { 'e', 5},
        { 'f', 6},
        { 'g', 7},
        { 'h', 8},
        { 'i', 9},
        { 'j', 10},
        { 'k', 11},
        { 'l', 12},
        { 'm', 13},
        { 'n', 14},
        { 'o', 15},
        { 'p', 16},
        { 'q', 17},
        { 'r', 18},
        { 's', 19},
        { 't', 20},
        { 'u', 21},
        { 'v', 22},
        { 'w', 23},
        { 'x', 24},
        { 'y', 25},
        { 'z', 26},
        { 'A', 27},
        { 'B', 28},
        { 'C', 29},
        { 'D', 30},
        { 'E', 31},
        { 'F', 32},
        { 'G', 33},
        { 'H', 34},
        { 'I', 35},
        { 'J', 36},
        { 'K', 37},
        { 'L', 38},
        { 'M', 39},
        { 'N', 40},
        { 'O', 41},
        { 'P', 42},
        { 'Q', 43},
        { 'R', 44},
        { 'S', 45},
        { 'T', 46},
        { 'U', 47},
        { 'V', 48},
        { 'W', 49},
        { 'X', 50},
        { 'Y', 51},
        { 'Z', 52 },
    };

        public static int GetPriority(string path)
        {
            var priority = 0;
            var chars = new List<char>();

            using (var stream = File.OpenRead(path))
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var front = line.Substring(0, line.Length / 2);
                    var back = line.Substring(line.Length / 2, line.Length / 2);

                    var hashSet = new HashSet<char>();

                    foreach (var c in front)
                    {
                        hashSet.Add(c);
                    }

                    foreach (char c in back)
                    {
                        if (hashSet.Contains(c))
                        {
                            chars.Add(c);
                            priority += priorityDict[c];
                            break;
                        }
                    }

                }
            }

            return priority;
        }

        public static int GetBadgeNum(string path)
        {
            var badges = new Dictionary<char, int>();
            var count = 0;

            using (var stream = File.OpenRead(path))
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    for (var i = 0; i < 3; i++)
                    {
                        foreach (var c in reader.ReadLine().Distinct())
                        {
                            if (badges.ContainsKey(c))
                            {
                                badges[c]++;
                            }
                            else
                            {
                                badges.Add(c, 1);
                            }
                        }
                    }

                    count += priorityDict[badges.Where(f => f.Value == 3).Select(z => z.Key).First()];

                    badges = new Dictionary<char, int>();
                }
            }

            return count;
        }
    }
}
