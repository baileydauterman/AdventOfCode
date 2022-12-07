namespace AdventOfCode
{
    internal class Day1
    {

        public static List<int> CalorieCounter(string path)
        {
            var nums = new List<int>();
            using (var stream = File.OpenRead(path))
            using (var reader = new StreamReader(stream))
            {
                var temp = 0;

                while (!reader.EndOfStream)
                {
                    if (int.TryParse(reader.ReadLine(), out var num))
                    {
                        temp += num;
                    }
                    else
                    {
                        nums.Add(temp);
                        temp = 0;
                    }
                }
            }

            return nums;
        }

        public static int Max(string path)
        {
            return CalorieCounter(path).Max();
        }

        public static int Top3(string path)
        {
            var nums = CalorieCounter(path);

            nums.Sort();
            nums.Reverse();

            return nums.Take(3).Sum();
        }
    }
}
