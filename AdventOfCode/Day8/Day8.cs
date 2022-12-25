namespace AdventOfCode
{
    public class Day8
    {
        public static int FindVisibleTrees(string path)
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

            return CountVisibleTrees(treesList);
        }

        private static int CountEdges(List<List<int>> trees)
        {
            // Add sides and remove 4 for double counting corners
            return trees[0].Count * 2 + trees.Count * 2 - 4;
        }

        private static int CountVisibleTrees(List<List<int>> trees)
        {
            var visibleTrees = CountEdges(trees);

            for (var row = 1; row < trees.Count - 2; row++)
            {
                for (var tree = 1; tree < trees[row].Count - 2; tree++)
                {
                    if (trees[row][tree] == 0)
                    {
                        continue; 
                    }

                    var current = trees[row][tree];

                    var left = trees[row].Take(tree).Where(t => !(t >= current)).Count();
                    var right = trees[row].Skip(tree + 1).Take(trees[row].Count - tree + 1).Where(t => !(t >= current)).Count();
                    var above = trees.Take(row).Select(t => t[row]).Where(t => !(t >= current)).Count();
                    var below = trees.Skip(row + 1).Take(trees.Count - row + 1).Select(t => t[row]).Where(t => !(t >= current)).Count();

                    if (left == 0 || right == 0 || above == 0 || below == 0)
                    {
                        visibleTrees += 1;
                    }
                }
            }

            return visibleTrees;
        }
    }
}
