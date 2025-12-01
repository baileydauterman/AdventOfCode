using System;
using System.Collections.Generic;
using System.Linq;
namespace AdventOfCode.Tests
{
    internal class Day3
    {
        [Test]
        public void Test()
        {
            var path = Common.BuildPath("3", Common.DataType.Test);

            Assert.That(AdventOfCode.Day3.GetPriority(path), Is.EqualTo(157));
            Assert.That(AdventOfCode.Day3.GetBadgeNum(path), Is.EqualTo(70));
        }

        [Test]
        public void Prod()
        {
            var path = Common.BuildPath("3", Common.DataType.Prod);

            Assert.That(AdventOfCode.Day3.GetPriority(path), Is.EqualTo(7817));
            Assert.That(AdventOfCode.Day3.GetBadgeNum(path), Is.EqualTo(2444));
        }
    }
}
