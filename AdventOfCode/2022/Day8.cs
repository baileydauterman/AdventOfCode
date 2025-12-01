using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Sources;

namespace AdventOfCode
{
    public class Day8
    {
        public static int FindVisibleTrees(string path)
        {
            var treesList = ReadFile(path);
            return CountOutsideVisibleTrees(treesList);
        }

        public static int FindScenicSpot(string path)
        {
            var treesList = ReadFile(path);
            return FindScenicTrees(treesList);
        }

        private static List<List<int>> ReadFile(string path)
        {
            var treesList = new List<List<int>>();

            using (var stream = File.OpenRead(path))
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    var trees = reader.ReadLine();
                    var row = new List<int>();

                    foreach (var tree in trees)
                    {
                        row.Add(int.Parse(tree.ToString()));
                    }

                    treesList.Add(row);
                }
            }

            return treesList;
        }

        private static int CountEdges(List<List<int>> trees)
        {
            // Add sides and remove 4 for double counting corners
            return trees[0].Count * 2 + trees.Count * 2 - 4;
        }

        private static int CountOutsideVisibleTrees(List<List<int>> trees)
        {
            var visibleTrees = CountEdges(trees);

            for (var row = 1; row < trees.Count - 1; row++)
            {
                for (var tree = 1; tree < trees[row].Count - 1; tree++)
                {
                    var current = trees[row][tree];

                    if (current == 0)
                    {
                        continue; 
                    }

                    // Take all the elements up to the current tree
                    // Only takes trees that are taller than the current tree
                    var left = trees[row].Take(tree).Where(t => t >= current).Count();

                    // Take all the elements from current tree to end
                    var right = trees[row].Skip(tree + 1).Take(trees[row].Count - tree + 1).Where(t => t >= current).Count();

                    // Take all the trees in the same column up to the current
                    var above = trees.Take(row).Select(t => t[tree]).Where(t => t >= current).Count();

                    // Take all the trees in the same column from current tree to the end
                    var below = trees.Skip(row + 1).Take(trees.Count - row + 1).Select(t => t[tree]).Where(t => t >= current).Count();

                    // If any of these are 0 the tree is visible
                    if (left == 0 || right == 0 || above == 0 || below == 0)
                    {
                        visibleTrees += 1;
                    }
                }
            }

            return visibleTrees;
        }

        private static int FindScenicTrees(List<List<int>> trees)
        {
            var scenicScores = new Dictionary<(int, int), int>();

            for (var row = 1; row < trees.Count - 1; row++)
            {
                for (var tree = 1; tree < trees[row].Count - 1; tree++)
                {
                    var current = trees[row][tree];

                    if (current == 0)
                    {
                        continue;
                    }

                    // Take all the elements up to the current tree
                    // Only takes trees that are taller than the current tree
                    var left = trees[row].Take(tree).ToArray();

                    // Take all the elements from current tree to end
                    var right = trees[row].Skip(tree + 1).Take(trees[row].Count - tree + 1).ToArray();

                    // Take all the trees in the same column up to the current
                    var above = trees.Take(row).Select(t => t[tree]).ToArray();

                    // Take all the trees in the same column from current tree to the end
                    var below = trees.Skip(row + 1).Take(trees.Count - row + 1).Select(t => t[tree]).ToArray();

                    var score = ScoreArray(left, current, true) * ScoreArray(right, current) * ScoreArray(above, current, true) * ScoreArray(below, current);

                    scenicScores.Add((row, tree), score);
                }
            }

            return scenicScores.Values.Max();
        }

        private static int ScoreArray(int[] trees, int current, bool reverse = false)
        {
            if (reverse)
            {
                trees = trees.Reverse().ToArray();
            }

            var output = 1;

            foreach (var t in trees)
            {
                if (t == current)
                {
                    return output;
                }

                output++;
            }

            return output;
        }
    }
}
