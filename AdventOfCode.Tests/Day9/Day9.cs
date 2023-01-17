using System;

namespace AdventOfCode.Tests
{
	public class Day9
	{
		[Test]
		public void Test()
		{
			var path = Path.Combine(".", "Day9", "i.test");

			Assert.That(new AdventOfCode.Day9().ParseFile(path), Is.EqualTo(13));
		}

		[Test]
		public void Prod()
		{
            var path = Path.Combine(".", "Day9", "i.prod");

            Assert.That(new AdventOfCode.Day9().ParseFile(path), Is.EqualTo(10289));
        }
	}
}

