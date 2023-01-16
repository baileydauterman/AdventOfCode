using System;

namespace AdventOfCode.Tests
{
	public class Day10
	{
		private Queue<int> priorityTicks = new Queue<int>();
		private List<int> nums = new List<int>
		{
			20,60,100,140,180,220
		};


		[Test]
		public void Test()
		{
			MakeQueue();
			var path = Path.Combine(".", "Day10", "i.test");

			Assert.That(new AdventOfCode.Day10().ParseFile(path, priorityTicks), Is.EqualTo(13140));
		}

		[Test]
		public void Prod()
		{
			MakeQueue();
			var path = Path.Combine(".", "Day10", "i.prod");

            Assert.That(new AdventOfCode.Day10().ParseFile(path, priorityTicks), Is.EqualTo(16480));
        }

        public void MakeQueue()
		{
			if (priorityTicks.Any())
			{
				priorityTicks.Clear();
			}

			foreach (var num in nums)
			{
				priorityTicks.Enqueue(num);
			}
		}
	}
}

