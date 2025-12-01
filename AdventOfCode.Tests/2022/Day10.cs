using System;

namespace AdventOfCode.Tests
{
	public class Day10
	{
		private readonly Queue<int> priorityTicks = new();
		private readonly List<int> nums = new()
		{
			20,60,100,140,180,220
		};


		[Test]
		public void Test()
		{
			MakeQueue();
			var path = Common.BuildPath("10", Common.DataType.Test);

			Assert.That(new AdventOfCode.Day10().ParseFile(path, priorityTicks), Is.EqualTo(13140));
		}

		[Test]
		public void Prod()
		{
			MakeQueue();
			var path = Common.BuildPath("10", Common.DataType.Prod);

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

