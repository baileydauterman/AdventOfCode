using System;
using NuGet.Frameworks;

namespace AdventOfCode.Tests._2025;

public class Day1
{
    [Test]
    public void Part1()
    {
        using (var stream = File.OpenRead(Common.BuildPath(2025, 1, Common.DataType.Test))) 
        {
            var dial = AdventOfCode._2025.Day1.Part1(stream);
            Assert.That(dial.Password1, Is.EqualTo(3));
        }
        
        
        using (var stream = File.OpenRead(Common.BuildPath(2025, 1, Common.DataType.Prod)))
        {
            var dial = AdventOfCode._2025.Day1.Part1(stream);
            Assert.That(dial.Password1, Is.EqualTo(1180));
        }
    }

    [Test]
    public void Part2()
    {
        using (var stream = File.OpenRead(Common.BuildPath(2025, 1, Common.DataType.Test))) 
        {
            var dial = AdventOfCode._2025.Day1.Part1(stream);
            Assert.That(dial.Password2, Is.EqualTo(6));
        }
        
        
        using (var stream = File.OpenRead(Common.BuildPath(2025, 1, Common.DataType.Prod)))
        {
            var dial = AdventOfCode._2025.Day1.Part1(stream);
            Assert.That(dial.Password2, Is.EqualTo(6911));
        }
    }
}
