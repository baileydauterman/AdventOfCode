using System.Text.RegularExpressions;

namespace AdventOfCode
{
    public class Day5
    {
        public List<Stack<char>> prodChars = new List<Stack<char>>
        {
            new Stack<char>(new[] { 'D', 'M', 'S', 'Z', 'R', 'F', 'W', 'N' }),
            new Stack<char>(new[] { 'W', 'P', 'Q', 'G', 'S' }),
            new Stack<char>(new[] { 'W', 'R', 'V', 'Q', 'F', 'N', 'J', 'C' }),
            new Stack<char>(new[] { 'F', 'Z', 'P', 'C', 'G', 'D', 'L' }),
            new Stack<char>(new[] { 'T', 'P', 'S' }),
            new Stack<char>(new[] { 'H', 'D', 'F', 'W', 'R', 'L' }),
            new Stack<char>(new[] { 'Z', 'N', 'D', 'C' }),
            new Stack<char>(new[] { 'W', 'N', 'R', 'F', 'V', 'S', 'J', 'Q' }),
            new Stack<char>(new[] { 'R', 'M', 'S', 'G', 'Z', 'W', 'V' }),
        };

        public readonly List<Stack<char>> testChars = new List<Stack<char>>
        {
            new Stack<char>(new[] { 'Z', 'N' }),
            new Stack<char>(new[] { 'M', 'C', 'D'}),
            new Stack<char>(new[] { 'P'})
        };

        public string CrateMover9000(string path, List<Stack<char>> boxes)
        {
            using (var stream = File.OpenRead(path))
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line is null)
                    {
                        break;
                    }

                    MoveCrates(line, boxes);
                }
            }

            return string.Join("", boxes.Select(r => r.Peek().ToString()));
        }

        public string CrateMover9001(string path, List<Stack<char>> boxes)
        {
            using (var stream = File.OpenRead(path))
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    MoveCrates9001(reader.ReadLine(), boxes);
                }
            }

            return string.Join("", boxes.Select(r => r.Peek().ToString()));
        }

        private void MoveCrates(string str, List<Stack<char>> boxes)
        {
            var match = matcher.Match(str);
            var source = int.Parse(match.Groups["source"].Value) == 0 ? 0 : int.Parse(match.Groups["source"].Value) - 1;
            var dest = int.Parse(match.Groups["dest"].Value) == 0 ? 0 : int.Parse(match.Groups["dest"].Value) - 1;

            for (var i = 0; i < int.Parse(match.Groups["count"].Value); i++)
            {
                boxes[dest].Push(boxes[source].Pop());
            }
        }

        private void MoveCrates9001(string str, List<Stack<char>> boxes)
        {
            var match = matcher.Match(str);
            var source = int.Parse(match.Groups["source"].Value) == 0 ? 0 : int.Parse(match.Groups["source"].Value) - 1;
            var dest = int.Parse(match.Groups["dest"].Value) == 0 ? 0 : int.Parse(match.Groups["dest"].Value) - 1;

            var temp = new Stack<char>();

            for (var i = 0; i < int.Parse(match.Groups["count"].Value); i++)
            {
                if (boxes[source].TryPop(out var c))
                {
                    temp.Push(c);
                }
            }

            while (temp.Count != 0)
            {
                boxes[dest].Push(temp.Pop());
            }
        }

        private Regex matcher = new(@"(move (?<count>\d+) from (?<source>\d+) to (?<dest>\d+))");
    }
}
