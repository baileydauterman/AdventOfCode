namespace AdventOfCode
{
    internal class Day4
    {

        public static int CheckSections(string path)
        {
            var overlap = 0;

            using (var stream = File.OpenRead(path))
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    (var first, var second) = GenerateRanges(reader.ReadLine());

                    if (!first.Except(second).Any() || !second.Except(first).Any())
                    {
                        overlap++;
                    }

                }
            }

            return overlap;
        }

        public static int CheckSectionsAny(string path)
        {
            var overlap = 0;

            using (var stream = File.OpenRead(path))
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    (var first, var second) = GenerateRanges(reader.ReadLine());

                    if (first.Intersect(second).Any() || second.Intersect(first).Any())
                    {
                        overlap++;
                    }

                }
            }

            return overlap;
        }

        private static (IEnumerable<int>, IEnumerable<int>) GenerateRanges(string? str)
        {
            var elves = str.Split(",");
            var first = elves[0].Split("-").Select(int.Parse).ToList();
            var second = elves[1].Split("-").Select(int.Parse).ToList();

            return (Enumerable.Range(first[0], first[1] - first[0] + 1),
                Enumerable.Range(second[0], second[1] - second[0] + 1));
        }
    }
}
