using System;

namespace AdventOfCode.Tests
{
	public class Day9
	{
		[Test]
		public void Test()
		{
			var path = Common.BuildPath("9", Common.DataType.Test);

			Assert.That(new AdventOfCode.Day9().ParseFile(path), Is.EqualTo(13));
		}

		[Test]
		public void Prod()
		{
			var path = Common.BuildPath("9", Common.DataType.Prod);

            Assert.That(new AdventOfCode.Day9().ParseFile(path), Is.EqualTo(10289));
        }
	}
}

