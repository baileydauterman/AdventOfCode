namespace AdventOfCode
{
    internal class Day1
    {

        public static List<int> CalorieCounter()
        {
            var nums = new List<int>();
            using (var stream = File.OpenRead("../../../Day1/input.prod"))
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

        public static int Max()
        {
            return CalorieCounter().Max();
        }

        public static int Top3()
        {
            var nums = CalorieCounter();

            nums.Sort();
            nums.Reverse();

            return nums.Take(3).Sum();
        }
    }
}
